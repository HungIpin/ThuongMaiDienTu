USE [master]
GO
/****** Object:  Database [QuanLyBanGiayASP]    Script Date: 7/9/2020 2:35:43 AM ******/
CREATE DATABASE [QuanLyBanGiayASP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBanGiayASP', FILENAME = N'C:\SQL\QuanLyBanGiayASP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyBanGiayASP_log', FILENAME = N'C:\SQL\QuanLyBanGiayASP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [QuanLyBanGiayASP] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBanGiayASP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBanGiayASP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyBanGiayASP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyBanGiayASP] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyBanGiayASP', N'ON'
GO
ALTER DATABASE [QuanLyBanGiayASP] SET QUERY_STORE = OFF
GO
USE [QuanLyBanGiayASP]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 7/9/2020 2:35:43 AM ******/
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
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 7/9/2020 2:35:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 7/9/2020 2:35:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 7/9/2020 2:35:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 7/9/2020 2:35:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 7/9/2020 2:35:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 7/9/2020 2:35:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Discriminator] [nvarchar](max) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 7/9/2020 2:35:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 7/9/2020 2:35:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 7/9/2020 2:35:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](max) NULL,
	[CustomerName] [nvarchar](max) NULL,
	[Date] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ImportDetails]    Script Date: 7/9/2020 2:35:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ImportDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DateImport] [datetime2](7) NOT NULL,
	[ProductId] [int] NOT NULL,
	[AmountProduct] [int] NOT NULL,
 CONSTRAINT [PK_ImportDetails] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Merchants]    Script Date: 7/9/2020 2:35:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Merchants](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name_merchant] [nvarchar](max) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
	[Phone] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Merchants] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 7/9/2020 2:35:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OrderID] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[tongtien] [float] NOT NULL,
 CONSTRAINT [PK_OrderItems] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 7/9/2020 2:35:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[isConfirmed] [bit] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[SalesPersonId] [nvarchar](450) NULL,
	[Address] [nvarchar](max) NULL,
	[CustomerPersonId] [nvarchar](450) NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 7/9/2020 2:35:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Price] [float] NOT NULL,
	[Available] [bit] NOT NULL,
	[Image] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NOT NULL,
	[InStock] [int] NOT NULL,
	[MerchantId] [int] NOT NULL,
	[BrandId] [int] NOT NULL,
	[TypeProductId] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeProducts]    Script Date: 7/9/2020 2:35:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeProducts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TypePro] [nvarchar](max) NULL,
 CONSTRAINT [PK_TypeProducts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191120072247_Database', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191120104419_update', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191120153650_addApplicationUserToDb_Name', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191121090059_AddSalesToDatabase', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191123023907_addOrdersToDatabaseNew', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191126034553_addImportDetailsAndStores', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191129031848_addbrandtodatabase', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191129090114_new', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191129095237_newnew', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191204094810_datanew', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191204095219_importproduct', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191209041528_newimportproduct', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191209081815_dataamount', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191210075100_newdateamoi', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20191210081138_Newdatabase', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200513132026_tongtien', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200516095524_tongtien', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200519074134_Address', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200519092530_addTypeProductToDatabase', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200519092845_producttype', N'3.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20200707050432_AddCustomerPersonId', N'3.0.0')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'3ab1378a-7f36-4456-ae4c-f310d3214bb4', N'Customer', N'CUSTOMER', N'5d4df037-6b19-4fe0-9194-eea9fa69b45b')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'952dd1be-358c-49a2-a35a-05e3154d110f', N'Admin', N'ADMIN', N'94b06fcb-9202-4973-be33-a7c921c45e94')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'9df6e4ca-46e1-4c34-8e1c-7a898e54b3c8', N'Super Admin', N'SUPER ADMIN', N'e5c1571f-c6c6-4429-9464-d4fae0d3bd2b')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0c89e72d-76b4-44b4-9cea-5e4b3be0d326', N'3ab1378a-7f36-4456-ae4c-f310d3214bb4')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'84761f5d-3677-4d1e-ba22-1e65347e2c4b', N'3ab1378a-7f36-4456-ae4c-f310d3214bb4')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a0eed888-773b-4fb7-b622-1f77b81474e5', N'3ab1378a-7f36-4456-ae4c-f310d3214bb4')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a609cb86-45ec-45e4-b6eb-c5c77ddf5351', N'3ab1378a-7f36-4456-ae4c-f310d3214bb4')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'aa2523e6-ea10-4b0c-89fc-5e97b5e41fe3', N'3ab1378a-7f36-4456-ae4c-f310d3214bb4')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cb31ebc5-15cc-4344-bd60-9dc7856d275b', N'3ab1378a-7f36-4456-ae4c-f310d3214bb4')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cd47d9d7-d8ab-4906-b2b3-327197be04e4', N'3ab1378a-7f36-4456-ae4c-f310d3214bb4')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd25cbd2f-38cd-4369-8fa7-9ad85b169d14', N'3ab1378a-7f36-4456-ae4c-f310d3214bb4')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2cd05bc7-d5dd-4d61-8e45-6e45d3eae01b', N'9df6e4ca-46e1-4c34-8e1c-7a898e54b3c8')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'3494eba0-016b-4c1e-b087-d09b3b13ff93', N'9df6e4ca-46e1-4c34-8e1c-7a898e54b3c8')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'79fda6e8-a0f3-47ab-a04b-164e6bf5cde3', N'9df6e4ca-46e1-4c34-8e1c-7a898e54b3c8')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Name]) VALUES (N'0c89e72d-76b4-44b4-9cea-5e4b3be0d326', N'chu@gmail.com', N'CHU@GMAIL.COM', N'chu@gmail.com', N'CHU@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEHkulTDQLSBVN0/ku4R6XEKMJW0GhOD/pkT0Zsw1UH4X9r2S+tDgIgV5aYFaxG8axA==', N'VFTCYFWJVK5OPKMWRD65WTVNPB63R74F', N'2809e17a-2e05-4795-bb54-204818c527f0', N'0988187295', 0, 0, NULL, 1, 0, N'ApplicationUser', N'chu')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Name]) VALUES (N'2cd05bc7-d5dd-4d61-8e45-6e45d3eae01b', N'ChuChu@gmail.com', N'CHUCHU@GMAIL.COM', N'ChuChu@gmail.com', N'CHUCHU@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEJr1VP3SYTqTXGw6KgSaSJBwP41G9Nhe9MSKhr6PUI+mRdpjLMaxNtwKmKWPOGdrZg==', N'NIME63VCS4LSLLARAGHIRWQWBPFNUFGF', N'2de1d4bc-9d5a-4217-ba31-24567965bbc6', N'0988187295', 0, 0, CAST(N'3020-04-21T09:53:50.8381559+07:00' AS DateTimeOffset), 1, 0, N'ApplicationUser', N'chuminhhoang')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Name]) VALUES (N'3494eba0-016b-4c1e-b087-d09b3b13ff93', N'Quang@gmail.com', N'QUANG@GMAIL.COM', N'Quang@gmail.com', N'QUANG@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEKcMw6P0YKhT/dGQqMjquoQBbxTo0WEWA1qHfWaf+CDOpcD9/AmSNnp8PBy+600u3g==', N'H4QASDHKKX6SDRNY5DACUN3ZOKZWNJ6X', N'852b5630-0bed-4c70-b801-694f3bf354cf', N'123456798', 0, 0, CAST(N'3020-07-07T00:03:03.9594442+07:00' AS DateTimeOffset), 1, 0, N'ApplicationUser', N'quang')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Name]) VALUES (N'79fda6e8-a0f3-47ab-a04b-164e6bf5cde3', N'admin@gmail.com', N'ADMIN@GMAIL.COM', N'admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEHo91KKPskkXnWQgYQwJSMCkvRWiyRiKY3Fs8SVgXhXP3wdUMWAKAXfHyYQ/nHOFoQ==', N'RZM5WNSLVC5VSDG27C45B4FAYIA3DZH3', N'abd28585-903d-41cf-a347-af01144daa5e', N'2321536253', 0, 0, CAST(N'2020-05-16T12:40:48.2145319+00:00' AS DateTimeOffset), 1, 0, N'ApplicationUser', N'Admin User')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Name]) VALUES (N'84761f5d-3677-4d1e-ba22-1e65347e2c4b', N'anh123@gmail.com', N'ANH123@GMAIL.COM', N'anh123@gmail.com', N'ANH123@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEI666Nx6OzV0Iww+ITtbiS8CzlsMrYo5FeYFA/W8+lskHoC4yqjNSGlwz8tSfGR2xQ==', N'T2DOBDRCNQIMVBX3QJE7IKMPTNFJOJL7', N'8553a21c-2d30-4be7-b20a-b091ecd69b27', N'01341441', 0, 0, NULL, 1, 0, N'ApplicationUser', N'Anh')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Name]) VALUES (N'a0eed888-773b-4fb7-b622-1f77b81474e5', N'cuong@gmail.com', N'CUONG@GMAIL.COM', N'cuong@gmail.com', N'CUONG@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEP25AhrTZzD/5OzWj1xJfZypnfR37sLPJCXLNDz0DRN0yP3IChP+g3KaOzjkA0ULLA==', N'APETAXT43BVZD4VU3I2VP62G4W3JDMOW', N'beca303d-9e59-4209-b73a-ceb998068f81', N'123456789', 0, 0, CAST(N'3020-05-02T09:51:40.4755814+07:00' AS DateTimeOffset), 1, 3, N'ApplicationUser', N'cuong')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Name]) VALUES (N'a609cb86-45ec-45e4-b6eb-c5c77ddf5351', N'linh123@gmail.com', N'LINH123@GMAIL.COM', N'linh123@gmail.com', N'LINH123@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEIr8kjz3/XzC3jHhnQxu+7OtTK37oB6OrfuZCYiVwndaTsmOyzbVXlzRi3J3NrlC9A==', N'OTHVLZPKWQ3X6GK2O63IITQFNHIWWQEO', N'a0cf3725-9819-4e00-805e-6749bd20a756', N'01312414', 0, 0, NULL, 1, 0, N'ApplicationUser', N'Linh')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Name]) VALUES (N'aa2523e6-ea10-4b0c-89fc-5e97b5e41fe3', N'bi@gmail.com', N'BI@GMAIL.COM', N'bi@gmail.com', N'BI@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAENwkLjpThSHv2uQk1WVai6+xgbZXcYugq6kv9Gxe+QS2LZy2jwhpSFxRj1t2Vj66sA==', N'7QQPEZW4HOZRWUR7UFGXU7GN5M57ZSZE', N'cc411167-35ec-4394-8697-76adc43fafcb', N'0988187295', 0, 0, NULL, 1, 0, N'ApplicationUser', N'bi')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Name]) VALUES (N'cb31ebc5-15cc-4344-bd60-9dc7856d275b', N'khoi1999@gmail.com', N'KHOI1999@GMAIL.COM', N'khoi1999@gmail.com', N'KHOI1999@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEI2KvP+IXG1nHEGv0niQSjIeKn1PHmVeP2EmtycFxgZB+hDv3sswhBdjIJBfwRVKkg==', N'M2V47SVM3XG6V23EKVC76X5R5BMOHVL6', N'51f44826-520f-4a7a-a038-7279044b8456', N'0386599985', 0, 0, NULL, 1, 0, N'ApplicationUser', N'Khôi')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Name]) VALUES (N'cd47d9d7-d8ab-4906-b2b3-327197be04e4', N'Hoang@gmail.com', N'HOANG@GMAIL.COM', N'Hoang@gmail.com', N'HOANG@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEBUfbW31vOydPyy3m/ZhuVeZh/bG9E+VDJVffpLaGZgT92V46tuWgrbEBNCkffFPbA==', N'ID36TR7PPIVMH755VBSXPGWVR3XKIW7X', N'77ffe489-f00b-4718-b6d4-142a76bee7c3', N'0988187295', 0, 0, NULL, 1, 2, N'ApplicationUser', N'chu')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Name]) VALUES (N'd25cbd2f-38cd-4369-8fa7-9ad85b169d14', N'pin@gmail.com', N'PIN@GMAIL.COM', N'pin@gmail.com', N'PIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAENioKFhKYP/QCFo+WcTbAlQcxFUz6UnBk/N0gAL6AGQyQSTeHojNfwYkJDy7rJcCmQ==', N'DYTGYYIJ4ZHEZSI5FQN7HUXAQ6VQAJPI', N'6e4ea6c2-4426-4f75-b66f-2921f9acb793', N'0988187294', 0, 0, CAST(N'2020-07-07T11:13:54.1782183+00:00' AS DateTimeOffset), 1, 0, N'ApplicationUser', N'pin')
