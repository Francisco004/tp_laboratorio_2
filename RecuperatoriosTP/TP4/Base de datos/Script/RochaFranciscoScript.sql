CREATE DATABASE RochaFranciscoTP4;
GO
USE [RochaFranciscoTP4]
GO
/****** Object:  Table [dbo].[Tabla_Celular]    Script Date: 13/7/2021 22:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tabla_Celular](
	[UPC] [int] NOT NULL,
	[Marca] [nvarchar](200) NOT NULL,
	[GPU] [nvarchar](200) NOT NULL,
	[Ram] [nvarchar](200) NOT NULL,
	[SistemaOperativo] [nvarchar](200) NOT NULL,
	[Almacenamiento] [nvarchar](200) NOT NULL,
	[Camara] [nvarchar](200) NOT NULL,
	[Bateria] [nvarchar](200) NOT NULL,
	[Material] [nvarchar](200) NOT NULL,
	[Pulgadas] [nvarchar](200) NOT NULL,
	[Resolucion] [nvarchar](200) NOT NULL,
	[Jack] [int] NOT NULL,
	[Huella] [int] NOT NULL,
 CONSTRAINT [PK_Tabla_Celular] PRIMARY KEY CLUSTERED 
(
	[UPC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tabla_PC]    Script Date: 13/7/2021 22:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tabla_PC](
	[UPC] [int] NOT NULL,
	[Marca] [nvarchar](200) NOT NULL,
	[Procesador] [nvarchar](200) NOT NULL,
	[Motherboard] [nvarchar](200) NOT NULL,
	[GPU] [nvarchar](200) NOT NULL,
	[Ram] [nvarchar](200) NOT NULL,
	[Fuente] [nvarchar](200) NOT NULL,
	[Gabinete] [nvarchar](200) NOT NULL,
	[SistemaOperativo] [nvarchar](200) NOT NULL,
	[Almacenamiento] [nvarchar](200) NOT NULL,
	[LectorCD] [int] NOT NULL,
 CONSTRAINT [PK_Tabla_PC] PRIMARY KEY CLUSTERED 
(
	[UPC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table_Almacen]    Script Date: 13/7/2021 22:42:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table_Almacen](
	[NombreDelAlamcen] [nvarchar](200) NULL,
	[CantidadDeProductos] [int] NULL
) ON [PRIMARY]
GO
