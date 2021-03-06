USE [master]
GO
/****** Object:  Database [stage pro]    Script Date: 04/09/2021 13:48:31 ******/
CREATE DATABASE [stage pro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'stage pro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\stage pro.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'stage pro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\stage pro_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [stage pro] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [stage pro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [stage pro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [stage pro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [stage pro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [stage pro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [stage pro] SET ARITHABORT OFF 
GO
ALTER DATABASE [stage pro] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [stage pro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [stage pro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [stage pro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [stage pro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [stage pro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [stage pro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [stage pro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [stage pro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [stage pro] SET  ENABLE_BROKER 
GO
ALTER DATABASE [stage pro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [stage pro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [stage pro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [stage pro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [stage pro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [stage pro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [stage pro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [stage pro] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [stage pro] SET  MULTI_USER 
GO
ALTER DATABASE [stage pro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [stage pro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [stage pro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [stage pro] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [stage pro] SET DELAYED_DURABILITY = DISABLED 
GO
USE [stage pro]
GO
/****** Object:  Table [dbo].[clientes_cf]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[clientes_cf](
	[dni] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[sexo] [nvarchar](50) NULL,
	[fecha_de_nacimiento] [date] NULL,
	[ocupacion] [nvarchar](50) NULL,
	[fecha_de_ingreso] [date] NULL,
	[activo] [nvarchar](50) NULL,
	[fecha_de_egreso] [date] NULL,
	[motivo_egreso] [nvarchar](50) NULL,
 CONSTRAINT [PK_clientes cf] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[compras]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compras](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_proveedor] [nvarchar](50) NOT NULL,
	[fecha] [date] NOT NULL,
	[proveedores] [nvarchar](50) NOT NULL,
	[factura] [nvarchar](50) NOT NULL,
	[total] [int] NOT NULL,
 CONSTRAINT [PK_compras] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detalle_compra]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_compra](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_compra] [int] NOT NULL,
	[codigo_material] [int] NULL,
	[cantidad] [int] NULL,
	[precio] [decimal](18, 0) NULL,
	[detalle] [nvarchar](400) NULL,
 CONSTRAINT [PK_detalle compra] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[dia_de_deposito]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dia_de_deposito](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[id_empleado] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_dia de deposito] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[direcciones]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[direcciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_persona] [nvarchar](50) NULL,
	[pais] [varchar](50) NULL,
	[provincia] [varchar](50) NULL,
	[localidad] [varchar](50) NULL,
	[cp] [int] NULL,
	[barrio] [varchar](50) NULL,
	[calle] [nvarchar](50) NULL,
	[numero] [int] NULL,
	[piso] [int] NULL,
	[dpto] [nvarchar](50) NULL,
	[mzna] [nvarchar](50) NULL,
	[lote] [nvarchar](50) NULL,
 CONSTRAINT [PK_direcciones] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[emails]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emails](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_persona] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NULL,
 CONSTRAINT [PK_emails] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[empleados]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleados](
	[dni] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[sexo] [nvarchar](50) NULL,
	[fecha_de_nacimiento] [date] NULL,
	[puesto] [nvarchar](50) NOT NULL,
	[fecha_de_ingreso] [date] NULL,
	[activo] [nvarchar](50) NOT NULL,
	[valor_dia_deposito] [decimal](18, 0) NULL,
	[valor_dia_evento] [decimal](18, 0) NULL,
	[fecha_de_egreso] [date] NULL,
	[motivo_egreso] [nvarchar](200) NULL,
 CONSTRAINT [PK_empleados] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[entrada_material]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[entrada_material](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_evento] [int] NOT NULL,
	[codigo_material] [nvarchar](50) NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_detalle entrada] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[eventos]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[eventos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_cliente] [nvarchar](50) NOT NULL,
	[fecha_inicio] [date] NULL,
	[hora_inicio] [nvarchar](5) NULL,
	[fecha_fin] [date] NULL,
	[lugar] [nvarchar](50) NOT NULL,
	[encargado] [nvarchar](50) NULL,
	[total] [int] NULL,
	[detalle] [nvarchar](2000) NULL,
	[activo] [nvarchar](50) NULL,
	[motivo] [nvarchar](200) NULL,
 CONSTRAINT [PK_eventos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[formato_material]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[formato_material](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[cod] [nvarchar](50) NOT NULL,
	[formato] [nvarchar](50) NOT NULL,
	[id_tipo] [int] NOT NULL,
 CONSTRAINT [PK_detalle_material] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[login]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[login](
	[nombre_usuario] [nvarchar](50) NOT NULL,
	[dni] [nvarchar](50) NOT NULL,
	[contraseña] [int] NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[permiso] [int] NOT NULL,
	[activo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[nombre_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[material]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[material](
	[tipo] [int] NOT NULL,
	[modelo] [int] NOT NULL,
	[numero] [int] NOT NULL,
	[codigo] [nvarchar](50) NOT NULL,
	[medida] [int] NULL,
	[formato] [int] NULL,
	[stock_general] [int] NULL,
	[disponobilidad] [int] NULL,
	[codigo_qr] [image] NULL,
	[activo] [nvarchar](50) NULL,
	[fecha_egreso] [date] NULL,
	[motivo] [nvarchar](50) NULL,
	[detalle] [nvarchar](50) NULL,
 CONSTRAINT [PK__material__608F568C18FEC89D] PRIMARY KEY CLUSTERED 
(
	[tipo] ASC,
	[modelo] ASC,
	[numero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[material_en_reparacion]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[material_en_reparacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[codigo_de_material] [int] NOT NULL,
	[cantidad] [int] NULL,
	[motivo] [nvarchar](200) NULL,
	[fecha_de_entrada] [date] NULL,
	[fecha_de_salida] [date] NULL,
	[detalle_de_raparacion] [nvarchar](200) NULL,
 CONSTRAINT [PK_material en reparacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[medida_material]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[medida_material](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_tipo] [int] NOT NULL,
	[medida] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_medida_material] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[modelo_material]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[modelo_material](
	[id] [int] NOT NULL,
	[id_tipo] [int] NOT NULL,
	[modelo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK__modelo_m__BEEAE93764FC1D9D] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[id_tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[permisos]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permisos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[permiso] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_permisos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[proveedores]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedores](
	[cuit] [nvarchar](50) NOT NULL,
	[razon_social] [nvarchar](50) NOT NULL,
	[nombre_fantasia] [nvarchar](50) NULL,
	[iva] [nvarchar](50) NULL,
	[rubro] [nvarchar](50) NULL,
	[fecha_de_ingreso] [date] NULL,
	[activo] [nvarchar](50) NULL,
	[fecha_de_egreso] [date] NULL,
	[motivo_egreso] [nvarchar](50) NULL,
 CONSTRAINT [PK_proveedores] PRIMARY KEY CLUSTERED 
(
	[cuit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[salida_de_empleados]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salida_de_empleados](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_evento] [int] NOT NULL,
	[id_empleado] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_salida de empleados] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[salida_material]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[salida_material](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_evento] [int] NOT NULL,
	[codigo_material] [nvarchar](50) NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_detalle salida] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[telefonos]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[telefonos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_persona] [nvarchar](50) NOT NULL,
	[codigo_de_area] [nvarchar](50) NULL,
	[numero] [nvarchar](50) NULL,
 CONSTRAINT [PK_telefonos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tipo_material]    Script Date: 04/09/2021 13:48:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipo_material](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tipo_material] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[compras]  WITH CHECK ADD  CONSTRAINT [FK_compras_proveedores] FOREIGN KEY([id_proveedor])
REFERENCES [dbo].[proveedores] ([cuit])
GO
ALTER TABLE [dbo].[compras] CHECK CONSTRAINT [FK_compras_proveedores]
GO
ALTER TABLE [dbo].[detalle_compra]  WITH CHECK ADD  CONSTRAINT [FK_detalle_compra_compras] FOREIGN KEY([id_compra])
REFERENCES [dbo].[compras] ([id])
GO
ALTER TABLE [dbo].[detalle_compra] CHECK CONSTRAINT [FK_detalle_compra_compras]
GO
ALTER TABLE [dbo].[dia_de_deposito]  WITH CHECK ADD  CONSTRAINT [FK_dia_de_deposito_empleados] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[empleados] ([dni])
GO
ALTER TABLE [dbo].[dia_de_deposito] CHECK CONSTRAINT [FK_dia_de_deposito_empleados]
GO
ALTER TABLE [dbo].[entrada_material]  WITH CHECK ADD  CONSTRAINT [FK_detalle_entrada_eventos] FOREIGN KEY([id_evento])
REFERENCES [dbo].[eventos] ([id])
GO
ALTER TABLE [dbo].[entrada_material] CHECK CONSTRAINT [FK_detalle_entrada_eventos]
GO
ALTER TABLE [dbo].[eventos]  WITH CHECK ADD  CONSTRAINT [FK_eventos_clientes_cf] FOREIGN KEY([id_cliente])
REFERENCES [dbo].[clientes_cf] ([dni])
GO
ALTER TABLE [dbo].[eventos] CHECK CONSTRAINT [FK_eventos_clientes_cf]
GO
ALTER TABLE [dbo].[eventos]  WITH CHECK ADD  CONSTRAINT [FK_eventos_empleados] FOREIGN KEY([encargado])
REFERENCES [dbo].[empleados] ([dni])
GO
ALTER TABLE [dbo].[eventos] CHECK CONSTRAINT [FK_eventos_empleados]
GO
ALTER TABLE [dbo].[login]  WITH CHECK ADD  CONSTRAINT [FK_login_empleados] FOREIGN KEY([dni])
REFERENCES [dbo].[empleados] ([dni])
GO
ALTER TABLE [dbo].[login] CHECK CONSTRAINT [FK_login_empleados]
GO
ALTER TABLE [dbo].[login]  WITH CHECK ADD  CONSTRAINT [FK_login_permisos] FOREIGN KEY([permiso])
REFERENCES [dbo].[permisos] ([id])
GO
ALTER TABLE [dbo].[login] CHECK CONSTRAINT [FK_login_permisos]
GO
ALTER TABLE [dbo].[modelo_material]  WITH CHECK ADD  CONSTRAINT [FK_modelo_material_tipo_material] FOREIGN KEY([id_tipo])
REFERENCES [dbo].[tipo_material] ([Id])
GO
ALTER TABLE [dbo].[modelo_material] CHECK CONSTRAINT [FK_modelo_material_tipo_material]
GO
ALTER TABLE [dbo].[salida_de_empleados]  WITH CHECK ADD  CONSTRAINT [FK_salida_de_empleados_empleados] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[empleados] ([dni])
GO
ALTER TABLE [dbo].[salida_de_empleados] CHECK CONSTRAINT [FK_salida_de_empleados_empleados]
GO
ALTER TABLE [dbo].[salida_de_empleados]  WITH CHECK ADD  CONSTRAINT [FK_salida_de_empleados_eventos] FOREIGN KEY([id_evento])
REFERENCES [dbo].[eventos] ([id])
GO
ALTER TABLE [dbo].[salida_de_empleados] CHECK CONSTRAINT [FK_salida_de_empleados_eventos]
GO
ALTER TABLE [dbo].[salida_material]  WITH CHECK ADD  CONSTRAINT [FK_detalle_salida_eventos] FOREIGN KEY([id_evento])
REFERENCES [dbo].[eventos] ([id])
GO
ALTER TABLE [dbo].[salida_material] CHECK CONSTRAINT [FK_detalle_salida_eventos]
GO
USE [master]
GO
ALTER DATABASE [stage pro] SET  READ_WRITE 
GO
