USE [master]
GO
/****** Object:  Database [WoodAdicctionGym]    Script Date: 11/07/2024 19:10:54 ******/
CREATE DATABASE [WoodAdicctionGym]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WoodAdicctionGym', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\WoodAdicctionGym.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WoodAdicctionGym_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\WoodAdicctionGym_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [WoodAdicctionGym] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WoodAdicctionGym].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WoodAdicctionGym] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET ARITHABORT OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WoodAdicctionGym] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WoodAdicctionGym] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WoodAdicctionGym] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WoodAdicctionGym] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WoodAdicctionGym] SET  MULTI_USER 
GO
ALTER DATABASE [WoodAdicctionGym] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WoodAdicctionGym] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WoodAdicctionGym] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WoodAdicctionGym] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WoodAdicctionGym] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WoodAdicctionGym] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [WoodAdicctionGym] SET QUERY_STORE = ON
GO
ALTER DATABASE [WoodAdicctionGym] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [WoodAdicctionGym]
GO
/****** Object:  Table [dbo].[AccesosDiarios]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccesosDiarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DniCliente] [int] NOT NULL,
	[FechaAcceso] [date] NOT NULL,
 CONSTRAINT [PK_AccesosDiarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[dni] [int] NOT NULL,
	[nroSocio] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[fechaNacimiento] [date] NULL,
	[telefono] [varchar](50) NULL,
	[imagenUrl] [varchar](100) NULL,
	[fechaInicio] [date] NOT NULL,
	[activo] [bit] NULL,
	[idTipoMembresia] [int] NOT NULL,
	[Saldo] [decimal](10, 2) NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Membresias]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Membresias](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[precio] [decimal](10, 2) NOT NULL,
	[descripcion] [varchar](200) NULL,
	[duracion] [int] NOT NULL,
 CONSTRAINT [PK_Membresias] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MetodosPago]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MetodosPago](
	[idMetodoPago] [int] IDENTITY(1,1) NOT NULL,
	[nombreMetodoPago] [varchar](100) NOT NULL,
 CONSTRAINT [PK_MetodosPago] PRIMARY KEY CLUSTERED 
(
	[idMetodoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MovimientosCaja]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MovimientosCaja](
	[transaccionId] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[descripcion] [varchar](200) NULL,
	[monto] [decimal](10, 2) NOT NULL,
	[metodoPagoId] [int] NOT NULL,
 CONSTRAINT [PK_MovimientosCaja] PRIMARY KEY CLUSTERED 
(
	[transaccionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AccesosDiarios]  WITH CHECK ADD  CONSTRAINT [FK_AccesosDiarios_Clientes] FOREIGN KEY([DniCliente])
REFERENCES [dbo].[Clientes] ([dni])
GO
ALTER TABLE [dbo].[AccesosDiarios] CHECK CONSTRAINT [FK_AccesosDiarios_Clientes]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Membresias] FOREIGN KEY([idTipoMembresia])
REFERENCES [dbo].[Membresias] ([id])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Membresias]
GO
ALTER TABLE [dbo].[MovimientosCaja]  WITH CHECK ADD  CONSTRAINT [FK_MovimientosCaja_MetodosPago] FOREIGN KEY([metodoPagoId])
REFERENCES [dbo].[MetodosPago] ([idMetodoPago])
GO
ALTER TABLE [dbo].[MovimientosCaja] CHECK CONSTRAINT [FK_MovimientosCaja_MetodosPago]
GO
/****** Object:  StoredProcedure [dbo].[BuscarCliente]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[BuscarCliente]
@dni int
as
 SELECT
        dni,
        C.nroSocio,
        C.nombre,
        C.apellido,
        C.fechaNacimiento,
        C.telefono,
        C.imagenUrl,
        C.fechaInicio,
        C.activo,
		C.Saldo,
        M.id,
        M.nombre AS Nombre,
        M.precio,
        M.descripcion,
        M.duracion
    FROM Clientes C, Membresias M
    where C.idTipoMembresia = M.id And C.dni = @dni
GO
/****** Object:  StoredProcedure [dbo].[ExistenMovimientosParaFecha]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ExistenMovimientosParaFecha]
@fecha DATE,
@esCierreSemanal BIT
AS
BEGIN
    IF @esCierreSemanal = 1
    BEGIN
        -- Cierre de caja semanal
        SELECT COUNT(*)
		FROM MovimientosCaja
        WHERE fecha >= DATEADD(DAY, -7, @fecha) AND fecha <= @fecha;
    END
    ELSE
    BEGIN
        -- Cierre de caja diario
        SELECT COUNT(*)
		FROM MovimientosCaja
        WHERE fecha = @fecha;
    END
END
GO
/****** Object:  StoredProcedure [dbo].[ObtenerPrecioMembresia]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ObtenerPrecioMembresia]
@id int 
as
select precio from Membresias where id = @id
GO
/****** Object:  StoredProcedure [dbo].[storedAgregarMembresia]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[storedAgregarMembresia]
@nombre varchar(50),
@precio decimal(10,2),
@descripcion varchar(200),
@duracion int
as
insert into Membresias values (@nombre, @precio, @descripcion, @duracion)
GO
/****** Object:  StoredProcedure [dbo].[storedAgregarMovimiento]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[storedAgregarMovimiento]
@fecha date,
@descripcion varchar(200),
@monto decimal(10,2),
@metodoPagoId int
as
insert into MovimientosCaja values (@fecha, @descripcion, @monto, @metodoPagoId)
GO
/****** Object:  StoredProcedure [dbo].[storedAltaCliente]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[storedAltaCliente]
@dni int,
@nombre varchar(50),
@apellido varchar(50),
@fechaNacimiento date,
@telefono varchar(50),
@imagenUrl varchar(100),
@fechaInicio date,
@activo bit,
@idTipoMembresia int,
@saldo decimal(10,2)
as
insert into Clientes values (@dni, @nombre, @apellido, @fechaNacimiento, @telefono, @imagenUrl, @fechaInicio, @activo, @idTipoMembresia, @saldo)
GO
/****** Object:  StoredProcedure [dbo].[storedCierreCaja]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[storedCierreCaja]
    @fecha DATE,
    @esCierreSemanal BIT
AS
BEGIN
    IF @esCierreSemanal = 1
    BEGIN
        -- Cierre de caja semanal para efectivo
        SELECT 
            SUM(CASE WHEN MetodoPagoId = 1 AND monto > 0 THEN monto ELSE 0 END) AS IngresosEfectivo,
            SUM(CASE WHEN MetodoPagoId = 1 AND monto < 0 THEN monto ELSE 0 END) AS GastosEfectivo,
            SUM(CASE WHEN MetodoPagoId = 2 AND monto > 0 THEN monto ELSE 0 END) AS IngresosTransferencias,
            SUM(CASE WHEN MetodoPagoId = 2 AND monto < 0 THEN monto ELSE 0 END) AS GastosTransferencias,
            SUM(CASE WHEN monto > 0 THEN monto ELSE 0 END) AS IngresosGenerales,
            SUM(CASE WHEN monto < 0 THEN monto ELSE 0 END) AS GastosGenerales,
            SUM(CASE WHEN MetodoPagoId = 1 THEN monto ELSE 0 END) AS TotalEfectivo,
            SUM(CASE WHEN MetodoPagoId = 2 THEN monto ELSE 0 END) AS TotalTransferencia
        FROM MovimientosCaja
        WHERE fecha >= DATEADD(DAY, -7, @fecha) AND fecha <= @fecha;
    END
    ELSE
    BEGIN
        -- Cierre de caja diario para efectivo y transferencia
        SELECT 
            SUM(CASE WHEN MetodoPagoId = 1 AND monto > 0 THEN monto ELSE 0 END) AS IngresosEfectivo,
            SUM(CASE WHEN MetodoPagoId = 1 AND monto < 0 THEN monto ELSE 0 END) AS GastosEfectivo,
            SUM(CASE WHEN MetodoPagoId = 2 AND monto > 0 THEN monto ELSE 0 END) AS IngresosTransferencias,
            SUM(CASE WHEN MetodoPagoId = 2 AND monto < 0 THEN monto ELSE 0 END) AS GastosTransferencias,
            SUM(CASE WHEN monto > 0 THEN monto ELSE 0 END) AS IngresosGenerales,
            SUM(CASE WHEN monto < 0 THEN monto ELSE 0 END) AS GastosGenerales,
            SUM(CASE WHEN MetodoPagoId = 1 THEN monto ELSE 0 END) AS TotalEfectivo,
            SUM(CASE WHEN MetodoPagoId = 2 THEN monto ELSE 0 END) AS TotalTransferencia
        FROM MovimientosCaja
        WHERE fecha = @fecha;
    END
END
GO
/****** Object:  StoredProcedure [dbo].[storedEliminarMembresia]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[storedEliminarMembresia]
@id int
as
delete from Membresias where id = @id
GO
/****** Object:  StoredProcedure [dbo].[storedIngreso]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[storedIngreso]
@dni int,
@fecha date
as
insert into AccesosDiarios values (@dni, @fecha)
GO
/****** Object:  StoredProcedure [dbo].[storedListarClientes]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[storedListarClientes]
AS
BEGIN
    UPDATE C
    SET C.activo = CASE
        WHEN DATEADD(DAY, M.duracion, C.fechaInicio) < GETDATE() THEN 0
        ELSE 1
    END
    FROM Clientes C
    INNER JOIN Membresias M ON C.idTipoMembresia = M.id;
    
    SELECT
        dni,
        C.nroSocio,
        C.nombre,
        C.apellido,
        C.fechaNacimiento,
        C.telefono,
        C.imagenUrl,
        C.fechaInicio,
        C.activo,
		C.Saldo,
        M.id,
        M.nombre AS Nombre,
        M.precio,
        M.descripcion,
        M.duracion
    FROM Clientes C
    INNER JOIN Membresias M ON C.idTipoMembresia = M.id;
END
GO
/****** Object:  StoredProcedure [dbo].[storedListarMembresias]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[storedListarMembresias] as
select id, nombre, precio, descripcion, duracion from Membresias
GO
/****** Object:  StoredProcedure [dbo].[storedListarMetodosPago]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[storedListarMetodosPago] as
select idMetodoPago, nombreMetodoPago from MetodosPago
GO
/****** Object:  StoredProcedure [dbo].[storedListarMovimientosCaja]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[storedListarMovimientosCaja] AS
select transaccionId, fecha, descripcion, monto, idMetodoPago, nombreMetodoPago
from MovimientosCaja, MetodosPago
where metodoPagoId = idMetodoPago
GO
/****** Object:  StoredProcedure [dbo].[storedListarMovimientosFiltro]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[storedListarMovimientosFiltro]
    @fecha DATE,
    @idMetodoPago INT
AS
BEGIN
    SELECT MC.transaccionId, MC.fecha, MC.descripcion, MC.monto, MP.idMetodoPago, MP.nombreMetodoPago
    FROM MovimientosCaja MC
    JOIN MetodosPago MP ON MC.metodoPagoId = MP.idMetodoPago
    WHERE MC.fecha = @fecha
    AND (@idMetodoPago = -1 OR MP.idMetodoPago = @idMetodoPago);
END;
GO
/****** Object:  StoredProcedure [dbo].[storedModificarCliente]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[storedModificarCliente] 
@dni int,
@nombre varchar(50),
@apellido varchar(50),
@fechaNacimiento date,
@telefono varchar(50),
@imagenUrl varchar(100),
@fechaInicio date,
@activo bit,
@idTipoMembresia int,
@saldo decimal(10,2),
@socioAmodificar int
as
update Clientes set dni = @dni, nombre = @nombre, apellido = @apellido, fechaNacimiento = @fechaNacimiento, telefono = @telefono,
imagenUrl = @imagenUrl, fechaInicio = @fechaInicio, activo = @activo, idTipoMembresia = @idTipoMembresia, saldo = @saldo
where dni = @socioAmodificar
GO
/****** Object:  StoredProcedure [dbo].[storedModificarMembresia]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[storedModificarMembresia]
@nombre varchar(50),
@precio decimal(10,2),
@descripcion varchar(200),
@duracion int,
@id int
as
UPDATE Membresias
SET nombre = @nombre,
    precio = @precio,
    descripcion = @descripcion,
    duracion = @duracion
WHERE id = @id
GO
/****** Object:  StoredProcedure [dbo].[storedModificarMovimiento]    Script Date: 11/07/2024 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[storedModificarMovimiento]
@fecha date,
@descripcion varchar(200),
@monto decimal(10,2),
@metodoPagoId int,
@transaccionId int
as
update MovimientosCaja set fecha = @fecha, descripcion = @descripcion, monto = @monto, metodoPagoId = @metodoPagoId
where transaccionId = @transaccionId
GO
USE [master]
GO
ALTER DATABASE [WoodAdicctionGym] SET  READ_WRITE 
GO
