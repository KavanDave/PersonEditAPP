The **PersonEditAPP** is created to demonstrate use of **technologies like  blazer, .NET Core and Entity frame work** mainly.
The API endpoints are created within the project and they are getting data from **SQL Server Database.**

The App is Consist of 3 main pages: 
1) Home Page that shows all records present in database
2) Add Persons Page that is used to add new user/person which is performed using APIs
3) Update Persons that is used for updating user/person data that is present on the specific id

Below script can be used to create the same database in SQL Server:-
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

USE [master]
GO
/****** Object:  Database [BlazerPersonAPP]    Script Date: 11/26/2024 12:17:40 AM ******/
CREATE DATABASE [BlazerPersonAPP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BlazerPersonAPP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\BlazerPersonAPP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BlazerPersonAPP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\BlazerPersonAPP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BlazerPersonAPP] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BlazerPersonAPP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BlazerPersonAPP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET ARITHABORT OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BlazerPersonAPP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BlazerPersonAPP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BlazerPersonAPP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BlazerPersonAPP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BlazerPersonAPP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BlazerPersonAPP] SET  MULTI_USER 
GO
ALTER DATABASE [BlazerPersonAPP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BlazerPersonAPP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BlazerPersonAPP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BlazerPersonAPP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BlazerPersonAPP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BlazerPersonAPP] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BlazerPersonAPP] SET QUERY_STORE = ON
GO
ALTER DATABASE [BlazerPersonAPP] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BlazerPersonAPP]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 11/26/2024 12:17:41 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fname] [varchar](50) NOT NULL,
	[lname] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[phone] [varchar](50) NOT NULL,
	[pass] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [BlazerPersonAPP] SET  READ_WRITE 
GO

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
