USE [master]
GO
/****** Object:  Database [QLCafe]    Script Date: 6/15/2019 3:23:10 AM ******/
CREATE DATABASE [QLCafe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLCafe', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLCafe.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLCafe_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLCafe_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLCafe] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLCafe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLCafe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLCafe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLCafe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLCafe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLCafe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLCafe] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLCafe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLCafe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLCafe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLCafe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLCafe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLCafe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLCafe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLCafe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLCafe] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLCafe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLCafe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLCafe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLCafe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLCafe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLCafe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLCafe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLCafe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLCafe] SET  MULTI_USER 
GO
ALTER DATABASE [QLCafe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLCafe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLCafe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLCafe] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLCafe] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLCafe]
GO
/****** Object:  Table [dbo].[ChiTietGioHang]    Script Date: 6/15/2019 3:23:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietGioHang](
	[MaSanPham] [int] NOT NULL,
	[MaGioHang] [int] NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietGioHang] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC,
	[MaGioHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 6/15/2019 3:23:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaSanPham] [int] NOT NULL,
	[MaHoaDon] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGiaHienTai] [float] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC,
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ChiTietThongKe]    Script Date: 6/15/2019 3:23:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietThongKe](
	[MaSanPham] [int] NOT NULL,
	[MaTaiKhoan] [int] NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_ChiTietThongKe] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC,
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GioHang]    Script Date: 6/15/2019 3:23:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioHang](
	[MaGioHang] [int] IDENTITY(1,1) NOT NULL,
	[TinhTrangGioHang] [ntext] NULL,
	[MaTaiKhoan] [int] NULL,
 CONSTRAINT [PK_GioHang] PRIMARY KEY CLUSTERED 
(
	[MaGioHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 6/15/2019 3:23:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[TongGiaTri] [float] NULL,
	[NgayLapHoaDon] [date] NULL,
	[MaTaiKhoan] [int] NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiQuanLi]    Script Date: 6/15/2019 3:23:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiQuanLi](
	[MaNQL] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [ntext] NULL,
	[CMND] [ntext] NULL,
	[DiaChi] [ntext] NULL,
	[SoDienThoai] [ntext] NULL,
 CONSTRAINT [PK_NguoiQuanLi] PRIMARY KEY CLUSTERED 
(
	[MaNQL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhomSanPham]    Script Date: 6/15/2019 3:23:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomSanPham](
	[MaNhom] [int] IDENTITY(1,1) NOT NULL,
	[TenNhom] [ntext] NULL,
	[isDeleted] [int] NULL,
 CONSTRAINT [PK_NhomSanPham] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 6/15/2019 3:23:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSanPham] [int] IDENTITY(1,1) NOT NULL,
	[TenSanPham] [ntext] NULL,
	[MoTa] [ntext] NULL,
	[GiaBan] [float] NULL,
	[TinhTrang] [ntext] NULL,
	[SoLuong] [int] NULL,
	[HinhAnh] [ntext] NULL,
	[MaNhom] [int] NULL,
	[isDeleted] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 6/15/2019 3:23:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTaiKhoan] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [ntext] NULL,
	[MatKhau] [ntext] NULL,
	[MaNQL] [int] NULL,
	[isDeleted] [int] NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ThongKe]    Script Date: 6/15/2019 3:23:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongKe](
	[MaTaiKhoan] [int] NOT NULL,
	[TongGiaTri] [float] NULL,
	[GiaTriMoiThanhPhan] [float] NULL,
 CONSTRAINT [PK_ThongKe] PRIMARY KEY CLUSTERED 
(
	[MaTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[NguoiQuanLi] ON 

INSERT [dbo].[NguoiQuanLi] ([MaNQL], [HoTen], [CMND], [DiaChi], [SoDienThoai]) VALUES (1, N'Nguyễn Hữu Hòa', N'231103404', N'Tân Bình,HCM', N'0982327118')
INSERT [dbo].[NguoiQuanLi] ([MaNQL], [HoTen], [CMND], [DiaChi], [SoDienThoai]) VALUES (2, N'Lê Tống Minh Hiếu', N'234566778', N'HCM,VN', N'0123456788')
INSERT [dbo].[NguoiQuanLi] ([MaNQL], [HoTen], [CMND], [DiaChi], [SoDienThoai]) VALUES (3, N'Hồ Thiên Hổ', N'231103404', N'Tân Bình,HCM', N'0982327118')
INSERT [dbo].[NguoiQuanLi] ([MaNQL], [HoTen], [CMND], [DiaChi], [SoDienThoai]) VALUES (4, N'NHH', N'231103404', N'Tân Bình,HCM', N'0982327118')
SET IDENTITY_INSERT [dbo].[NguoiQuanLi] OFF
SET IDENTITY_INSERT [dbo].[NhomSanPham] ON 

INSERT [dbo].[NhomSanPham] ([MaNhom], [TenNhom], [isDeleted]) VALUES (1, N'Cafe', 0)
INSERT [dbo].[NhomSanPham] ([MaNhom], [TenNhom], [isDeleted]) VALUES (2, N'Nước giải khát', 0)
INSERT [dbo].[NhomSanPham] ([MaNhom], [TenNhom], [isDeleted]) VALUES (3, N'Nước mía', 0)
INSERT [dbo].[NhomSanPham] ([MaNhom], [TenNhom], [isDeleted]) VALUES (4, N'Nước lọc', 0)
SET IDENTITY_INSERT [dbo].[NhomSanPham] OFF
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [GiaBan], [TinhTrang], [SoLuong], [HinhAnh], [MaNhom], [isDeleted]) VALUES (1, N'Cafe Đen', N'Không có mô tả.', 15000, N'Còn', 20, N'C:\git\CoffeeShop\HinhAnh\cafe_den.jpg', 1, 0)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [GiaBan], [TinhTrang], [SoLuong], [HinhAnh], [MaNhom], [isDeleted]) VALUES (2, N'Cafe sữa', N'Cafe nhưng có thêm sữa', 20000, N'Còn', 20, N'C:\git\CoffeeShop\HinhAnh\cafe_sua.jpg', 1, 0)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [GiaBan], [TinhTrang], [SoLuong], [HinhAnh], [MaNhom], [isDeleted]) VALUES (3, N'Cafe sữa không đường', N'béo ngậy và không đường', 15000, N'Còn', 20, N'C:\git\CoffeeShop\HinhAnh\cafe_sua.jpg', 1, 0)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [GiaBan], [TinhTrang], [SoLuong], [HinhAnh], [MaNhom], [isDeleted]) VALUES (4, N'Coca 500ml', N'Nước giải khát cocacola thể tích thực 500ml', 10000, N'Còn', 20, N'C:\git\CoffeeShop\HinhAnh\coca500.jpg', 2, 0)
INSERT [dbo].[SanPham] ([MaSanPham], [TenSanPham], [MoTa], [GiaBan], [TinhTrang], [SoLuong], [HinhAnh], [MaNhom], [isDeleted]) VALUES (5, N'Cafe Robusta', N'Đen đá ít đường', 15000, N'Còn', 20, N'C:\git\CoffeeShop\HinhAnh\cafe_den.jpg', 1, 0)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenDangNhap], [MatKhau], [MaNQL], [isDeleted]) VALUES (8, N'admin', N'123', 1, 0)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenDangNhap], [MatKhau], [MaNQL], [isDeleted]) VALUES (9, N'hoa', N'hoa123', 1, 0)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenDangNhap], [MatKhau], [MaNQL], [isDeleted]) VALUES (10, N'hieu', N'hieu123', 2, 0)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenDangNhap], [MatKhau], [MaNQL], [isDeleted]) VALUES (12, N'hoa2', N'1234', 4, 0)
INSERT [dbo].[TaiKhoan] ([MaTaiKhoan], [TenDangNhap], [MatKhau], [MaNQL], [isDeleted]) VALUES (13, N'ho2', N'123', 3, 0)
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
ALTER TABLE [dbo].[ChiTietGioHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietGioHang_GioHang] FOREIGN KEY([MaGioHang])
REFERENCES [dbo].[GioHang] ([MaGioHang])
GO
ALTER TABLE [dbo].[ChiTietGioHang] CHECK CONSTRAINT [FK_ChiTietGioHang_GioHang]
GO
ALTER TABLE [dbo].[ChiTietGioHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietGioHang_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietGioHang] CHECK CONSTRAINT [FK_ChiTietGioHang_SanPham]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHoaDon])
REFERENCES [dbo].[HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[ChiTietThongKe]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietThongKe_SanPham] FOREIGN KEY([MaSanPham])
REFERENCES [dbo].[SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[ChiTietThongKe] CHECK CONSTRAINT [FK_ChiTietThongKe_SanPham]
GO
ALTER TABLE [dbo].[ChiTietThongKe]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietThongKe_ThongKe] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[ThongKe] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[ChiTietThongKe] CHECK CONSTRAINT [FK_ChiTietThongKe_ThongKe]
GO
ALTER TABLE [dbo].[GioHang]  WITH CHECK ADD  CONSTRAINT [FK_GioHang_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[GioHang] CHECK CONSTRAINT [FK_GioHang_TaiKhoan]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_TaiKhoan] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TaiKhoan] ([MaTaiKhoan])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_TaiKhoan]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_NhomSanPham] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NhomSanPham] ([MaNhom])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_NhomSanPham]
GO
ALTER TABLE [dbo].[TaiKhoan]  WITH CHECK ADD  CONSTRAINT [FK_TaiKhoan_NguoiQuanLi] FOREIGN KEY([MaNQL])
REFERENCES [dbo].[NguoiQuanLi] ([MaNQL])
GO
ALTER TABLE [dbo].[TaiKhoan] CHECK CONSTRAINT [FK_TaiKhoan_NguoiQuanLi]
GO
USE [master]
GO
ALTER DATABASE [QLCafe] SET  READ_WRITE 
GO
