USE [master]
GO
/****** Object:  Database [ConceptHotel]    Script Date: 21.12.2023 11:13:44 ******/
CREATE DATABASE [ConceptHotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ConceptHotel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.GGEZ\MSSQL\DATA\ConceptHotel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ConceptHotel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.GGEZ\MSSQL\DATA\ConceptHotel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [ConceptHotel] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ConceptHotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ConceptHotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ConceptHotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ConceptHotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ConceptHotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ConceptHotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [ConceptHotel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ConceptHotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ConceptHotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ConceptHotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ConceptHotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ConceptHotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ConceptHotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ConceptHotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ConceptHotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ConceptHotel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ConceptHotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ConceptHotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ConceptHotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ConceptHotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ConceptHotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ConceptHotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ConceptHotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ConceptHotel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ConceptHotel] SET  MULTI_USER 
GO
ALTER DATABASE [ConceptHotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ConceptHotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ConceptHotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ConceptHotel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ConceptHotel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ConceptHotel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ConceptHotel] SET QUERY_STORE = ON
GO
ALTER DATABASE [ConceptHotel] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ConceptHotel]
GO
/****** Object:  Table [dbo].[Bron]    Script Date: 21.12.2023 11:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bron](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Room_Number] [nvarchar](10) NOT NULL,
	[Client_ID] [nvarchar](10) NOT NULL,
	[Bron_IN] [nvarchar](32) NOT NULL,
	[Bron_Out] [nvarchar](32) NOT NULL,
	[Active] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Bron] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 21.12.2023 11:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Surname] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Passport] [nvarchar](50) NOT NULL,
	[Active] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nomera]    Script Date: 21.12.2023 11:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nomera](
	[Nomer] [nvarchar](10) NOT NULL,
	[Type] [nvarchar](15) NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
	[Free] [nvarchar](3) NOT NULL,
	[Active] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Nomera] PRIMARY KEY CLUSTERED 
(
	[Nomer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 21.12.2023 11:13:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[User_ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Roles] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Bron] ON 

INSERT [dbo].[Bron] ([ID], [Room_Number], [Client_ID], [Bron_IN], [Bron_Out], [Active]) VALUES (20, N'219', N'8', N'11 декабря 2023 г.', N'11 декабря 2023 г.', N'Нет       ')
INSERT [dbo].[Bron] ([ID], [Room_Number], [Client_ID], [Bron_IN], [Bron_Out], [Active]) VALUES (22, N'219', N'8', N'11 декабря 2023 г.', N'11 декабря 2023 г.', N'Нет       ')
INSERT [dbo].[Bron] ([ID], [Room_Number], [Client_ID], [Bron_IN], [Bron_Out], [Active]) VALUES (23, N'219', N'8', N'11 декабря 2023 г.', N'11 декабря 2023 г.', N'Нет       ')
INSERT [dbo].[Bron] ([ID], [Room_Number], [Client_ID], [Bron_IN], [Bron_Out], [Active]) VALUES (24, N'3228', N'8', N'19 декабря 2023 г.', N'19 декабря 2023 г.', N'Нет       ')
SET IDENTITY_INSERT [dbo].[Bron] OFF
GO
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([ID], [Name], [Surname], [Phone], [Passport], [Active]) VALUES (7, N'Igor', N'Pavlov', N'79164911158', N'4515 151515', N'Нет       ')
INSERT [dbo].[Clients] ([ID], [Name], [Surname], [Phone], [Passport], [Active]) VALUES (8, N'Dan', N'Voron', N'79164911153', N'4518 5555', N'Да        ')
INSERT [dbo].[Clients] ([ID], [Name], [Surname], [Phone], [Passport], [Active]) VALUES (9, N'Даниил', N'Воронин', N'888005553535', N'7518 787878', N'Да        ')
SET IDENTITY_INSERT [dbo].[Clients] OFF
GO
INSERT [dbo].[Nomera] ([Nomer], [Type], [Phone], [Free], [Active]) VALUES (N'218', N'Одиночная', N'1518', N'Нет', N'Нет       ')
INSERT [dbo].[Nomera] ([Nomer], [Type], [Phone], [Free], [Active]) VALUES (N'219', N'Одиночная', N'8888888', N'Да', N'Да        ')
INSERT [dbo].[Nomera] ([Nomer], [Type], [Phone], [Free], [Active]) VALUES (N'3228', N'Одиночная', N'635', N'Да', N'Да        ')
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([User_ID], [Login], [Password], [Roles]) VALUES (2, N'Admin', N'Admin', N'Админ')
INSERT [dbo].[Users] ([User_ID], [Login], [Password], [Roles]) VALUES (4, N'DanVoron', N'DanVoron', N'Менеджер')
INSERT [dbo].[Users] ([User_ID], [Login], [Password], [Roles]) VALUES (9, N'Daniil', N'Daniil', N'Сотрудник')
INSERT [dbo].[Users] ([User_ID], [Login], [Password], [Roles]) VALUES (21, N'danvoron', N'danvoron', N'Менеджер')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
USE [master]
GO
ALTER DATABASE [ConceptHotel] SET  READ_WRITE 
GO
