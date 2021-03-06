USE [master]
GO
/****** Object:  Database [db_sistema_ventas]    Script Date: 06/03/2020 11:20:50 a.m. ******/
CREATE DATABASE [db_sistema_ventas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_sistema_ventas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\db_sistema_ventas.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_sistema_ventas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\db_sistema_ventas_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_sistema_ventas] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_sistema_ventas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_sistema_ventas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [db_sistema_ventas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_sistema_ventas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_sistema_ventas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_sistema_ventas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_sistema_ventas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET RECOVERY FULL 
GO
ALTER DATABASE [db_sistema_ventas] SET  MULTI_USER 
GO
ALTER DATABASE [db_sistema_ventas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_sistema_ventas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_sistema_ventas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_sistema_ventas] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_sistema_ventas', N'ON'
GO
USE [db_sistema_ventas]
GO
/****** Object:  StoredProcedure [dbo].[anular_venta]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[anular_venta]
@id_venta int
as
update detalle_venta set nEstado = 2 where id_venta = @id_venta

DECLARE @tabla table(id_detalle_venta int, id_producto int, cantidad int)
INSERT INTO @tabla(id_detalle_venta, id_producto, cantidad) SELECT id_detalle_venta, id_producto, cantidad FROM detalle_venta WHERE id_venta = @id_venta
DECLARE @contador int = (SELECT COUNT(*) FROM @tabla)
while (SELECT @contador) > 0
BEGIN
	DECLARE @id_detalle_venta int = (SELECT TOP(1) id_detalle_venta FROM @tabla ORDER BY id_detalle_venta)
	DECLARE @id_producto int = (SELECT TOP(1) id_producto FROM @tabla ORDER BY id_detalle_venta)
	DECLARE @cantidad int = (SELECT TOP(1) cantidad FROM @tabla ORDER BY id_detalle_venta)

	UPDATE producto SET stock = stock + @cantidad WHERE producto.id_producto = @id_producto

	DELETE FROM @tabla WHERE id_detalle_venta = @id_detalle_venta

	SET @contador = (SELECT COUNT(*) FROM @tabla)
END
GO
/****** Object:  StoredProcedure [dbo].[buscar_cliente]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_cliente]
@nombre varchar(50),
@filtro varchar(50),
@columna varchar(50)
as
if (@nombre = 'dni')
	set @columna = (select name from sys.columns where name = @nombre and column_id = 4)

else
	set @columna = (select name from sys.columns where name = @nombre and column_id = 3)

 if (@columna = 'dni')
	select * from cliente where dni = @filtro

else if (@columna = 'nombres')
	select * from cliente where nombres like '%' + @filtro + '%'
else
	select * from cliente where apellidos like '%' + @filtro + '%'

GO
/****** Object:  StoredProcedure [dbo].[editar_categoria]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_categoria]
@id_categoria int,
@nombre_categoria varchar(50)
as
update categoria set nombre_categoria = @nombre_categoria
where id_categoria = @id_categoria

GO
/****** Object:  StoredProcedure [dbo].[editar_cliente]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_cliente]
@idcliente int,
@dni varchar(8),
@nombres varchar(50),
@apellidos varchar(50),
@telefono varchar(20),
@direccion varchar(100)
as
update cliente set dni = @dni, nombres = @nombres, apellidos = @apellidos, telefono = @telefono, direccion = @direccion
where id_cliente = @idcliente

GO
/****** Object:  StoredProcedure [dbo].[editar_producto]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[editar_producto]
@id_producto int,
@id_categoria int,
@nombre varchar(50),
@cantidad int,
@precio decimal(18,2),
@mensaje varchar(100) OUTPUT,
@num_documento varchar(50),
@observacion varchar(100)
as


	update producto set id_categoria = @id_categoria, nombre = @nombre, stock = stock + @cantidad, precio = @precio
	where id_producto = @id_producto
	SET @mensaje = 'Null';

if @cantidad <> 0 and @num_documento <> ''
	EXEC inserta_movimiento @id_producto, @cantidad, 'entrada', @num_documento, '';
GO
/****** Object:  StoredProcedure [dbo].[editar_usuario]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_usuario]

@id_usuario int,
@nombres varchar(50),
@apellidos varchar(50),
@dni varchar(50),
@username varchar(50),
@password varchar(50),
@estatus tinyint

AS

update usuario set nombres = @nombres, apellidos = @apellidos, dni = @dni, username = @username, password = @password, estatus = @estatus

where id_usuario = @id_usuario


GO
/****** Object:  StoredProcedure [dbo].[editar_venta]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[editar_venta]
@id_venta int,
@id_cliente int,
@fecha_venta date,
@tipo_documento varchar(20),
@num_documento varchar(50)
as
update venta set id_cliente = @id_cliente, fecha_venta = @fecha_venta, tipo_documento = @tipo_documento, num_documento = @num_documento
where id_venta = @id_venta

GO
/****** Object:  StoredProcedure [dbo].[eliminar_categoria]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_categoria]
@id_categoria int
as
delete from categoria where id_categoria = @id_categoria

GO
/****** Object:  StoredProcedure [dbo].[eliminar_cliente]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_cliente]
@idcliente int
as
delete from cliente where id_cliente = @idcliente

GO
/****** Object:  StoredProcedure [dbo].[eliminar_detalle_venta]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_detalle_venta]
@id_detalle_venta int
as
delete from detalle_venta
where id_detalle_venta = @id_detalle_venta

GO
/****** Object:  StoredProcedure [dbo].[eliminar_producto]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_producto]
@id_producto int
as
delete from producto where id_producto = @id_producto

GO
/****** Object:  StoredProcedure [dbo].[eliminar_usuario]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_usuario]

@id_usuario int

as

delete from usuario where id_usuario = @id_usuario


GO
/****** Object:  StoredProcedure [dbo].[eliminar_venta]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_venta]
@id_venta int
as
delete from venta where id_venta = @id_venta

GO
/****** Object:  StoredProcedure [dbo].[genera_comp_venta]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[genera_comp_venta]
@idventa int
as 
SELECT        dbo.venta.fecha_venta, dbo.venta.tipo_documento, dbo.venta.num_documento, dbo.producto.nombre AS producto, dbo.detalle_venta.cantidad, dbo.producto.precio, dbo.detalle_venta.precio_unitario AS total, 
                         dbo.cliente.dni, dbo.cliente.nombres, dbo.cliente.apellidos, dbo.cliente.direccion
FROM            dbo.venta INNER JOIN
                         dbo.detalle_venta ON dbo.venta.id_venta = dbo.detalle_venta.id_venta INNER JOIN
                         dbo.producto ON dbo.detalle_venta.id_producto = dbo.producto.id_producto INNER JOIN
                         dbo.cliente ON dbo.venta.id_cliente = dbo.cliente.id_cliente

				WHERE venta.id_venta = @idventa

GO
/****** Object:  StoredProcedure [dbo].[inserta_movimiento]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[inserta_movimiento]
@id_producto int,
@cantidad int,
@tipo_movimiento varchar(50),
@num_documento varchar(50),
@observacion varchar(100)
AS

if @observacion <> ''
SET @observacion = 'producto insertado automaticamente';

INSERT INTO inventario (id_producto, tipo_movimiento, fecha_movimiento, cantidad, observacion, num_documento)
VALUES
(@id_producto, @tipo_movimiento, GETDATE(), @cantidad, @observacion, @num_documento);
GO
/****** Object:  StoredProcedure [dbo].[insertar_categoria]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_categoria]
@nombre_categoria varchar(50)
as
insert into categoria (nombre_categoria) values (@nombre_categoria)

GO
/****** Object:  StoredProcedure [dbo].[insertar_cliente]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_cliente]
@dni varchar(8),
@nombres varchar(50),
@apellidos varchar(50),
@telefono varchar(20),
@direccion varchar(100)
as
insert into cliente (dni, nombres, apellidos, telefono, direccion) values (@dni, @nombres, @apellidos, @telefono, @direccion)

GO
/****** Object:  StoredProcedure [dbo].[insertar_detalle_venta]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_detalle_venta]
@id_venta int,
@id_producto int,
@cantidad int,
@precio_unitario decimal(18,2),
@num_documento varchar(50)
as
SET @num_documento = (SELECT num_documento FROM venta where id_venta = @id_venta)
insert into detalle_venta (id_venta, id_producto, cantidad, precio_unitario) values
(@id_venta, @id_producto, @cantidad, @precio_unitario)

EXEC inserta_movimiento @id_producto, @cantidad, 'salida', @num_documento, 'Salida por venta'
GO
/****** Object:  StoredProcedure [dbo].[insertar_producto]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_producto]
@id_categoria int,
@nombre varchar(50),
@cantidad int,
@precio decimal(18,2),
@num_documento varchar(50),
@mensaje varchar(100) OUTPUT,
@observacion varchar(100),
@id_producto int
as

if
	(SELECT COUNT(nombre) FROM producto where nombre = @nombre and id_categoria = @id_categoria) <> 0
		SET @mensaje = 'El producto ya existe';
else
	insert into producto (id_categoria, nombre, stock, precio) values
	(@id_categoria, @nombre, @cantidad, @precio)
	SET @mensaje = 'Null';

SET @id_producto = SCOPE_IDENTITY()
EXEC inserta_movimiento @id_producto, @cantidad, 'entrada', @num_documento, ''
GO
/****** Object:  StoredProcedure [dbo].[insertar_usuario]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_usuario]

@nombres varchar(50),
@apellidos varchar(50),
@dni varchar(50),
@username varchar(50),
@password varchar(50)

AS

insert into usuario (nombres, apellidos, dni, username, password, estatus) values
	(@nombres, @apellidos, @dni, @username, @password, 1)


GO
/****** Object:  StoredProcedure [dbo].[insertar_venta]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_venta]
@id_cliente int,
@fecha_venta date,
@tipo_documento varchar(20),
@num_documento varchar(50),
@id_ventaI int OUTPUT
as
insert into venta (id_cliente, fecha_venta, tipo_documento, num_documento) values
(@id_cliente, @fecha_venta, @tipo_documento, @num_documento)

set @id_ventaI = SCOPE_IDENTITY()
GO
/****** Object:  StoredProcedure [dbo].[mostrar_categoria]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_categoria]
as
select * from categoria

GO
/****** Object:  StoredProcedure [dbo].[mostrar_cliente]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_cliente]
as
select * from cliente order by dni

GO
/****** Object:  StoredProcedure [dbo].[mostrar_movimientos]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[mostrar_movimientos]

@id_producto int

AS

SELECT tipo_movimiento, CONVERT(varchar, fecha_movimiento, 103) as fecha, cantidad, observacion, num_documento as nro_comprobante FROM inventario WHERE id_producto = @id_producto


GO
/****** Object:  StoredProcedure [dbo].[mostrar_producto]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_producto]
as
select producto.id_producto, producto.id_categoria, producto.nombre, categoria.nombre_categoria as categoria, producto.stock, producto.precio from producto
inner join categoria on producto.id_categoria = categoria.id_categoria
order by producto.id_producto desc
GO
/****** Object:  StoredProcedure [dbo].[mostrar_usuario]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_usuario]
as
SELECT * FROM usuario

GO
/****** Object:  StoredProcedure [dbo].[mostrar_venta]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_venta]
as
SELECT DISTINCT dbo.venta.id_venta, dbo.venta.id_cliente, dbo.venta.num_documento as nro_comprobante, dbo.venta.tipo_documento as comprobante, dbo.venta.fecha_venta as fecha, dbo.cliente.dni, dbo.cliente.nombres, dbo.cliente.apellidos, 

CASE WHEN dbo.detalle_venta.nEstado = 1 THEN
'registrado'

END
as estado
FROM            dbo.cliente INNER JOIN
                         dbo.venta ON dbo.cliente.id_cliente = dbo.venta.id_cliente INNER JOIN
						 dbo.detalle_venta ON dbo.detalle_venta.id_venta = dbo.venta.id_venta
WHERE dbo.detalle_venta.nEstado = 1
GO
/****** Object:  StoredProcedure [dbo].[verifica_usuario]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[verifica_usuario]

@username varchar(50),
@password varchar(50),
@mensaje varchar(100) OUTPUT

as

SELECT * FROM usuario where username = @username and password = @password and estatus = 1

IF
	(SELECT estatus FROM usuario where username = @username and password = @password) <> 1
	SET @mensaje = 'el usuario se encuentra bloqueado'
ELSE
	SET @mensaje = 'Null'
GO
/****** Object:  StoredProcedure [dbo].[verifica_venta]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[verifica_venta]
@tipo_comprobante varchar(20),
@num_comprobante varchar(50),
@mensaje varchar(100) output
AS
IF
	(SELECT COUNT(id_venta) from venta where tipo_documento = @tipo_comprobante and num_documento = @num_comprobante) = 1
	SET @mensaje = 'la venta ya existe'
ELSE
	SET @mensaje = 'Null'

GO
/****** Object:  Table [dbo].[categoria]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[nombre_categoria] [varchar](50) NOT NULL,
 CONSTRAINT [PK_categoria] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[id_cliente] [int] IDENTITY(1,1) NOT NULL,
	[dni] [varchar](8) NOT NULL,
	[nombres] [varchar](50) NOT NULL,
	[apellidos] [varchar](50) NOT NULL,
	[telefono] [varchar](20) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[id_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[detalle_venta]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_venta](
	[id_detalle_venta] [int] IDENTITY(1,1) NOT NULL,
	[id_venta] [int] NOT NULL,
	[id_producto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[precio_unitario] [decimal](18, 2) NOT NULL,
	[nEstado] [tinyint] NULL,
 CONSTRAINT [PK_detalle_venta] PRIMARY KEY CLUSTERED 
(
	[id_detalle_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[inventario]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[inventario](
	[id_inventario] [int] IDENTITY(1,1) NOT NULL,
	[id_producto] [int] NOT NULL,
	[tipo_movimiento] [varchar](50) NOT NULL,
	[fecha_movimiento] [datetime] NOT NULL,
	[cantidad] [int] NOT NULL,
	[observacion] [varchar](100) NULL,
	[num_documento] [varchar](50) NOT NULL,
 CONSTRAINT [PK_inventario] PRIMARY KEY CLUSTERED 
(
	[id_inventario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[inventario] SET (LOCK_ESCALATION = AUTO)
GO
/****** Object:  Table [dbo].[producto]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[id_categoria] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[stock] [int] NOT NULL,
	[precio] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_producto_1] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](50) NOT NULL,
	[apellidos] [varchar](50) NOT NULL,
	[dni] [varchar](8) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[estatus] [tinyint] NOT NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[venta]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[venta](
	[id_venta] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [int] NOT NULL,
	[fecha_venta] [date] NOT NULL,
	[tipo_documento] [varchar](20) NOT NULL,
	[num_documento] [varchar](50) NOT NULL,
 CONSTRAINT [PK_venta_1] PRIMARY KEY CLUSTERED 
(
	[id_venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id_producto])
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_producto]
GO
ALTER TABLE [dbo].[detalle_venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle_venta_venta] FOREIGN KEY([id_venta])
REFERENCES [dbo].[venta] ([id_venta])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detalle_venta] CHECK CONSTRAINT [FK_detalle_venta_venta]
GO
ALTER TABLE [dbo].[inventario]  WITH CHECK ADD  CONSTRAINT [FK_inventario_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id_producto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[inventario] CHECK CONSTRAINT [FK_inventario_producto]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categoria] ([id_categoria])
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_categoria]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_venta_cliente] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[cliente] ([id_cliente])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_venta_cliente]
GO
/****** Object:  Trigger [dbo].[reducir_stock]    Script Date: 06/03/2020 11:20:50 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[reducir_stock]
ON [dbo].[detalle_venta]
AFTER INSERT
AS
BEGIN
DECLARE @id_producto int
DECLARE @cantidad int
SET @id_producto = (select id_producto FROM inserted)
SET @cantidad = (select cantidad FROM inserted)
UPDATE producto
SET producto.stock = producto.stock - @cantidad
WHERE producto.id_producto = @id_producto

END
GO
USE [master]
GO
ALTER DATABASE [db_sistema_ventas] SET  READ_WRITE 
GO