INSERT [dbo].[AspNetUserTokens] ([UserId], [LoginProvider], [Name], [Value]) VALUES (N'79fda6e8-a0f3-47ab-a04b-164e6bf5cde3', N'[AspNetUserStore]', N'AuthenticatorKey', N'BPXUIUWWINARCRXON7OJEHAEGMOAXCXA')
SET IDENTITY_INSERT [dbo].[Brands] ON 

INSERT [dbo].[Brands] ([ID], [Name]) VALUES (1, N'MSJ')
INSERT [dbo].[Brands] ([ID], [Name]) VALUES (2, N'TTS')
INSERT [dbo].[Brands] ([ID], [Name]) VALUES (3, N'MKLI')
SET IDENTITY_INSERT [dbo].[Brands] OFF
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6053, N'Just Order', N'Anh', N'07/31/1999', N'anh123@gmail.com', N'01232131')
INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6054, N'Just Order', N'Anh', N'07/31/1999', N'anh123@gmail.com', N'01232131')
INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6055, N'Just Order', N'Anh', N'07/31/1999', N'anh123@gmail.com', N'01232131')
INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6056, NULL, N'Anh', NULL, N'anh123@gmail.com', N'01232131')
INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6057, NULL, N'Anh', NULL, N'anh123@gmail.com', N'01232131')
INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6058, NULL, N'Anh', NULL, N'anh123@gmail.com', N'01232131')
INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6059, N'Just Order', N'chu', N'07/16/2020', N'chu@gmail.com', N'0988187295')
INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6060, N'Just Order', N'IPIN', N'05/16/2020', N'chu@2123gmail.com', N'091723')
INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6061, N'Just Order', N'pin', N'05/16/2020', N'chu@2123gmail.com', N'0982098334')
INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6062, NULL, N'chu', NULL, N'chu@gmail.com', N'0988187295')
INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6063, NULL, N'IPIN', NULL, N'chu@2123gmail.com', N'091723')
INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6064, NULL, N'Anh', NULL, N'anh123@gmail.com', N'01232131')
INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6065, N'Just Order', NULL, NULL, NULL, NULL)
INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6066, NULL, N'pin', NULL, N'chu@2123gmail.com', N'0982098334')
INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6067, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6068, N'Just Order', NULL, NULL, NULL, NULL)
INSERT [dbo].[Customers] ([ID], [Status], [CustomerName], [Date], [Email], [Phone]) VALUES (6069, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[ImportDetails] ON 

INSERT [dbo].[ImportDetails] ([ID], [DateImport], [ProductId], [AmountProduct]) VALUES (1, CAST(N'2019-12-31T00:00:00.0000000' AS DateTime2), 3, 0)
INSERT [dbo].[ImportDetails] ([ID], [DateImport], [ProductId], [AmountProduct]) VALUES (2, CAST(N'2019-12-31T00:00:00.0000000' AS DateTime2), 4, 0)
INSERT [dbo].[ImportDetails] ([ID], [DateImport], [ProductId], [AmountProduct]) VALUES (3, CAST(N'2019-12-30T00:00:00.0000000' AS DateTime2), 3, 0)
INSERT [dbo].[ImportDetails] ([ID], [DateImport], [ProductId], [AmountProduct]) VALUES (4, CAST(N'2020-05-07T00:00:00.0000000' AS DateTime2), 3, 0)
INSERT [dbo].[ImportDetails] ([ID], [DateImport], [ProductId], [AmountProduct]) VALUES (5, CAST(N'2020-05-07T00:00:00.0000000' AS DateTime2), 3, 0)
INSERT [dbo].[ImportDetails] ([ID], [DateImport], [ProductId], [AmountProduct]) VALUES (6, CAST(N'2020-05-27T00:00:00.0000000' AS DateTime2), 5, 0)
INSERT [dbo].[ImportDetails] ([ID], [DateImport], [ProductId], [AmountProduct]) VALUES (7, CAST(N'2020-05-21T00:00:00.0000000' AS DateTime2), 5, 0)
INSERT [dbo].[ImportDetails] ([ID], [DateImport], [ProductId], [AmountProduct]) VALUES (10, CAST(N'2020-05-17T00:00:00.0000000' AS DateTime2), 3, 0)
INSERT [dbo].[ImportDetails] ([ID], [DateImport], [ProductId], [AmountProduct]) VALUES (11, CAST(N'2020-05-18T00:00:00.0000000' AS DateTime2), 8, 0)
INSERT [dbo].[ImportDetails] ([ID], [DateImport], [ProductId], [AmountProduct]) VALUES (12, CAST(N'2020-05-27T00:00:00.0000000' AS DateTime2), 3, 70)
INSERT [dbo].[ImportDetails] ([ID], [DateImport], [ProductId], [AmountProduct]) VALUES (13, CAST(N'2020-05-27T00:00:00.0000000' AS DateTime2), 3, 10)
INSERT [dbo].[ImportDetails] ([ID], [DateImport], [ProductId], [AmountProduct]) VALUES (14, CAST(N'2020-05-17T00:00:00.0000000' AS DateTime2), 3, 0)
INSERT [dbo].[ImportDetails] ([ID], [DateImport], [ProductId], [AmountProduct]) VALUES (15, CAST(N'2020-05-17T00:00:00.0000000' AS DateTime2), 3, 0)
INSERT [dbo].[ImportDetails] ([ID], [DateImport], [ProductId], [AmountProduct]) VALUES (16, CAST(N'2020-05-17T00:00:00.0000000' AS DateTime2), 3, 2)
SET IDENTITY_INSERT [dbo].[ImportDetails] OFF
SET IDENTITY_INSERT [dbo].[Merchants] ON 

INSERT [dbo].[Merchants] ([ID], [Name_merchant], [Address], [Phone], [Description]) VALUES (1, N'ABCD', N'Number 111', N'021354896', N'Supply any sport shoes')
INSERT [dbo].[Merchants] ([ID], [Name_merchant], [Address], [Phone], [Description]) VALUES (2, N'ABC', N'Number 111', N'021354896', N'Supply any sport shoes for athaelic')
SET IDENTITY_INSERT [dbo].[Merchants] OFF
SET IDENTITY_INSERT [dbo].[OrderItems] ON 

INSERT [dbo].[OrderItems] ([ID], [OrderID], [Amount], [ProductID], [tongtien]) VALUES (5035, 6040, 1, 4, 90)
INSERT [dbo].[OrderItems] ([ID], [OrderID], [Amount], [ProductID], [tongtien]) VALUES (5036, 6041, 1, 5, 123)
INSERT [dbo].[OrderItems] ([ID], [OrderID], [Amount], [ProductID], [tongtien]) VALUES (5037, 6041, 1, 3, 99)
INSERT [dbo].[OrderItems] ([ID], [OrderID], [Amount], [ProductID], [tongtien]) VALUES (5038, 6042, 1, 4, 90)
INSERT [dbo].[OrderItems] ([ID], [OrderID], [Amount], [ProductID], [tongtien]) VALUES (5039, 6043, 5, 3, 495)
INSERT [dbo].[OrderItems] ([ID], [OrderID], [Amount], [ProductID], [tongtien]) VALUES (5040, 6044, 1, 4, 90)
INSERT [dbo].[OrderItems] ([ID], [OrderID], [Amount], [ProductID], [tongtien]) VALUES (5041, 6045, 1, 4, 90)
INSERT [dbo].[OrderItems] ([ID], [OrderID], [Amount], [ProductID], [tongtien]) VALUES (5042, 6046, 1, 3, 99)
SET IDENTITY_INSERT [dbo].[OrderItems] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([ID], [Date], [isConfirmed], [CustomerID], [SalesPersonId], [Address], [CustomerPersonId]) VALUES (6040, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 6064, N'2cd05bc7-d5dd-4d61-8e45-6e45d3eae01b', N'Thủ Đức', N'84761f5d-3677-4d1e-ba22-1e65347e2c4b')
INSERT [dbo].[Orders] ([ID], [Date], [isConfirmed], [CustomerID], [SalesPersonId], [Address], [CustomerPersonId]) VALUES (6041, CAST(N'2001-01-01T00:00:00.0000000' AS DateTime2), 1, 6058, N'3494eba0-016b-4c1e-b087-d09b3b13ff93', N'Thủ Đức', N'84761f5d-3677-4d1e-ba22-1e65347e2c4b')
INSERT [dbo].[Orders] ([ID], [Date], [isConfirmed], [CustomerID], [SalesPersonId], [Address], [CustomerPersonId]) VALUES (6042, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 6062, N'2cd05bc7-d5dd-4d61-8e45-6e45d3eae01b', N'khu 5', NULL)
INSERT [dbo].[Orders] ([ID], [Date], [isConfirmed], [CustomerID], [SalesPersonId], [Address], [CustomerPersonId]) VALUES (6043, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 6063, N'2cd05bc7-d5dd-4d61-8e45-6e45d3eae01b', N'khu 5', NULL)
INSERT [dbo].[Orders] ([ID], [Date], [isConfirmed], [CustomerID], [SalesPersonId], [Address], [CustomerPersonId]) VALUES (6044, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 6066, N'3494eba0-016b-4c1e-b087-d09b3b13ff93', N'khu 5', N'0c89e72d-76b4-44b4-9cea-5e4b3be0d326')
INSERT [dbo].[Orders] ([ID], [Date], [isConfirmed], [CustomerID], [SalesPersonId], [Address], [CustomerPersonId]) VALUES (6045, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 6067, N'2cd05bc7-d5dd-4d61-8e45-6e45d3eae01b', NULL, N'0c89e72d-76b4-44b4-9cea-5e4b3be0d326')
INSERT [dbo].[Orders] ([ID], [Date], [isConfirmed], [CustomerID], [SalesPersonId], [Address], [CustomerPersonId]) VALUES (6046, CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), 1, 6069, N'79fda6e8-a0f3-47ab-a04b-164e6bf5cde3', NULL, N'0c89e72d-76b4-44b4-9cea-5e4b3be0d326')
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ID], [Name], [Price], [Available], [Image], [Description], [InStock], [MerchantId], [BrandId], [TypeProductId]) VALUES (3, N'Shoes CV', 99, 1, N'\images\ProductImage\3.png', N'Kiểu dáng cổ thấp, chất liệu vải dù siêu bền với thiết kế các lỗ nhỏ giúp không khi bên trong giày lưu thông, tránh bị hôi chân. Các bạn có thể giặt giũ thoải mái mà ko lo hư hại nhưng lưu ý phơi giày trong bóng râm để giày ko bị bay màu nhé. Giày gồm có 3 màu: hồng, đen, trắng cơ bản dễ phối đồ lắm nhé! ', 54, 1, 1, 2)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Available], [Image], [Description], [InStock], [MerchantId], [BrandId], [TypeProductId]) VALUES (4, N'Giay Cao Cot', 90, 1, N'\images\ProductImage\4.png', N'Kiểu dáng cổ thấp, chất liệu vải dù siêu bền với thiết kế các lỗ nhỏ giúp không khi bên trong giày lưu thông, tránh bị hôi chân. Các bạn có thể giặt giũ thoải mái mà ko lo hư hại nhưng lưu ý phơi giày trong bóng râm để giày ko bị bay màu nhé. Giày gồm có 3 màu: hồng, đen, trắng cơ bản dễ phối đồ lắm nhé! ', 75, 1, 2, 2)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Available], [Image], [Description], [InStock], [MerchantId], [BrandId], [TypeProductId]) VALUES (5, N'show', 123, 1, N'\images\ProductImage\5.png', N'Kiểu dáng cổ thấp, chất liệu vải dù siêu bền với thiết kế các lỗ nhỏ giúp không khi bên trong giày lưu thông, tránh bị hôi chân. Các bạn có thể giặt giũ thoải mái mà ko lo hư hại nhưng lưu ý phơi giày trong bóng râm để giày ko bị bay màu nhé. Giày gồm có 3 màu: hồng, đen, trắng cơ bản dễ phối đồ lắm nhé! ', 23, 1, 2, 1)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Available], [Image], [Description], [InStock], [MerchantId], [BrandId], [TypeProductId]) VALUES (8, N'ads', 23, 1, N'\images\ProductImage\8.png', N'Kiểu dáng cổ thấp, chất liệu vải dù siêu bền với thiết kế các lỗ nhỏ giúp không khi bên trong giày lưu thông, tránh bị hôi chân. Các bạn có thể giặt giũ thoải mái mà ko lo hư hại nhưng lưu ý phơi giày trong bóng râm để giày ko bị bay màu nhé. Giày gồm có 3 màu: hồng, đen, trắng cơ bản dễ phối đồ lắm nhé! ', 6, 1, 1, 4)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Available], [Image], [Description], [InStock], [MerchantId], [BrandId], [TypeProductId]) VALUES (11, N'Shoes base', 169, 1, N'\images\ProductImage\11.png', N'New Product Make Style New Product Make Style New Product Make Style New Product Make Style New Product Make Style New Product Make Style New Product Make Style', 69, 2, 3, 4)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Available], [Image], [Description], [InStock], [MerchantId], [BrandId], [TypeProductId]) VALUES (12, N'addidas Nike', 56, 1, N'\images\ProductImage\12.png', N'New Product Make Style New Product Make Style New Product Make Style New Product Make StyleNew Product Make StyleNew Product Make StyleNew Product Make Style New Product Make Style', 100, 1, 3, 3)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Available], [Image], [Description], [InStock], [MerchantId], [BrandId], [TypeProductId]) VALUES (13, N'Jodan Vius', 95, 1, N'\images\ProductImage\13.png', N'New Product Make Style New Product Make Style New Product Make Style New Product Make StyleNew Product Make StyleNew Product Make StyleNew Product Make StyleNew Product Make StyleNew Product Make Style ', 100, 2, 2, 1)
INSERT [dbo].[Products] ([ID], [Name], [Price], [Available], [Image], [Description], [InStock], [MerchantId], [BrandId], [TypeProductId]) VALUES (14, N'Jodan v4', 36, 1, N'\images\ProductImage\14.jpg', N'Style Product Var Style Product Var Style Product Var Style Product Var Style Product Var Style Product VarStyle Product Var Style Product Var Style Product Var ', 100, 1, 1, 3)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[TypeProducts] ON 

