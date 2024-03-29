USE [master]
GO
/****** Object:  Database [videorental]    Script Date: 30/09/2019 10:59:53 AM ******/
CREATE DATABASE [videorental]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'videorental', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\videorental.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'videorental_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\videorental_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [videorental] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [videorental].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [videorental] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [videorental] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [videorental] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [videorental] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [videorental] SET ARITHABORT OFF 
GO
ALTER DATABASE [videorental] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [videorental] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [videorental] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [videorental] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [videorental] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [videorental] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [videorental] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [videorental] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [videorental] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [videorental] SET  DISABLE_BROKER 
GO
ALTER DATABASE [videorental] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [videorental] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [videorental] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [videorental] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [videorental] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [videorental] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [videorental] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [videorental] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [videorental] SET  MULTI_USER 
GO
ALTER DATABASE [videorental] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [videorental] SET DB_CHAINING OFF 
GO
ALTER DATABASE [videorental] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [videorental] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [videorental] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [videorental] SET QUERY_STORE = OFF
GO
USE [videorental]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 30/09/2019 10:59:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](255) NULL,
	[LastName] [nvarchar](255) NULL,
	[Address] [nvarchar](255) NULL,
	[Phone] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 30/09/2019 10:59:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[Rating] [nvarchar](50) NULL,
	[Title] [nvarchar](255) NULL,
	[Year] [nvarchar](255) NULL,
	[Rental_Cost] [money] NULL,
	[Copies] [nvarchar](50) NULL,
	[Plot] [ntext] NULL,
	[Genre] [nvarchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentedMovies]    Script Date: 30/09/2019 10:59:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovies](
	[RMID] [int] IDENTITY(1,1) NOT NULL,
	[MovieIDFK] [int] NULL,
	[CustIDFK] [int] NULL,
	[DateRented] [varchar](50) NULL,
	[DateReturned] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (40, N'singh', N'44 puhinui road', N'02041463366', NULL)
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (43, N'Shields', N'111 Brook Lane', N'44349721', NULL)
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (44, N'Short', N'875 Edgewood Drive', N'2615295', NULL)
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (45, N'Shaw', N'936 Walnut Street', N'9245619', N'')
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (46, N'Shepherd', N'398 Pine Street', N'8346936', NULL)
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (47, N'Short', N'955 Valley Drive', N'8406969', NULL)
INSERT [dbo].[Customer] ([CustID], [FirstName], [LastName], [Address], [Phone]) VALUES (48, N'Shepherd', N'226 Front Street South', N'9208849', N'')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (1, N'8', N'Harry Potter and the Deathly Hallows: Part 2', N'2011', 2.0000, N'', N'Harry, Ron and Hermione search for Voldemort''s remaining Horcruxes in their effort to destroy the Dark Lord as the final battle rages on at Hogwarts.', N'Adventure, Fantasy, Mystery')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (2, N'8', N'FX/2', N'1991', 2.0000, N'2', N'34', N'23')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (3, N'PG-13', N'Troll 2', N'1990', 2.0000, N'', N'A family vacationing in a small town discovers the entire town is inhabited by goblins in disguise as humans, who plan to eat them.', N'Fantasy, Horror, Mystery')
INSERT [dbo].[Movies] ([MovieID], [Rating], [Title], [Year], [Rental_Cost], [Copies], [Plot], [Genre]) VALUES (4, N'G', N'Monsters, Inc.', N'2001', 2.0000, N'', N'Monsters generate their city''s power by scaring children, but they are terribly afraid themselves of being contaminated by children, so when one enters Monstropolis, top scarer Sulley finds his world disrupted.', N'Animation, Adventure, Comedy')
SET IDENTITY_INSERT [dbo].[Movies] OFF
SET IDENTITY_INSERT [dbo].[RentedMovies] ON 

INSERT [dbo].[RentedMovies] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (20, 356, 1, N'Apr  9 2014 11:11AM', N'Mar  8 2016  1:40PM')
INSERT [dbo].[RentedMovies] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (21, 322, 1, N'Apr  9 2014 11:14AM', N'Mar  8 2016  1:40PM')
INSERT [dbo].[RentedMovies] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (22, 503, 1, N'Apr  9 2014 11:18AM', N'Apr  9 2014  3:34PM')
INSERT [dbo].[RentedMovies] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (23, 447, 1, N'Apr  9 2014 11:21AM', N'Apr 10 2014  3:36PM')
INSERT [dbo].[RentedMovies] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (24, 76, 1, N'Apr  9 2014 11:44AM', N'Apr 11 2014 10:49AM')
INSERT [dbo].[RentedMovies] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (25, 503, 1, N'Apr  9 2014 11:55AM', N'Apr 11 2014 10:50AM')
INSERT [dbo].[RentedMovies] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (26, 294, 1, N'Apr  9 2014  1:25PM', N'Wednesday, February 20, 2019')
INSERT [dbo].[RentedMovies] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (27, 503, 1, N'Apr  9 2014  1:25PM', N'Apr 14 2014 10:04AM')
INSERT [dbo].[RentedMovies] ([RMID], [MovieIDFK], [CustIDFK], [DateRented], [DateReturned]) VALUES (28, 69, 5, N'Apr 10 2014  3:27PM', N'Apr 10 2014  3:27PM')
SET IDENTITY_INSERT [dbo].[RentedMovies] OFF
USE [master]
GO
ALTER DATABASE [videorental] SET  READ_WRITE 
GO
