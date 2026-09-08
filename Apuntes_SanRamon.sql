create database Apuntes_SanRamon3;
go

use Apuntes_SanRamon3;
go

create table Empleados (
	IdEmpleado int identity(1,1) primary key,
	NombreCompleto nvarchar(255) not null,
	LugarTrabajo nvarchar(255) not null
);
go

create table Apuntes (
	IdApunte int identity(1,1) primary key,
	IdEmpleado int not null,
	Monto int not null,
	Detalle nvarchar(255) not null,
	Origen nvarchar(50) not null,
	Fecha datetime not null default getdate(),

	Constraint FK_Empleados_Apuntes foreign key (IdEmpleado) references Empleados(IdEmpleado),
	Constraint CHK_Origen_Apuntes check (Origen in ('Zarcereño', 'Restaurante', 'Souvenir'))
);
go

create table HistorialPagos (
	IdHistorialPago int identity(1,1) primary key,
	IdEmpleado int not null,
	Monto int not null,
	Detalle nvarchar(255) not null,
	Origen nvarchar(50) not null,
	SePagoEn nvarchar(255) not null,
	FechaPago datetime not null default getdate(),

	Constraint FK_Empleados_Pagos foreign key (IdEmpleado) references Empleados(IdEmpleado),
	Constraint CHK_Origen_Pagos check (Origen in ('Zarcereño', 'Restaurante', 'Souvenir'))
);
go



create table LugaresTrabajo (
	IdLugarTrabajo int primary key identity(1,1),
	NombreLugarTrabajo nvarchar(255) not null
);

insert into LugaresTrabajo (NombreLugarTrabajo) values
(''),
('Zarcereño'),
('Restaurante'),
('Souvenir'),
('Finca');
go

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

-- Pagar Todo
create or alter procedure SP_PagarTodo
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
		set @Mensaje = 'Todos los apuntes pagados correctamente.';
	end try
	begin catch
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
		hp.FechaPago
	from HistorialPagos hp
	inner join Empleados e on hp.IdEmpleado = e.IdEmpleado
	where hp.Origen = @Origen
end
go

--Obtener todos los Apuntes para Admin
create or alter procedure SP_ObtenerApuntesTodos
AS
BEGIN
	select
		e.IdEmpleado,
		e.NombreCompleto,
		e.LugarTrabajo,
		SUM(CASE WHEN a.Origen = 'Zarcereño' THEN a.Monto ELSE 0 END) AS Zarcereño,
		SUM(CASE WHEN a.Origen = 'Souvenir' THEN a.Monto ELSE 0 END) AS Souvenir,
		SUM(CASE WHEN a.Origen = 'Restaurante' THEN a.Monto ELSE 0 END) AS Restaurante,
		SUM(a.Monto) AS Total
	from Empleados e
	left join Apuntes a on e.IdEmpleado = a.IdEmpleado
	where a.IdApunte is not null
	group by e.NombreCompleto, e.LugarTrabajo, e.IdEmpleado;
END;
GO

-- Ver Detalles de Apuntes para Admin
create or alter procedure SP_DetalleApuntesTodos
	@IdEmpleado int
AS
BEGIN
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
END;
go
-- Ver Historial Pagos Todos
create view VW_VerHistorialPagosTodos
AS
select
	hp.IdHistorialPago,
	e.NombreCompleto,
	hp.Monto,
	hp.Detalle,
	hp.Origen,
	hp.SePagoEn,
	hp.FechaPago
from HistorialPagos hp
inner join Empleados e on hp.IdEmpleado = e.IdEmpleado
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
		insert into HistorialPagos (IdEmpleado, Monto, Detalle, SePagoEn, Origen)
		select IdEmpleado, Monto, Detalle, @SePagoEn, Origen
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


-- Actualizaciones
alter table Apuntes drop CONSTRAINT CHK_Origen_Apuntes
alter table HistorialPagos drop CONSTRAINT CHK_Origen_Pagos
