USE [master]
GO
/****** Object:  Database [Barzola]    Script Date: 28/06/2019 21:03:11 ******/
CREATE DATABASE [Barzola]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Barzola', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Barzola.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Barzola_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Barzola_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Barzola] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Barzola].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Barzola] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Barzola] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Barzola] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Barzola] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Barzola] SET ARITHABORT OFF 
GO
ALTER DATABASE [Barzola] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Barzola] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Barzola] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Barzola] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Barzola] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Barzola] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Barzola] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Barzola] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Barzola] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Barzola] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Barzola] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Barzola] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Barzola] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Barzola] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Barzola] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Barzola] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Barzola] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Barzola] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Barzola] SET  MULTI_USER 
GO
ALTER DATABASE [Barzola] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Barzola] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Barzola] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Barzola] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Barzola] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Barzola] SET QUERY_STORE = OFF
GO
USE [Barzola]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Barzola]
GO
/****** Object:  Table [dbo].[PEDIDOS]    Script Date: 28/06/2019 21:03:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PEDIDOS](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[IDMESA] [bigint] NOT NULL,
	[fecha] [datetime] NULL,
	[idmesero] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PLATOSXPED]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PLATOSXPED](
	[IDPEDIDO] [bigint] NOT NULL,
	[IDPLATO] [bigint] NOT NULL,
	[CANTIDAD] [bigint] NOT NULL,
	[Entregado] [bit] NULL,
	[Estado] [bit] NULL,
	[precio] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPEDIDO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLEADO]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLEADO](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[APELLIDO] [varchar](50) NOT NULL,
	[PUESTO] [varchar](50) NOT NULL,
	[DNI] [int] NOT NULL,
	[ESTADO] [bit] NOT NULL,
	[USUARIO] [varchar](50) NOT NULL,
	[CONTRASENA] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MESA]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MESA](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[IDMESERO] [bigint] NOT NULL,
	[OCUPADO] [bit] NOT NULL,
	[ESTADO] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[IDMESERO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VwCantPlatos]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[VwCantPlatos] as
select em.NOMBRE+','+em.APELLIDO as NomApe,  COUNT(m.idmesero) as Cant 
from PEDIDOS as p
inner join PLATOSXPED as pp on pp.IDPEDIDO=p.ID
inner join MESA as m on p.IDMESA=m.ID
inner join EMPLEADO as em on em.ID=m.IDMESERO
group by m.IDMESERO,em.NOMBRE,em.APELLIDO
GO
/****** Object:  Table [dbo].[PLATO]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PLATO](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[DESCRIPCION] [varchar](50) NULL,
	[TIPO] [bigint] NOT NULL,
	[PRECIO] [money] NOT NULL,
	[ESTADO] [bit] NOT NULL,
	[cantidad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[NOMBRE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[EstadisticaPlato]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[EstadisticaPlato] as
select pl.nombre, isnull (sum (pp.CANTIDAD),0) as cant from PLATO as pl
left join PLATOSXPED as pp on pp.IDPLATO=pl.ID
left join PEDIDOS as pe on pe.ID=pp.IDPEDIDO

group by pl.nombre
GO
/****** Object:  View [dbo].[EstadisticaEmpleados]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[EstadisticaEmpleados] as
select e.NOMBRE+','+e.APELLIDO as nomape,
count (px.IDPEDIDO) as cant
 from EMPLEADO as e
left join PEDIDOS as pe on pe.idmesero =e.id
left join PLATOSXPED as px on px.IDPEDIDO =pe.id
where e.PUESTO like 'mesero'
group by e.NOMBRE,e.APELLIDO
GO
/****** Object:  Table [dbo].[BEBIDASXPEDIDO]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BEBIDASXPEDIDO](
	[IDPEDIDO] [bigint] NOT NULL,
	[IDBEBIDA] [bigint] NOT NULL,
	[CANTIDAD] [bigint] NOT NULL,
	[estado] [bit] NULL,
	[Entregado] [bit] NULL,
	[precio] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDPEDIDO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[EstadisticaRecaudacionMes]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[EstadisticaRecaudacionMes] as
select distinct DATEPART(day,fecha) as dia,
isnull((select sum ( pl.CANTIDAD*pl.precio) from PLATOSXPED as pl
inner join PEDIDOS as p on p.ID=pl.IDPEDIDO
where DATEPART(day,p.fecha)=DATEPART(day,pe.fecha)
)+
(select sum ( be.CANTIDAD*be.precio) from BEBIDASXPEDIDO as be
inner join PEDIDOS as p on p.ID=be.IDPEDIDO
where DATEPART(day,p.fecha)=DATEPART(day,pe.fecha)
),0) as rec

 from PEDIDOS as pe
where 
DATEPART(MONTH,fecha) = DATEPART(MONTH,getdate())
GO
/****** Object:  View [dbo].[vw_pedidos]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vw_pedidos] as
select p.id,p.idmesa,p.estado,pp.idplato,pp.cantidad as cantPl from pedidos as p
--inner join bebidasxpedido as bp on p.id=bp.idpedido
inner join platosxped as pp on pp.idpedido=p.id
GO
/****** Object:  Table [dbo].[TIPO_PLATO]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPO_PLATO](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_platos]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[view_platos]
as select p.id,p.NOMBRE,p.PRECIO,p.TIPO as idtipo,tp.NOMBRE as Tipo,p.ESTADO,p.DESCRIPCION,p.cantidad from PLATO as p
inner join TIPO_PLATO as tp on tp.ID=p.TIPO
GO
/****** Object:  Table [dbo].[VAJILLAXPLATO]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VAJILLAXPLATO](
	[IDVAJILLA] [int] NOT NULL,
	[IDPLATO] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDVAJILLA] ASC,
	[IDPLATO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VAJILLA]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VAJILLA](
	[ID] [int] IDENTITY(10,1) NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[CANTIDAD] [int] NULL,
	[ESTADO] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[view_vajillaXplato]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[view_vajillaXplato]
as select vp.IDPLATO,v.NOMBRE  from VAJILLAXPLATO as vp
inner join VAJILLA as v on v.ID=vp.IDVAJILLA
GO
/****** Object:  View [dbo].[View_VajillaXPla]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[View_VajillaXPla]
as select  p.NOMBRE as nombrePla,v.NOMBRE as nombrevaj, p.ID as idpla,v.ID as idvaj from vajillaxplato as vp
inner join VAJILLA as v on vp.IDVAJILLA=v.ID
inner join PLATO as p on p.ID=vp.IDPLATO
GO
/****** Object:  Table [dbo].[BEBIDA]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BEBIDA](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[IDMARCA] [bigint] NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[DESCRIPCION] [varchar](50) NULL,
	[PRECIO] [money] NOT NULL,
	[COPA] [bit] NOT NULL,
	[CANTIDAD] [int] NULL,
	[ESTADO] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[IDMARCA] ASC,
	[NOMBRE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MARCA]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MARCA](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[ESTADO] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[NOMBRE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_marca]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[View_marca]
as select b.NOMBRE as nombre_bebida, b.PRECIO,
b.ID, b.ESTADO,b.DESCRIPCION,b.COPA,b.CANTIDAD,m.NOMBRE as marca, m.ID as marcaid from BEBIDA as b
inner join MARCA as M on m.ID=b.IDMARCA
GO
/****** Object:  View [dbo].[vw_mesero]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vw_mesero] as
SELECT id, nombre + ',' + apellido AS Nombre, puesto,dni,estado,usuario,contrasena 
FROM empleado 
GO
/****** Object:  View [dbo].[vw_mesas]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE view [dbo].[vw_mesas] as
select m.id as idmesa, em.nombre +', '+ em.apellido as nom_ap , em.id as idemp,
m.estado,m.ocupado from mesa as m 
inner join empleado as em on m.idmesero=em.id
GO
SET IDENTITY_INSERT [dbo].[BEBIDA] ON 
GO
INSERT [dbo].[BEBIDA] ([ID], [IDMARCA], [NOMBRE], [DESCRIPCION], [PRECIO], [COPA], [CANTIDAD], [ESTADO]) VALUES (1, 5, N'AGUA SABORIZADA', N'BOTELLA DE 600ML', 60.0000, 0, 0, 0)
GO
INSERT [dbo].[BEBIDA] ([ID], [IDMARCA], [NOMBRE], [DESCRIPCION], [PRECIO], [COPA], [CANTIDAD], [ESTADO]) VALUES (2, 3, N'Gaseosa lima', N'LATA DE 250ML', 40.0000, 0, 50, 0)
GO
INSERT [dbo].[BEBIDA] ([ID], [IDMARCA], [NOMBRE], [DESCRIPCION], [PRECIO], [COPA], [CANTIDAD], [ESTADO]) VALUES (3, 1, N'GASEOSA NARANJA', N'BOTELLA DE 600ML', 645.0000, 0, 47, 1)
GO
INSERT [dbo].[BEBIDA] ([ID], [IDMARCA], [NOMBRE], [DESCRIPCION], [PRECIO], [COPA], [CANTIDAD], [ESTADO]) VALUES (5, 5, N'Pomelo', N'Botella 600ml', 22.0000, 1, 44, 1)
GO
INSERT [dbo].[BEBIDA] ([ID], [IDMARCA], [NOMBRE], [DESCRIPCION], [PRECIO], [COPA], [CANTIDAD], [ESTADO]) VALUES (6, 3, N'Cola', N'botella 600ml', 30.0000, 0, 0, 0)
GO
INSERT [dbo].[BEBIDA] ([ID], [IDMARCA], [NOMBRE], [DESCRIPCION], [PRECIO], [COPA], [CANTIDAD], [ESTADO]) VALUES (7, 2, N'Paso de los toros', N'Botella 500ml', 40.0000, 0, 19, 1)
GO
INSERT [dbo].[BEBIDA] ([ID], [IDMARCA], [NOMBRE], [DESCRIPCION], [PRECIO], [COPA], [CANTIDAD], [ESTADO]) VALUES (8, 1, N'Agua saborizada', N'Naranja, 600ml', 80.0000, 0, 0, 0)
GO
INSERT [dbo].[BEBIDA] ([ID], [IDMARCA], [NOMBRE], [DESCRIPCION], [PRECIO], [COPA], [CANTIDAD], [ESTADO]) VALUES (9, 2, N'Pepsi cola', N'lata de 250ml', 50.0000, 0, 90, 1)
GO
INSERT [dbo].[BEBIDA] ([ID], [IDMARCA], [NOMBRE], [DESCRIPCION], [PRECIO], [COPA], [CANTIDAD], [ESTADO]) VALUES (10, 2, N'Mirinda', N'gaseosa de naranja, 600ml', 70.0000, 0, 50, 1)
GO
INSERT [dbo].[BEBIDA] ([ID], [IDMARCA], [NOMBRE], [DESCRIPCION], [PRECIO], [COPA], [CANTIDAD], [ESTADO]) VALUES (11, 3, N'Coca cola', N'lata 250ml', 50.0000, 0, 54, 1)
GO
INSERT [dbo].[BEBIDA] ([ID], [IDMARCA], [NOMBRE], [DESCRIPCION], [PRECIO], [COPA], [CANTIDAD], [ESTADO]) VALUES (12, 3, N'Sprite', N'Gaseosa lima , 600ml', 70.0000, 0, 40, 1)
GO
INSERT [dbo].[BEBIDA] ([ID], [IDMARCA], [NOMBRE], [DESCRIPCION], [PRECIO], [COPA], [CANTIDAD], [ESTADO]) VALUES (13, 5, N'naranja', N'600ml ', 40.0000, 0, 30, 1)
GO
INSERT [dbo].[BEBIDA] ([ID], [IDMARCA], [NOMBRE], [DESCRIPCION], [PRECIO], [COPA], [CANTIDAD], [ESTADO]) VALUES (14, 8, N'Vino tinto', N'Malbec botella', 400.0000, 1, 13, 1)
GO
INSERT [dbo].[BEBIDA] ([ID], [IDMARCA], [NOMBRE], [DESCRIPCION], [PRECIO], [COPA], [CANTIDAD], [ESTADO]) VALUES (15, 1, N'Licuado', N'frutilla, banana, durazno', 120.0000, 0, 10, 1)
GO
SET IDENTITY_INSERT [dbo].[BEBIDA] OFF
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (117, 9, 2, 0, 0, 50.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (118, 9, 2, 0, 0, 50.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (123, 5, 1, 0, 0, 22.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (124, 5, 1, 0, 0, 22.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (129, 3, 1, 0, 0, 645.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (130, 3, 1, 0, 0, 645.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (131, 3, 1, 0, 0, 645.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (135, 9, 1, 0, 0, 50.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (136, 9, 1, 0, 0, 50.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (137, 8, 1, 0, 0, 80.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (141, 5, 1, 0, 0, 22.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (145, 12, 1, 0, 0, 70.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (146, 14, 1, 0, 0, 400.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (153, 7, 1, 0, 0, 40.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (154, 7, 1, 0, 0, 40.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (159, 5, 1, 0, 0, 22.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (160, 14, 1, 0, 0, 400.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (161, 6, 1, 0, 0, 30.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (162, 6, 1, 0, 0, 30.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (169, 7, 1, 0, 0, 40.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (170, 5, 1, 0, 0, 22.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (176, 6, 1, 0, 0, 30.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (177, 12, 1, 0, 0, 70.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (178, 7, 1, 0, 0, 40.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (185, 11, 1, 0, 0, 50.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (186, 3, 1, 0, 0, 645.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (187, 14, 1, 0, 0, 400.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (188, 7, 1, 0, 0, 40.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (194, 7, 1, 0, 0, 40.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (195, 5, 1, 0, 0, 22.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (196, 14, 1, 0, 0, 400.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (197, 3, 1, 0, 0, 645.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (207, 11, 1, 0, 0, 50.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (208, 14, 1, 0, 0, 400.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (209, 14, 1, 0, 0, 400.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (210, 7, 1, 0, 0, 40.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (214, 7, 1, 0, 0, 40.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (217, 7, 1, 0, 0, 40.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (218, 7, 3, 0, 0, 40.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (219, 14, 2, 0, 0, 400.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (220, 6, 15, 0, 0, 30.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (221, 6, 1, 0, 0, 30.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (222, 6, 1, 0, 0, 30.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (223, 6, 1, 0, 0, 30.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (224, 6, 1, 0, 0, 30.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (225, 6, 1, 0, 0, 30.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (226, 6, 1, 0, 0, 30.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (227, 11, 1, 0, 0, 50.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (228, 11, 1, 0, 0, 50.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (229, 11, 1, 0, 0, 50.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (230, 11, 1, 0, 0, 50.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (231, 6, 2, 0, 0, 30.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (232, 6, 2, 0, 0, 30.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (233, 6, 1, 0, 0, 30.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (234, 6, 1, 0, 0, 30.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (235, 7, 2, 0, 0, 40.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (236, 11, 1, 0, 0, 50.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (237, 3, 1, 0, 0, 645.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (241, 7, 1, 0, 0, 40.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (242, 7, 1, 0, 0, 40.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (243, 7, 1, 0, 0, 40.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (244, 7, 1, 0, 0, 40.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (20217, 8, 100, 0, 0, 80.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (20223, 7, 1, 0, 0, 40.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (20225, 3, 1, 0, 0, 645.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (20228, 3, 1, 1, 0, 645.0000)
GO
INSERT [dbo].[BEBIDASXPEDIDO] ([IDPEDIDO], [IDBEBIDA], [CANTIDAD], [estado], [Entregado], [precio]) VALUES (20231, 11, 1, 0, 0, 50.0000)
GO
SET IDENTITY_INSERT [dbo].[EMPLEADO] ON 
GO
INSERT [dbo].[EMPLEADO] ([ID], [NOMBRE], [APELLIDO], [PUESTO], [DNI], [ESTADO], [USUARIO], [CONTRASENA]) VALUES (1, N'santiago', N'barzola', N'administrativo', 40870363, 1, N'saney', N'1234')
GO
INSERT [dbo].[EMPLEADO] ([ID], [NOMBRE], [APELLIDO], [PUESTO], [DNI], [ESTADO], [USUARIO], [CONTRASENA]) VALUES (2, N'Patricia', N'Eymann', N'Mesero', 22675746, 0, N'patriEy', N'12345')
GO
INSERT [dbo].[EMPLEADO] ([ID], [NOMBRE], [APELLIDO], [PUESTO], [DNI], [ESTADO], [USUARIO], [CONTRASENA]) VALUES (4, N'Facundo', N'Gonzalez', N'Mesero', 4567879, 0, N'fafuf', N'0000')
GO
INSERT [dbo].[EMPLEADO] ([ID], [NOMBRE], [APELLIDO], [PUESTO], [DNI], [ESTADO], [USUARIO], [CONTRASENA]) VALUES (5, N'Julio', N'Fernandez', N'Mesero', 22334593, 1, N'JulFer2', N'999')
GO
INSERT [dbo].[EMPLEADO] ([ID], [NOMBRE], [APELLIDO], [PUESTO], [DNI], [ESTADO], [USUARIO], [CONTRASENA]) VALUES (6, N'Mariano', N'Iudica', N'Mesero', 43212343, 1, N'mariu', N'8789')
GO
INSERT [dbo].[EMPLEADO] ([ID], [NOMBRE], [APELLIDO], [PUESTO], [DNI], [ESTADO], [USUARIO], [CONTRASENA]) VALUES (7, N'Santiago', N'Del moro', N'Mesero', 34576544, 1, N'SanMoro', N'7777')
GO
INSERT [dbo].[EMPLEADO] ([ID], [NOMBRE], [APELLIDO], [PUESTO], [DNI], [ESTADO], [USUARIO], [CONTRASENA]) VALUES (8, N'Moria', N'Casan', N'Mesero', 40987678, 0, N'Morcas', N'6666')
GO
INSERT [dbo].[EMPLEADO] ([ID], [NOMBRE], [APELLIDO], [PUESTO], [DNI], [ESTADO], [USUARIO], [CONTRASENA]) VALUES (9, N'Dalma ', N'Maradona', N'Mesero', 34543567, 1, N'dalmar', N'3333')
GO
INSERT [dbo].[EMPLEADO] ([ID], [NOMBRE], [APELLIDO], [PUESTO], [DNI], [ESTADO], [USUARIO], [CONTRASENA]) VALUES (10, N'Maxi', N'sar', N'Mesero', 4056765, 1, N'max', N'sar')
GO
INSERT [dbo].[EMPLEADO] ([ID], [NOMBRE], [APELLIDO], [PUESTO], [DNI], [ESTADO], [USUARIO], [CONTRASENA]) VALUES (15, N'asdas', N'asda', N'Mesero', 21321, 0, N'dsad', N'2131')
GO
INSERT [dbo].[EMPLEADO] ([ID], [NOMBRE], [APELLIDO], [PUESTO], [DNI], [ESTADO], [USUARIO], [CONTRASENA]) VALUES (16, N'rodrigo', N'sar', N'Mesero', 345765433, 1, N'sadas', N'2131')
GO
INSERT [dbo].[EMPLEADO] ([ID], [NOMBRE], [APELLIDO], [PUESTO], [DNI], [ESTADO], [USUARIO], [CONTRASENA]) VALUES (18, N'Jorge', N'lanata', N'Mesero', 32432, 1, N'lana', N'1234')
GO
INSERT [dbo].[EMPLEADO] ([ID], [NOMBRE], [APELLIDO], [PUESTO], [DNI], [ESTADO], [USUARIO], [CONTRASENA]) VALUES (22, N'sergio', N'massa', N'Mesero', 7678, 1, N'dad', N'123')
GO
SET IDENTITY_INSERT [dbo].[EMPLEADO] OFF
GO
SET IDENTITY_INSERT [dbo].[MARCA] ON 
GO
INSERT [dbo].[MARCA] ([ID], [NOMBRE], [ESTADO]) VALUES (1, N'Villa del sur', 1)
GO
INSERT [dbo].[MARCA] ([ID], [NOMBRE], [ESTADO]) VALUES (2, N'Pepsi', 1)
GO
INSERT [dbo].[MARCA] ([ID], [NOMBRE], [ESTADO]) VALUES (3, N'Coca Cola', 1)
GO
INSERT [dbo].[MARCA] ([ID], [NOMBRE], [ESTADO]) VALUES (5, N'Manaos', 1)
GO
INSERT [dbo].[MARCA] ([ID], [NOMBRE], [ESTADO]) VALUES (6, N'Termidor', 0)
GO
INSERT [dbo].[MARCA] ([ID], [NOMBRE], [ESTADO]) VALUES (7, N'Hileret', 0)
GO
INSERT [dbo].[MARCA] ([ID], [NOMBRE], [ESTADO]) VALUES (8, N'Vino', 1)
GO
SET IDENTITY_INSERT [dbo].[MARCA] OFF
GO
SET IDENTITY_INSERT [dbo].[MESA] ON 
GO
INSERT [dbo].[MESA] ([ID], [IDMESERO], [OCUPADO], [ESTADO]) VALUES (1, 5, 1, 1)
GO
INSERT [dbo].[MESA] ([ID], [IDMESERO], [OCUPADO], [ESTADO]) VALUES (2, 6, 1, 1)
GO
INSERT [dbo].[MESA] ([ID], [IDMESERO], [OCUPADO], [ESTADO]) VALUES (3, 6, 0, 1)
GO
INSERT [dbo].[MESA] ([ID], [IDMESERO], [OCUPADO], [ESTADO]) VALUES (4, 9, 0, 1)
GO
INSERT [dbo].[MESA] ([ID], [IDMESERO], [OCUPADO], [ESTADO]) VALUES (5, 9, 0, 1)
GO
INSERT [dbo].[MESA] ([ID], [IDMESERO], [OCUPADO], [ESTADO]) VALUES (6, 7, 0, 1)
GO
INSERT [dbo].[MESA] ([ID], [IDMESERO], [OCUPADO], [ESTADO]) VALUES (7, 7, 0, 1)
GO
INSERT [dbo].[MESA] ([ID], [IDMESERO], [OCUPADO], [ESTADO]) VALUES (8, 7, 0, 0)
GO
INSERT [dbo].[MESA] ([ID], [IDMESERO], [OCUPADO], [ESTADO]) VALUES (9, 5, 0, 1)
GO
INSERT [dbo].[MESA] ([ID], [IDMESERO], [OCUPADO], [ESTADO]) VALUES (10, 6, 0, 0)
GO
INSERT [dbo].[MESA] ([ID], [IDMESERO], [OCUPADO], [ESTADO]) VALUES (11, 6, 0, 1)
GO
INSERT [dbo].[MESA] ([ID], [IDMESERO], [OCUPADO], [ESTADO]) VALUES (12, 6, 0, 1)
GO
SET IDENTITY_INSERT [dbo].[MESA] OFF
GO
SET IDENTITY_INSERT [dbo].[PEDIDOS] ON 
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (114, 1, CAST(N'2019-06-19T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (115, 1, CAST(N'2019-06-19T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (116, 1, CAST(N'2019-06-19T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (117, 1, CAST(N'2019-06-19T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (118, 1, CAST(N'2019-06-19T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (119, 9, CAST(N'2019-06-19T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (120, 9, CAST(N'2019-06-19T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (121, 9, CAST(N'2019-06-19T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (122, 9, CAST(N'2019-06-19T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (123, 9, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (124, 9, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (125, 1, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (126, 1, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (127, 1, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (128, 1, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (129, 1, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (130, 1, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (131, 1, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (132, 11, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (133, 11, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (134, 11, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (135, 11, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (136, 11, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (137, 11, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (138, 11, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (139, 11, CAST(N'2019-06-20T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (140, 11, CAST(N'2019-06-18T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (141, 11, CAST(N'2019-06-18T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (142, 12, CAST(N'2019-06-18T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (143, 12, CAST(N'2019-06-18T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (144, 12, CAST(N'2019-06-18T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (145, 12, CAST(N'2019-06-18T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (146, 12, CAST(N'2019-06-18T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (147, 12, CAST(N'2019-06-18T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (148, 11, CAST(N'2019-06-18T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (149, 11, CAST(N'2019-06-18T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (150, 11, CAST(N'2019-06-14T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (151, 11, CAST(N'2019-06-14T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (152, 11, CAST(N'2019-06-14T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (153, 11, CAST(N'2019-06-14T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (154, 11, CAST(N'2019-06-14T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (155, 12, CAST(N'2019-06-14T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (156, 12, CAST(N'2019-06-14T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (157, 12, CAST(N'2019-06-14T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (158, 12, CAST(N'2019-06-14T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (159, 12, CAST(N'2019-06-14T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (160, 12, CAST(N'2019-06-12T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (161, 12, CAST(N'2019-06-12T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (162, 12, CAST(N'2019-06-12T00:00:00.000' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (163, 2, CAST(N'2019-06-12T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (164, 2, CAST(N'2019-06-12T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (165, 2, CAST(N'2019-06-12T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (166, 2, CAST(N'2019-06-12T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (167, 2, CAST(N'2019-06-12T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (168, 2, CAST(N'2019-06-12T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (169, 2, CAST(N'2019-06-12T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (170, 2, CAST(N'2019-06-10T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (171, 3, CAST(N'2019-06-10T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (172, 3, CAST(N'2019-06-10T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (173, 3, CAST(N'2019-06-10T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (174, 3, CAST(N'2019-06-10T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (175, 3, CAST(N'2019-06-10T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (176, 3, CAST(N'2019-06-10T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (177, 3, CAST(N'2019-06-10T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (178, 3, CAST(N'2019-06-10T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (179, 2, CAST(N'2019-06-10T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (180, 2, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (181, 2, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (182, 2, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (183, 2, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (184, 2, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (185, 2, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (186, 2, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (187, 2, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (188, 2, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (189, 2, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (190, 3, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (191, 3, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (192, 3, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (193, 3, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (194, 3, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (195, 3, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (196, 3, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (197, 3, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (198, 6, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 7)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (199, 6, CAST(N'2019-06-22T00:00:00.000' AS DateTime), 7)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (200, 6, CAST(N'2019-06-22T00:42:20.897' AS DateTime), 7)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (201, 6, CAST(N'2019-06-22T00:42:23.480' AS DateTime), 7)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (202, 6, CAST(N'2019-06-22T00:42:25.140' AS DateTime), 7)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (203, 6, CAST(N'2019-06-22T00:42:25.613' AS DateTime), 7)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (204, 6, CAST(N'2019-06-22T00:42:27.310' AS DateTime), 7)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (205, 6, CAST(N'2019-06-22T00:42:29.800' AS DateTime), 7)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (206, 6, CAST(N'2019-06-22T00:42:32.623' AS DateTime), 7)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (207, 6, CAST(N'2019-06-22T00:42:36.797' AS DateTime), 7)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (208, 6, CAST(N'2019-06-22T00:42:39.237' AS DateTime), 7)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (209, 6, CAST(N'2019-06-22T00:42:40.640' AS DateTime), 7)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (210, 6, CAST(N'2019-06-22T00:42:42.370' AS DateTime), 7)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (211, 9, CAST(N'2019-06-22T01:00:16.260' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (212, 9, CAST(N'2019-06-22T01:02:47.213' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (213, 1, CAST(N'2019-06-22T01:03:08.727' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (214, 1, CAST(N'2019-06-22T01:03:18.473' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (215, 1, CAST(N'2019-06-22T01:58:49.143' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (216, 1, CAST(N'2019-06-22T01:58:58.423' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (217, 1, CAST(N'2019-06-25T20:59:14.890' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (218, 1, CAST(N'2019-06-25T20:59:28.903' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (219, 1, CAST(N'2019-06-25T20:59:56.320' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (220, 1, CAST(N'2019-06-25T21:35:59.213' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (221, 1, CAST(N'2019-06-25T21:49:43.400' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (222, 1, CAST(N'2019-06-25T21:49:55.277' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (223, 11, CAST(N'2019-06-25T21:54:39.743' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (224, 11, CAST(N'2019-06-25T21:54:43.233' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (225, 1, CAST(N'2019-06-25T22:02:55.807' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (226, 1, CAST(N'2019-06-25T22:03:12.720' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (227, 1, CAST(N'2019-06-25T22:03:15.573' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (228, 1, CAST(N'2019-06-25T22:03:19.543' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (229, 1, CAST(N'2019-06-25T22:03:21.020' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (230, 1, CAST(N'2019-06-25T22:03:21.933' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (231, 1, CAST(N'2019-06-25T22:10:29.003' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (232, 1, CAST(N'2019-06-25T22:10:50.100' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (233, 1, CAST(N'2019-06-25T22:17:16.660' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (234, 1, CAST(N'2019-06-25T22:17:18.537' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (235, 1, CAST(N'2019-06-25T22:23:46.730' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (236, 1, CAST(N'2019-06-25T22:31:49.697' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (237, 1, CAST(N'2019-06-25T22:38:17.440' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (238, 1, CAST(N'2019-06-25T22:38:34.200' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (239, 1, CAST(N'2019-06-25T22:38:50.677' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (240, 1, CAST(N'2019-06-25T22:38:50.870' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (241, 1, CAST(N'2019-06-25T22:38:56.790' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (242, 1, CAST(N'2019-06-25T22:38:58.010' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (243, 1, CAST(N'2019-06-25T22:38:58.457' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (244, 1, CAST(N'2019-06-25T22:38:59.040' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (10217, 1, CAST(N'2019-06-26T18:48:59.987' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (10218, 1, CAST(N'2019-06-26T18:49:29.887' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (20217, 1, CAST(N'2019-06-26T19:24:22.710' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (20218, 1, CAST(N'2019-06-26T19:28:25.433' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (20219, 1, CAST(N'2019-06-26T19:30:10.333' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (20220, 1, CAST(N'2019-06-26T19:32:41.540' AS DateTime), 5)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (20221, 11, CAST(N'2019-06-27T18:20:34.917' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (20222, 11, CAST(N'2019-06-27T18:20:41.967' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (20223, 11, CAST(N'2019-06-27T18:20:56.357' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (20224, 11, CAST(N'2019-06-27T20:27:24.743' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (20225, 11, CAST(N'2019-06-27T20:27:31.167' AS DateTime), 8)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (20226, 3, CAST(N'2019-06-27T22:00:11.810' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (20227, 2, CAST(N'2019-06-27T22:00:29.180' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (20228, 2, CAST(N'2019-06-27T22:00:34.133' AS DateTime), 6)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (20229, 6, CAST(N'2019-06-27T22:01:13.153' AS DateTime), 7)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (20230, 4, CAST(N'2019-06-27T22:02:08.657' AS DateTime), 9)
GO
INSERT [dbo].[PEDIDOS] ([ID], [IDMESA], [fecha], [idmesero]) VALUES (20231, 4, CAST(N'2019-06-27T22:02:15.207' AS DateTime), 9)
GO
SET IDENTITY_INSERT [dbo].[PEDIDOS] OFF
GO
SET IDENTITY_INSERT [dbo].[PLATO] ON 
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (1, N'Panqueques', N'CON DULCE', 1, 50.0000, 0, 10)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (2, N'Flan', N'CON DULCE DE LECHE O CREMA', 1, 110.0000, 1, 7)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (3, N'Pizza de muzzarella', N'MUZZARELLA', 2, 280.0000, 1, 7)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (4, N'Doritos chedar', N'chedar', 5, 90.0000, 1, 10)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (5, N'Tarta', N'a', 2, 3.0000, 0, 10)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (6, N'Milanesa Napolitana', N'', 2, 250.0000, 1, 9)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (7, N'Choripan', N'', 2, 150.0000, 0, 10)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (8, N'Locro', N'', 2, 180.0000, 0, 10)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (9, N'Medialunas', N'', 5, 20.0000, 1, 10)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (10, N'Bife de chorizo', N'con ensalada', 2, 300.0000, 1, 10)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (11, N'Empanadas de carne', N'carne ', 2, 45.0000, 1, 4)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (12, N'Vacio al horno', N'Con papas al horno ', 2, 400.0000, 1, 9)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (13, N'Pescado frito ', N'Porcion pescado frito al plato', 2, 280.0000, 1, 9)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (14, N'Paella de Mariscos', N'es sólo con frutos del mar.', 2, 400.0000, 1, 10)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (18, N'Sopa de pollo', N'caparazones, huesos, pescuezo y ', 2, 300.0000, 1, 10)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (19, N'Calamares en su tinta', N'Con un poco de arroz blanco', 2, 500.0000, 0, 0)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (20, N'Arroz con leche', N'', 1, 180.0000, 1, 10)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (21, N'Tiramisú', N'', 1, 170.0000, 1, 10)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (22, N'Pastafrola', N'Porcion de Pastafrola', 1, 70.0000, 1, 10)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (23, N'Alfajores', N'Caceros', 1, 50.0000, 1, 10)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (24, N'Rabas ', N'', 3, 130.0000, 1, 8)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (25, N'Sopa fría de tomates', N'', 3, 90.0000, 1, 9)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (26, N'Paté de dos jamones', N'', 3, 130.0000, 1, 10)
GO
INSERT [dbo].[PLATO] ([ID], [NOMBRE], [DESCRIPCION], [TIPO], [PRECIO], [ESTADO], [cantidad]) VALUES (27, N'Pechugas', N'', 2, 100.0000, 1, 2)
GO
SET IDENTITY_INSERT [dbo].[PLATO] OFF
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (114, 10, 1, 0, 0, 300.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (115, 10, 1, 0, 0, 300.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (116, 12, 1, 0, 0, 400.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (119, 25, 1, 0, 0, 90.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (120, 25, 1, 0, 0, 90.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (121, 10, 1, 0, 0, 300.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (122, 10, 1, 0, 0, 300.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (125, 24, 1, 0, 0, 130.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (126, 26, 1, 0, 0, 130.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (127, 6, 1, 0, 0, 250.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (128, 6, 1, 0, 0, 250.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (132, 6, 1, 0, 0, 250.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (133, 6, 1, 0, 0, 250.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (134, 6, 1, 0, 0, 250.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (138, 13, 1, 0, 0, 280.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (139, 20, 1, 0, 0, 180.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (140, 20, 1, 0, 0, 180.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (142, 25, 1, 0, 0, 90.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (143, 13, 1, 0, 0, 280.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (144, 18, 1, 0, 0, 300.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (147, 14, 1, 0, 0, 400.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (148, 24, 1, 0, 0, 130.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (149, 24, 1, 0, 0, 130.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (150, 25, 1, 0, 0, 90.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (151, 3, 1, 0, 0, 280.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (152, 3, 1, 0, 0, 280.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (155, 3, 1, 0, 0, 280.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (156, 13, 1, 0, 0, 280.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (157, 14, 1, 0, 0, 400.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (158, 18, 1, 0, 0, 300.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (163, 6, 2, 0, 0, 250.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (164, 11, 1, 0, 0, 45.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (165, 14, 1, 0, 0, 400.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (166, 6, 1, 0, 0, 250.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (167, 18, 1, 0, 0, 300.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (168, 21, 1, 0, 0, 170.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (171, 25, 1, 0, 0, 90.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (172, 4, 1, 0, 0, 90.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (173, 21, 1, 0, 0, 170.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (174, 23, 1, 0, 0, 50.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (175, 22, 1, 0, 0, 70.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (179, 25, 1, 0, 0, 90.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (180, 2, 1, 0, 0, 110.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (181, 2, 1, 0, 0, 110.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (182, 25, 1, 0, 0, 90.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (183, 20, 1, 0, 0, 180.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (184, 4, 1, 0, 0, 90.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (189, 10, 1, 0, 0, 300.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (190, 6, 1, 0, 0, 250.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (191, 12, 1, 0, 0, 400.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (192, 14, 1, 0, 0, 400.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (193, 18, 1, 0, 0, 300.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (198, 21, 1, 0, 0, 170.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (199, 3, 1, 0, 0, 280.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (200, 11, 1, 0, 0, 45.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (201, 11, 1, 0, 0, 45.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (202, 13, 1, 0, 0, 280.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (203, 13, 1, 0, 0, 280.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (204, 6, 1, 0, 0, 250.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (205, 2, 1, 0, 0, 110.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (206, 22, 1, 0, 0, 70.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (211, 3, 1, 0, 0, 280.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (212, 6, 1, 0, 0, 250.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (213, 10, 1, 0, 0, 300.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (215, 3, 1, 0, 0, 280.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (216, 10, 1, 0, 0, 300.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (238, 2, 1, 0, 0, 110.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (239, 2, 1, 0, 0, 110.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (240, 2, 1, 0, 0, 110.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (10217, 2, 1, 0, 0, 110.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (10218, 3, 2, 0, 0, 280.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (20218, 2, 1, 0, 1, 110.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (20219, 12, 1, 0, 1, 400.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (20220, 19, 10, 0, 1, 500.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (20221, 3, 1, 0, 0, 280.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (20222, 11, 6, 0, 0, 45.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (20224, 24, 2, 0, 0, 130.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (20226, 2, 1, 0, 0, 110.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (20227, 6, 1, 0, 1, 250.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (20229, 13, 1, 0, 0, 280.0000)
GO
INSERT [dbo].[PLATOSXPED] ([IDPEDIDO], [IDPLATO], [CANTIDAD], [Entregado], [Estado], [precio]) VALUES (20230, 25, 1, 0, 0, 90.0000)
GO
SET IDENTITY_INSERT [dbo].[TIPO_PLATO] ON 
GO
INSERT [dbo].[TIPO_PLATO] ([ID], [NOMBRE], [estado]) VALUES (1, N'Postre', 1)
GO
INSERT [dbo].[TIPO_PLATO] ([ID], [NOMBRE], [estado]) VALUES (2, N'Principal', 1)
GO
INSERT [dbo].[TIPO_PLATO] ([ID], [NOMBRE], [estado]) VALUES (3, N'Entrada', 1)
GO
INSERT [dbo].[TIPO_PLATO] ([ID], [NOMBRE], [estado]) VALUES (4, N'Guarnicion', 1)
GO
INSERT [dbo].[TIPO_PLATO] ([ID], [NOMBRE], [estado]) VALUES (5, N'Otro', 1)
GO
INSERT [dbo].[TIPO_PLATO] ([ID], [NOMBRE], [estado]) VALUES (13, N'jamon', 0)
GO
SET IDENTITY_INSERT [dbo].[TIPO_PLATO] OFF
GO
SET IDENTITY_INSERT [dbo].[VAJILLA] ON 
GO
INSERT [dbo].[VAJILLA] ([ID], [NOMBRE], [CANTIDAD], [ESTADO]) VALUES (10, N'Cuchillo', 21, 1)
GO
INSERT [dbo].[VAJILLA] ([ID], [NOMBRE], [CANTIDAD], [ESTADO]) VALUES (11, N'Cuchara', 100, 1)
GO
INSERT [dbo].[VAJILLA] ([ID], [NOMBRE], [CANTIDAD], [ESTADO]) VALUES (12, N'Tenedor', 4, 1)
GO
INSERT [dbo].[VAJILLA] ([ID], [NOMBRE], [CANTIDAD], [ESTADO]) VALUES (14, N'Palos chinos', 3, 0)
GO
INSERT [dbo].[VAJILLA] ([ID], [NOMBRE], [CANTIDAD], [ESTADO]) VALUES (17, N'Cuchara sopera', 0, 0)
GO
INSERT [dbo].[VAJILLA] ([ID], [NOMBRE], [CANTIDAD], [ESTADO]) VALUES (18, N'Plato playo', 40, 0)
GO
INSERT [dbo].[VAJILLA] ([ID], [NOMBRE], [CANTIDAD], [ESTADO]) VALUES (19, N'Plato hondo', 2, 1)
GO
INSERT [dbo].[VAJILLA] ([ID], [NOMBRE], [CANTIDAD], [ESTADO]) VALUES (20, N'Vaso', 10, 1)
GO
INSERT [dbo].[VAJILLA] ([ID], [NOMBRE], [CANTIDAD], [ESTADO]) VALUES (21, N'Copa', 20, 1)
GO
SET IDENTITY_INSERT [dbo].[VAJILLA] OFF
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (10, 3)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (10, 6)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (10, 10)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (10, 11)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (10, 12)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (10, 13)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (10, 14)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (10, 19)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (10, 22)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (10, 26)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (11, 1)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (11, 2)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (11, 6)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (11, 18)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (11, 19)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (11, 20)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (11, 21)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (11, 25)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (12, 1)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (12, 3)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (12, 10)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (12, 12)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (12, 13)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (12, 14)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (12, 19)
GO
INSERT [dbo].[VAJILLAXPLATO] ([IDVAJILLA], [IDPLATO]) VALUES (12, 22)
GO
/****** Object:  Index [UQ__BEBIDA__3214EC26E041C359]    Script Date: 28/06/2019 21:03:12 ******/
ALTER TABLE [dbo].[BEBIDA] ADD UNIQUE NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__EMPLEADO__C035B8DDBEE8EABD]    Script Date: 28/06/2019 21:03:12 ******/
ALTER TABLE [dbo].[EMPLEADO] ADD UNIQUE NONCLUSTERED 
(
	[DNI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__MARCA__3214EC2642843C03]    Script Date: 28/06/2019 21:03:12 ******/
ALTER TABLE [dbo].[MARCA] ADD UNIQUE NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__MESA__3214EC2630F086C3]    Script Date: 28/06/2019 21:03:12 ******/
ALTER TABLE [dbo].[MESA] ADD UNIQUE NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ__PLATO__3214EC2607A8528A]    Script Date: 28/06/2019 21:03:12 ******/
ALTER TABLE [dbo].[PLATO] ADD UNIQUE NONCLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__VAJILLA__B21D0AB97585DCCB]    Script Date: 28/06/2019 21:03:12 ******/
ALTER TABLE [dbo].[VAJILLA] ADD UNIQUE NONCLUSTERED 
(
	[NOMBRE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TIPO_PLATO] ADD  DEFAULT ('') FOR [estado]
GO
ALTER TABLE [dbo].[BEBIDA]  WITH CHECK ADD  CONSTRAINT [FK_BEBIDA] FOREIGN KEY([IDMARCA])
REFERENCES [dbo].[MARCA] ([ID])
GO
ALTER TABLE [dbo].[BEBIDA] CHECK CONSTRAINT [FK_BEBIDA]
GO
ALTER TABLE [dbo].[BEBIDASXPEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_BEBIDASXPE] FOREIGN KEY([IDPEDIDO])
REFERENCES [dbo].[PEDIDOS] ([ID])
GO
ALTER TABLE [dbo].[BEBIDASXPEDIDO] CHECK CONSTRAINT [FK_BEBIDASXPE]
GO
ALTER TABLE [dbo].[BEBIDASXPEDIDO]  WITH CHECK ADD  CONSTRAINT [FK_BEBIDASXPEDOS] FOREIGN KEY([IDBEBIDA])
REFERENCES [dbo].[BEBIDA] ([ID])
GO
ALTER TABLE [dbo].[BEBIDASXPEDIDO] CHECK CONSTRAINT [FK_BEBIDASXPEDOS]
GO
ALTER TABLE [dbo].[MESA]  WITH CHECK ADD  CONSTRAINT [FK_IDMESERO] FOREIGN KEY([IDMESERO])
REFERENCES [dbo].[EMPLEADO] ([ID])
GO
ALTER TABLE [dbo].[MESA] CHECK CONSTRAINT [FK_IDMESERO]
GO
ALTER TABLE [dbo].[PEDIDOS]  WITH CHECK ADD  CONSTRAINT [FK_IDMESA] FOREIGN KEY([IDMESA])
REFERENCES [dbo].[MESA] ([ID])
GO
ALTER TABLE [dbo].[PEDIDOS] CHECK CONSTRAINT [FK_IDMESA]
GO
ALTER TABLE [dbo].[PLATO]  WITH CHECK ADD  CONSTRAINT [FK_PLATO] FOREIGN KEY([TIPO])
REFERENCES [dbo].[TIPO_PLATO] ([ID])
GO
ALTER TABLE [dbo].[PLATO] CHECK CONSTRAINT [FK_PLATO]
GO
ALTER TABLE [dbo].[PLATOSXPED]  WITH CHECK ADD  CONSTRAINT [FK_PLATOXPED] FOREIGN KEY([IDPLATO])
REFERENCES [dbo].[PLATO] ([ID])
GO
ALTER TABLE [dbo].[PLATOSXPED] CHECK CONSTRAINT [FK_PLATOXPED]
GO
ALTER TABLE [dbo].[PLATOSXPED]  WITH CHECK ADD  CONSTRAINT [FK_PLAXPE] FOREIGN KEY([IDPEDIDO])
REFERENCES [dbo].[PEDIDOS] ([ID])
GO
ALTER TABLE [dbo].[PLATOSXPED] CHECK CONSTRAINT [FK_PLAXPE]
GO
ALTER TABLE [dbo].[VAJILLAXPLATO]  WITH CHECK ADD  CONSTRAINT [FK_VAJILLA] FOREIGN KEY([IDVAJILLA])
REFERENCES [dbo].[VAJILLA] ([ID])
GO
ALTER TABLE [dbo].[VAJILLAXPLATO] CHECK CONSTRAINT [FK_VAJILLA]
GO
ALTER TABLE [dbo].[VAJILLAXPLATO]  WITH CHECK ADD  CONSTRAINT [FK_VAXPLA] FOREIGN KEY([IDPLATO])
REFERENCES [dbo].[PLATO] ([ID])
GO
ALTER TABLE [dbo].[VAJILLAXPLATO] CHECK CONSTRAINT [FK_VAXPLA]
GO
/****** Object:  StoredProcedure [dbo].[AgegarBebidaPedido]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AgegarBebidaPedido]
@idmesa bigint , @idbebida bigint , @cant bigint,
@idmesero bigint 
as 
insert into pedidos(idmesa,idmesero,fecha) values (@idmesa,@idmesero,getdate())
insert into BEBIDASXPEDIDO(idpedido,IDBEBIDA,CANTIDAD,estado,Entregado,precio) 
values ((select max (id) from PEDIDOS where IDMESA=@idmesa),
@idbebida,@cant,1,0,(select PRECIO from BEBIDA where id=@idbebida))
GO
/****** Object:  StoredProcedure [dbo].[AgregarPlatoPedido]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[AgregarPlatoPedido]
@idplato bigint , @idmesa bigint,@cant bigint, @idmesero bigint,
@precio money
as 

insert into pedidos (idmesa,idmesero,fecha)
values (@idmesa,@idmesero,getdate ())
insert into platosxped (idpedido,idplato,cantidad,entregado,estado,precio)
values ((select max (id) from pedidos where idmesa=@idmesa),
 @idplato,@cant,0,1,@precio)
GO
/****** Object:  StoredProcedure [dbo].[BebidasxMarca]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[BebidasxMarca]
@idmarca bigint as 
select NOMBRE + '    $'+ CAST(PRECIO AS varchar) as nombre,ID,DESCRIPCION from bebida where IDMARCA=@idmarca and ESTADO=1
GO
/****** Object:  StoredProcedure [dbo].[bebidaxmesa]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[bebidaxmesa]
@idmesa bigint as

select p.id, b.NOMBRE,b.DESCRIPCION,b.PRECIO,bp.CANTIDAD,bp.Entregado  from pedidos as p
inner join BEBIDASXPEDIDO as bp on p.ID=bp.IDPEDIDO
inner join BEBIDA as b on b.ID=bp.IDBEBIDA
where p.idmesa=@idmesa and bp.estado=1
GO
/****** Object:  StoredProcedure [dbo].[descripcionBebida]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[descripcionBebida]
@idbebida bigint as 
select DESCRIPCION from BEBIDA where ID=@idbebida
GO
/****** Object:  StoredProcedure [dbo].[idmesero]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[idmesero] 
@fecha datetime ,
@idMe int  ,
@idM int  as 

update PEDIDOS set fecha=@fecha where id>@idMe and id<@idM
GO
/****** Object:  StoredProcedure [dbo].[platoxmesa]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[platoxmesa]
@idmesa bigint as

select p.id,pp.cantidad,pl.nombre,pl.descripcion,pl.precio,p.idmesa,pp.Entregado from pedidos as p
inner join platosxped as pp on p.id=pp.idpedido
inner join plato as pl on pl.id=pp.idplato
where p.idmesa=@idmesa and pp.estado=1
GO
/****** Object:  StoredProcedure [dbo].[precioPlato]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[precioPlato]
@idplato bigint as 
select precio from plato as p
where p.id=@idplato
GO
/****** Object:  StoredProcedure [dbo].[sp_mesasXmesero]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_mesasXmesero]
@idmesero bigint  as 
select id,ocupado from mesa where idmesero=@idmesero and ESTADO=1
GO
/****** Object:  StoredProcedure [dbo].[sp_OcupadoMesa]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_OcupadoMesa]
@idmesa bigint,@ocupado bit as 
update MESA set OCUPADO=@ocupado where ID=@idmesa
GO
/****** Object:  StoredProcedure [dbo].[sp_platoXtipo]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_platoXtipo]
@idtipo bigint  as 
select id ,nombre,descripcion from plato  as pl
where tipo=@idtipo and pl.estado=1
GO
/****** Object:  StoredProcedure [dbo].[spBebidasPendientes]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spBebidasPendientes]
 @idmesa bigint as 
select p.id as idpedido, b.nombre, b.descripcion,b.precio,bp.cantidad from pedidos as p
inner join bebidasxpedido as bp on bp.idpedido=p.id
inner join bebida as b on b.id=bp.idbebida
where entregado=0 and p.idmesa=@idmesa and bp.estado=1
GO
/****** Object:  StoredProcedure [dbo].[SPcantidadBebidas]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPcantidadBebidas] 
 @idbebida bigint as 
select cantidad from bebida where id = @idbebida
GO
/****** Object:  StoredProcedure [dbo].[spCantidadMesas]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spCantidadMesas]
@idmesero bigint as 
select count (*) as cantidad from mesa as m
where m.idmesero=@idmesero and estado=1
GO
/****** Object:  StoredProcedure [dbo].[SPcantidadPa]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create procedure [dbo].[SPcantidadPa]
 @idplato bigint as 
select cantidad from plato where id = @idplato
GO
/****** Object:  StoredProcedure [dbo].[SPcobrar]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SPcobrar] 
@idMesa bigint as

select * from PEDIDOS as p
right join PLATOSXPED as pxp on pxp.IDPEDIDO=p.ID
right join BEBIDASXPEDIDO as b on b.IDPEDIDO=p.ID

where IDMESA=1
GO
/****** Object:  StoredProcedure [dbo].[SpCobrarBebidas]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SpCobrarBebidas]
 @idmesa bigint as 
select p.id as idpedido, b.nombre, b.descripcion,b.precio,bp.cantidad from pedidos as p
inner join bebidasxpedido as bp on bp.idpedido=p.id
inner join bebida as b on b.id=bp.idbebida
where p.idmesa=@idmesa and bp.estado=1
GO
/****** Object:  StoredProcedure [dbo].[SPcobrarMesa]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SPcobrarMesa] 
@idmesa bigint as 


update BEBIDASXPEDIDO set estado=0 
where IDPEDIDO in (
select ID from PEDIDOS 
where IDMESA=@idmesa)

update PLATOSXPED set estado=0 
where IDPEDIDO in (
select ID from PEDIDOS 
where IDMESA=@idmesa)
GO
/****** Object:  StoredProcedure [dbo].[SpCobrarPlatos]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SpCobrarPlatos]
@idmesa bigint as 
select p.id, pl.nombre,pl.precio,pp.cantidad from pedidos as p
inner join platosxped as pp on p.id=pp.idpedido
inner join plato as pl on pl.id=pp.idplato
where p.idmesa=@idmesa and pp.estado=1
GO
/****** Object:  StoredProcedure [dbo].[spDNI]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spDNI]
@dni int as 
select dni from empleado where dni=@dni
GO
/****** Object:  StoredProcedure [dbo].[spEntregado]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[spEntregado]
@idpedido bigint as 
update platosxped set entregado =1 where idpedido=@idpedido
update bebidasxpedido set entregado =1 where idpedido=@idpedido
GO
/****** Object:  StoredProcedure [dbo].[spEstadisticaEmpleados]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spEstadisticaEmpleados] 
@desde date , @hasta date
as
select e.NOMBRE+','+e.APELLIDO as nomape,
(select count (*) from pedidos as pe 
inner join PLATOSXPED as px on px.IDPEDIDO =pe.id
where pe.idmesero =e.id and pe.fecha between @desde 
and @hasta ) as cant ,DNI
 from EMPLEADO as e
where e.PUESTO like 'mesero'  
order by cant desc
GO
/****** Object:  StoredProcedure [dbo].[spEstadisticaPlato]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spEstadisticaPlato] 
@inicio date , @fin date
as
select pl.nombre, isnull ((
select sum(cantidad) from PLATOSXPED as pp 
inner join PEDIDOS as pe on pe.ID=pp.IDPEDIDO where pl.id=pp.idplato
and  pe.fecha between @inicio  and @fin
),0) 
as cant from PLATO as pl
order by cant desc
GO
/****** Object:  StoredProcedure [dbo].[spLogin]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spLogin] 
@usuario varchar (50), @contra varchar (10)as 
select id from empleado 
where usuario=@usuario and contrasena=@contra and estado=1
GO
/****** Object:  StoredProcedure [dbo].[spLoginMaster]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spLoginMaster]
@usuario varchar (50), @contra varchar (10)as 
select id from empleado 
where usuario=@usuario and contrasena=@contra and estado=1 and puesto like 'administrativo'
GO
/****** Object:  StoredProcedure [dbo].[spNombre]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spNombre]
@idempl bigint as
select nombre +','+apellido as nomApe from empleado
where id=@idempl 
GO
/****** Object:  StoredProcedure [dbo].[spPlatosPendientes]    Script Date: 28/06/2019 21:03:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[spPlatosPendientes]
@idmesa bigint as 
select p.id, pl.nombre,pl.precio,pp.cantidad from pedidos as p
inner join platosxped as pp on p.id=pp.idpedido
inner join plato as pl on pl.id=pp.idplato
where entregado=0 and p.idmesa=@idmesa and pp.estado=1
GO
USE [master]
GO
ALTER DATABASE [Barzola] SET  READ_WRITE 
GO
