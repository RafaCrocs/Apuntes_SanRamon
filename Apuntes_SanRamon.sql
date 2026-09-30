-- =============================================
-- Apuntes San Ramon
-- Script re-ejecutable: crea lo que falte y actualiza
-- procedimientos y vistas (create or alter).
-- =============================================

if db_id('Apuntes_SanRamon4') is null
	create database Apuntes_SanRamon4;
go

use Apuntes_SanRamon4;
go

-- Los procedimientos guardan estas opciones al crearse; SP_ObtenerApuntesTodos las necesita (usa XML)
set ansi_nulls on;
set quoted_identifier on;
go

-- =============================================
-- Tablas
-- =============================================

if object_id('Empleados', 'U') is null
create table Empleados (
	IdEmpleado int identity(1,1) primary key,
	NombreCompleto nvarchar(255) not null,
	LugarTrabajo nvarchar(255) not null
);
go

if object_id('Apuntes', 'U') is null
create table Apuntes (
	IdApunte int identity(1,1) primary key,
	IdEmpleado int not null,
	Monto int not null,
	Detalle nvarchar(255) not null,
	Origen nvarchar(50) not null,
	Fecha datetime not null default getdate(),

	Constraint FK_Empleados_Apuntes foreign key (IdEmpleado) references Empleados(IdEmpleado)
);
go

if object_id('HistorialPagos', 'U') is null
create table HistorialPagos (
	IdHistorialPago int identity(1,1) primary key,
	IdEmpleado int not null,
	Monto int not null,
	Detalle nvarchar(255) not null,
	Origen nvarchar(50) not null,
	SePagoEn nvarchar(255) not null,
	FechaPago datetime not null default getdate(),
	FechaApunte datetime not null default getdate(),

	Constraint FK_Empleados_Pagos foreign key (IdEmpleado) references Empleados(IdEmpleado)
);
go

if object_id('LugaresTrabajo', 'U') is null
create table LugaresTrabajo (
	IdLugarTrabajo int primary key identity(1,1),
	NombreLugarTrabajo nvarchar(255) not null
);
go

if not exists (select 1 from LugaresTrabajo)
insert into LugaresTrabajo (NombreLugarTrabajo) values
(N''),
(N'Zarcereño'),
(N'Restaurante'),
(N'Souvenir'),
(N'Finca');
go

-- =============================================
-- Actualizaciones para bases creadas con versiones anteriores del script
-- =============================================

-- Se quitan las restricciones de Origen para permitir nuevos puntos de venta
if object_id('CHK_Origen_Apuntes', 'C') is not null
	alter table Apuntes drop constraint CHK_Origen_Apuntes;
if object_id('CHK_Origen_Pagos', 'C') is not null
	alter table HistorialPagos drop constraint CHK_Origen_Pagos;
go

-- Fecha en que se hizo el apunte, se guarda al pagarlo
if col_length('HistorialPagos', 'FechaApunte') is null
	alter table HistorialPagos add FechaApunte datetime not null default getdate();
go

-- =============================================
-- Empleados y lugares de trabajo
-- =============================================

create or alter procedure SP_ObtenerLugaresTrabajo
as
begin
	select NombreLugarTrabajo from LugaresTrabajo;
end;
go

create or alter procedure SP_InsertarEmpleado
	@NombreCompleto nvarchar(255),
	@LugarTrabajo nvarchar(255),
	@Resultado bit output,
	@Mensaje nvarchar(255) output
as
begin
	if exists (select 1 from Empleados where NombreCompleto = @NombreCompleto and LugarTrabajo = @LugarTrabajo)
	begin
		set @Resultado = 0;
		set @Mensaje = 'El colaborador ya existe';
		return;
	end

	insert into Empleados (NombreCompleto, LugarTrabajo)
	values (@NombreCompleto, @LugarTrabajo);

	set @Resultado = 1;
	set @Mensaje = 'Colaborador insertado correctamente.';
end
go

-- =============================================
-- Apuntes por punto de venta (proyecto Apuntes)
-- =============================================

--Registrar Apunte
create or alter procedure SP_InsertarApunte
	@IdEmpleado int,
	@Monto int,
	@Detalle nvarchar(255),
	@Origen nvarchar(50),
	@Resultado bit output,
	@Mensaje nvarchar(255) output
