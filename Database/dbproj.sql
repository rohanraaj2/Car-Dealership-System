USE [master]
GO
/****** Object:  Database [dbproj]    Script Date: 04/12/2022 4:15:11 pm ******/
CREATE DATABASE [dbproj]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dbproj', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SPARTA\MSSQL\DATA\dbproj.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dbproj_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SPARTA\MSSQL\DATA\dbproj_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dbproj] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dbproj].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dbproj] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dbproj] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dbproj] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dbproj] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dbproj] SET ARITHABORT OFF 
GO
ALTER DATABASE [dbproj] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dbproj] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dbproj] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dbproj] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dbproj] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dbproj] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dbproj] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dbproj] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dbproj] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dbproj] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dbproj] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dbproj] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dbproj] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dbproj] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dbproj] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dbproj] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dbproj] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dbproj] SET RECOVERY FULL 
GO
ALTER DATABASE [dbproj] SET  MULTI_USER 
GO
ALTER DATABASE [dbproj] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dbproj] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dbproj] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dbproj] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dbproj] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dbproj] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dbproj', N'ON'
GO
ALTER DATABASE [dbproj] SET QUERY_STORE = OFF
GO
USE [dbproj]
GO
/****** Object:  Table [dbo].[BookingDetails]    Script Date: 04/12/2022 4:15:12 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingDetails](
	[booking_id] [int] NOT NULL,
	[car_id] [int] NOT NULL,
	[salesperson_id] [int] NOT NULL,
	[customer_id] [int] NOT NULL,
	[booking_date] [date] NOT NULL,
	[delivery_date] [date] NOT NULL,
 CONSTRAINT [PK_BOOKINGDETAILS] PRIMARY KEY CLUSTERED 
(
	[booking_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookingTranscaction]    Script Date: 04/12/2022 4:15:12 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookingTranscaction](
	[transaction_id] [int] NOT NULL,
	[booking_id] [int] NOT NULL,
	[payment_date] [date] NOT NULL,
	[amount] [varchar](255) NULL,
 CONSTRAINT [PK_BOOKINGTRANSCACTION] PRIMARY KEY CLUSTERED 
(
	[transaction_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CarDetails]    Script Date: 04/12/2022 4:15:12 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CarDetails](
	[car_id] [int] NOT NULL,
	[name] [varchar](255) NOT NULL,
	[model] [varchar](255) NOT NULL,
	[price] [varchar](255) NULL,
 CONSTRAINT [PK_CARDETAILS] PRIMARY KEY CLUSTERED 
(
	[car_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CustomerDetails]    Script Date: 04/12/2022 4:15:12 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerDetails](
	[customer_id] [int] NOT NULL,
	[first_name] [varchar](255) NOT NULL,
	[last_name] [varchar](255) NOT NULL,
	[phone_number] [int] NOT NULL,
	[address] [varchar](255) NOT NULL,
 CONSTRAINT [PK_CUSTOMERDETAILS] PRIMARY KEY CLUSTERED 
(
	[customer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeDetails]    Script Date: 04/12/2022 4:15:12 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeDetails](
	[salesperson_id] [int] NOT NULL,
	[first_name] [varchar](255) NOT NULL,
	[last_name] [varchar](255) NOT NULL,
 CONSTRAINT [PK_EMPLOYEEDETAILS] PRIMARY KEY CLUSTERED 
(
	[salesperson_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 04/12/2022 4:15:12 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[service_id] [int] NOT NULL,
	[service_name] [varchar](255) NOT NULL,
	[charges] [float] NOT NULL,
 CONSTRAINT [PK_SERVICE] PRIMARY KEY CLUSTERED 
(
	[service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceInvoice]    Script Date: 04/12/2022 4:15:12 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceInvoice](
	[invoice_id] [int] NOT NULL,
	[service_ticket_id] [int] NOT NULL,
	[amount_paid] [int] NOT NULL,
	[payment_date] [date] NULL,
 CONSTRAINT [PK_SERVICEINVOICE] PRIMARY KEY CLUSTERED 
(
	[invoice_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceTicket]    Script Date: 04/12/2022 4:15:12 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceTicket](
	[service_ticket_id] [int] NOT NULL,
	[customer_id] [int] NOT NULL,
	[service_id] [int] NOT NULL,
	[date_recieved] [date] NOT NULL,
	[date_returned] [date] NOT NULL,
	[vehicle_number] [varchar](255) NULL,
	[Instructions] [varchar](255) NULL,
 CONSTRAINT [PK_SERVICETICKET] PRIMARY KEY CLUSTERED 
(
	[service_ticket_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SparePartsDetails]    Script Date: 04/12/2022 4:15:12 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SparePartsDetails](
	[part_id] [int] NOT NULL,
	[part_type] [varchar](255) NULL,
	[part_price] [int] NULL,
	[supplier_id] [int] NULL,
	[part_stock_level] [int] NULL,
 CONSTRAINT [PK_SPAREPARTSDETAILS] PRIMARY KEY CLUSTERED 
(
	[part_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SupplierDetails]    Script Date: 04/12/2022 4:15:12 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SupplierDetails](
	[supplier_id] [int] NOT NULL,
	[supplier_name] [varchar](255) NOT NULL,
 CONSTRAINT [PK_SUPPLIERDETAILS] PRIMARY KEY CLUSTERED 
(
	[supplier_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (1, 1, 1, 3, CAST(N'2022-01-05' AS Date), CAST(N'2022-04-05' AS Date))
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (2, 1, 3, 1, CAST(N'2022-03-06' AS Date), CAST(N'2022-06-06' AS Date))
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (3, 4, 1, 1, CAST(N'2022-09-22' AS Date), CAST(N'2022-12-22' AS Date))
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (4, 2, 2, 2, CAST(N'2022-11-18' AS Date), CAST(N'2023-02-18' AS Date))
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (5, 2, 1, 1, CAST(N'2021-08-07' AS Date), CAST(N'2021-11-07' AS Date))
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (6, 3, 5, 2, CAST(N'2020-02-24' AS Date), CAST(N'2020-05-24' AS Date))
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (7, 6, 2, 3, CAST(N'2022-05-17' AS Date), CAST(N'2022-08-17' AS Date))
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (8, 7, 5, 3, CAST(N'2022-07-07' AS Date), CAST(N'2022-10-07' AS Date))
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (9, 2, 2, 4, CAST(N'2022-12-01' AS Date), CAST(N'2023-02-25' AS Date))
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (10, 5, 2, 5, CAST(N'2022-12-01' AS Date), CAST(N'2023-02-25' AS Date))
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (11, 4, 2, 5, CAST(N'2022-12-02' AS Date), CAST(N'2023-02-25' AS Date))
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (12, 7, 2, 4, CAST(N'2022-12-02' AS Date), CAST(N'2023-02-25' AS Date))
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (13, 5, 2, 3, CAST(N'2022-12-02' AS Date), CAST(N'2023-02-25' AS Date))
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (14, 1, 2, 2, CAST(N'2022-12-02' AS Date), CAST(N'2023-02-25' AS Date))
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (15, 5, 2, 4, CAST(N'2022-12-02' AS Date), CAST(N'2023-02-25' AS Date))
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (16, 1, 2, 5, CAST(N'2022-12-02' AS Date), CAST(N'2023-02-25' AS Date))
INSERT [dbo].[BookingDetails] ([booking_id], [car_id], [salesperson_id], [customer_id], [booking_date], [delivery_date]) VALUES (17, 6, 2, 4, CAST(N'2022-12-02' AS Date), CAST(N'2023-02-25' AS Date))
GO
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (1, 1, CAST(N'2022-05-30' AS Date), N'3,899,000')
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (2, 2, CAST(N'2021-12-06' AS Date), N'3,899,000')
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (3, 3, CAST(N'2022-09-04' AS Date), N'6,349,000')
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (4, 4, CAST(N'2021-12-18' AS Date), N'4,139,000')
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (5, 5, CAST(N'2022-05-23' AS Date), N'4,139,000')
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (6, 6, CAST(N'2022-05-20' AS Date), N'4,479,000')
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (7, 7, CAST(N'2022-07-21' AS Date), N'7,549,000')
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (8, 8, CAST(N'2022-07-12' AS Date), N'4,939,000')
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (9, 9, CAST(N'2022-12-01' AS Date), N'4,139,000')
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (10, 10, CAST(N'2022-12-01' AS Date), N'6,599,000')
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (11, 11, CAST(N'2022-12-02' AS Date), N'6,349,000')
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (12, 12, CAST(N'2022-12-02' AS Date), N'4,939,000')
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (13, 13, CAST(N'2022-12-02' AS Date), N'4,139,000')
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (14, 14, CAST(N'2022-12-02' AS Date), N'3,899,000')
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (15, 15, CAST(N'2022-12-02' AS Date), N'6,599,000')
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (16, 16, CAST(N'2022-12-02' AS Date), N'3,899,000')
INSERT [dbo].[BookingTranscaction] ([transaction_id], [booking_id], [payment_date], [amount]) VALUES (17, 17, CAST(N'2022-12-02' AS Date), N'4,479,000')
GO
INSERT [dbo].[CarDetails] ([car_id], [name], [model], [price]) VALUES (1, N'City', N'City 1.2LS', N'3,899,000')
INSERT [dbo].[CarDetails] ([car_id], [name], [model], [price]) VALUES (2, N'City', N'City 1.5LS', N'4,139,000')
INSERT [dbo].[CarDetails] ([car_id], [name], [model], [price]) VALUES (3, N'City', N'Aspire 1.5LAS', N'4,479,000')
INSERT [dbo].[CarDetails] ([car_id], [name], [model], [price]) VALUES (4, N'Civic', N'Civic Standard', N'6,349,000')
INSERT [dbo].[CarDetails] ([car_id], [name], [model], [price]) VALUES (5, N'Civic', N'Civic Oriel', N'6,599,000')
INSERT [dbo].[CarDetails] ([car_id], [name], [model], [price]) VALUES (6, N'Civic', N'Civic RS', N'7,549,000')
INSERT [dbo].[CarDetails] ([car_id], [name], [model], [price]) VALUES (7, N'BRV', N'BR-V CVT S 1.5 L', N'4,939,000')
GO
INSERT [dbo].[CustomerDetails] ([customer_id], [first_name], [last_name], [phone_number], [address]) VALUES (1, N'Hunain', N'Ahmed', 6754, N'Gulshan e Iqbal, Block 11')
INSERT [dbo].[CustomerDetails] ([customer_id], [first_name], [last_name], [phone_number], [address]) VALUES (2, N'Ahmed', N'Shoaib', 1123, N'Gulistan e Jauhar, Block 6')
INSERT [dbo].[CustomerDetails] ([customer_id], [first_name], [last_name], [phone_number], [address]) VALUES (3, N'Asad ', N'Muhammad ', 1146, N'Gulshan e Iqbal, Block 10')
INSERT [dbo].[CustomerDetails] ([customer_id], [first_name], [last_name], [phone_number], [address]) VALUES (4, N'Nisar ', N'Syed', 1187, N'North Nazimabad ')
INSERT [dbo].[CustomerDetails] ([customer_id], [first_name], [last_name], [phone_number], [address]) VALUES (5, N'Huzaifa ', N'Naveed ', 1196, N'Malir Cantt, Askari 5')
INSERT [dbo].[CustomerDetails] ([customer_id], [first_name], [last_name], [phone_number], [address]) VALUES (6, N'Ali', N'Naveed', 6786, N'Clifton')
INSERT [dbo].[CustomerDetails] ([customer_id], [first_name], [last_name], [phone_number], [address]) VALUES (7, N'Ahmed', N'Naveed', 6756, N'Korangi')
INSERT [dbo].[CustomerDetails] ([customer_id], [first_name], [last_name], [phone_number], [address]) VALUES (8, N'Areeb', N'Ahmed', 5687, N'Gulshan')
INSERT [dbo].[CustomerDetails] ([customer_id], [first_name], [last_name], [phone_number], [address]) VALUES (9, N'Ahmed', N'Areeb', 7654, N'Lahore')
INSERT [dbo].[CustomerDetails] ([customer_id], [first_name], [last_name], [phone_number], [address]) VALUES (10, N'Muhammad', N'Ali', 7765, N'Gulshan')
INSERT [dbo].[CustomerDetails] ([customer_id], [first_name], [last_name], [phone_number], [address]) VALUES (11, N'Joe', N'Biden', 1234, N'United States')
GO
INSERT [dbo].[EmployeeDetails] ([salesperson_id], [first_name], [last_name]) VALUES (1, N'Rohan', N'Raj')
INSERT [dbo].[EmployeeDetails] ([salesperson_id], [first_name], [last_name]) VALUES (2, N'Ahmed', N'Anwar')
INSERT [dbo].[EmployeeDetails] ([salesperson_id], [first_name], [last_name]) VALUES (3, N'Fahad', N'Shaikh')
INSERT [dbo].[EmployeeDetails] ([salesperson_id], [first_name], [last_name]) VALUES (4, N'Neil', N'Lakhani')
INSERT [dbo].[EmployeeDetails] ([salesperson_id], [first_name], [last_name]) VALUES (5, N'Areeb', N'Khalil')
INSERT [dbo].[EmployeeDetails] ([salesperson_id], [first_name], [last_name]) VALUES (6, N'Huzaifa', N'Tariq')
GO
INSERT [dbo].[Service] ([service_id], [service_name], [charges]) VALUES (1, N'Check the engine oil', 500)
INSERT [dbo].[Service] ([service_id], [service_name], [charges]) VALUES (2, N'Oil filter replacement', 1000)
INSERT [dbo].[Service] ([service_id], [service_name], [charges]) VALUES (3, N'Fuel filter replacement', 1500)
INSERT [dbo].[Service] ([service_id], [service_name], [charges]) VALUES (4, N'Change engine oil', 5000)
INSERT [dbo].[Service] ([service_id], [service_name], [charges]) VALUES (5, N'Air filter replacement', 1000)
INSERT [dbo].[Service] ([service_id], [service_name], [charges]) VALUES (6, N'Check brake fluid level', 800)
INSERT [dbo].[Service] ([service_id], [service_name], [charges]) VALUES (7, N'Check battery', 500)
INSERT [dbo].[Service] ([service_id], [service_name], [charges]) VALUES (8, N'Check tire conditions ', 200)
INSERT [dbo].[Service] ([service_id], [service_name], [charges]) VALUES (9, N'Check clutch fluid', 500)
GO
INSERT [dbo].[ServiceInvoice] ([invoice_id], [service_ticket_id], [amount_paid], [payment_date]) VALUES (1, 1, 1000, CAST(N'2022-03-12' AS Date))
INSERT [dbo].[ServiceInvoice] ([invoice_id], [service_ticket_id], [amount_paid], [payment_date]) VALUES (2, 2, 5000, CAST(N'2022-12-04' AS Date))
INSERT [dbo].[ServiceInvoice] ([invoice_id], [service_ticket_id], [amount_paid], [payment_date]) VALUES (3, 3, 1000, CAST(N'2022-04-03' AS Date))
INSERT [dbo].[ServiceInvoice] ([invoice_id], [service_ticket_id], [amount_paid], [payment_date]) VALUES (4, 4, 500, CAST(N'2022-03-02' AS Date))
INSERT [dbo].[ServiceInvoice] ([invoice_id], [service_ticket_id], [amount_paid], [payment_date]) VALUES (5, 5, 2000, CAST(N'2022-04-03' AS Date))
INSERT [dbo].[ServiceInvoice] ([invoice_id], [service_ticket_id], [amount_paid], [payment_date]) VALUES (6, 6, 1500, CAST(N'2022-10-09' AS Date))
INSERT [dbo].[ServiceInvoice] ([invoice_id], [service_ticket_id], [amount_paid], [payment_date]) VALUES (7, 7, 2000, CAST(N'2022-06-05' AS Date))
INSERT [dbo].[ServiceInvoice] ([invoice_id], [service_ticket_id], [amount_paid], [payment_date]) VALUES (8, 8, 3000, CAST(N'2022-08-08' AS Date))
INSERT [dbo].[ServiceInvoice] ([invoice_id], [service_ticket_id], [amount_paid], [payment_date]) VALUES (9, 9, 1500, CAST(N'2022-05-05' AS Date))
INSERT [dbo].[ServiceInvoice] ([invoice_id], [service_ticket_id], [amount_paid], [payment_date]) VALUES (10, 10, 800, CAST(N'2022-03-02' AS Date))
INSERT [dbo].[ServiceInvoice] ([invoice_id], [service_ticket_id], [amount_paid], [payment_date]) VALUES (11, 11, 5000, CAST(N'2022-03-04' AS Date))
INSERT [dbo].[ServiceInvoice] ([invoice_id], [service_ticket_id], [amount_paid], [payment_date]) VALUES (12, 12, 500, CAST(N'2022-12-02' AS Date))
GO
INSERT [dbo].[ServiceTicket] ([service_ticket_id], [customer_id], [service_id], [date_recieved], [date_returned], [vehicle_number], [Instructions]) VALUES (1, 2, 5, CAST(N'2022-07-07' AS Date), CAST(N'2022-07-14' AS Date), N'AVZ-111', N'none')
INSERT [dbo].[ServiceTicket] ([service_ticket_id], [customer_id], [service_id], [date_recieved], [date_returned], [vehicle_number], [Instructions]) VALUES (2, 1, 3, CAST(N'2022-09-13' AS Date), CAST(N'2022-10-18' AS Date), N'AXF-787', N'none')
INSERT [dbo].[ServiceTicket] ([service_ticket_id], [customer_id], [service_id], [date_recieved], [date_returned], [vehicle_number], [Instructions]) VALUES (3, 2, 1, CAST(N'2022-07-04' AS Date), CAST(N'2022-08-31' AS Date), N'AHU-999', N'none')
INSERT [dbo].[ServiceTicket] ([service_ticket_id], [customer_id], [service_id], [date_recieved], [date_returned], [vehicle_number], [Instructions]) VALUES (4, 2, 2, CAST(N'2022-01-29' AS Date), CAST(N'2022-03-08' AS Date), N'ACD-890', N'none')
INSERT [dbo].[ServiceTicket] ([service_ticket_id], [customer_id], [service_id], [date_recieved], [date_returned], [vehicle_number], [Instructions]) VALUES (5, 3, 1, CAST(N'2022-06-02' AS Date), CAST(N'2022-08-27' AS Date), N'AMN-567', N'none')
INSERT [dbo].[ServiceTicket] ([service_ticket_id], [customer_id], [service_id], [date_recieved], [date_returned], [vehicle_number], [Instructions]) VALUES (6, 3, 4, CAST(N'2022-05-04' AS Date), CAST(N'2022-07-29' AS Date), N'ALO-543', N'none')
INSERT [dbo].[ServiceTicket] ([service_ticket_id], [customer_id], [service_id], [date_recieved], [date_returned], [vehicle_number], [Instructions]) VALUES (7, 3, 3, CAST(N'2022-10-06' AS Date), CAST(N'2022-11-28' AS Date), N'ARR-878', N'none')
INSERT [dbo].[ServiceTicket] ([service_ticket_id], [customer_id], [service_id], [date_recieved], [date_returned], [vehicle_number], [Instructions]) VALUES (8, 3, 2, CAST(N'2022-09-10' AS Date), CAST(N'2022-10-03' AS Date), N'APL-675', N'none')
INSERT [dbo].[ServiceTicket] ([service_ticket_id], [customer_id], [service_id], [date_recieved], [date_returned], [vehicle_number], [Instructions]) VALUES (9, 2, 3, CAST(N'2022-10-10' AS Date), CAST(N'2022-10-27' AS Date), N'ACK-990', N'none')
INSERT [dbo].[ServiceTicket] ([service_ticket_id], [customer_id], [service_id], [date_recieved], [date_returned], [vehicle_number], [Instructions]) VALUES (10, 1, 3, CAST(N'2022-11-27' AS Date), CAST(N'2022-12-06' AS Date), N'ANO-887', N'none')
INSERT [dbo].[ServiceTicket] ([service_ticket_id], [customer_id], [service_id], [date_recieved], [date_returned], [vehicle_number], [Instructions]) VALUES (11, 1, 3, CAST(N'2022-12-01' AS Date), CAST(N'2022-12-03' AS Date), N'ABC-224', N'none')
INSERT [dbo].[ServiceTicket] ([service_ticket_id], [customer_id], [service_id], [date_recieved], [date_returned], [vehicle_number], [Instructions]) VALUES (12, 1, 1, CAST(N'2022-12-02' AS Date), CAST(N'2022-12-03' AS Date), N'ABC 123', N'none')
GO
INSERT [dbo].[SparePartsDetails] ([part_id], [part_type], [part_price], [supplier_id], [part_stock_level]) VALUES (1, N'Battery', 50000, 3, 20)
INSERT [dbo].[SparePartsDetails] ([part_id], [part_type], [part_price], [supplier_id], [part_stock_level]) VALUES (2, N'Radiator', 40000, 2, 25)
INSERT [dbo].[SparePartsDetails] ([part_id], [part_type], [part_price], [supplier_id], [part_stock_level]) VALUES (3, N'Side Mirror', 10000, 1, 80)
INSERT [dbo].[SparePartsDetails] ([part_id], [part_type], [part_price], [supplier_id], [part_stock_level]) VALUES (4, N'Brakes', 15000, 1, 65)
INSERT [dbo].[SparePartsDetails] ([part_id], [part_type], [part_price], [supplier_id], [part_stock_level]) VALUES (5, N'Transmission', 60000, 4, 45)
INSERT [dbo].[SparePartsDetails] ([part_id], [part_type], [part_price], [supplier_id], [part_stock_level]) VALUES (6, N'Alternator ', 50000, 2, 76)
INSERT [dbo].[SparePartsDetails] ([part_id], [part_type], [part_price], [supplier_id], [part_stock_level]) VALUES (7, N'Air Filter', 1500, 1, 54)
GO
INSERT [dbo].[SupplierDetails] ([supplier_id], [supplier_name]) VALUES (1, N'Jan Motors')
INSERT [dbo].[SupplierDetails] ([supplier_id], [supplier_name]) VALUES (2, N'Car Parts PK')
INSERT [dbo].[SupplierDetails] ([supplier_id], [supplier_name]) VALUES (3, N'Habib Auto Parts')
INSERT [dbo].[SupplierDetails] ([supplier_id], [supplier_name]) VALUES (4, N'Farhan Autos')
INSERT [dbo].[SupplierDetails] ([supplier_id], [supplier_name]) VALUES (6, N'Ali Parts')
INSERT [dbo].[SupplierDetails] ([supplier_id], [supplier_name]) VALUES (7, N'Ahmed Motors')
INSERT [dbo].[SupplierDetails] ([supplier_id], [supplier_name]) VALUES (8, N'Ali Motors')
INSERT [dbo].[SupplierDetails] ([supplier_id], [supplier_name]) VALUES (9, N'ABC Motors')
GO
ALTER TABLE [dbo].[BookingDetails]  WITH CHECK ADD  CONSTRAINT [BookingDetails_fk0] FOREIGN KEY([car_id])
REFERENCES [dbo].[CarDetails] ([car_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[BookingDetails] CHECK CONSTRAINT [BookingDetails_fk0]
GO
ALTER TABLE [dbo].[BookingDetails]  WITH CHECK ADD  CONSTRAINT [BookingDetails_fk1] FOREIGN KEY([salesperson_id])
REFERENCES [dbo].[EmployeeDetails] ([salesperson_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[BookingDetails] CHECK CONSTRAINT [BookingDetails_fk1]
GO
ALTER TABLE [dbo].[BookingDetails]  WITH CHECK ADD  CONSTRAINT [BookingDetails_fk2] FOREIGN KEY([customer_id])
REFERENCES [dbo].[CustomerDetails] ([customer_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[BookingDetails] CHECK CONSTRAINT [BookingDetails_fk2]
GO
ALTER TABLE [dbo].[BookingTranscaction]  WITH CHECK ADD  CONSTRAINT [BookingTranscaction_fk0] FOREIGN KEY([booking_id])
REFERENCES [dbo].[BookingDetails] ([booking_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[BookingTranscaction] CHECK CONSTRAINT [BookingTranscaction_fk0]
GO
ALTER TABLE [dbo].[ServiceInvoice]  WITH CHECK ADD  CONSTRAINT [ServiceInvoice_fk0] FOREIGN KEY([service_ticket_id])
REFERENCES [dbo].[ServiceTicket] ([service_ticket_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ServiceInvoice] CHECK CONSTRAINT [ServiceInvoice_fk0]
GO
ALTER TABLE [dbo].[ServiceTicket]  WITH CHECK ADD  CONSTRAINT [ServiceTicket_fk1] FOREIGN KEY([customer_id])
REFERENCES [dbo].[CustomerDetails] ([customer_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ServiceTicket] CHECK CONSTRAINT [ServiceTicket_fk1]
GO
ALTER TABLE [dbo].[ServiceTicket]  WITH CHECK ADD  CONSTRAINT [ServiceTicket_fk2] FOREIGN KEY([service_id])
REFERENCES [dbo].[Service] ([service_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[ServiceTicket] CHECK CONSTRAINT [ServiceTicket_fk2]
GO
ALTER TABLE [dbo].[SparePartsDetails]  WITH CHECK ADD  CONSTRAINT [SparePartsDetails_fk0] FOREIGN KEY([supplier_id])
REFERENCES [dbo].[SupplierDetails] ([supplier_id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[SparePartsDetails] CHECK CONSTRAINT [SparePartsDetails_fk0]
GO
USE [master]
GO
ALTER DATABASE [dbproj] SET  READ_WRITE 
GO