INSERT [dbo].[TypeProducts] ([ID], [TypePro]) VALUES (1, N'POPULAR')
INSERT [dbo].[TypeProducts] ([ID], [TypePro]) VALUES (2, N'PRO')
INSERT [dbo].[TypeProducts] ([ID], [TypePro]) VALUES (3, N'SELLEST')
INSERT [dbo].[TypeProducts] ([ID], [TypePro]) VALUES (4, N'BAD')
SET IDENTITY_INSERT [dbo].[TypeProducts] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 7/9/2020 2:35:44 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 7/9/2020 2:35:44 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 7/9/2020 2:35:44 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 7/9/2020 2:35:44 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 7/9/2020 2:35:44 AM ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 7/9/2020 2:35:44 AM ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 7/9/2020 2:35:44 AM ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_ImportDetails_ProductId]    Script Date: 7/9/2020 2:35:44 AM ******/
CREATE NONCLUSTERED INDEX [IX_ImportDetails_ProductId] ON [dbo].[ImportDetails]
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderItems_OrderID]    Script Date: 7/9/2020 2:35:44 AM ******/
CREATE NONCLUSTERED INDEX [IX_OrderItems_OrderID] ON [dbo].[OrderItems]
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderItems_ProductID]    Script Date: 7/9/2020 2:35:44 AM ******/
CREATE NONCLUSTERED INDEX [IX_OrderItems_ProductID] ON [dbo].[OrderItems]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_CustomerID]    Script Date: 7/9/2020 2:35:44 AM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_CustomerID] ON [dbo].[Orders]
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Orders_CustomerPersonId]    Script Date: 7/9/2020 2:35:44 AM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_CustomerPersonId] ON [dbo].[Orders]
(
	[CustomerPersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Orders_SalesPersonId]    Script Date: 7/9/2020 2:35:44 AM ******/
CREATE NONCLUSTERED INDEX [IX_Orders_SalesPersonId] ON [dbo].[Orders]
(
	[SalesPersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_BrandId]    Script Date: 7/9/2020 2:35:44 AM ******/
CREATE NONCLUSTERED INDEX [IX_Products_BrandId] ON [dbo].[Products]
(
	[BrandId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_MerchantId]    Script Date: 7/9/2020 2:35:44 AM ******/
CREATE NONCLUSTERED INDEX [IX_Products_MerchantId] ON [dbo].[Products]
(
	[MerchantId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_TypeProductId]    Script Date: 7/9/2020 2:35:44 AM ******/
CREATE NONCLUSTERED INDEX [IX_Products_TypeProductId] ON [dbo].[Products]
(
	[TypeProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUsers] ADD  DEFAULT (N'') FOR [Discriminator]
GO
ALTER TABLE [dbo].[ImportDetails] ADD  DEFAULT ((0)) FOR [ProductId]
GO
ALTER TABLE [dbo].[ImportDetails] ADD  DEFAULT ((0)) FOR [AmountProduct]
GO
ALTER TABLE [dbo].[OrderItems] ADD  DEFAULT ((0.0000000000000000e+000)) FOR [tongtien]
GO
ALTER TABLE [dbo].[Products] ADD  DEFAULT ((0)) FOR [BrandId]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ImportDetails]  WITH CHECK ADD  CONSTRAINT [FK_ImportDetails_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ImportDetails] CHECK CONSTRAINT [FK_ImportDetails_Products_ProductId]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Orders_OrderID] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Orders_OrderID]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD  CONSTRAINT [FK_OrderItems_Products_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderItems] CHECK CONSTRAINT [FK_OrderItems_Products_ProductID]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_AspNetUsers_CustomerPersonId] FOREIGN KEY([CustomerPersonId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_AspNetUsers_CustomerPersonId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_AspNetUsers_SalesPersonId] FOREIGN KEY([SalesPersonId])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_AspNetUsers_SalesPersonId]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers_CustomerID] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers_CustomerID]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Brands_BrandId] FOREIGN KEY([BrandId])
REFERENCES [dbo].[Brands] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Brands_BrandId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Merchants_MerchantId] FOREIGN KEY([MerchantId])
REFERENCES [dbo].[Merchants] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Merchants_MerchantId]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_TypeProducts_TypeProductId] FOREIGN KEY([TypeProductId])
REFERENCES [dbo].[TypeProducts] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_TypeProducts_TypeProductId]
GO
USE [master]
GO
ALTER DATABASE [QuanLyBanGiayASP] SET  READ_WRITE 
GO
