USE [master]
GO
/****** Object:  Database [QL_Sach]    Script Date: 19-10-18 8:25:33 CH ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'QL_Sach')
BEGIN
CREATE DATABASE [QL_Sach]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QL_Sach', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QL_Sach.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QL_Sach_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QL_Sach_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END

GO
ALTER DATABASE [QL_Sach] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QL_Sach].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QL_Sach] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QL_Sach] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QL_Sach] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QL_Sach] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QL_Sach] SET ARITHABORT OFF 
GO
ALTER DATABASE [QL_Sach] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QL_Sach] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QL_Sach] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QL_Sach] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QL_Sach] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QL_Sach] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QL_Sach] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QL_Sach] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QL_Sach] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QL_Sach] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QL_Sach] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QL_Sach] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QL_Sach] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QL_Sach] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QL_Sach] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QL_Sach] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QL_Sach] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QL_Sach] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QL_Sach] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QL_Sach] SET  MULTI_USER 
GO
ALTER DATABASE [QL_Sach] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QL_Sach] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QL_Sach] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QL_Sach] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QL_Sach]
GO
/****** Object:  Table [dbo].[Quản lý mượn]    Script Date: 19-10-18 8:25:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Quản lý mượn]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Quản lý mượn](
	[Mã Sách] [nchar](10) NOT NULL,
	[MSSV] [nchar](10) NULL,
	[Ngày mượn] [date] NOT NULL,
	[Số lượng mượn] [int] NULL,
	[Ngày gia hạn] [date] NULL,
 CONSTRAINT [PK_Quản lý mượn] PRIMARY KEY CLUSTERED 
(
	[Mã Sách] ASC,
	[Ngày mượn] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Quản lý Trả]    Script Date: 19-10-18 8:25:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Quản lý Trả]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Quản lý Trả](
	[Mã Sách] [nchar](10) NOT NULL,
	[MSSV] [nchar](10) NULL,
	[Ngày mượn] [date] NULL,
	[Ngày hẹn trả] [date] NULL,
	[Ngày trả] [date] NOT NULL,
	[Số lượng mượn] [int] NULL,
 CONSTRAINT [PK_Quản lý Trả] PRIMARY KEY CLUSTERED 
(
	[Mã Sách] ASC,
	[Ngày trả] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Sách]    Script Date: 19-10-18 8:25:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Sách]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Sách](
	[Mấ Sách] [char](10) NOT NULL,
	[Tên Sách] [nvarchar](50) NULL,
	[Ngày Nhập] [date] NULL,
	[Tác Giả] [nvarchar](50) NULL,
	[Số lượng] [int] NULL,
	[Trạng thái] [nvarchar](50) NULL,
 CONSTRAINT [PK_Sách] PRIMARY KEY CLUSTERED 
(
	[Mấ Sách] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Thông tin sinh viên]    Script Date: 19-10-18 8:25:33 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Thông tin sinh viên]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Thông tin sinh viên](
	[MSSV] [nchar](10) NULL,
	[Tên Sinh Viên] [nvarchar](50) NULL,
	[Mã lớp] [nchar](10) NULL,
	[Tên lớp] [nvarchar](20) NULL,
	[Khoa] [nvarchar](20) NULL,
	[Ngày sinh] [date] NULL,
	[Giới tính] [nvarchar](10) NULL
) ON [PRIMARY]
END
GO
INSERT [dbo].[Quản lý mượn] ([Mã Sách], [MSSV], [Ngày mượn], [Số lượng mượn], [Ngày gia hạn]) VALUES (N'S01       ', N'SV01      ', CAST(N'2015-12-12' AS Date), 10, CAST(N'2015-12-17' AS Date))
INSERT [dbo].[Quản lý mượn] ([Mã Sách], [MSSV], [Ngày mượn], [Số lượng mượn], [Ngày gia hạn]) VALUES (N'S02       ', N'SV02      ', CAST(N'2016-03-12' AS Date), 4, CAST(N'2016-02-17' AS Date))
INSERT [dbo].[Quản lý mượn] ([Mã Sách], [MSSV], [Ngày mượn], [Số lượng mượn], [Ngày gia hạn]) VALUES (N'S03       ', N'SV05      ', CAST(N'2018-10-31' AS Date), 5, CAST(N'2018-11-03' AS Date))
INSERT [dbo].[Quản lý mượn] ([Mã Sách], [MSSV], [Ngày mượn], [Số lượng mượn], [Ngày gia hạn]) VALUES (N'S04       ', N'SV07      ', CAST(N'2017-11-11' AS Date), 2, CAST(N'2017-11-17' AS Date))
INSERT [dbo].[Quản lý Trả] ([Mã Sách], [MSSV], [Ngày mượn], [Ngày hẹn trả], [Ngày trả], [Số lượng mượn]) VALUES (N'S01       ', N'SV01      ', CAST(N'2015-12-12' AS Date), CAST(N'2015-12-17' AS Date), CAST(N'2015-12-15' AS Date), 5)
INSERT [dbo].[Quản lý Trả] ([Mã Sách], [MSSV], [Ngày mượn], [Ngày hẹn trả], [Ngày trả], [Số lượng mượn]) VALUES (N'S02       ', N'SV02      ', CAST(N'2016-03-12' AS Date), CAST(N'2016-02-17' AS Date), CAST(N'2016-02-16' AS Date), 3)
INSERT [dbo].[Quản lý Trả] ([Mã Sách], [MSSV], [Ngày mượn], [Ngày hẹn trả], [Ngày trả], [Số lượng mượn]) VALUES (N'S03       ', N'SV05      ', CAST(N'2018-10-31' AS Date), CAST(N'2018-11-03' AS Date), CAST(N'2018-11-03' AS Date), 2)
INSERT [dbo].[Quản lý Trả] ([Mã Sách], [MSSV], [Ngày mượn], [Ngày hẹn trả], [Ngày trả], [Số lượng mượn]) VALUES (N'S04       ', N'SV07      ', CAST(N'2017-11-11' AS Date), CAST(N'2017-11-17' AS Date), CAST(N'2017-11-17' AS Date), 2)
INSERT [dbo].[Sách] ([Mấ Sách], [Tên Sách], [Ngày Nhập], [Tác Giả], [Số lượng], [Trạng thái]) VALUES (N'S01       ', N'Phương pháp nghiên cứu khoa học', CAST(N'2010-12-12' AS Date), N'Hoàng Văn Nghệ', 100, N'Còn')
INSERT [dbo].[Sách] ([Mấ Sách], [Tên Sách], [Ngày Nhập], [Tác Giả], [Số lượng], [Trạng thái]) VALUES (N'S02       ', N'An toàn lao động ', CAST(N'2011-02-02' AS Date), N'Võ Tuyển', 30, N'Còn')
INSERT [dbo].[Sách] ([Mấ Sách], [Tên Sách], [Ngày Nhập], [Tác Giả], [Số lượng], [Trạng thái]) VALUES (N'S03       ', N'Mạng máy tính', CAST(N'2010-02-03' AS Date), N'Trần Đắc Tốt', 20, N'Còn')
INSERT [dbo].[Sách] ([Mấ Sách], [Tên Sách], [Ngày Nhập], [Tác Giả], [Số lượng], [Trạng thái]) VALUES (N'S04       ', N'Đường lối Đảng Cộng Sản Việt Nam', CAST(N'2010-11-04' AS Date), N'Nguyễn Viết Thông', 10, N'Còn')
INSERT [dbo].[Sách] ([Mấ Sách], [Tên Sách], [Ngày Nhập], [Tác Giả], [Số lượng], [Trạng thái]) VALUES (N'S05       ', N'Vũ trụ to chừng nào', CAST(N'2012-12-05' AS Date), N'Vũ Như Huy', 20, N'Còn')
INSERT [dbo].[Sách] ([Mấ Sách], [Tên Sách], [Ngày Nhập], [Tác Giả], [Số lượng], [Trạng thái]) VALUES (N'S06       ', N'Rừng nguyên sinh', CAST(N'2012-12-06' AS Date), N'Đoàn Minh Khải', 15, N'Còn')
INSERT [dbo].[Sách] ([Mấ Sách], [Tên Sách], [Ngày Nhập], [Tác Giả], [Số lượng], [Trạng thái]) VALUES (N'S07       ', N'Đỉnh doanh số', CAST(N'2010-10-02' AS Date), N'Nguyễn Mạnh Hiền', 12, N'Còn')
INSERT [dbo].[Sách] ([Mấ Sách], [Tên Sách], [Ngày Nhập], [Tác Giả], [Số lượng], [Trạng thái]) VALUES (N'S08       ', N'Luyện nói tiếng anh như bản ngữ', CAST(N'2011-10-10' AS Date), N'A.J.Hoge', 15, N'Còn')
INSERT [dbo].[Thông tin sinh viên] ([MSSV], [Tên Sinh Viên], [Mã lớp], [Tên lớp], [Khoa], [Ngày sinh], [Giới tính]) VALUES (N'SV01      ', N'Nguyễn Văn A', N'07DHTH1   ', N'07 Đại học tin học 1', N'Công nghệ thông tin', CAST(N'1998-03-20' AS Date), N'Nam')
INSERT [dbo].[Thông tin sinh viên] ([MSSV], [Tên Sinh Viên], [Mã lớp], [Tên lớp], [Khoa], [Ngày sinh], [Giới tính]) VALUES (N'SV02      ', N'Huỳnh Văn Nam', N'07DHTH2   ', N'07 Đại học tin học 2', N'Công nghệ thông tin', CAST(N'1998-04-12' AS Date), N'Nam')
INSERT [dbo].[Thông tin sinh viên] ([MSSV], [Tên Sinh Viên], [Mã lớp], [Tên lớp], [Khoa], [Ngày sinh], [Giới tính]) VALUES (N'SV03      ', N'Nguyễn Thị Lài', N'06DHTH3   ', N'06 Đại học tin học 3', N'Công nghệ thông tin', CAST(N'1995-11-04' AS Date), N'Nữ')
INSERT [dbo].[Thông tin sinh viên] ([MSSV], [Tên Sinh Viên], [Mã lớp], [Tên lớp], [Khoa], [Ngày sinh], [Giới tính]) VALUES (N'SV04      ', N'Lê Thị Hồng', N'05DHDT1   ', N'05 Đại học điện tử 1', N'Điện tử', CAST(N'1994-09-07' AS Date), N'Nữ')
INSERT [dbo].[Thông tin sinh viên] ([MSSV], [Tên Sinh Viên], [Mã lớp], [Tên lớp], [Khoa], [Ngày sinh], [Giới tính]) VALUES (N'SV05      ', N'Phan Thánh Tâm', N'08DHCM4   ', N'08 Đại học may 4', N'Công nghệ may', CAST(N'1999-06-05' AS Date), N'Nam')
INSERT [dbo].[Thông tin sinh viên] ([MSSV], [Tên Sinh Viên], [Mã lớp], [Tên lớp], [Khoa], [Ngày sinh], [Giới tính]) VALUES (N'SV06      ', N'Lê Văn Nam', N'09DHAV2   ', N'09 Đại học anh văn 2', N'Ngoại ngữ', CAST(N'1998-12-12' AS Date), N'Nam')
INSERT [dbo].[Thông tin sinh viên] ([MSSV], [Tên Sinh Viên], [Mã lớp], [Tên lớp], [Khoa], [Ngày sinh], [Giới tính]) VALUES (N'SV07      ', N'Nguyễn Văn Tài', N'06DHKT1   ', N'06 Đại học kế toán 1', N'Kế toán', CAST(N'1997-03-21' AS Date), N'Nam')
USE [master]
GO
ALTER DATABASE [QL_Sach] SET  READ_WRITE 
GO
