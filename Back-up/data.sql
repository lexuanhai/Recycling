USE [master]
GO
/****** Object:  Database [EnvironmentGreen]    Script Date: 6/16/2022 7:03:58 AM ******/
CREATE DATABASE [EnvironmentGreen]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EnvironmentGreen', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\EnvironmentGreen.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EnvironmentGreen_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\EnvironmentGreen_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EnvironmentGreen] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EnvironmentGreen].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EnvironmentGreen] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET ARITHABORT OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EnvironmentGreen] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EnvironmentGreen] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EnvironmentGreen] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EnvironmentGreen] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [EnvironmentGreen] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET RECOVERY FULL 
GO
ALTER DATABASE [EnvironmentGreen] SET  MULTI_USER 
GO
ALTER DATABASE [EnvironmentGreen] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EnvironmentGreen] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EnvironmentGreen] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EnvironmentGreen] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EnvironmentGreen] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EnvironmentGreen', N'ON'
GO
ALTER DATABASE [EnvironmentGreen] SET QUERY_STORE = OFF
GO
USE [EnvironmentGreen]
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
USE [EnvironmentGreen]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 6/16/2022 7:03:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppRoles]    Script Date: 6/16/2022 7:03:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppRoles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](max) NULL,
	[Description] [nvarchar](500) NULL,
 CONSTRAINT [PK_AppRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppUsers]    Script Date: 6/16/2022 7:03:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUsers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Phone] [varchar](12) NULL,
	[Address] [varchar](250) NULL,
	[City] [nvarchar](max) NULL,
	[TotalPoint] [int] NULL,
	[Avartar] [nvarchar](max) NULL,
	[Status] [int] NULL,
	[UserName] [varchar](max) NULL,
	[PassWord] [varchar](max) NULL,
	[IsDeleted] [bit] NULL,
 CONSTRAINT [PK_AppUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AppUsersProduct]    Script Date: 6/16/2022 7:03:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AppUsersProduct](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NULL,
	[AppUserId] [int] NULL,
 CONSTRAINT [PK_AppUsersProduct] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 6/16/2022 7:03:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[ParentId] [int] NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 6/16/2022 7:03:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Decription] [nvarchar](max) NULL,
	[UrlImage] [nvarchar](max) NULL,
	[SubDecription] [nvarchar](max) NULL,
	[Price] [decimal](18, 0) NULL,
	[ReducedPrice] [decimal](18, 0) NULL,
	[Total] [int] NULL,
	[CategoryId] [int] NULL,
	[Status] [bit] NULL,
	[IsDeleted] [bit] NULL,
	[Point] [int] NULL,
	[DateExpired] [nvarchar](max) NULL,
	[PricePercent] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Telecom]    Script Date: 6/16/2022 7:03:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Telecom](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[UserId] [int] NULL,
	[Exchange] [nvarchar](max) NULL,
	[Point] [int] NULL,
 CONSTRAINT [PK_Telecom] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_AppUsersProduct_AppUserId]    Script Date: 6/16/2022 7:03:59 AM ******/
CREATE NONCLUSTERED INDEX [IX_AppUsersProduct_AppUserId] ON [dbo].[AppUsersProduct]
(
	[AppUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AppUsersProduct_ProductId]    Script Date: 6/16/2022 7:03:59 AM ******/
CREATE NONCLUSTERED INDEX [IX_AppUsersProduct_ProductId] ON [dbo].[AppUsersProduct]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Category_ParentId]    Script Date: 6/16/2022 7:03:59 AM ******/
CREATE NONCLUSTERED INDEX [IX_Category_ParentId] ON [dbo].[Category]
(
	[ParentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Product_CategoryId]    Script Date: 6/16/2022 7:03:59 AM ******/
CREATE NONCLUSTERED INDEX [IX_Product_CategoryId] ON [dbo].[Product]
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AppUsersProduct]  WITH CHECK ADD  CONSTRAINT [FK_AppUsersProduct_AppUsers_AppUserId] FOREIGN KEY([AppUserId])
REFERENCES [dbo].[AppUsers] ([Id])
GO
ALTER TABLE [dbo].[AppUsersProduct] CHECK CONSTRAINT [FK_AppUsersProduct_AppUsers_AppUserId]
GO
ALTER TABLE [dbo].[AppUsersProduct]  WITH CHECK ADD  CONSTRAINT [FK_AppUsersProduct_Product_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[AppUsersProduct] CHECK CONSTRAINT [FK_AppUsersProduct_Product_ProductId]
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_Category_ParentId] FOREIGN KEY([ParentId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Category_Category_ParentId]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Category_CategoryId]
GO
USE [master]
GO
ALTER DATABASE [EnvironmentGreen] SET  READ_WRITE 
GO
