USE [master]
GO
/****** Object:  Database [AutoSaloon]    Script Date: 10/22/2018 12:41:34 AM ******/
CREATE DATABASE [AutoSaloon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AutoSaloon', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\AutoSaloon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AutoSaloon_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\AutoSaloon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [AutoSaloon] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AutoSaloon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AutoSaloon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AutoSaloon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AutoSaloon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AutoSaloon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AutoSaloon] SET ARITHABORT OFF 
GO
ALTER DATABASE [AutoSaloon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AutoSaloon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AutoSaloon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AutoSaloon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AutoSaloon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AutoSaloon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AutoSaloon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AutoSaloon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AutoSaloon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AutoSaloon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [AutoSaloon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AutoSaloon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AutoSaloon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AutoSaloon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AutoSaloon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AutoSaloon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AutoSaloon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AutoSaloon] SET RECOVERY FULL 
GO
ALTER DATABASE [AutoSaloon] SET  MULTI_USER 
GO
ALTER DATABASE [AutoSaloon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AutoSaloon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AutoSaloon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AutoSaloon] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AutoSaloon] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AutoSaloon', N'ON'
GO
ALTER DATABASE [AutoSaloon] SET QUERY_STORE = OFF
GO
USE [AutoSaloon]
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
USE [AutoSaloon]
GO
/****** Object:  Table [dbo].[Franchise]    Script Date: 10/22/2018 12:41:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Franchise](
	[FranchiseId] [int] IDENTITY(1,1) NOT NULL,
	[FranchiseName] [nvarchar](50) NOT NULL,
	[FranchiseDesc] [nvarchar](1000) NULL,
	[FranchiseImage] [image] NULL,
	[FranchiseIsActive] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatorId] [int] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[LastModifierID] [int] NOT NULL,
	[DeletedDate] [datetime] NULL,
	[DeleterID] [int] NULL,
 CONSTRAINT [PK_Franchise] PRIMARY KEY CLUSTERED 
(
	[FranchiseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FranchisePackage]    Script Date: 10/22/2018 12:41:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FranchisePackage](
	[FranchisePackageId] [int] IDENTITY(1,1) NOT NULL,
	[FranchiseId] [int] NOT NULL,
	[PackageId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatorId] [int] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[LastModifierID] [int] NOT NULL,
	[DeletedDate] [datetime] NULL,
	[DeleterID] [int] NULL,
 CONSTRAINT [PK_FranchisePackage] PRIMARY KEY CLUSTERED 
(
	[FranchisePackageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FranchiseProduct]    Script Date: 10/22/2018 12:41:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FranchiseProduct](
	[FranchiseProductId] [int] IDENTITY(1,1) NOT NULL,
	[FranchiseId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatorId] [int] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[LastModifierID] [int] NOT NULL,
	[DeletedDate] [datetime] NULL,
	[DeleterID] [int] NULL,
 CONSTRAINT [PK_FranchiseProduct] PRIMARY KEY CLUSTERED 
(
	[FranchiseProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FranchiseUser]    Script Date: 10/22/2018 12:41:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FranchiseUser](
	[FranchiseUserId] [int] IDENTITY(1,1) NOT NULL,
	[FranchiseId] [int] NOT NULL,
	[LoginId] [int] NOT NULL,
	[IsAdmin] [bit] NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatorId] [int] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[LastModifierID] [int] NOT NULL,
	[DeletedDate] [datetime] NULL,
	[DeleterID] [int] NULL,
 CONSTRAINT [PK_FranchiseUser] PRIMARY KEY CLUSTERED 
(
	[FranchiseUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginDetail]    Script Date: 10/22/2018 12:41:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginDetail](
	[LoginId] [int] IDENTITY(1,1) NOT NULL,
	[LoginEmail] [nvarchar](500) NOT NULL,
	[LoginPassword] [nvarchar](500) NOT NULL,
	[LoginPasswordSalt] [nvarchar](100) NOT NULL,
	[LoginPasswordEncryptType] [int] NOT NULL,
	[LoginPasswordUpdateDate] [datetime] NOT NULL,
	[LoginUserFirstName] [nvarchar](100) NOT NULL,
	[LoginUserLastName] [nvarchar](100) NOT NULL,
	[LoginUserMobile] [nvarchar](50) NULL,
	[LoginLocked] [bit] NOT NULL,
	[LoginActive] [bit] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatorId] [int] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[LastModifierID] [int] NOT NULL,
	[DeletedDate] [datetime] NULL,
	[DeleterID] [int] NULL,
	[LoginUserFullName]  AS (([LoginUserFirstName]+' ')+[LoginUserLastName]) PERSISTED NOT NULL,
 CONSTRAINT [PK_LoginDetail_LoginId] PRIMARY KEY CLUSTERED 
(
	[LoginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_LoginDetail_LoginEmail] UNIQUE NONCLUSTERED 
(
	[LoginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Package]    Script Date: 10/22/2018 12:41:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Package](
	[PackageId] [int] IDENTITY(1,1) NOT NULL,
	[PackageName] [nvarchar](50) NOT NULL,
	[PackageDesc] [nvarchar](1000) NULL,
	[PackagePrice] [decimal](10, 2) NOT NULL,
	[PackageMinDiscountPercentage] [int] NULL,
	[PackageMaxDiscountPercentage] [nchar](10) NULL,
	[PackageImage] [image] NULL,
	[PackageIsActive] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatorId] [int] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[LastModifierID] [int] NOT NULL,
	[DeletedDate] [datetime] NULL,
	[DeleterID] [int] NULL,
 CONSTRAINT [PK_Package] PRIMARY KEY CLUSTERED 
(
	[PackageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PackageProduct]    Script Date: 10/22/2018 12:41:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PackageProduct](
	[PackageProductId] [int] IDENTITY(1,1) NOT NULL,
	[PackageId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[IsActive] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatorId] [int] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[LastModifierID] [int] NOT NULL,
	[DeletedDate] [datetime] NULL,
	[DeleterID] [int] NULL,
 CONSTRAINT [PK_PackageProduct] PRIMARY KEY CLUSTERED 
(
	[PackageProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 10/22/2018 12:41:34 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[ProductDesc] [nvarchar](1000) NULL,
	[ProductPrice] [decimal](10, 2) NOT NULL,
	[ProductMinDiscountPercentage] [int] NULL,
	[ProductMaxDiscountPercentage] [nchar](10) NULL,
	[ProductImage] [image] NULL,
	[ProductIsActive] [bit] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatorId] [int] NOT NULL,
	[LastModifiedDate] [datetime] NOT NULL,
	[LastModifierID] [int] NOT NULL,
	[DeletedDate] [datetime] NULL,
	[DeleterID] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [AutoSaloon] SET  READ_WRITE 
GO