as
begin
	begin try
		if @Monto <= 0
		begin
			set @Resultado = 0;
			set @Mensaje = 'El monto debe ser mayor que cero.';
			return;
		end

		insert into Apuntes (IdEmpleado, Monto, Detalle, Origen)
		values (@IdEmpleado, @Monto, @Detalle, @Origen);
		set @Resultado = 1;
		set @Mensaje = 'Apunte insertado correctamente.';
	end try
	begin catch
		set @Resultado = 0;
		set @Mensaje = 'Error al insertar el apunte: ' + ERROR_MESSAGE();
	end catch
end
go

-- Obtener Apuntes por Origen
create or alter procedure SP_ObtenerApuntesPorOrigen
	@Origen nvarchar(50)
as
begin
	select
		e.IdEmpleado,
		e.NombreCompleto,
		e.LugarTrabajo,
		SUM(a.Monto) as MontoTotal
	from Apuntes a
	left join Empleados e on a.IdEmpleado = e.IdEmpleado
	where Origen = @Origen
	group by e.IdEmpleado, e.NombreCompleto, e.LugarTrabajo
end
go

-- Ver Detalle de Apunte
create or alter procedure SP_DetalleApuntesPorOrigen
	@IdEmpleado int,
	@Origen nvarchar(50)
as
begin
	select
		a.IdApunte,
		e.NombreCompleto,
		a.Monto,
		a.Detalle,
		a.Fecha
	from Apuntes a
	inner join Empleados e on a.IdEmpleado = e.IdEmpleado
	where a.IdEmpleado = @IdEmpleado and a.Origen = @Origen
end
go

-- Pagar Apunte
create or alter procedure SP_PagarApunte
	@IdApunte int,
	@SePagoEn nvarchar(255),
	@Resultado bit output,
	@Mensaje nvarchar(255) output
as
begin
	begin try
		insert into HistorialPagos (IdEmpleado, Monto, Detalle, SePagoEn, Origen, FechaApunte)
		select IdEmpleado, Monto, Detalle, @SePagoEn, Origen, Fecha
		from Apuntes
		where IdApunte = @IdApunte;

		delete from Apuntes
		where IdApunte = @IdApunte;

		set @Resultado = 1;
		set @Mensaje = 'Apunte pagado correctamente.';
	end try
	begin catch
		set @Resultado = 0;
		set @Mensaje = 'Error al pagar el apunte: ' + ERROR_MESSAGE();
	end catch
end
go

-- Pagar Todo: solo los apuntes del punto de venta que paga (@Origen)
-- La transaccion y los bloqueos evitan borrar un apunte que se agregue mientras se paga sin pasarlo al historial.
create or alter procedure SP_PagarTodoPorOrigen
	@IdEmpleado int,
	@Origen nvarchar(50),
	@SePagoEn nvarchar(255),
	@Resultado bit output,
	@Mensaje nvarchar(255) output
as
begin
	begin try
		begin tran;

		insert into HistorialPagos (IdEmpleado, Monto, Detalle, SePagoEn, Origen, FechaApunte)
		select IdEmpleado, Monto, Detalle, @SePagoEn, Origen, Fecha
		from Apuntes with (updlock, holdlock)
		where IdEmpleado = @IdEmpleado and Origen = @Origen;

		delete from Apuntes
		where IdEmpleado = @IdEmpleado and Origen = @Origen;

		commit;

		set @Resultado = 1;
		set @Mensaje = 'Apuntes de ' + @Origen + ' pagados correctamente.';
	end try
	begin catch
		if @@trancount > 0 rollback;
		set @Resultado = 0;
		set @Mensaje = 'Error al pagar los apuntes: ' + ERROR_MESSAGE();
	end catch
end
go

-- Historial de pagos por origen
create or alter procedure SP_HistorialPagosPorOrigen
	@Origen nvarchar(50)
as
begin
	select
		hp.IdHistorialPago,
		e.NombreCompleto,
		hp.Monto,
		hp.Detalle,
		hp.Origen,
		hp.SePagoEn,
		hp.FechaPago,
		hp.FechaApunte
	from HistorialPagos hp
	inner join Empleados e on hp.IdEmpleado = e.IdEmpleado
	where hp.Origen = @Origen
	order by hp.IdHistorialPago desc
