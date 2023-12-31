USE [master]
GO
/****** Object:  Database [AdministrationResources]    Script Date: 5/12/2023 19:21:54 ******/
CREATE DATABASE [AdministrationResources]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AdministrationResources', FILENAME = N'E:\SQLServer\MSSQL16.MSSQLSERVER\MSSQL\DATA\AdministrationResources.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AdministrationResources_log', FILENAME = N'E:\SQLServer\MSSQL16.MSSQLSERVER\MSSQL\DATA\AdministrationResources_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [AdministrationResources] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AdministrationResources].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AdministrationResources] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AdministrationResources] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AdministrationResources] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AdministrationResources] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AdministrationResources] SET ARITHABORT OFF 
GO
ALTER DATABASE [AdministrationResources] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AdministrationResources] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AdministrationResources] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AdministrationResources] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AdministrationResources] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AdministrationResources] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AdministrationResources] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AdministrationResources] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AdministrationResources] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AdministrationResources] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AdministrationResources] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AdministrationResources] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AdministrationResources] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AdministrationResources] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AdministrationResources] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AdministrationResources] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AdministrationResources] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AdministrationResources] SET RECOVERY FULL 
GO
ALTER DATABASE [AdministrationResources] SET  MULTI_USER 
GO
ALTER DATABASE [AdministrationResources] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AdministrationResources] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AdministrationResources] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AdministrationResources] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AdministrationResources] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AdministrationResources] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AdministrationResources', N'ON'
GO
ALTER DATABASE [AdministrationResources] SET QUERY_STORE = ON
GO
ALTER DATABASE [AdministrationResources] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [AdministrationResources]
GO
/****** Object:  Table [dbo].[Direccion]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Direccion](
	[idDireccion] [int] NOT NULL,
	[localidad] [varchar](45) NULL,
	[calle] [varchar](45) NULL,
	[numero] [int] NULL,
	[piso] [int] NULL,
	[departamento] [varchar](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[idDireccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Incidencias]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Incidencias](
	[idIncidencias] [int] NOT NULL,
	[fecha_solicitud] [date] NULL,
	[fecha_solucion] [date] NULL,
	[estado] [varchar](45) NULL,
	[idTecnico] [int] NULL,
	[detalle] [varchar](140) NULL,
 CONSTRAINT [PK_Incidencias] PRIMARY KEY CLUSTERED 
(
	[idIncidencias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido](
	[idPedido] [int] NOT NULL,
	[fecha_solicitud] [date] NULL,
	[fecha_entrega] [date] NULL,
	[estado] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPedido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pedido_has_Producto]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pedido_has_Producto](
	[Pedido_idPedido] [int] NOT NULL,
	[Producto_idProducto] [int] NOT NULL,
	[Producto_Proveedor_idProveedor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Pedido_idPedido] ASC,
	[Producto_idProducto] ASC,
	[Producto_Proveedor_idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idProducto] [int] NOT NULL,
	[descripcion] [varchar](45) NULL,
	[precio] [decimal](18, 0) NULL,
	[fecha_adquisicion] [date] NULL,
	[fecha_garantia] [date] NULL,
	[Proveedor_idProveedor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC,
	[Proveedor_idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[idProveedor] [int] NOT NULL,
	[cuit] [varchar](45) NULL,
	[razon_social] [varchar](45) NULL,
	[descripcionEmpresa] [varchar](45) NULL,
	[telefono] [varchar](45) NULL,
	[calificacion] [bigint] NULL,
	[calificacion_counter] [bigint] NULL,
	[Direccion_idDireccion] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tecnico]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tecnico](
	[id] [int] NOT NULL,
	[apellido] [varchar](45) NULL,
	[nombre] [varchar](45) NULL,
	[telefono] [varchar](45) NULL,
	[email] [varchar](45) NULL,
	[calificacion] [bigint] NULL,
	[calificacion_counter] [bigint] NULL,
	[Proveedor_idProveedor] [int] NOT NULL,
	[Direccion_idDireccion] [int] NOT NULL,
 CONSTRAINT [PK_Tecnico] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] NULL,
	[Contraseña] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Direccion] ([idDireccion], [localidad], [calle], [numero], [piso], [departamento]) VALUES (1, N'San Miguel de Tucuman', N'Santiago', 10, 1, NULL)
INSERT [dbo].[Direccion] ([idDireccion], [localidad], [calle], [numero], [piso], [departamento]) VALUES (2, N'Colombres', N'Malvianas', 20, 1, N'B')
INSERT [dbo].[Direccion] ([idDireccion], [localidad], [calle], [numero], [piso], [departamento]) VALUES (3, N'Monteros', N'Santa Fe', 30, 2, N'C')
INSERT [dbo].[Direccion] ([idDireccion], [localidad], [calle], [numero], [piso], [departamento]) VALUES (4, N'Famailla', N'San Juan', 40, 1, N'D')
GO
INSERT [dbo].[Incidencias] ([idIncidencias], [fecha_solicitud], [fecha_solucion], [estado], [idTecnico], [detalle]) VALUES (1, CAST(N'2023-01-05' AS Date), CAST(N'2023-08-10' AS Date), N'Resolved', 1, N'Levanta mucha temperatura')
INSERT [dbo].[Incidencias] ([idIncidencias], [fecha_solicitud], [fecha_solucion], [estado], [idTecnico], [detalle]) VALUES (2, CAST(N'2023-02-05' AS Date), CAST(N'2023-02-10' AS Date), N'Resolved', 1, N'Pantalla Rota')
INSERT [dbo].[Incidencias] ([idIncidencias], [fecha_solicitud], [fecha_solucion], [estado], [idTecnico], [detalle]) VALUES (3, CAST(N'2023-03-05' AS Date), CAST(N'2023-07-10' AS Date), N'Resolved', 2, N'levanta mucha temperatura')
INSERT [dbo].[Incidencias] ([idIncidencias], [fecha_solicitud], [fecha_solucion], [estado], [idTecnico], [detalle]) VALUES (4, CAST(N'2023-04-05' AS Date), CAST(N'2023-12-10' AS Date), N'Pending', 3, N'levanta mucha temperatura')
INSERT [dbo].[Incidencias] ([idIncidencias], [fecha_solicitud], [fecha_solucion], [estado], [idTecnico], [detalle]) VALUES (5, CAST(N'2023-04-05' AS Date), CAST(N'2023-12-10' AS Date), N'Pending', 4, N'Pantalla Rota')
INSERT [dbo].[Incidencias] ([idIncidencias], [fecha_solicitud], [fecha_solucion], [estado], [idTecnico], [detalle]) VALUES (6, CAST(N'2023-04-05' AS Date), CAST(N'2023-12-10' AS Date), N'Pending', 4, N'Limpieza')
INSERT [dbo].[Incidencias] ([idIncidencias], [fecha_solicitud], [fecha_solucion], [estado], [idTecnico], [detalle]) VALUES (7, CAST(N'2023-04-05' AS Date), CAST(N'2023-12-10' AS Date), N'Resolved', 3, N'Pantalla Rota')
GO
INSERT [dbo].[Pedido] ([idPedido], [fecha_solicitud], [fecha_entrega], [estado]) VALUES (1, CAST(N'2023-01-10' AS Date), CAST(N'2023-01-15' AS Date), N'Delivered')
INSERT [dbo].[Pedido] ([idPedido], [fecha_solicitud], [fecha_entrega], [estado]) VALUES (2, CAST(N'2023-02-10' AS Date), CAST(N'2023-02-15' AS Date), N'Pending')
INSERT [dbo].[Pedido] ([idPedido], [fecha_solicitud], [fecha_entrega], [estado]) VALUES (3, CAST(N'2023-03-10' AS Date), CAST(N'2023-03-15' AS Date), N'Processing')
INSERT [dbo].[Pedido] ([idPedido], [fecha_solicitud], [fecha_entrega], [estado]) VALUES (4, CAST(N'2023-04-10' AS Date), CAST(N'2023-04-15' AS Date), N'Completed')
GO
INSERT [dbo].[Pedido_has_Producto] ([Pedido_idPedido], [Producto_idProducto], [Producto_Proveedor_idProveedor]) VALUES (1, 1, 1)
INSERT [dbo].[Pedido_has_Producto] ([Pedido_idPedido], [Producto_idProducto], [Producto_Proveedor_idProveedor]) VALUES (2, 2, 2)
INSERT [dbo].[Pedido_has_Producto] ([Pedido_idPedido], [Producto_idProducto], [Producto_Proveedor_idProveedor]) VALUES (3, 3, 3)
INSERT [dbo].[Pedido_has_Producto] ([Pedido_idPedido], [Producto_idProducto], [Producto_Proveedor_idProveedor]) VALUES (4, 4, 4)
GO
INSERT [dbo].[Producto] ([idProducto], [descripcion], [precio], [fecha_adquisicion], [fecha_garantia], [Proveedor_idProveedor]) VALUES (1, N'Televisor', CAST(122000 AS Decimal(18, 0)), CAST(N'2023-11-01' AS Date), CAST(N'2024-01-01' AS Date), 1)
INSERT [dbo].[Producto] ([idProducto], [descripcion], [precio], [fecha_adquisicion], [fecha_garantia], [Proveedor_idProveedor]) VALUES (2, N'PC', CAST(75000 AS Decimal(18, 0)), CAST(N'2023-11-21' AS Date), CAST(N'2024-02-01' AS Date), 1)
INSERT [dbo].[Producto] ([idProducto], [descripcion], [precio], [fecha_adquisicion], [fecha_garantia], [Proveedor_idProveedor]) VALUES (3, N'Celular', CAST(20000 AS Decimal(18, 0)), CAST(N'2023-03-01' AS Date), CAST(N'2024-03-01' AS Date), 3)
INSERT [dbo].[Producto] ([idProducto], [descripcion], [precio], [fecha_adquisicion], [fecha_garantia], [Proveedor_idProveedor]) VALUES (4, N'Impresora', CAST(10000 AS Decimal(18, 0)), CAST(N'2023-04-01' AS Date), CAST(N'2024-04-01' AS Date), 4)
INSERT [dbo].[Producto] ([idProducto], [descripcion], [precio], [fecha_adquisicion], [fecha_garantia], [Proveedor_idProveedor]) VALUES (5, N'Placa de video', CAST(45000 AS Decimal(18, 0)), CAST(N'2023-12-01' AS Date), CAST(N'2024-05-12' AS Date), 4)
GO
INSERT [dbo].[Proveedor] ([idProveedor], [cuit], [razon_social], [descripcionEmpresa], [telefono], [calificacion], [calificacion_counter], [Direccion_idDireccion]) VALUES (1, N'123456789', N'Nvidia', N'Nvidia', N'123-456-789', 10, 4, 1)
INSERT [dbo].[Proveedor] ([idProveedor], [cuit], [razon_social], [descripcionEmpresa], [telefono], [calificacion], [calificacion_counter], [Direccion_idDireccion]) VALUES (2, N'987654321', N'AMD', N'AMD', N'987-654-321', 12, 3, 2)
INSERT [dbo].[Proveedor] ([idProveedor], [cuit], [razon_social], [descripcionEmpresa], [telefono], [calificacion], [calificacion_counter], [Direccion_idDireccion]) VALUES (3, N'111222333', N'SAMSUNG', N'SAMSUNG', N'111-222-333', 20, 4, 3)
INSERT [dbo].[Proveedor] ([idProveedor], [cuit], [razon_social], [descripcionEmpresa], [telefono], [calificacion], [calificacion_counter], [Direccion_idDireccion]) VALUES (4, N'444555666', N'SONY', N'SONY', N'444-555-666', 15, 5, 4)
GO
INSERT [dbo].[Tecnico] ([id], [apellido], [nombre], [telefono], [email], [calificacion], [calificacion_counter], [Proveedor_idProveedor], [Direccion_idDireccion]) VALUES (1, N'Coca', N'Luis', N'111-111-111', N'luiscc@gmail.com', 4, 10, 1, 1)
INSERT [dbo].[Tecnico] ([id], [apellido], [nombre], [telefono], [email], [calificacion], [calificacion_counter], [Proveedor_idProveedor], [Direccion_idDireccion]) VALUES (2, N'Robles', N'Juan', N'222-222-222', N'juany@gmail.com', 3, 8, 2, 2)
INSERT [dbo].[Tecnico] ([id], [apellido], [nombre], [telefono], [email], [calificacion], [calificacion_counter], [Proveedor_idProveedor], [Direccion_idDireccion]) VALUES (3, N'Rodriguez', N'Carlos', N'333-333-333', N'carlos@gmail.com', 5, 12, 3, 3)
INSERT [dbo].[Tecnico] ([id], [apellido], [nombre], [telefono], [email], [calificacion], [calificacion_counter], [Proveedor_idProveedor], [Direccion_idDireccion]) VALUES (4, N'Rios', N'Santiago', N'444-444-444', N'santy@gmail.com', 4, 9, 4, 4)
GO
INSERT [dbo].[Usuario] ([IdUsuario], [Contraseña], [Nombre]) VALUES (1, N'123', N'Admin')
GO
ALTER TABLE [dbo].[Incidencias]  WITH CHECK ADD  CONSTRAINT [FK_Incidencias_Tecnico] FOREIGN KEY([idTecnico])
REFERENCES [dbo].[Tecnico] ([id])
GO
ALTER TABLE [dbo].[Incidencias] CHECK CONSTRAINT [FK_Incidencias_Tecnico]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD FOREIGN KEY([Proveedor_idProveedor])
REFERENCES [dbo].[Proveedor] ([idProveedor])
GO
ALTER TABLE [dbo].[Proveedor]  WITH CHECK ADD FOREIGN KEY([Direccion_idDireccion])
REFERENCES [dbo].[Direccion] ([idDireccion])
GO
ALTER TABLE [dbo].[Tecnico]  WITH CHECK ADD  CONSTRAINT [FK__Tecnico__Direcci__3D5E1FD2] FOREIGN KEY([Direccion_idDireccion])
REFERENCES [dbo].[Direccion] ([idDireccion])
GO
ALTER TABLE [dbo].[Tecnico] CHECK CONSTRAINT [FK__Tecnico__Direcci__3D5E1FD2]
GO
ALTER TABLE [dbo].[Tecnico]  WITH CHECK ADD  CONSTRAINT [FK__Tecnico__Proveed__3C69FB99] FOREIGN KEY([Proveedor_idProveedor])
REFERENCES [dbo].[Proveedor] ([idProveedor])
GO
ALTER TABLE [dbo].[Tecnico] CHECK CONSTRAINT [FK__Tecnico__Proveed__3C69FB99]
GO
/****** Object:  StoredProcedure [dbo].[CalificarTecnico]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--USE [SpFramework]
--declare @xmlData xml
--set @xmlData='
--<ArrayOfPersona xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
--  <Persona>
--    <PersonaId>1</PersonaId>
--    <Edad>23</Edad>
--    <Name>Tomas</Name>
--  </Persona>
--</ArrayOfPersona>
--'
--exec [dbo].[InsertarPersonasDesdeXML] @xmlData


CREATE PROCEDURE [dbo].[CalificarTecnico] (@id int ,@Calification bigint)
AS
BEGIN
update Tecnico set [calificacion_counter]=[calificacion_counter]+1
                   ,[calificacion]=[calificacion]+[calificacion]
where id=@id
END
GO
/****** Object:  StoredProcedure [dbo].[CreateTecnicos]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[CreateTecnicos] (@xmlData XML)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN;
       DECLARE @xmlHandle INT
EXEC sp_xml_preparedocument @xmlHandle OUTPUT, @xmlData

INSERT INTO [dbo].[Tecnico] ([apellido],[nombre],[telefono],[email],[calificacion],[calificacion_counter])
SELECT Apellido,Nombre,Telefono,Email,0,0
FROM OPENXML(@xmlHandle, 'ArrayOfTecnico/Tecnico', 2)
WITH
(
    Apellido INT
    ,Nombre varchar(45)
	,Telefono varchar(45)
	,Email varchar(45)
)

EXEC sp_xml_removedocument @xmlHandle

        Select  SCOPE_IDENTITY() as ID 
        
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH

        ROLLBACK TRANSACTION;
		
		THROW;
		
    END CATCH;
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteTecnico]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[DeleteTecnico] (@id int)
AS
BEGIN
delete Tecnico where id=@id
END
GO
/****** Object:  StoredProcedure [dbo].[Get_Incidenciass]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE procedure [dbo].[Get_Incidenciass] 

as

begin

SELECT [idIncidencias]
      ,[fecha_solicitud]
      ,[fecha_solucion]
      ,[estado]
	   ,[detalle]
      ,[idTecnico]
     
  FROM [AdministrationResources].[dbo].[Incidencias]

end;

/*

(id: _Incidencias.Count + 1,
                                        fechaSolicitud: DateTime.Now,
                                        fechaSolucion: fechaSolucionPicker.Value,
                                        estado: txtEstado.Text,
                                        detalle: txtDescripcion.Text
*/
GO
/****** Object:  StoredProcedure [dbo].[Get_Productos]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Get_Productos] 

as

begin


SELECT  [idProducto]
      ,[descripcion]
      ,[precio]
      ,[fecha_adquisicion]
      ,[fecha_garantia]
      ,[Proveedor].[descripcionEmpresa]
  FROM [AdministrationResources].[dbo].[Producto]
  inner join [dbo].[Proveedor] on [Producto].[Proveedor_idProveedor]=[Proveedor].[idProveedor]

end;
GO
/****** Object:  StoredProcedure [dbo].[Get_Proveedors]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Get_Proveedors] 

as

begin


SELECT [idProveedor]
      ,[cuit]
      ,[razon_social]
      ,[descripcionEmpresa]
      ,[telefono]
      ,cast(([calificacion] / [calificacion_counter]) as float) as calification
      ,[Direccion_idDireccion]
  FROM [AdministrationResources].[dbo].[Proveedor]

end;
GO
/****** Object:  StoredProcedure [dbo].[Get_ReportInisidencias]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Get_ReportInisidencias] 

as

begin

select  AbS(DATEDIFF(DAY,[fecha_solucion],[fecha_solicitud])), [detalle]
from [dbo].[Incidencias]


end;

GO
/****** Object:  StoredProcedure [dbo].[Get_ReportProducts]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Get_ReportProducts] 

as

begin


SELECT  
	   [Proveedor].[descripcionEmpresa] as Descripcion
 	   ,count(idProducto) as Cantidad
  FROM [AdministrationResources].[dbo].[Producto]
  inner join [dbo].[Proveedor] on [Producto].[Proveedor_idProveedor]=[Proveedor].[idProveedor]
  group by [Proveedor].[idProveedor],[Proveedor].[descripcionEmpresa]
  
 

end;
GO
/****** Object:  StoredProcedure [dbo].[Get_Tecnicos]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[Get_Tecnicos] 

as

begin

SELECT [id]
      ,[apellido]
      ,[nombre]
      ,t.[telefono]
      ,[email]
      ,(t.[calificacion] / t.[calificacion_counter]) as calification
      --,[calificacion_counter]
    --  ,[Proveedor_idProveedor]
	   , Proveedor.descripcionEmpresa
     -- ,[Direccion_idDireccion]
  FROM [AdministrationResources].[dbo].[Tecnico] as t
  inner join Proveedor on  t.[Proveedor_idProveedor]=Proveedor.idProveedor

end;
GO
/****** Object:  StoredProcedure [dbo].[Get_Usuarios]    Script Date: 5/12/2023 19:21:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Get_Usuarios] as
begin
SELECT --[IdUsuario]
      [Nombre]
      ,[Contraseña]
  FROM [AdministrationResources].[dbo].[Usuario]
end;
GO
USE [master]
GO
ALTER DATABASE [AdministrationResources] SET  READ_WRITE 
GO
