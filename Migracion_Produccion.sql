-- =============================================
-- Migracion de la base de PRODUCCION (Apuntes_SanRamon, SQL Server 2014)
-- a la version que usan las apps actuales.
--
-- * Compatible con SQL Server 2014: no usa CREATE OR ALTER ni STRING_AGG.
-- * Se puede ejecutar mas de una vez: cada paso revisa si ya se aplico.
-- * SP_PagarApunte y SP_PagarTodo siguen aceptando @Origen (se ignora) para que
--   las apps viejas sigan funcionando mientras se instalan las nuevas.
-- * La app nueva de los puntos de venta usa SP_PagarTodoPorOrigen, que solo paga
--   los apuntes de ese punto de venta. SP_PagarTodo queda solo para las apps viejas.
--
-- ANTES DE EJECUTAR: sacar un respaldo de la base.
-- =============================================

use [Apuntes_SanRamon];
go

set ansi_nulls on;
set quoted_identifier on;
go

-- =============================================
-- 1. Tabla LugaresTrabajo (no existe en produccion)
--    Se llena con los lugares de siempre mas los que ya tengan los empleados.
-- =============================================

if object_id(N'dbo.LugaresTrabajo', N'U') is null
begin
	create table dbo.LugaresTrabajo (
		IdLugarTrabajo int primary key identity(1,1),
		NombreLugarTrabajo nvarchar(255) not null
	);
end
go

if not exists (select 1 from dbo.LugaresTrabajo)
begin
	insert into dbo.LugaresTrabajo (NombreLugarTrabajo) values (N'');

	insert into dbo.LugaresTrabajo (NombreLugarTrabajo)
	select Lugar from (
		select N'Zarcereño' as Lugar union
		select N'Restaurante' union
		select N'Souvenir' union
		select N'Finca' union
		select LugarTrabajo from dbo.Empleados where LugarTrabajo <> N''
	) l
	order by Lugar;
end
go

if object_id(N'dbo.SP_ObtenerLugaresTrabajo', N'P') is null
	exec(N'create procedure dbo.SP_ObtenerLugaresTrabajo as return 0;');
go

alter procedure dbo.SP_ObtenerLugaresTrabajo
as
begin
	select NombreLugarTrabajo from LugaresTrabajo;
end;
go

-- =============================================
-- 2. Se quitan las restricciones de Origen para permitir nuevos puntos de venta
-- =============================================

if object_id(N'dbo.CHK_Origen_Apuntes', N'C') is not null
	alter table dbo.Apuntes drop constraint CHK_Origen_Apuntes;
if object_id(N'dbo.CHK_Origen_Pagos', N'C') is not null
	alter table dbo.HistorialPagos drop constraint CHK_Origen_Pagos;
go

-- =============================================
-- 3. Pagos: el Origen se toma del apunte y se guarda FechaApunte
-- =============================================

-- Pagar Apunte
if object_id(N'dbo.SP_PagarApunte', N'P') is null
	exec(N'create procedure dbo.SP_PagarApunte as return 0;');
go

alter procedure dbo.SP_PagarApunte
	@IdApunte int,
	@SePagoEn nvarchar(255),
	@Resultado bit output,
	@Mensaje nvarchar(255) output,
	@Origen nvarchar(50) = null -- ya no se usa, solo para compatibilidad con apps viejas
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

-- Pagar Todo (solo apps viejas: paga los apuntes de todos los origenes)
if object_id(N'dbo.SP_PagarTodo', N'P') is null
	exec(N'create procedure dbo.SP_PagarTodo as return 0;');
go

alter procedure dbo.SP_PagarTodo
	@IdEmpleado int,
	@SePagoEn nvarchar(255),
	@Resultado bit output,
	@Mensaje nvarchar(255) output,
	@Origen nvarchar(50) = null -- ya no se usa, solo para compatibilidad con apps viejas
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

-- Pagar Todo: solo los apuntes del punto de venta que paga (@Origen)
-- La transaccion y los bloqueos evitan borrar un apunte que se agregue mientras se paga sin pasarlo al historial.
if object_id(N'dbo.SP_PagarTodoPorOrigen', N'P') is null
	exec(N'create procedure dbo.SP_PagarTodoPorOrigen as return 0;');
go

alter procedure dbo.SP_PagarTodoPorOrigen
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

-- =============================================
-- 4. Admin: Total sin Souvenir y columna DetallesSouvenir
-- =============================================

if object_id(N'dbo.SP_ObtenerApuntesTodos', N'P') is null
	exec(N'create procedure dbo.SP_ObtenerApuntesTodos as return 0;');
go

-- Total no incluye Souvenir porque se rebaja por aparte.
-- DetallesSouvenir: un renglon "Detalle - Monto" por cada apunte de Souvenir.
alter procedure dbo.SP_ObtenerApuntesTodos
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

-- =============================================
-- 5. Historial: incluye FechaApunte, busqueda entre fechas por dias completos
-- =============================================

-- Historial de pagos por origen
if object_id(N'dbo.SP_HistorialPagosPorOrigen', N'P') is null
	exec(N'create procedure dbo.SP_HistorialPagosPorOrigen as return 0;');
go

alter procedure dbo.SP_HistorialPagosPorOrigen
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

-- Historial de pagos entre dos fechas (incluye ambos dias completos)
if object_id(N'dbo.sp_BuscarEntreFechas', N'P') is null
	exec(N'create procedure dbo.sp_BuscarEntreFechas as return 0;');
go

alter procedure dbo.sp_BuscarEntreFechas
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
if object_id(N'dbo.VW_VerHistorialPagosTodos', N'V') is null
	exec(N'create view dbo.VW_VerHistorialPagosTodos as select 1 as Id;');
go

alter view dbo.VW_VerHistorialPagosTodos
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

print 'Migracion aplicada correctamente.';
go