end
go

-- =============================================
-- Administracion (proyecto ApuntesTodos)
-- =============================================

-- Obtener todos los Apuntes para Admin
-- Total no incluye Souvenir porque se rebaja por aparte.
-- DetallesSouvenir: un renglon "Detalle - Monto" por cada apunte de Souvenir.
create or alter procedure SP_ObtenerApuntesTodos
as
begin
	select
		e.IdEmpleado,
		e.NombreCompleto,
		e.LugarTrabajo,
		SUM(CASE WHEN a.Origen = N'Souvenir' THEN a.Monto ELSE 0 END) AS Souvenir,
		SUM(CASE WHEN a.Origen = N'Zarcereño' THEN a.Monto ELSE 0 END) AS Zarcereño,
		SUM(CASE WHEN a.Origen = N'Restaurante' THEN a.Monto ELSE 0 END) AS Restaurante,
		SUM(a.Monto) - SUM(CASE WHEN a.Origen = N'Souvenir' THEN a.Monto ELSE 0 END) AS Total,
		STUFF((
			select CHAR(13) + CHAR(10) + s.Detalle + N' - ' + FORMAT(s.Monto, 'C0', 'es-CR')
			from Apuntes s
			where s.IdEmpleado = e.IdEmpleado and s.Origen = N'Souvenir'
			order by s.Fecha
			for xml path(''), type
		).value('.', 'nvarchar(max)'), 1, 2, N'') AS DetallesSouvenir
	from Empleados e
	left join Apuntes a on e.IdEmpleado = a.IdEmpleado
	where a.IdApunte is not null
	group by e.NombreCompleto, e.LugarTrabajo, e.IdEmpleado;
end;
go

-- Ver Detalles de Apuntes para Admin
create or alter procedure SP_DetalleApuntesTodos
	@IdEmpleado int
as
begin
	select
		a.IdApunte,
		e.NombreCompleto,
		e.LugarTrabajo,
		a.Origen,
		a.Monto,
		a.Detalle,
		a.Fecha
	from Apuntes a
	inner join Empleados e on a.IdEmpleado = e.IdEmpleado
	where a.IdEmpleado = @IdEmpleado
end;
go

-- Pagar Todo en Salario
create or alter procedure SP_PagarTodoSalario
	@IdEmpleado int,
	@SePagoEn nvarchar(255),
	@Resultado bit output,
	@Mensaje nvarchar(255) output
as
begin
	begin try
		insert into HistorialPagos (IdEmpleado, Monto, Detalle, SePagoEn, Origen, FechaApunte)
		select IdEmpleado, Monto, Detalle, @SePagoEn, Origen, Fecha
		from Apuntes
		where IdEmpleado = @IdEmpleado;

		delete from Apuntes
		where IdEmpleado = @IdEmpleado;

		set @Resultado = 1;
		set @Mensaje = 'Todos los apuntes pagados correctamente en salario.';
	end try
	begin catch
		set @Resultado = 0;
		set @Mensaje = 'Error al pagar los apuntes: ' + ERROR_MESSAGE();
	end catch
end
go

-- Historial de pagos entre dos fechas (incluye ambos dias completos)
create or alter procedure sp_BuscarEntreFechas
	@FechaInicio datetime,
	@FechaFin datetime
as
begin
	select
		hp.IdHistorialPago,
		e.NombreCompleto,
		hp.Monto,
		hp.Detalle,
		hp.Origen,
		hp.SePagoEn,
		hp.FechaPago,
		hp.FechaApunte
	from HistorialPagos hp
	inner join Empleados e on hp.IdEmpleado = e.IdEmpleado
	where hp.FechaPago >= cast(@FechaInicio as date)
		and hp.FechaPago < dateadd(day, 1, cast(@FechaFin as date))
	order by hp.FechaPago desc
end
go

-- Ver Historial Pagos Todos
create or alter view VW_VerHistorialPagosTodos
as
select
	hp.IdHistorialPago,
	e.NombreCompleto,
	hp.Monto,
	hp.Detalle,
	hp.Origen,
	hp.SePagoEn,
	hp.FechaPago,
	hp.FechaApunte
from HistorialPagos hp
inner join Empleados e on hp.IdEmpleado = e.IdEmpleado
go
