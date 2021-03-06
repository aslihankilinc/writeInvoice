USE [master]
GO
/****** Object:  Database [invoiceDesing]    Script Date: 2.06.2022 14:48:27 ******/
CREATE DATABASE [invoiceDesing]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'invoiceDesing', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\invoiceDesing.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'invoiceDesing_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\invoiceDesing_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [invoiceDesing] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [invoiceDesing].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [invoiceDesing] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [invoiceDesing] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [invoiceDesing] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [invoiceDesing] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [invoiceDesing] SET ARITHABORT OFF 
GO
ALTER DATABASE [invoiceDesing] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [invoiceDesing] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [invoiceDesing] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [invoiceDesing] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [invoiceDesing] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [invoiceDesing] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [invoiceDesing] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [invoiceDesing] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [invoiceDesing] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [invoiceDesing] SET  DISABLE_BROKER 
GO
ALTER DATABASE [invoiceDesing] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [invoiceDesing] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [invoiceDesing] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [invoiceDesing] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [invoiceDesing] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [invoiceDesing] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [invoiceDesing] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [invoiceDesing] SET RECOVERY FULL 
GO
ALTER DATABASE [invoiceDesing] SET  MULTI_USER 
GO
ALTER DATABASE [invoiceDesing] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [invoiceDesing] SET DB_CHAINING OFF 
GO
ALTER DATABASE [invoiceDesing] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [invoiceDesing] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [invoiceDesing] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'invoiceDesing', N'ON'
GO
USE [invoiceDesing]
GO
/****** Object:  Table [dbo].[tblBody]    Script Date: 2.06.2022 14:48:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBody](
	[No] [smallint] IDENTITY(1,1) NOT NULL,
	[ScomeNo] [smallint] NOT NULL,
	[Left] [numeric](5, 2) NOT NULL,
	[Top] [numeric](5, 2) NOT NULL,
 CONSTRAINT [PK_tblBody] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblCeki]    Script Date: 2.06.2022 14:48:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCeki](
	[No] [int] IDENTITY(1,1) NOT NULL,
	[AracNo] [smallint] NOT NULL,
	[Palet] [smallint] NOT NULL,
	[Net] [decimal](18, 2) NULL,
	[Brut] [decimal](18, 2) NULL,
	[AracNet] [decimal](18, 2) NULL,
	[GirisTarih] [datetime] NULL,
	[CikisTarih] [datetime] NULL,
 CONSTRAINT [PK_tblCeki] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblDocument]    Script Date: 2.06.2022 14:48:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDocument](
	[No] [smallint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[FontFamily] [varchar](100) NULL,
	[FontSize] [smallint] NULL,
	[Head] [varchar](100) NULL,
 CONSTRAINT [PK_tblDocument] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblDriver]    Script Date: 2.06.2022 14:48:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblDriver](
	[No] [smallint] IDENTITY(1,1) NOT NULL,
	[Driver] [varchar](100) NULL,
	[TC] [varchar](20) NULL,
	[Plaka1] [varchar](20) NULL,
	[Plaka2] [varchar](20) NULL,
 CONSTRAINT [PK_tblDriver] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblHeader]    Script Date: 2.06.2022 14:48:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHeader](
	[No] [smallint] IDENTITY(1,1) NOT NULL,
	[ScomeNo] [smallint] NOT NULL,
	[Left] [numeric](5, 2) NOT NULL,
	[Top] [numeric](5, 2) NOT NULL,
 CONSTRAINT [PK_tblHeader] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblScomeName]    Script Date: 2.06.2022 14:48:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblScomeName](
	[No] [smallint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[DocumentNo] [smallint] NULL,
	[Description] [varchar](50) NULL,
	[Order] [smallint] NULL,
 CONSTRAINT [PK_tblScomeName] PRIMARY KEY CLUSTERED 
(
	[No] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tblBody]  WITH CHECK ADD  CONSTRAINT [FK_tblBody_tblScomeName] FOREIGN KEY([ScomeNo])
REFERENCES [dbo].[tblScomeName] ([No])
GO
ALTER TABLE [dbo].[tblBody] CHECK CONSTRAINT [FK_tblBody_tblScomeName]
GO
ALTER TABLE [dbo].[tblCeki]  WITH CHECK ADD  CONSTRAINT [FK_tblCeki_tblDriver] FOREIGN KEY([AracNo])
REFERENCES [dbo].[tblDriver] ([No])
GO
ALTER TABLE [dbo].[tblCeki] CHECK CONSTRAINT [FK_tblCeki_tblDriver]
GO
ALTER TABLE [dbo].[tblHeader]  WITH CHECK ADD  CONSTRAINT [FK_tblHeader_tblScomeName] FOREIGN KEY([ScomeNo])
REFERENCES [dbo].[tblScomeName] ([No])
GO
ALTER TABLE [dbo].[tblHeader] CHECK CONSTRAINT [FK_tblHeader_tblScomeName]
GO
ALTER TABLE [dbo].[tblScomeName]  WITH CHECK ADD  CONSTRAINT [FK_tblScomeName_tblDocument] FOREIGN KEY([DocumentNo])
REFERENCES [dbo].[tblDocument] ([No])
GO
ALTER TABLE [dbo].[tblScomeName] CHECK CONSTRAINT [FK_tblScomeName_tblDocument]
GO
USE [master]
GO
ALTER DATABASE [invoiceDesing] SET  READ_WRITE 
GO
