USE [master]
GO
/****** Object:  Database [QuanLyThuVienCNTP2]    Script Date: 1/11/2021 12:48:33 AM ******/
CREATE DATABASE [QuanLyThuVienCNTP2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyThuVienCNTP2', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyThuVienCNTP2.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyThuVienCNTP2_log', FILENAME = N'D:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\QuanLyThuVienCNTP2_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyThuVienCNTP2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QuanLyThuVienCNTP2]
GO
/****** Object:  Table [dbo].[CHUDE]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUDE](
	[MaChuDe] [int] IDENTITY(1,1) NOT NULL,
	[TenChuDe] [nvarchar](200) NULL,
	[TinhTrangXoa] [bit] NOT NULL,
 CONSTRAINT [PK_CHUDE] PRIMARY KEY CLUSTERED 
(
	[MaChuDe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CT_PHIEUMUON]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_PHIEUMUON](
	[MaChiTietPhieuMuon] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuMuon] [int] NULL,
	[TinhTrangTraCT] [bit] NULL,
	[TinhTrangXoa] [bit] NULL,
	[MaVach] [varchar](50) NULL,
 CONSTRAINT [PK_CT_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_PHIEUNHAP]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_PHIEUNHAP](
	[MaChiTietPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuNhap] [int] NULL,
	[MaVach] [varchar](50) NULL,
	[MaNhaCungCap] [int] NULL,
	[TinhTrangXoa] [bit] NOT NULL,
 CONSTRAINT [PK_CT_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_PHIEUTRA]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_PHIEUTRA](
	[MaChiTietPhieuTra] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuTra] [int] NULL,
	[TinhTrangXoa] [bit] NULL,
	[MaPhieuMuon] [int] NULL,
	[MaVach] [varchar](50) NULL,
 CONSTRAINT [PK_CT_PHIEUTRA] PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_XULYVIPHAM]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_XULYVIPHAM](
	[MaChiTietXuLyViPham] [int] IDENTITY(1,1) NOT NULL,
	[MaXuLyViPham] [int] NULL,
	[MaLoaiViPham] [int] NULL,
	[MaVach] [varchar](50) NULL,
	[TinhTrangXoa] [bit] NULL,
	[TienBoiThuong] [float] NULL,
 CONSTRAINT [PK_CT_XULYVIPHAM] PRIMARY KEY CLUSTERED 
(
	[MaChiTietXuLyViPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DOCGIA](
	[MaTheThuVien] [varchar](50) NOT NULL,
	[MaLoaiDocGia] [int] NOT NULL,
	[MaNganh] [varchar](50) NULL,
	[TenDocGia] [nvarchar](200) NULL,
	[CMND] [varchar](12) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[SoDienThoai] [varchar](50) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[Email] [varchar](200) NULL,
	[HanSuDungTheThuVien] [date] NULL,
	[TinhTrangTheThuVien] [bit] NULL,
	[NgayLamThe] [date] NULL,
	[HinhAnh] [varchar](50) NULL,
	[MatKhau] [varchar](200) NULL,
	[TinhTrangXoa] [bit] NOT NULL,
 CONSTRAINT [PK_DOCGIA] PRIMARY KEY CLUSTERED 
(
	[MaTheThuVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HINHTHUCXULY]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HINHTHUCXULY](
	[MaHinhThucXuLy] [int] IDENTITY(1,1) NOT NULL,
	[PhiBoiThuong] [int] NULL,
 CONSTRAINT [PK_HINHTHUCXULY] PRIMARY KEY CLUSTERED 
(
	[MaHinhThucXuLy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KHOA]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHOA](
	[MaKhoa] [int] IDENTITY(1,1) NOT NULL,
	[TenKhoa] [nvarchar](200) NOT NULL,
	[TinhTrangXoa] [bit] NOT NULL,
 CONSTRAINT [PK_KHOA] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAIDOCGIA]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIDOCGIA](
	[MaLoaiDocGia] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiDocGia] [nvarchar](200) NULL,
	[TinhTrangXoa] [bit] NULL,
 CONSTRAINT [PK_LOAIDOCGIA_1] PRIMARY KEY CLUSTERED 
(
	[MaLoaiDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAINHANVIEN]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAINHANVIEN](
	[MaLoaiNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiNhanVien] [nvarchar](200) NULL,
	[TinhTrangXoa] [bit] NOT NULL,
 CONSTRAINT [PK_LOAINHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAITAILIEU]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAITAILIEU](
	[MaLoaiTaiLieu] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiTaiLieu] [nvarchar](200) NULL,
	[TinhTrangXoa] [bit] NOT NULL,
 CONSTRAINT [PK_LOAITAILIEU] PRIMARY KEY CLUSTERED 
(
	[MaLoaiTaiLieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAITINTUC]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAITINTUC](
	[MaLoaiTinTuc] [int] IDENTITY(1,1) NOT NULL,
	[TenMaLoaiTinTuc] [nvarchar](200) NULL,
 CONSTRAINT [PK_LOAITINTUC] PRIMARY KEY CLUSTERED 
(
	[MaLoaiTinTuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LOAIVIPHAM]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIVIPHAM](
	[MaLoaiViPham] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiViPham] [nvarchar](200) NULL,
	[MaHinhThucXuLy] [int] NULL,
 CONSTRAINT [PK_LOAIVIPHAM] PRIMARY KEY CLUSTERED 
(
	[MaLoaiViPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MANHINH]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MANHINH](
	[MaManHinh] [varchar](50) NOT NULL,
	[TenManHinh] [nvarchar](200) NULL,
 CONSTRAINT [PK_MANHINH_1] PRIMARY KEY CLUSTERED 
(
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGANH]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NGANH](
	[MaNganh] [varchar](50) NOT NULL,
	[TenNganh] [nvarchar](200) NULL,
	[MaKhoa] [int] NULL,
 CONSTRAINT [PK_NGANH] PRIMARY KEY CLUSTERED 
(
	[MaNganh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NGONNGU]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NGONNGU](
	[MaNgonNgu] [int] IDENTITY(1,1) NOT NULL,
	[TenNgonNgu] [nvarchar](200) NULL,
	[TinhTrangXoa] [bit] NOT NULL,
 CONSTRAINT [PK_NGONNGU_1] PRIMARY KEY CLUSTERED 
(
	[MaNgonNgu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNhaCungCap] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaCungCap] [nvarchar](200) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[SoDienThoai] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [int] IDENTITY(10000000,1) NOT NULL,
	[MaLoaiNhanVien] [int] NULL,
	[TenNhanVien] [nvarchar](200) NULL,
	[NgaySinh] [date] NULL,
	[GioiTinh] [nvarchar](20) NULL,
	[SoDienThoai] [varchar](20) NULL,
	[CMND] [varchar](12) NULL,
	[DiaChi] [nvarchar](200) NULL,
	[NgayVaoLam] [date] NULL,
	[HinhAnh] [varchar](200) NULL,
	[TinhTrangTK] [bit] NULL,
	[MatKhau] [varchar](200) NULL,
	[TinhTrangXoa] [bit] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHAXUATBAN](
	[MaNhaXuatBan] [int] IDENTITY(1,1) NOT NULL,
	[TenNhaXuatBan] [nvarchar](200) NULL,
	[TinhTrangXoa] [bit] NOT NULL,
 CONSTRAINT [PK_NHAXUATBAN] PRIMARY KEY CLUSTERED 
(
	[MaNhaXuatBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHANQUYEN](
	[MaLoaiNhanVien] [int] NOT NULL,
	[MaManHinh] [varchar](50) NOT NULL,
	[CoQuyen] [bit] NULL,
 CONSTRAINT [PK_PHANQUYEN_1] PRIMARY KEY CLUSTERED 
(
	[MaLoaiNhanVien] ASC,
	[MaManHinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUMUON](
	[MaPhieuMuon] [int] IDENTITY(1,1) NOT NULL,
	[MaTheThuVien] [varchar](50) NULL,
	[MaNhanVien] [int] NULL,
	[NgayLap] [date] NULL,
	[ThoiHanMuon] [date] NULL,
	[SoSachMuon] [int] NULL,
	[TinhTrangTra] [bit] NOT NULL,
	[PhiCoc] [float] NULL,
	[TinhTrangXoa] [bit] NOT NULL,
 CONSTRAINT [PK_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MaPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPhieuNhap] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [int] NULL,
	[NgayNhap] [date] NULL,
	[TongTien] [float] NULL,
	[TinhTrangXoa] [bit] NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUTRA]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTRA](
	[MaPhieuTra] [int] IDENTITY(1,1) NOT NULL,
	[MaNhanVien] [int] NULL,
	[NgayLap] [date] NULL,
	[SoLuongSachTra] [int] NULL,
	[TinhTrangXoa] [bit] NULL,
 CONSTRAINT [PK_PHIEUTRA] PRIMARY KEY CLUSTERED 
(
	[MaPhieuTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PHIEUXULYVIPHAM]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUXULYVIPHAM](
	[MaXuLyViPham] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuTra] [int] NULL,
	[MaNhanVien] [int] NULL,
	[NgayLap] [date] NULL,
	[TinhTrangXoa] [bit] NULL,
	[TongTienBoiThuong] [float] NULL,
 CONSTRAINT [PK_PHIEUXULYVIPHAM] PRIMARY KEY CLUSTERED 
(
	[MaXuLyViPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TACGIA]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TACGIA](
	[MaTacGia] [int] IDENTITY(1,1) NOT NULL,
	[TenTacGia] [nvarchar](200) NULL,
	[TinhTrangXoa] [bit] NOT NULL,
 CONSTRAINT [PK_TACGIA] PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TAILIEU]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TAILIEU](
	[MaVach] [varchar](50) NOT NULL,
	[MaTaiLieu] [varchar](50) NOT NULL,
	[MaLoaiTaiLieu] [int] NULL,
	[MaDauTaiLieu] [varchar](50) NULL,
	[MaChuDe] [int] NULL,
	[MaTap] [varchar](50) NULL,
	[TenTaiLieu] [nvarchar](200) NULL,
	[SoTrang] [int] NULL,
	[Gia] [float] NULL,
	[NamXuatBan] [int] NULL,
	[MaTacGia] [int] NULL,
	[MaNhaXuatBan] [int] NULL,
	[ThongTinTaiLieu] [nvarchar](max) NULL,
	[MaNgonNgu] [int] NULL,
	[MaViTri] [varchar](50) NOT NULL,
	[HinhAnh] [varchar](50) NULL,
	[TinhTrangXoa] [bit] NULL,
 CONSTRAINT [PK_TAILIEU] PRIMARY KEY CLUSTERED 
(
	[MaVach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TINTUC]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TINTUC](
	[MaTinTuc] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiTinTuc] [int] NULL,
	[TieuDe] [nvarchar](200) NULL,
	[MoTaNgan] [nvarchar](500) NULL,
	[NoiDung] [nvarchar](max) NULL,
	[NgayTao] [date] NULL,
	[NguoiLap] [int] NULL,
	[HinhAnh] [varchar](max) NULL,
	[SoLuongLuotXem] [int] NULL,
	[HienThiTrangChu] [bit] NOT NULL,
	[TinhTrangXoa] [bit] NOT NULL,
	[Logo] [varchar](max) NULL,
 CONSTRAINT [PK_TINTUC] PRIMARY KEY CLUSTERED 
(
	[MaTinTuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VITRI]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VITRI](
	[MaViTri] [varchar](50) NOT NULL,
	[Tang] [int] NULL,
	[TinhTrangXoa] [bit] NULL,
	[Ke] [varchar](50) NULL,
 CONSTRAINT [PK_VITRI_1] PRIMARY KEY CLUSTERED 
(
	[MaViTri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[VW_TAILIEU]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_TAILIEU]
AS
SELECT                      dbo.NHAXUATBAN.MaNhaXuatBan AS Expr1, dbo.NHAXUATBAN.TenNhaXuatBan, dbo.VITRI.MaViTri AS Expr2, dbo.VITRI.Tang, dbo.VITRI.Ke, dbo.NGONNGU.MaNgonNgu AS Expr3, 
                                      dbo.NGONNGU.TenNgonNgu, dbo.LOAITAILIEU.MaLoaiTaiLieu AS Expr4, dbo.LOAITAILIEU.TenLoaiTaiLieu, dbo.CHUDE.MaChuDe AS Expr5, dbo.CHUDE.TenChuDe, dbo.TACGIA.MaTacGia AS Expr6, 
                                      dbo.TACGIA.TenTacGia, dbo.TAILIEU.*
FROM                         dbo.CHUDE INNER JOIN
                                      dbo.TAILIEU ON dbo.CHUDE.MaChuDe = dbo.TAILIEU.MaChuDe INNER JOIN
                                      dbo.VITRI ON dbo.TAILIEU.MaViTri = dbo.VITRI.MaViTri INNER JOIN
                                      dbo.NHAXUATBAN ON dbo.TAILIEU.MaNhaXuatBan = dbo.NHAXUATBAN.MaNhaXuatBan INNER JOIN
                                      dbo.TACGIA ON dbo.TAILIEU.MaTacGia = dbo.TACGIA.MaTacGia INNER JOIN
                                      dbo.LOAITAILIEU ON dbo.TAILIEU.MaLoaiTaiLieu = dbo.LOAITAILIEU.MaLoaiTaiLieu INNER JOIN
                                      dbo.NGONNGU ON dbo.TAILIEU.MaNgonNgu = dbo.NGONNGU.MaNgonNgu



GO
/****** Object:  View [dbo].[VW_TAILIEUDANGMUON]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_TAILIEUDANGMUON]
AS
SELECT                      dbo.PHIEUMUON.MaPhieuMuon AS Expr1, dbo.PHIEUMUON.MaTheThuVien, dbo.PHIEUMUON.MaNhanVien, dbo.PHIEUMUON.NgayLap, dbo.PHIEUMUON.ThoiHanMuon, dbo.PHIEUMUON.SoSachMuon, 
                                      dbo.PHIEUMUON.TinhTrangTra, dbo.PHIEUMUON.PhiCoc, dbo.CT_PHIEUMUON.MaChiTietPhieuMuon, dbo.CT_PHIEUMUON.MaPhieuMuon, dbo.CT_PHIEUMUON.TinhTrangTraCT, 
                                      dbo.VW_TAILIEU.TenNhaXuatBan, dbo.VW_TAILIEU.Tang, dbo.VW_TAILIEU.Ke, dbo.VW_TAILIEU.TenNgonNgu, dbo.VW_TAILIEU.TenLoaiTaiLieu, dbo.VW_TAILIEU.TenChuDe, dbo.VW_TAILIEU.TenTacGia, 
                                      dbo.VW_TAILIEU.MaVach, dbo.VW_TAILIEU.MaTaiLieu, dbo.VW_TAILIEU.MaLoaiTaiLieu, dbo.VW_TAILIEU.MaDauTaiLieu, dbo.VW_TAILIEU.MaChuDe, dbo.VW_TAILIEU.MaTap, dbo.VW_TAILIEU.TenTaiLieu, 
                                      dbo.VW_TAILIEU.SoTrang, dbo.VW_TAILIEU.Gia, dbo.VW_TAILIEU.NamXuatBan, dbo.VW_TAILIEU.MaTacGia, dbo.VW_TAILIEU.MaNhaXuatBan, dbo.VW_TAILIEU.ThongTinTaiLieu, dbo.VW_TAILIEU.MaNgonNgu, 
                                      dbo.VW_TAILIEU.MaViTri, dbo.VW_TAILIEU.HinhAnh, dbo.VW_TAILIEU.TinhTrangXoa
FROM                         dbo.CT_PHIEUMUON INNER JOIN
                                      dbo.PHIEUMUON ON dbo.CT_PHIEUMUON.MaPhieuMuon = dbo.PHIEUMUON.MaPhieuMuon INNER JOIN
                                      dbo.VW_TAILIEU ON dbo.CT_PHIEUMUON.MaVach = dbo.VW_TAILIEU.MaVach



GO
/****** Object:  View [dbo].[VW_TAILIEUDAMUON]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_TAILIEUDAMUON]
AS
SELECT                      dbo.CT_PHIEUTRA.MaChiTietPhieuTra, dbo.CT_PHIEUTRA.MaPhieuTra, dbo.CT_PHIEUTRA.MaPhieuMuon, dbo.CT_PHIEUTRA.MaVach, dbo.PHIEUTRA.MaPhieuTra AS Expr1, dbo.PHIEUTRA.MaNhanVien, 
                                      dbo.PHIEUTRA.NgayLap, dbo.PHIEUTRA.SoLuongSachTra, dbo.CT_PHIEUMUON.MaChiTietPhieuMuon, dbo.CT_PHIEUMUON.MaPhieuMuon AS Expr2, dbo.CT_PHIEUMUON.TinhTrangTraCT, 
                                      dbo.CT_PHIEUMUON.MaVach AS Expr3, dbo.PHIEUMUON.MaPhieuMuon AS Expr4, dbo.PHIEUMUON.MaTheThuVien, dbo.PHIEUMUON.MaNhanVien AS Expr5, dbo.PHIEUMUON.ThoiHanMuon, 
                                      dbo.PHIEUMUON.SoSachMuon, dbo.PHIEUMUON.TinhTrangTra, dbo.PHIEUMUON.PhiCoc, dbo.VW_TAILIEU.TenNhaXuatBan, dbo.VW_TAILIEU.Tang, dbo.VW_TAILIEU.Ke, dbo.VW_TAILIEU.TenNgonNgu, 
                                      dbo.VW_TAILIEU.TenLoaiTaiLieu, dbo.VW_TAILIEU.TenChuDe, dbo.VW_TAILIEU.TenTacGia, dbo.VW_TAILIEU.MaVach AS Expr7, dbo.VW_TAILIEU.MaTaiLieu, dbo.VW_TAILIEU.MaLoaiTaiLieu, 
                                      dbo.VW_TAILIEU.MaDauTaiLieu, dbo.VW_TAILIEU.MaChuDe, dbo.VW_TAILIEU.MaTap, dbo.VW_TAILIEU.TenTaiLieu, dbo.VW_TAILIEU.SoTrang, dbo.VW_TAILIEU.Gia, dbo.VW_TAILIEU.NamXuatBan, 
                                      dbo.VW_TAILIEU.MaTacGia, dbo.VW_TAILIEU.MaNhaXuatBan, dbo.VW_TAILIEU.ThongTinTaiLieu, dbo.VW_TAILIEU.MaNgonNgu, dbo.VW_TAILIEU.MaViTri, dbo.VW_TAILIEU.HinhAnh, 
                                      dbo.PHIEUMUON.NgayLap AS Expr6
FROM                         dbo.PHIEUTRA INNER JOIN
                                      dbo.CT_PHIEUTRA ON dbo.PHIEUTRA.MaPhieuTra = dbo.CT_PHIEUTRA.MaPhieuTra INNER JOIN
                                      dbo.CT_PHIEUMUON INNER JOIN
                                      dbo.PHIEUMUON ON dbo.CT_PHIEUMUON.MaPhieuMuon = dbo.PHIEUMUON.MaPhieuMuon ON dbo.CT_PHIEUTRA.MaPhieuMuon = dbo.PHIEUMUON.MaPhieuMuon INNER JOIN
                                      dbo.VW_TAILIEU ON dbo.CT_PHIEUMUON.MaVach = dbo.VW_TAILIEU.MaVach AND dbo.CT_PHIEUTRA.MaVach = dbo.VW_TAILIEU.MaVach



GO
/****** Object:  View [dbo].[VW_TAILIEUCUNGTACGIA]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_TAILIEUCUNGTACGIA]
AS
SELECT TenTaiLieu, MaTaiLieu, TenTacGia
FROM     dbo.VW_TAILIEU



GO
/****** Object:  View [dbo].[VW_TAILIEUCUNGCHUDE]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_TAILIEUCUNGCHUDE]
AS
SELECT MaTaiLieu, TenChuDe, TenTaiLieu
FROM     dbo.VW_TAILIEU



GO
/****** Object:  View [dbo].[VW_DOCGIA]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_DOCGIA]
AS
SELECT                      dbo.NGANH.MaNganh AS Expr3, dbo.NGANH.TenNganh, dbo.KHOA.MaKhoa, dbo.KHOA.TenKhoa, dbo.NGANH.MaKhoa AS Expr1, dbo.DOCGIA.*
FROM                         dbo.DOCGIA INNER JOIN
                                      dbo.NGANH ON dbo.DOCGIA.MaNganh = dbo.NGANH.MaNganh INNER JOIN
                                      dbo.KHOA ON dbo.NGANH.MaKhoa = dbo.KHOA.MaKhoa



GO
/****** Object:  View [dbo].[VW_NHANVIEN]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_NHANVIEN]
AS
SELECT dbo.LOAINHANVIEN.TenLoaiNhanVien, dbo.NHANVIEN.*
FROM     dbo.NHANVIEN INNER JOIN
                  dbo.LOAINHANVIEN ON dbo.NHANVIEN.MaLoaiNhanVien = dbo.LOAINHANVIEN.MaLoaiNhanVien


GO
/****** Object:  View [dbo].[VW_TINTUC]    Script Date: 1/11/2021 12:48:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_TINTUC]
AS
SELECT dbo.TINTUC.*, dbo.LOAITINTUC.TenMaLoaiTinTuc, dbo.TINTUC.NguoiLap AS Expr1, dbo.NHANVIEN.TenNhanVien, dbo.NHANVIEN.MaNhanVien
FROM     dbo.TINTUC INNER JOIN
                  dbo.LOAITINTUC ON dbo.TINTUC.MaLoaiTinTuc = dbo.LOAITINTUC.MaLoaiTinTuc INNER JOIN
                  dbo.NHANVIEN ON dbo.TINTUC.NguoiLap = dbo.NHANVIEN.MaNhanVien


GO
SET IDENTITY_INSERT [dbo].[CHUDE] ON 

INSERT [dbo].[CHUDE] ([MaChuDe], [TenChuDe], [TinhTrangXoa]) VALUES (1, N'Từ điển', 0)
INSERT [dbo].[CHUDE] ([MaChuDe], [TenChuDe], [TinhTrangXoa]) VALUES (2, N'Văn Hoá', 0)
INSERT [dbo].[CHUDE] ([MaChuDe], [TenChuDe], [TinhTrangXoa]) VALUES (3, N'Lịch sử', 0)
INSERT [dbo].[CHUDE] ([MaChuDe], [TenChuDe], [TinhTrangXoa]) VALUES (4, N'Công nghệ thông tin', 0)
INSERT [dbo].[CHUDE] ([MaChuDe], [TenChuDe], [TinhTrangXoa]) VALUES (5, N'Kinh doanh', 0)
INSERT [dbo].[CHUDE] ([MaChuDe], [TenChuDe], [TinhTrangXoa]) VALUES (6, N'Khoa học kỹ thuật', 0)
INSERT [dbo].[CHUDE] ([MaChuDe], [TenChuDe], [TinhTrangXoa]) VALUES (7, N'Pháp luật', 0)
INSERT [dbo].[CHUDE] ([MaChuDe], [TenChuDe], [TinhTrangXoa]) VALUES (8, N'test', 1)
INSERT [dbo].[CHUDE] ([MaChuDe], [TenChuDe], [TinhTrangXoa]) VALUES (9, N'Ngoại Ngữ', 0)
SET IDENTITY_INSERT [dbo].[CHUDE] OFF
SET IDENTITY_INSERT [dbo].[CT_PHIEUMUON] ON 

INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (1, 1, 1, 0, N'100000021')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (2, 1, 1, 0, N'100000022')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (3, 1, 1, 0, N'100000023')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (4, 2, 1, 0, N'100000025')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (5, 3, 0, 0, N'100000001')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (6, 3, 0, 0, N'100000002')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (7, 3, 0, 0, N'100000003')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (8, 4, 0, 0, N'100000022')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (9, 4, 0, 0, N'100000026')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (10, 4, 0, 1, N'100000031')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (11, 5, 0, 0, N'100000032')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (12, 5, 0, 0, N'100000035')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (13, 6, 0, 0, N'100000024')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (14, 7, 0, 0, N'100000034')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (15, 8, 0, 0, N'100000039')
SET IDENTITY_INSERT [dbo].[CT_PHIEUMUON] OFF
SET IDENTITY_INSERT [dbo].[CT_PHIEUNHAP] ON 

INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (1, 1, N'100000000', 1, 1)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (2, 1, N'100000027', 1, 1)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (3, 1, N'100000028', 1, 1)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (4, 2, N'100000037', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (5, 2, N'100000038', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (6, 2, N'100000039', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (7, 2, N'100000042', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (8, 2, N'100000043', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (9, 2, N'100000044', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (10, 2, N'100000045', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (11, 2, N'100000046', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (12, 2, N'100000047', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (13, 2, N'100000048', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (14, 2, N'100000049', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (15, 6, N'100000050', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (16, 6, N'100000051', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (17, 7, N'100000052', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (18, 7, N'100000053', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (19, 7, N'100000054', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (20, 7, N'100000055', 1, 0)
SET IDENTITY_INSERT [dbo].[CT_PHIEUNHAP] OFF
SET IDENTITY_INSERT [dbo].[CT_PHIEUTRA] ON 

INSERT [dbo].[CT_PHIEUTRA] ([MaChiTietPhieuTra], [MaPhieuTra], [TinhTrangXoa], [MaPhieuMuon], [MaVach]) VALUES (1, 1, 0, 1, N'100000021')
INSERT [dbo].[CT_PHIEUTRA] ([MaChiTietPhieuTra], [MaPhieuTra], [TinhTrangXoa], [MaPhieuMuon], [MaVach]) VALUES (4, 2, 0, 1, N'100000022')
INSERT [dbo].[CT_PHIEUTRA] ([MaChiTietPhieuTra], [MaPhieuTra], [TinhTrangXoa], [MaPhieuMuon], [MaVach]) VALUES (5, 2, 0, 1, N'100000023')
INSERT [dbo].[CT_PHIEUTRA] ([MaChiTietPhieuTra], [MaPhieuTra], [TinhTrangXoa], [MaPhieuMuon], [MaVach]) VALUES (6, 2, 0, 2, N'100000025')
SET IDENTITY_INSERT [dbo].[CT_PHIEUTRA] OFF
SET IDENTITY_INSERT [dbo].[CT_XULYVIPHAM] ON 

INSERT [dbo].[CT_XULYVIPHAM] ([MaChiTietXuLyViPham], [MaXuLyViPham], [MaLoaiViPham], [MaVach], [TinhTrangXoa], [TienBoiThuong]) VALUES (1, 1, 2, N'100000021', 0, 384000)
INSERT [dbo].[CT_XULYVIPHAM] ([MaChiTietXuLyViPham], [MaXuLyViPham], [MaLoaiViPham], [MaVach], [TinhTrangXoa], [TienBoiThuong]) VALUES (2, 1, 1, N'100000022', 0, 4000)
INSERT [dbo].[CT_XULYVIPHAM] ([MaChiTietXuLyViPham], [MaXuLyViPham], [MaLoaiViPham], [MaVach], [TinhTrangXoa], [TienBoiThuong]) VALUES (3, 2, 1, N'100000022', 0, 5000)
INSERT [dbo].[CT_XULYVIPHAM] ([MaChiTietXuLyViPham], [MaXuLyViPham], [MaLoaiViPham], [MaVach], [TinhTrangXoa], [TienBoiThuong]) VALUES (4, 2, 2, N'100000023', 0, 872000)
SET IDENTITY_INSERT [dbo].[CT_XULYVIPHAM] OFF
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170001', 1, N'7540106', N'Hứa Tôn Đạt', N'025895109', CAST(0xE7410B00 AS Date), N'Nữ', N'0789163351', N'Vũng Tàu', N'huatondat@gmail.com', CAST(0xC3420B00 AS Date), 1, CAST(0xEA410B00 AS Date), N'2001170001.png', N'2001170001', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170018', 1, N'7480201', N'Hứa Tôn Đạt Nhật 222', N'025895109', CAST(0xBE400B00 AS Date), N'Nam', N'0789163351', N'53/10 Đường 8B, P.BHHA, Quận Bình Tân', N'huatondat1621999@gmail.com', CAST(0x09420B00 AS Date), 0, CAST(0x9B400B00 AS Date), N'2001170018.jpg', N'123123', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170019', 1, N'7480201', N'Hứa Tôn Đạt Nhật', N'025895109', CAST(0xBE400B00 AS Date), N'Nam', N'0789163351', N'53/10 Đường 8B, P.BHHA, Quận Bình Tân', N'huatondat1621999@gmail.com', CAST(0x09420B00 AS Date), 0, CAST(0x9B400B00 AS Date), N'2001170018.jpg', N'2001170018', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170020', 1, N'7480201', N'Hứa Tôn Đạt Nhật', N'025895109', CAST(0xBE400B00 AS Date), N'Nam', N'0789163351', N'53/10 Đường 8B, P.BHHA, Quận Bình Tân', N'huatondat1621999@gmail.com', CAST(0x09420B00 AS Date), 0, CAST(0x9B400B00 AS Date), N'2001170018.jpg', N'2001170018', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170031', 3, N'7480201', N'Trần Ngọc Sinh aa', N'025648885555', CAST(0x053F0B00 AS Date), N'Nữ', N'0789163355', N'53111 Trần Bình Trọng, Quận 5', N'tranngocsinh@gmail.com', CAST(0x09420B00 AS Date), 1, CAST(0x9B400B00 AS Date), N'2001170031.jpg', N'2001170031', 1)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170033', 1, N'7480201', N'Trần Phương Anh', N'025895109', CAST(0xB3400B00 AS Date), N'Nam', N'0789163351', N'TP.HCM', N'phuonganh@gmail.com', CAST(0x09420B00 AS Date), 0, CAST(0xE9410B00 AS Date), N'2001170033.jpg', N'2001170033', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170034', 2, N'7480201', N'Nguyễn Nhật Lâm', N'025891654', CAST(0x18410B00 AS Date), N'Nữ', N'0789163351', N'5351 3/2, Quận 11', N'nhatlam@gmail.com', CAST(0x05420B00 AS Date), 0, CAST(0x97400B00 AS Date), N'2001170034.jpg', N'nhatlam', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170092', 1, N'7340120', N'Nguyễn Thị Mỹ Duyên', N'0789163351', CAST(0xBE400B00 AS Date), N'Nữ', N'0789163351', N'53/10 Đường 8B', N'nguyenthimyduyen@gmail.com', CAST(0x09420B00 AS Date), 0, CAST(0x9B400B00 AS Date), N'2001170092.jpg', N'2001170092', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170373', 1, N'7480201', N'Nhật Lâm', N'000301693007', CAST(0xFF230B00 AS Date), N'Nam', N'0703456400', N'Long An', N'nhatlam@gmail.com', CAST(0xFC410B00 AS Date), 0, CAST(0xDF410B00 AS Date), N'2001170373.jpg', N'2001170373', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207519', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(0xE7410B00 AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(0xE7410B00 AS Date), 0, CAST(0xEA410B00 AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207520', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(0xE7410B00 AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(0xE7410B00 AS Date), 0, CAST(0xEA410B00 AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207521', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(0xE7410B00 AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(0xE7410B00 AS Date), 0, CAST(0xEA410B00 AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207522', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(0xE7410B00 AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(0xE7410B00 AS Date), 0, CAST(0xEA410B00 AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207523', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(0xE7410B00 AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(0xE7410B00 AS Date), 0, CAST(0xEA410B00 AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207524', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(0xE7410B00 AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(0xE7410B00 AS Date), 0, CAST(0xEA410B00 AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207525', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(0xE7410B00 AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(0xE7410B00 AS Date), 0, CAST(0xEA410B00 AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207526', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(0xE7410B00 AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(0xE7410B00 AS Date), 0, CAST(0xEA410B00 AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207527', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(0xE7410B00 AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(0xE7410B00 AS Date), 0, CAST(0xEA410B00 AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207528', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(0xE7410B00 AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(0xE7410B00 AS Date), 0, CAST(0xEA410B00 AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207529', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(0xE7410B00 AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(0xE7410B00 AS Date), 0, CAST(0xEA410B00 AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207531', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(0xE7410B00 AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(0xE7410B00 AS Date), 0, CAST(0xEA410B00 AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207532', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(0xE7410B00 AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(0xE7410B00 AS Date), 0, CAST(0xEA410B00 AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207533', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(0xE7410B00 AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(0xE7410B00 AS Date), 0, CAST(0xEA410B00 AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207534', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(0xE7410B00 AS Date), N'Nữ', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(0xE7410B00 AS Date), 0, CAST(0xEA410B00 AS Date), N'2033207534.png', N'2033207534', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207535', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(0xE7410B00 AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(0xE7410B00 AS Date), 1, CAST(0xEA410B00 AS Date), N'2033207535.png', N'2033207535', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'21381723123', 3, N'0', N'ádasdasd', N'123123123', CAST(0xF5410B00 AS Date), N'Nam', N'123123123', N'12312312', N'12312312', CAST(0xF5410B00 AS Date), 0, CAST(0xF5410B00 AS Date), N'21381723123.png', N'21381723123', 0)
SET IDENTITY_INSERT [dbo].[HINHTHUCXULY] ON 

INSERT [dbo].[HINHTHUCXULY] ([MaHinhThucXuLy], [PhiBoiThuong]) VALUES (1, 1000)
INSERT [dbo].[HINHTHUCXULY] ([MaHinhThucXuLy], [PhiBoiThuong]) VALUES (2, 2)
SET IDENTITY_INSERT [dbo].[HINHTHUCXULY] OFF
SET IDENTITY_INSERT [dbo].[KHOA] ON 

INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [TinhTrangXoa]) VALUES (1, N'Công nghệ thông tin', 0)
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [TinhTrangXoa]) VALUES (2, N'Quản trị kinh doanh', 0)
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [TinhTrangXoa]) VALUES (3, N'Công nghệ thực phẩm', 0)
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [TinhTrangXoa]) VALUES (4, N'Công nghệ cơ khí', 0)
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [TinhTrangXoa]) VALUES (5, N'Công nghệ sinh học', 0)
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [TinhTrangXoa]) VALUES (6, N'Công nghệ Điện - Điện tử', 0)
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [TinhTrangXoa]) VALUES (7, N'Công nghệ hoá học', 0)
INSERT [dbo].[KHOA] ([MaKhoa], [TenKhoa], [TinhTrangXoa]) VALUES (8, N'Không', 0)
SET IDENTITY_INSERT [dbo].[KHOA] OFF
SET IDENTITY_INSERT [dbo].[LOAIDOCGIA] ON 

INSERT [dbo].[LOAIDOCGIA] ([MaLoaiDocGia], [TenLoaiDocGia], [TinhTrangXoa]) VALUES (1, N'Sinh viên', 0)
INSERT [dbo].[LOAIDOCGIA] ([MaLoaiDocGia], [TenLoaiDocGia], [TinhTrangXoa]) VALUES (2, N'Giáo viên', 0)
INSERT [dbo].[LOAIDOCGIA] ([MaLoaiDocGia], [TenLoaiDocGia], [TinhTrangXoa]) VALUES (3, N'Độc giả ngoài trường', 0)
SET IDENTITY_INSERT [dbo].[LOAIDOCGIA] OFF
SET IDENTITY_INSERT [dbo].[LOAINHANVIEN] ON 

INSERT [dbo].[LOAINHANVIEN] ([MaLoaiNhanVien], [TenLoaiNhanVien], [TinhTrangXoa]) VALUES (1, N'Thủ thư', 0)
INSERT [dbo].[LOAINHANVIEN] ([MaLoaiNhanVien], [TenLoaiNhanVien], [TinhTrangXoa]) VALUES (2, N'Quản lý tài liệu', 0)
INSERT [dbo].[LOAINHANVIEN] ([MaLoaiNhanVien], [TenLoaiNhanVien], [TinhTrangXoa]) VALUES (3, N'Giám đốc', 0)
SET IDENTITY_INSERT [dbo].[LOAINHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[LOAITAILIEU] ON 

INSERT [dbo].[LOAITAILIEU] ([MaLoaiTaiLieu], [TenLoaiTaiLieu], [TinhTrangXoa]) VALUES (1, N'Sách', 0)
INSERT [dbo].[LOAITAILIEU] ([MaLoaiTaiLieu], [TenLoaiTaiLieu], [TinhTrangXoa]) VALUES (2, N'Tạp chí', 0)
INSERT [dbo].[LOAITAILIEU] ([MaLoaiTaiLieu], [TenLoaiTaiLieu], [TinhTrangXoa]) VALUES (3, N'CD, DVD', 0)
INSERT [dbo].[LOAITAILIEU] ([MaLoaiTaiLieu], [TenLoaiTaiLieu], [TinhTrangXoa]) VALUES (4, N'Tạp chí', 1)
SET IDENTITY_INSERT [dbo].[LOAITAILIEU] OFF
SET IDENTITY_INSERT [dbo].[LOAITINTUC] ON 

INSERT [dbo].[LOAITINTUC] ([MaLoaiTinTuc], [TenMaLoaiTinTuc]) VALUES (1, N'Tin tức - sự kiện')
INSERT [dbo].[LOAITINTUC] ([MaLoaiTinTuc], [TenMaLoaiTinTuc]) VALUES (2, N'Thông báo')
INSERT [dbo].[LOAITINTUC] ([MaLoaiTinTuc], [TenMaLoaiTinTuc]) VALUES (3, N'Sách mới')
INSERT [dbo].[LOAITINTUC] ([MaLoaiTinTuc], [TenMaLoaiTinTuc]) VALUES (4, N'Tạp chí mới')
SET IDENTITY_INSERT [dbo].[LOAITINTUC] OFF
SET IDENTITY_INSERT [dbo].[LOAIVIPHAM] ON 

INSERT [dbo].[LOAIVIPHAM] ([MaLoaiViPham], [TenLoaiViPham], [MaHinhThucXuLy]) VALUES (1, N'Trễ hạn', 1)
INSERT [dbo].[LOAIVIPHAM] ([MaLoaiViPham], [TenLoaiViPham], [MaHinhThucXuLy]) VALUES (2, N'Mất tài liệu', 2)
SET IDENTITY_INSERT [dbo].[LOAIVIPHAM] OFF
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SF001', N'Quản lý mượn trả')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SF002', N'Quản lý nhân viên')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SF003', N'Quản lý tài liệu')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SF004', N'Quản lý độc giả')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SF005', N'Quản lý phiếu trả')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SF006', N'Quản lý phiếu mượn')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SF007', N'Quản lý phiếu nhập')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SF008', N'Thống kê')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SF009', N'Phân quyền')
INSERT [dbo].[MANHINH] ([MaManHinh], [TenManHinh]) VALUES (N'SF010', N'Quản lý phiếu vi phạm')
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'0', N'Không', 8)
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'7340101', N'Quản trị kinh doanh', 2)
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'7340120', N'Kinh doanh quốc tế', 2)
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'7380107', N'Luật kinh tế', 2)
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'7420201', N'Công nghệ sinh học', 5)
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'7480201', N'Công nghệ thông tin', 1)
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'7480202', N'An toàn thông tin', 1)
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'7510202', N'Công nghệ chế tạo máy', 4)
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'7510203', N'Công nghệ kỹ thuật cơ điện tử', 4)
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'7510301', N'Công nghệ kỹ thuật điện, điện tử', 6)
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'7510303', N'Công nghệ kỹ thuật điều khiển và tự động hóa', 6)
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'7510401', N'Công nghệ kỹ thuật hoá học', 7)
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'7510402', N'Công nghệ vật liệu', 6)
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'7540101', N'Công nghệ thực phẩm', 3)
INSERT [dbo].[NGANH] ([MaNganh], [TenNganh], [MaKhoa]) VALUES (N'7540106', N'Đảm bảo chất lượng và an toàn thực phẩm', 3)
SET IDENTITY_INSERT [dbo].[NGONNGU] ON 

INSERT [dbo].[NGONNGU] ([MaNgonNgu], [TenNgonNgu], [TinhTrangXoa]) VALUES (1, N'Tiếng Việt', 0)
INSERT [dbo].[NGONNGU] ([MaNgonNgu], [TenNgonNgu], [TinhTrangXoa]) VALUES (2, N'Tiếng Anh', 0)
INSERT [dbo].[NGONNGU] ([MaNgonNgu], [TenNgonNgu], [TinhTrangXoa]) VALUES (3, N'Tiếng Trung Quốc', 0)
INSERT [dbo].[NGONNGU] ([MaNgonNgu], [TenNgonNgu], [TinhTrangXoa]) VALUES (4, N'Tiếng Nhật', 0)
INSERT [dbo].[NGONNGU] ([MaNgonNgu], [TenNgonNgu], [TinhTrangXoa]) VALUES (5, N'Tiếng Pháp', 0)
INSERT [dbo].[NGONNGU] ([MaNgonNgu], [TenNgonNgu], [TinhTrangXoa]) VALUES (6, N'Tiếng Đức', 0)
INSERT [dbo].[NGONNGU] ([MaNgonNgu], [TenNgonNgu], [TinhTrangXoa]) VALUES (7, N'Tiếng Hàn', 0)
INSERT [dbo].[NGONNGU] ([MaNgonNgu], [TenNgonNgu], [TinhTrangXoa]) VALUES (8, N'Tiếng Campuchia aa', 1)
INSERT [dbo].[NGONNGU] ([MaNgonNgu], [TenNgonNgu], [TinhTrangXoa]) VALUES (9, N'Tiếng Nga', 0)
SET IDENTITY_INSERT [dbo].[NGONNGU] OFF
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] ON 

INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [SoDienThoai], [Email]) VALUES (1, N'Fahasa', N'320 Nguyễn Chí Thanh, Quận 10', N'0255656842', N'fahasa@gmail.com')
SET IDENTITY_INSERT [dbo].[NHACUNGCAP] OFF
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON 

INSERT [dbo].[NHANVIEN] ([MaNhanVien], [MaLoaiNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SoDienThoai], [CMND], [DiaChi], [NgayVaoLam], [HinhAnh], [TinhTrangTK], [MatKhau], [TinhTrangXoa]) VALUES (10000001, 2, N'Hứa Tôn Đạt', CAST(0xBE400B00 AS Date), N'Nam', N'0789163351', N'02589510912', N'53/10', CAST(0xF5410B00 AS Date), N'10000001.png', 1, N'123', 0)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [MaLoaiNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SoDienThoai], [CMND], [DiaChi], [NgayVaoLam], [HinhAnh], [TinhTrangTK], [MatKhau], [TinhTrangXoa]) VALUES (10000002, 1, N'Nguyễn Nhật Lâm', CAST(0xFE230B00 AS Date), N'Nam', N'0789163351', N'012345678912', N'123123123123123', CAST(0xF5410B00 AS Date), N'10000002.png', 1, N'123', 0)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [MaLoaiNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SoDienThoai], [CMND], [DiaChi], [NgayVaoLam], [HinhAnh], [TinhTrangTK], [MatKhau], [TinhTrangXoa]) VALUES (10000003, 3, N'Nguyễn Văn A', CAST(0x371E0B00 AS Date), N'Nữ', N'0791456321', N'014785269365', N'TP HCM', CAST(0x493C0B00 AS Date), N'10000003.jpg', 1, N'111', 0)
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
SET IDENTITY_INSERT [dbo].[NHAXUATBAN] ON 

INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan], [TinhTrangXoa]) VALUES (1, N'NXB Khoa Học Xã Hội', 0)
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan], [TinhTrangXoa]) VALUES (2, N'NXB Đại Học Quốc Gia Hà Nội', 0)
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan], [TinhTrangXoa]) VALUES (3, N'NXB Thế Giới', 0)
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan], [TinhTrangXoa]) VALUES (4, N'NXB Đại học bách khoa Hà Nội', 0)
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan], [TinhTrangXoa]) VALUES (5, N'NXB Tét', 1)
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan], [TinhTrangXoa]) VALUES (6, N'Picador', 0)
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan], [TinhTrangXoa]) VALUES (7, N'John Murray', 0)
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan], [TinhTrangXoa]) VALUES (8, N'NXB Trẻ', 0)
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan], [TinhTrangXoa]) VALUES (9, N'NXB Công Thương', 0)
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan], [TinhTrangXoa]) VALUES (10, N'NXB Tổng Hợp TPHCM', 0)
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan], [TinhTrangXoa]) VALUES (11, N'Penguin USA', 0)
INSERT [dbo].[NHAXUATBAN] ([MaNhaXuatBan], [TenNhaXuatBan], [TinhTrangXoa]) VALUES (12, N'NXB Thông Tin và Truyền Thông', 0)
SET IDENTITY_INSERT [dbo].[NHAXUATBAN] OFF
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (1, N'SF001', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (1, N'SF002', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (1, N'SF003', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (1, N'SF004', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (1, N'SF005', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (1, N'SF006', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (1, N'SF007', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (1, N'SF008', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (1, N'SF009', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (1, N'SF010', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF001', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF002', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF003', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF004', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF005', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF006', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF007', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF008', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF009', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF010', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF001', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF002', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF003', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF004', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF005', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF006', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF007', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF008', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF009', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF010', 1)
SET IDENTITY_INSERT [dbo].[PHIEUMUON] ON 

INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaTheThuVien], [MaNhanVien], [NgayLap], [ThoiHanMuon], [SoSachMuon], [TinhTrangTra], [PhiCoc], [TinhTrangXoa]) VALUES (1, N'2001170373', 10000003, CAST(0xF8410B00 AS Date), CAST(0x17420B00 AS Date), 3, 1, 150000, 0)
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaTheThuVien], [MaNhanVien], [NgayLap], [ThoiHanMuon], [SoSachMuon], [TinhTrangTra], [PhiCoc], [TinhTrangXoa]) VALUES (2, N'2001170373', 10000003, CAST(0xF8410B00 AS Date), CAST(0x17420B00 AS Date), 1, 1, 150000, 0)
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaTheThuVien], [MaNhanVien], [NgayLap], [ThoiHanMuon], [SoSachMuon], [TinhTrangTra], [PhiCoc], [TinhTrangXoa]) VALUES (3, N'2001170373', 10000002, CAST(0x1D3F0B00 AS Date), CAST(0x3C3F0B00 AS Date), 3, 0, 150000, 0)
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaTheThuVien], [MaNhanVien], [NgayLap], [ThoiHanMuon], [SoSachMuon], [TinhTrangTra], [PhiCoc], [TinhTrangXoa]) VALUES (4, N'2001170018', 10000002, CAST(0x1D3F0B00 AS Date), CAST(0x3C3F0B00 AS Date), 3, 0, 100000, 0)
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaTheThuVien], [MaNhanVien], [NgayLap], [ThoiHanMuon], [SoSachMuon], [TinhTrangTra], [PhiCoc], [TinhTrangXoa]) VALUES (5, N'2033207524', 10000002, CAST(0x1D3F0B00 AS Date), CAST(0x3C3F0B00 AS Date), 2, 0, 50000, 0)
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaTheThuVien], [MaNhanVien], [NgayLap], [ThoiHanMuon], [SoSachMuon], [TinhTrangTra], [PhiCoc], [TinhTrangXoa]) VALUES (6, N'2033207526', 10000002, CAST(0x1D3F0B00 AS Date), CAST(0x3C3F0B00 AS Date), 1, 0, 50000, 0)
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaTheThuVien], [MaNhanVien], [NgayLap], [ThoiHanMuon], [SoSachMuon], [TinhTrangTra], [PhiCoc], [TinhTrangXoa]) VALUES (7, N'2033207526', 10000002, CAST(0x1D3F0B00 AS Date), CAST(0x3C3F0B00 AS Date), 1, 0, 250000, 0)
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaTheThuVien], [MaNhanVien], [NgayLap], [ThoiHanMuon], [SoSachMuon], [TinhTrangTra], [PhiCoc], [TinhTrangXoa]) VALUES (8, N'2033207526', 10000002, CAST(0x1D3F0B00 AS Date), CAST(0x3C3F0B00 AS Date), 1, 0, 35000, 0)
SET IDENTITY_INSERT [dbo].[PHIEUMUON] OFF
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] ON 

INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (1, 10000002, CAST(0xEE410B00 AS Date), 250000, 1)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (2, 10000001, CAST(0xEE410B00 AS Date), 2982000, 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (3, 10000001, CAST(0xEE410B00 AS Date), 1250000, 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (4, 10000002, CAST(0xEE410B00 AS Date), 3250000, 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (5, 10000001, CAST(0xEE410B00 AS Date), 612000, 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (6, 10000001, CAST(0xEE410B00 AS Date), 1276000, 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (7, 10000001, CAST(0xF2410B00 AS Date), 763000, 0)
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] OFF
SET IDENTITY_INSERT [dbo].[PHIEUTRA] ON 

INSERT [dbo].[PHIEUTRA] ([MaPhieuTra], [MaNhanVien], [NgayLap], [SoLuongSachTra], [TinhTrangXoa]) VALUES (1, 10000003, CAST(0xF8410B00 AS Date), 1, 0)
INSERT [dbo].[PHIEUTRA] ([MaPhieuTra], [MaNhanVien], [NgayLap], [SoLuongSachTra], [TinhTrangXoa]) VALUES (2, 10000003, CAST(0xF8410B00 AS Date), 3, 0)
SET IDENTITY_INSERT [dbo].[PHIEUTRA] OFF
SET IDENTITY_INSERT [dbo].[PHIEUXULYVIPHAM] ON 

INSERT [dbo].[PHIEUXULYVIPHAM] ([MaXuLyViPham], [MaPhieuTra], [MaNhanVien], [NgayLap], [TinhTrangXoa], [TongTienBoiThuong]) VALUES (1, 1, 10000003, CAST(0xF8410B00 AS Date), 0, 388000)
INSERT [dbo].[PHIEUXULYVIPHAM] ([MaXuLyViPham], [MaPhieuTra], [MaNhanVien], [NgayLap], [TinhTrangXoa], [TongTienBoiThuong]) VALUES (2, 2, 10000003, CAST(0xF8410B00 AS Date), 0, 877000)
SET IDENTITY_INSERT [dbo].[PHIEUXULYVIPHAM] OFF
SET IDENTITY_INSERT [dbo].[TACGIA] ON 

INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia], [TinhTrangXoa]) VALUES (1, N'Trương Văn Giới', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia], [TinhTrangXoa]) VALUES (2, N'Trần Mạnh Tường', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia], [TinhTrangXoa]) VALUES (3, N'Hiromi Shinya', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia], [TinhTrangXoa]) VALUES (4, N'Kim Dung', 1)
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia], [TinhTrangXoa]) VALUES (5, N'Simon Winder', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia], [TinhTrangXoa]) VALUES (6, N'Rob Schmitz', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia], [TinhTrangXoa]) VALUES (7, N'Phan Mạnh Quỳnh', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia], [TinhTrangXoa]) VALUES (8, N'Al Ries', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia], [TinhTrangXoa]) VALUES (9, N'Bernard Marr', 0)
INSERT [dbo].[TACGIA] ([MaTacGia], [TenTacGia], [TinhTrangXoa]) VALUES (10, N'Joshua Foer', 0)
SET IDENTITY_INSERT [dbo].[TACGIA] OFF
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000000', N'1000001', 1, N'1', 1, N'0', N'Từ Điển Việt - Hán Hiện Đại', 1440, 120000, 2018, 1, 1, N'Từ Điển Việt - Hán Hiện Đại', 1, N'B-400', N'100000000.jpg', 1)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000001', N'1000002', 1, N'1', 1, N'0', N'Từ Điển Anh Việt - Việt Anh (Tái Bản)', 1600, 115000, 2019, 2, 2, N'Cuốn sách được các chuyên gia biên soạn kỹ lưỡng với lượng từ phong phú, giải thích dễ hiểu với các từ vựng thường dùng trong sinh hoạt, giao tiếp hằng ngày.
Ngoài ra cuốn sách còn cập nhật nhiều từ mới trong lĩnh vực kinh tế, khoa học, kỹ thuật, văn hóa, xã hội… Các mục từ được trình bày rõ ràng dễ hiểu tra cứu giúp người đọc thuận tiện khi tham khảo đối chiếu nhanh tại nhà, cơ quan, trường học…', 1, N'B-400', N'100000001.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000002', N'1000003', 1, N'1', 6, N'1', N'
Nhân Tố Enzyme - Minh Họa (Tái Bản 2018)', 99, 64000, 2018, 3, 3, N'Nhân Tố Enzyme 4 - Minh Họa nói về phương pháp sống đúng, sống khỏe đã được tác giả đã truyền tải hết trong ba cuốn trước của bộ sách Nhân tố Enzyme, và trong cuốn này, ông tóm tắt lại các điểm chính. Mỗi phần đều có kèm theo sơ đồ hay hình ảnh minh họa để độc giả dễ theo dõi. Mỗi phần đều được trình bày trên hai trang mở liền nhau nên dễ đọc, dễ theo dõi.

Việc đọc lại toàn bộ ba cuốn trong bộ sách có thể sẽ khá vất vả với các bạn, nhưng với cuốn sách này, bạn chỉ cần 30 phút là có thể đọc xong. Do đó, cuốn sách này có lẽ sẽ rất cần thiết cho những ai muốn củng cố lại kiến thức hay kể cả những người mới bắt đầu đọc.

Sách có 4 phần, mỗi phần đều nói về các phương pháp khác nhau để có sức khỏe sống trong cuộc sống chúng ta:

Phần 1: Hãy làm sạch vị tướng, tràng tướng.
Phần 2: Thói quen ăn uống lành mạnh.
Phần 3: Phương pháp thải độc cho cơ thể.
Phần 4: Thói quen tạo cho một cơ thể không bị bệnh.', 1, N'B-500', N'100000002.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000003', N'1000004', 1, N'1', 6, N'100000002', N'​Nhân Tố Enzyme 2 - Thực Hành (Tái Bản 2018)', 291, 85000, 2018, 3, 3, N'Nhân Tố Enzyme - Thực Hành

Ngày nay, nền y học hiện đại đang không ngừng phát triển, thế nhưng tại sao số người phải chống chọi với bệnh tật vẫn không hề giảm bớt?

Sau hàng chục năm nghiên cứu, bác sĩ Hiromi Shinya nhận ra rằng việc một người hấp thu loại thực phẩm gì, với số lượng bao nhiêu, cũng như có thói quen sinh hoạt như thế nào đều quan hệ mật thiết tới vị tướng, tràng tướng. Hơn nữa, việc này còn liên quan tới cả tình trạng sức khỏe của chính người đó.

Tại các cơ sở y tế, các bác sĩ cũng hướng dẫn ăn uống đối với một số căn bệnh cần phải hạn chế ăn uống như bệnh tiểu đường. Tuy nhiên, những hướng dẫn đó chỉ giúp bệnh tình không trở nặng hơn. Không quá lời khi nói rằng cho đến nay, những hướng dẫn trong cách ăn uống, sinh hoạt để bệnh nhân không bị bệnh, hay có thể sống thọ một cách khỏe mạnh vẫn còn là điểm mù của nền y học hiện đại.

Vốn dĩ cơ thể con người có rất nhiều hệ thống phòng vệ và cơ chế miễn dịch bảo vệ khỏi bệnh tật. Do đó, nếu không phải là các vấn đề bẩm sinh, chỉ cần không làm những việc quá bất thường thì dù đôi khi vi phạm một hai điều, bạn vẫn sẽ không bị mắc bệnh.

Nguyên nhân lớn nhất khiến cơ thể vốn có cơ chế tự bảo vệ bị mắc bệnh chính là do “thói quen ăn uống và sinh hoạt sai lầm” được tích lũy trong thời gian dài.

Do phần lớn mọi người không biết thực phẩm nào là tốt, thực phẩm nào là không tốt đối với cơ thể con người nên mới bị mắc bệnh. Với tâm nguyện giới thiệu về thói quen ăn uống và sinh hoạt đúng đắn để giúp mọi người có thể duy trì sức khỏe của bản thân, tác giả đã cho ra đời cuốn sách Nhân tố enzyme – Phương thứcsống lành mạnh giới thiệu với mọi người về “bữa ăn lý tưởng” và thói quen sinh hoạt lý tưởng”. Đã nhận được rất nhiều phản hồi từ bạn đọc trên thế giới.

Nhưng nếu như Nhân tố enzyme – Phương thức sống lành mạnh chỉ là những đề xuất “lý tưởng”, thì cuốn sách này của tác giả chính là “cuốn thực hành” để bạn có thể vừa tận hưởng cuộc sống, vừa biết cách ăn uống, sinh hoạt tốt cho cơ thể của mình. Trong cuốn sách này, tác giả đã trình bày nhiều phương pháp để bạn có thể biết được giới hạn cho phép của bản thân và có thể thực hiện những thói quen sinh hoạt tốt cho cơ thể mà không quá hà khắc.

Hy vọng rằng bạn có thể tìm thấy phương pháp phù hợp với lối sống riêng của mình để có thể vừa tận hưởng cuộc sống, vừa có thể sống khỏe mạnh mỗi ngày.', 1, N'B-500', N'100000003.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000004', N'1000005', 1, N'1', 6, N'100000003', N'Nhân Tố Enzyme 3 - Trẻ Hóa (Tái Bản 2018)', 175, 65000, 2018, 3, 3, N'Nhân Tố Enzyme – Trẻ Hóa

Trên thế giới này, không có ai trẻ hơn tuổi thực của mình cả. Có chăng chỉ là người đúng với tuổi thực và người già hơn tuổi thực mà thôi.

Nói cách khác, những người trẻ nhất mà bạn thấy cũng chỉ là những người đang ở trạng thái đúng với tuổi thật của mình. Sự trẻ trung khiến người khác phải ghen tị thực ra cũng chính là dáng vẻ vốn có đúng với độ tuổi của bạn.

Giữa thân thể và tinh thần của con người có một mối quan hệ khăng khít bền chặt không thể tách rời. Nếu bạn chỉ làm những việc tốt cho cơ thể hay chỉ làm những việc tốt cho tinh thần thì bạn không thể có được sự trẻ trung thực sự. Con người chỉ có được sự trẻ trung thực sự khi đồng thời thực hiện cả hai việc là trẻ hóa cơ thể và trẻ hóa tâm hồn.

Nằm trong bộ sách Nhân tố Enzyme, cuốn sách Nhân tố Enzyme – Trẻ hóa sẽ tập trung vào những kiến thức và bí quyết giúp bạn đạt được điều đó.', 1, N'B-500', N'100000004.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000021', N'1000007', 1, N'1', 3, N'0', N'Lotharingia: A Personal History Of Europe''s Lost Country', 528, 192000, 2019, 5, 6, N'In 843 AD, the three surviving grandsons of the great emperor Charlemagne met at Verdun. After years of bitter squabbles over who would inherit the family land, they finally decided to divide the territory and go their separate ways. In a moment of staggering significance, one grandson inherited the area we now know as France, another Germany and the third received the piece in between: Lotharingia.

Lotharingia is a history of in-between Europe; the story of a place between places. In this beguiling and compelling book, Simon Winder retraces the various powers that have tried to overtake the land that stretches from the mouth of the Rhine to the Alps and the might of the peoples who have lived there for centuries.', 2, N'B-300', N'100000021.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000022', N'1000007', 1, N'2', 3, N'0', N'Lotharingia: A Personal History Of Europe''s Lost Country', 528, 192000, 2019, 5, 6, N'In 843 AD, the three surviving grandsons of the great emperor Charlemagne met at Verdun. After years of bitter squabbles over who would inherit the family land, they finally decided to divide the territory and go their separate ways. In a moment of staggering significance, one grandson inherited the area we now know as France, another Germany and the third received the piece in between: Lotharingia.

Lotharingia is a history of in-between Europe; the story of a place between places. In this beguiling and compelling book, Simon Winder retraces the various powers that have tried to overtake the land that stretches from the mouth of the Rhine to the Alps and the might of the peoples who have lived there for centuries.', 2, N'B-300', N'100000022.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000023', N'1000008', 1, N'1', 1, N'0', N'Street Of Eternal Happiness: Big City Dreams Along A Shanghai Road', 336, 436000, 2016, 6, 7, N'Street Of Eternal Happiness: Big City Dreams Along A Shanghai Road

''Enjoyable and illuminating . . . Rob Schmitz writes with great affection'' Guardian

Shanghai: a global city in the midst of a renaissance, where dreamers arrive each day to partake in a mad torrent of capital, ideas and opportunity. Rob Schmitz is one of them. He immerses himself in his neighbourhood, forging relationships with ordinary people who see a brighter future in the city''s sleek skyline. There''s Zhao, whose path from factory floor to shopkeeper is sidetracked by her desperate measures to ensure a better future for her sons. Down the street lives Auntie Fu, a fervent capitalist forever trying to improve herself while keeping her sceptical husband at bay. Up a flight of stairs, CK sets up shop to attract young dreamers like himself, but learns he''s searching for something more. As Schmitz becomes increasingly involved in their lives, he makes surprising discoveries which untangle the complexities of modern China: a mysterious box of letters that serve as a portal to a family''s - and country''s - dark past, and an abandoned neighbourhood where fates have been violently altered by unchecked power and greed.

A tale of twenty-first-century China, Street of Eternal Happiness profiles China''s distinct generations through multifaceted characters who illuminate an enlightening, humorous and, at times, heartrending journey along the winding road to the Chinese dream. Each story adds another layer of humanity to modern China, a tapestry also woven with Schmitz''s insight as a foreign correspondent. The result is an intimate and surprising portrait that dispenses with the tired stereotypes of a country we think we know, immersing us instead in the vivid stories of the people who make up one of the world''s most captivating cities.', 1, N'B-300', N'100000023.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000024', N'1000008', 1, N'2', 1, N'0', N'Street Of Eternal Happiness: Big City Dreams Along A Shanghai Road', 336, 436000, 2016, 6, 7, N'Street Of Eternal Happiness: Big City Dreams Along A Shanghai Road

''Enjoyable and illuminating . . . Rob Schmitz writes with great affection'' Guardian

Shanghai: a global city in the midst of a renaissance, where dreamers arrive each day to partake in a mad torrent of capital, ideas and opportunity. Rob Schmitz is one of them. He immerses himself in his neighbourhood, forging relationships with ordinary people who see a brighter future in the city''s sleek skyline. There''s Zhao, whose path from factory floor to shopkeeper is sidetracked by her desperate measures to ensure a better future for her sons. Down the street lives Auntie Fu, a fervent capitalist forever trying to improve herself while keeping her sceptical husband at bay. Up a flight of stairs, CK sets up shop to attract young dreamers like himself, but learns he''s searching for something more. As Schmitz becomes increasingly involved in their lives, he makes surprising discoveries which untangle the complexities of modern China: a mysterious box of letters that serve as a portal to a family''s - and country''s - dark past, and an abandoned neighbourhood where fates have been violently altered by unchecked power and greed.

A tale of twenty-first-century China, Street of Eternal Happiness profiles China''s distinct generations through multifaceted characters who illuminate an enlightening, humorous and, at times, heartrending journey along the winding road to the Chinese dream. Each story adds another layer of humanity to modern China, a tapestry also woven with Schmitz''s insight as a foreign correspondent. The result is an intimate and surprising portrait that dispenses with the tired stereotypes of a country we think we know, immersing us instead in the vivid stories of the people who make up one of the world''s most captivating cities.', 1, N'B-300', N'100000024.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000025', N'1000009', 1, N'1', 1, N'0', N'Tiếng Nhật Cho Mọi Người - Sơ Cấp 2 - Bản Tiếng Nhật (Bản Mới 2018)', 310, 138000, 2018, 7, 8, N'Giáo trình dạy tiếng Nhật Minna no Nihongo bộ mới', 4, N'B-400', N'100000025.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000026', N'1000009', 1, N'2', 1, N'0', N'Tiếng Nhật Cho Mọi Người - Sơ Cấp 2 - Bản Tiếng Nhật (Bản Mới 2018)', 310, 138000, 2018, 7, 8, N'Giáo trình dạy tiếng Nhật Minna no Nihongo bộ mới', 4, N'B-400', N'100000026.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000027', N'1000010', 1, N'1', 6, N'0', N'Data Strategy - Chiến Lược Dữ Liệu', 272, 79000, 2019, 9, 10, N'Data Strategy - Chiến Lược Dữ Liệu

Dữ liệu đang thay đổi cách chúng ta sống và làm việc với tốc độ chưa từng có. Nó là tất cả dấu vết ta để lại khi lướt web, mua hàng qua thẻ tín dụng, gửi e-mail, chụp ảnh, đọc báo trực tuyến, thậm chí dạo phố khi mang theo điện thoại di động hoặc đi trong khu vực có hệ thống .

Nhờ vào dữ liệu, nhà bán lẻ Target tại Mỹ đã dự đoán đúng một thiếu nữ đang mang thai dựa trên thói quen mua hàng của cô ấy; Google có thể hiển thị chính xác quảng cáo phù hợp với bạn; Facebook biết bạn của bạn là ai, bạn đang trong mối quan hệ với người nào, dự đoán được mối quan hệ này kéo dài trong bao lâu, khi nào bạn sẽ có một mối quan hệ tình cảm, thậm chí cho biết mức độ thông minh của bạn…

Tuy nhiên, hiện có chưa đến 0,5% dữ liệu được phân tích và sử dụng. Nhận thấy mảnh đất màu mỡ này, Bernard Marr đã cho ra đời Chiến Lược Dữ Liệu - nơi hội tụ những kiến thức về dữ liệu được đơn giản hóa với nhiều ví dụ dễ hiểu - cung cấp cho bạn cách thức tối đa hóa sức mạnh của dữ liệu bên cạnh việc tránh những rắc rối liên quan đến pháp lý, danh tiếng và tài chính.

Tầm quan trọng của chiến lược dữ liệu ngày càng được khẳng định qua thành công của các doanh nghiệp hoạt động trên nền tảng dữ liệu như Alphabet, Facebook, Narrative Science, Amazon, Apple… Việc có một chiến lược dữ liệu mạnh và lộ trình khoa học đã trở thành một phần tất yếu trong ADN của mỗi tổ chức. Nó xứng đáng nhận được sự quan tâm ngang với chiến lược marketing, khách hàng, sản phẩm hay thu hút nhân tài của doanh nghiệp.

Chiến Lược Dữ Liệu không chỉ phù hợp cho người bước đầu làm quen với dữ liệu, mà còn cung cấp nhịp điệu bao quát về những thay đổi đang diễn ra trên thị trường và trang bị nền tảng ban đầu cho người đang chịu trách nhiệm về mảng dữ liệu của doanh nghiệp.', 1, N'A-200', N'100000027.jpg', 1)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000028', N'1000010', 1, N'2', 6, N'0', N'Data Strategy - Chiến Lược Dữ Liệu', 272, 79000, 2019, 9, 10, N'Data Strategy - Chiến Lược Dữ Liệu

Dữ liệu đang thay đổi cách chúng ta sống và làm việc với tốc độ chưa từng có. Nó là tất cả dấu vết ta để lại khi lướt web, mua hàng qua thẻ tín dụng, gửi e-mail, chụp ảnh, đọc báo trực tuyến, thậm chí dạo phố khi mang theo điện thoại di động hoặc đi trong khu vực có hệ thống .

Nhờ vào dữ liệu, nhà bán lẻ Target tại Mỹ đã dự đoán đúng một thiếu nữ đang mang thai dựa trên thói quen mua hàng của cô ấy; Google có thể hiển thị chính xác quảng cáo phù hợp với bạn; Facebook biết bạn của bạn là ai, bạn đang trong mối quan hệ với người nào, dự đoán được mối quan hệ này kéo dài trong bao lâu, khi nào bạn sẽ có một mối quan hệ tình cảm, thậm chí cho biết mức độ thông minh của bạn…

Tuy nhiên, hiện có chưa đến 0,5% dữ liệu được phân tích và sử dụng. Nhận thấy mảnh đất màu mỡ này, Bernard Marr đã cho ra đời Chiến Lược Dữ Liệu - nơi hội tụ những kiến thức về dữ liệu được đơn giản hóa với nhiều ví dụ dễ hiểu - cung cấp cho bạn cách thức tối đa hóa sức mạnh của dữ liệu bên cạnh việc tránh những rắc rối liên quan đến pháp lý, danh tiếng và tài chính.

Tầm quan trọng của chiến lược dữ liệu ngày càng được khẳng định qua thành công của các doanh nghiệp hoạt động trên nền tảng dữ liệu như Alphabet, Facebook, Narrative Science, Amazon, Apple… Việc có một chiến lược dữ liệu mạnh và lộ trình khoa học đã trở thành một phần tất yếu trong ADN của mỗi tổ chức. Nó xứng đáng nhận được sự quan tâm ngang với chiến lược marketing, khách hàng, sản phẩm hay thu hút nhân tài của doanh nghiệp.

Chiến Lược Dữ Liệu không chỉ phù hợp cho người bước đầu làm quen với dữ liệu, mà còn cung cấp nhịp điệu bao quát về những thay đổi đang diễn ra trên thị trường và trang bị nền tảng ban đầu cho người đang chịu trách nhiệm về mảng dữ liệu của doanh nghiệp.', 1, N'A-200', N'100000028.jpg', 1)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000029', N'1000010', 1, N'0', 6, N'0', N'Data Strategy - Chiến Lược Dữ Liệu', 272, 79000, 2019, 9, 10, N'Data Strategy - Chiến Lược Dữ Liệu

Dữ liệu đang thay đổi cách chúng ta sống và làm việc với tốc độ chưa từng có. Nó là tất cả dấu vết ta để lại khi lướt web, mua hàng qua thẻ tín dụng, gửi e-mail, chụp ảnh, đọc báo trực tuyến, thậm chí dạo phố khi mang theo điện thoại di động hoặc đi trong khu vực có hệ thống .

Nhờ vào dữ liệu, nhà bán lẻ Target tại Mỹ đã dự đoán đúng một thiếu nữ đang mang thai dựa trên thói quen mua hàng của cô ấy; Google có thể hiển thị chính xác quảng cáo phù hợp với bạn; Facebook biết bạn của bạn là ai, bạn đang trong mối quan hệ với người nào, dự đoán được mối quan hệ này kéo dài trong bao lâu, khi nào bạn sẽ có một mối quan hệ tình cảm, thậm chí cho biết mức độ thông minh của bạn…

Tuy nhiên, hiện có chưa đến 0,5% dữ liệu được phân tích và sử dụng. Nhận thấy mảnh đất màu mỡ này, Bernard Marr đã cho ra đời Chiến Lược Dữ Liệu - nơi hội tụ những kiến thức về dữ liệu được đơn giản hóa với nhiều ví dụ dễ hiểu - cung cấp cho bạn cách thức tối đa hóa sức mạnh của dữ liệu bên cạnh việc tránh những rắc rối liên quan đến pháp lý, danh tiếng và tài chính.

Tầm quan trọng của chiến lược dữ liệu ngày càng được khẳng định qua thành công của các doanh nghiệp hoạt động trên nền tảng dữ liệu như Alphabet, Facebook, Narrative Science, Amazon, Apple… Việc có một chiến lược dữ liệu mạnh và lộ trình khoa học đã trở thành một phần tất yếu trong ADN của mỗi tổ chức. Nó xứng đáng nhận được sự quan tâm ngang với chiến lược marketing, khách hàng, sản phẩm hay thu hút nhân tài của doanh nghiệp.

Chiến Lược Dữ Liệu không chỉ phù hợp cho người bước đầu làm quen với dữ liệu, mà còn cung cấp nhịp điệu bao quát về những thay đổi đang diễn ra trên thị trường và trang bị nền tảng ban đầu cho người đang chịu trách nhiệm về mảng dữ liệu của doanh nghiệp.', 1, N'A-200', N'100000029.jpg', 1)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000030', N'1000010', 1, N'0', 6, N'0', N'Data Strategy - Chiến Lược Dữ Liệu', 272, 79000, 2019, 9, 10, N'Data Strategy - Chiến Lược Dữ Liệu

Dữ liệu đang thay đổi cách chúng ta sống và làm việc với tốc độ chưa từng có. Nó là tất cả dấu vết ta để lại khi lướt web, mua hàng qua thẻ tín dụng, gửi e-mail, chụp ảnh, đọc báo trực tuyến, thậm chí dạo phố khi mang theo điện thoại di động hoặc đi trong khu vực có hệ thống .

Nhờ vào dữ liệu, nhà bán lẻ Target tại Mỹ đã dự đoán đúng một thiếu nữ đang mang thai dựa trên thói quen mua hàng của cô ấy; Google có thể hiển thị chính xác quảng cáo phù hợp với bạn; Facebook biết bạn của bạn là ai, bạn đang trong mối quan hệ với người nào, dự đoán được mối quan hệ này kéo dài trong bao lâu, khi nào bạn sẽ có một mối quan hệ tình cảm, thậm chí cho biết mức độ thông minh của bạn…

Tuy nhiên, hiện có chưa đến 0,5% dữ liệu được phân tích và sử dụng. Nhận thấy mảnh đất màu mỡ này, Bernard Marr đã cho ra đời Chiến Lược Dữ Liệu - nơi hội tụ những kiến thức về dữ liệu được đơn giản hóa với nhiều ví dụ dễ hiểu - cung cấp cho bạn cách thức tối đa hóa sức mạnh của dữ liệu bên cạnh việc tránh những rắc rối liên quan đến pháp lý, danh tiếng và tài chính.

Tầm quan trọng của chiến lược dữ liệu ngày càng được khẳng định qua thành công của các doanh nghiệp hoạt động trên nền tảng dữ liệu như Alphabet, Facebook, Narrative Science, Amazon, Apple… Việc có một chiến lược dữ liệu mạnh và lộ trình khoa học đã trở thành một phần tất yếu trong ADN của mỗi tổ chức. Nó xứng đáng nhận được sự quan tâm ngang với chiến lược marketing, khách hàng, sản phẩm hay thu hút nhân tài của doanh nghiệp.

Chiến Lược Dữ Liệu không chỉ phù hợp cho người bước đầu làm quen với dữ liệu, mà còn cung cấp nhịp điệu bao quát về những thay đổi đang diễn ra trên thị trường và trang bị nền tảng ban đầu cho người đang chịu trách nhiệm về mảng dữ liệu của doanh nghiệp.', 1, N'A-200', N'100000030.jpg', 1)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000031', N'1000010', 1, N'3', 6, N'0', N'Data Strategy - Chiến Lược Dữ Liệu', 272, 79000, 2019, 9, 10, N'Data Strategy - Chiến Lược Dữ Liệu

Dữ liệu đang thay đổi cách chúng ta sống và làm việc với tốc độ chưa từng có. Nó là tất cả dấu vết ta để lại khi lướt web, mua hàng qua thẻ tín dụng, gửi e-mail, chụp ảnh, đọc báo trực tuyến, thậm chí dạo phố khi mang theo điện thoại di động hoặc đi trong khu vực có hệ thống .

Nhờ vào dữ liệu, nhà bán lẻ Target tại Mỹ đã dự đoán đúng một thiếu nữ đang mang thai dựa trên thói quen mua hàng của cô ấy; Google có thể hiển thị chính xác quảng cáo phù hợp với bạn; Facebook biết bạn của bạn là ai, bạn đang trong mối quan hệ với người nào, dự đoán được mối quan hệ này kéo dài trong bao lâu, khi nào bạn sẽ có một mối quan hệ tình cảm, thậm chí cho biết mức độ thông minh của bạn…

Tuy nhiên, hiện có chưa đến 0,5% dữ liệu được phân tích và sử dụng. Nhận thấy mảnh đất màu mỡ này, Bernard Marr đã cho ra đời Chiến Lược Dữ Liệu - nơi hội tụ những kiến thức về dữ liệu được đơn giản hóa với nhiều ví dụ dễ hiểu - cung cấp cho bạn cách thức tối đa hóa sức mạnh của dữ liệu bên cạnh việc tránh những rắc rối liên quan đến pháp lý, danh tiếng và tài chính.

Tầm quan trọng của chiến lược dữ liệu ngày càng được khẳng định qua thành công của các doanh nghiệp hoạt động trên nền tảng dữ liệu như Alphabet, Facebook, Narrative Science, Amazon, Apple… Việc có một chiến lược dữ liệu mạnh và lộ trình khoa học đã trở thành một phần tất yếu trong ADN của mỗi tổ chức. Nó xứng đáng nhận được sự quan tâm ngang với chiến lược marketing, khách hàng, sản phẩm hay thu hút nhân tài của doanh nghiệp.

Chiến Lược Dữ Liệu không chỉ phù hợp cho người bước đầu làm quen với dữ liệu, mà còn cung cấp nhịp điệu bao quát về những thay đổi đang diễn ra trên thị trường và trang bị nền tảng ban đầu cho người đang chịu trách nhiệm về mảng dữ liệu của doanh nghiệp.', 1, N'A-200', N'100000031.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000032', N'1000011', 1, N'1', 5, N'0', N'Định Vị (Tái Bản 2018)', 352, 117000, 2018, 8, 9, N'ịnh vị sẽ cho bạn biết:

- Giá thấp nhất, tốc độ phải cao.

- Ai chơi giỏi hơn, kẻ đó sẽ tồn tại.

- Đừng đối đầu với những kẻ dẫn đầu vững vàng.

- Sản phẩm khác biệt chỉ dành cho những người khác biệt.

- Thường xuyên rà soát từng thị trường như một vị trướng khảo sát trận địa.

- Bạn cần tầm nhìn, lòng can đảm, sự khách quan, sự đơn giản nhưng không thể thiếu sự tinh tế.', 1, N'B-500', N'100000032.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000033', N'1000011', 1, N'2', 5, N'0', N'Định Vị (Tái Bản 2018)', 352, 117000, 2018, 8, 9, N'ịnh vị sẽ cho bạn biết:

- Giá thấp nhất, tốc độ phải cao.

- Ai chơi giỏi hơn, kẻ đó sẽ tồn tại.

- Đừng đối đầu với những kẻ dẫn đầu vững vàng.

- Sản phẩm khác biệt chỉ dành cho những người khác biệt.

- Thường xuyên rà soát từng thị trường như một vị trướng khảo sát trận địa.

- Bạn cần tầm nhìn, lòng can đảm, sự khách quan, sự đơn giản nhưng không thể thiếu sự tinh tế.', 1, N'B-500', N'100000033.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000034', N'1000011', 1, N'3', 5, N'0', N'Định Vị (Tái Bản 2018)', 352, 117000, 2018, 8, 9, N'ịnh vị sẽ cho bạn biết:

- Giá thấp nhất, tốc độ phải cao.

- Ai chơi giỏi hơn, kẻ đó sẽ tồn tại.

- Đừng đối đầu với những kẻ dẫn đầu vững vàng.

- Sản phẩm khác biệt chỉ dành cho những người khác biệt.

- Thường xuyên rà soát từng thị trường như một vị trướng khảo sát trận địa.

- Bạn cần tầm nhìn, lòng can đảm, sự khách quan, sự đơn giản nhưng không thể thiếu sự tinh tế.', 1, N'B-500', N'100000034.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000035', N'1000011', 1, N'4', 5, N'0', N'Định Vị (Tái Bản 2018)', 352, 117000, 2018, 8, 9, N'ịnh vị sẽ cho bạn biết:

- Giá thấp nhất, tốc độ phải cao.

- Ai chơi giỏi hơn, kẻ đó sẽ tồn tại.

- Đừng đối đầu với những kẻ dẫn đầu vững vàng.

- Sản phẩm khác biệt chỉ dành cho những người khác biệt.

- Thường xuyên rà soát từng thị trường như một vị trướng khảo sát trận địa.

- Bạn cần tầm nhìn, lòng can đảm, sự khách quan, sự đơn giản nhưng không thể thiếu sự tinh tế.', 1, N'B-500', N'100000035.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000036', N'1000011', 1, N'5', 5, N'0', N'Định Vị (Tái Bản 2018)', 352, 117000, 2018, 8, 9, N'ịnh vị sẽ cho bạn biết:

- Giá thấp nhất, tốc độ phải cao.

- Ai chơi giỏi hơn, kẻ đó sẽ tồn tại.

- Đừng đối đầu với những kẻ dẫn đầu vững vàng.

- Sản phẩm khác biệt chỉ dành cho những người khác biệt.

- Thường xuyên rà soát từng thị trường như một vị trướng khảo sát trận địa.

- Bạn cần tầm nhìn, lòng can đảm, sự khách quan, sự đơn giản nhưng không thể thiếu sự tinh tế.', 1, N'B-500', N'100000036.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000037', N'1000012', 1, N'1', 6, N'0', N'Bí Mật Dotcom', 292, 135000, 2018, 9, 10, N'Bạn đang cầm trên tay cuốn sách này, chắc hẳn bạn đang quan tâm tìm hiểu, khám phá những sức mạnh và những tiềm năng vô hạn của thế giới Dotcom. Và tôi tin rằng - những Bí Mật được tiết lộ trong cuốn sách này sẽ làm cho bạn thỏa mãn với điều đó. Bí Mật Dotcom là cuốn sách ĐẦU TIÊN, chân thực nhất tiết lộ cho bạn biết về cách thức mà các chuyên gia Marketing trên Internet đã kiếm về hàng triệu đô từ Internet như thế nào. Những bí mật này thông thường không được tiết lộ. Và bạn cũng sẽ biết cách để áp dụng những kiến thức này để thay đổi cuộc sống tài chính của bạn.

Lần đầu đọc Bí Mật Dotcom tôi đã thấy rất nhiều sự khác biệt và giá trị của cuốn sách mang đến cho tôi quả thực là vô giá. Chỉ trong vòng chưa đầy một tháng tôi đã quyết định thay đổi toàn bộ chiến lược để áp dụng theo cách mà tác giả trình bày trong cuốn sách này. Và bạn có tin, mọi thứ trong công việc kinh doanh của tôi thay đổi. Từ định vị lại giá trị sản phẩm của mình, thay đổi đối tượng khách hàng mục tiêu, cách tiếp cận, cách chào hàng và chốt đơn hàng….. mọi thứ đều được thay đổi theo những gì Bí Mật Dotcom hướng dẫn và kết quả tôi nhận được thì trên cả tuyệt vời.', 1, N'A-200', N'100000037.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000038', N'1000012', 1, N'2', 6, N'0', N'Bí Mật Dotcom', 292, 135000, 2018, 9, 10, N'Bạn đang cầm trên tay cuốn sách này, chắc hẳn bạn đang quan tâm tìm hiểu, khám phá những sức mạnh và những tiềm năng vô hạn của thế giới Dotcom. Và tôi tin rằng - những Bí Mật được tiết lộ trong cuốn sách này sẽ làm cho bạn thỏa mãn với điều đó. Bí Mật Dotcom là cuốn sách ĐẦU TIÊN, chân thực nhất tiết lộ cho bạn biết về cách thức mà các chuyên gia Marketing trên Internet đã kiếm về hàng triệu đô từ Internet như thế nào. Những bí mật này thông thường không được tiết lộ. Và bạn cũng sẽ biết cách để áp dụng những kiến thức này để thay đổi cuộc sống tài chính của bạn.

Lần đầu đọc Bí Mật Dotcom tôi đã thấy rất nhiều sự khác biệt và giá trị của cuốn sách mang đến cho tôi quả thực là vô giá. Chỉ trong vòng chưa đầy một tháng tôi đã quyết định thay đổi toàn bộ chiến lược để áp dụng theo cách mà tác giả trình bày trong cuốn sách này. Và bạn có tin, mọi thứ trong công việc kinh doanh của tôi thay đổi. Từ định vị lại giá trị sản phẩm của mình, thay đổi đối tượng khách hàng mục tiêu, cách tiếp cận, cách chào hàng và chốt đơn hàng….. mọi thứ đều được thay đổi theo những gì Bí Mật Dotcom hướng dẫn và kết quả tôi nhận được thì trên cả tuyệt vời.', 1, N'A-200', N'100000038.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000039', N'1000012', 1, N'0', 6, N'0', N'Bí Mật Dotcom', 292, 135000, 2018, 9, 10, N'Bạn đang cầm trên tay cuốn sách này, chắc hẳn bạn đang quan tâm tìm hiểu, khám phá những sức mạnh và những tiềm năng vô hạn của thế giới Dotcom. Và tôi tin rằng - những Bí Mật được tiết lộ trong cuốn sách này sẽ làm cho bạn thỏa mãn với điều đó. Bí Mật Dotcom là cuốn sách ĐẦU TIÊN, chân thực nhất tiết lộ cho bạn biết về cách thức mà các chuyên gia Marketing trên Internet đã kiếm về hàng triệu đô từ Internet như thế nào. Những bí mật này thông thường không được tiết lộ. Và bạn cũng sẽ biết cách để áp dụng những kiến thức này để thay đổi cuộc sống tài chính của bạn.

Lần đầu đọc Bí Mật Dotcom tôi đã thấy rất nhiều sự khác biệt và giá trị của cuốn sách mang đến cho tôi quả thực là vô giá. Chỉ trong vòng chưa đầy một tháng tôi đã quyết định thay đổi toàn bộ chiến lược để áp dụng theo cách mà tác giả trình bày trong cuốn sách này. Và bạn có tin, mọi thứ trong công việc kinh doanh của tôi thay đổi. Từ định vị lại giá trị sản phẩm của mình, thay đổi đối tượng khách hàng mục tiêu, cách tiếp cận, cách chào hàng và chốt đơn hàng….. mọi thứ đều được thay đổi theo những gì Bí Mật Dotcom hướng dẫn và kết quả tôi nhận được thì trên cả tuyệt vời.', 1, N'A-200', N'100000039.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000040', N'1000013', 1, N'1', 6, N'0', N'Moonwalking with Einstein: The Art and Science of Remembering Everything', 307, 267000, 2012, 10, 11, N'The blockbuster phenomenon that charts an amazing journey of the mind while revolutionizing our concept of memory 

An instant bestseller that is poised to become a classic, Moonwalking with Einstein recounts Joshua Foer''s yearlong quest to improve his memory under the tutelage of top -mental athletes.- He draws on cutting-edge research, a surprising cultural history of remembering, and venerable tricks of the mentalist''s trade to transform our understanding of human memory. From the United States Memory Championship to deep within the author''s own mind, this is an electrifying work of journalism that reminds us that, in every way that matters, we are the sum of our memories.', 1, N'B-500', N'100000040.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000041', N'1000013', 1, N'2', 6, N'0', N'Moonwalking with Einstein: The Art and Science of Remembering Everything', 307, 267000, 2012, 10, 11, N'The blockbuster phenomenon that charts an amazing journey of the mind while revolutionizing our concept of memory 

An instant bestseller that is poised to become a classic, Moonwalking with Einstein recounts Joshua Foer''s yearlong quest to improve his memory under the tutelage of top -mental athletes.- He draws on cutting-edge research, a surprising cultural history of remembering, and venerable tricks of the mentalist''s trade to transform our understanding of human memory. From the United States Memory Championship to deep within the author''s own mind, this is an electrifying work of journalism that reminds us that, in every way that matters, we are the sum of our memories.', 1, N'B-500', N'100000041.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000042', N'1000014', 1, N'1', 3, N'0', N'Thế Giới Phẳng - Tóm Lược Lịch Sử Thế Giới Thế Kỷ Xxi (Bản Cập Nhật Và Bổ Sung Hai Chương Mới Nhất - 2018)', 720, 279000, 2018, 1, 1, N'Trong xu thế toàn cầu hóa, việc tiếp cận và tham khảo những tri thức đương đại từ những nước đã phát triển về sự chuyển động của thế giới (đang ở bước ngoặt từ “tròn” sang “phẳng”, như cách nói của tác giả) có lẽ sẽ giúp chúng ta có thêm những thông tin bổ ích để có sự chủ động trong quá trình hội nhập. Với mục đích cung cấp và cập nhật những thông tin đang là sự kiện dẫn đầu có giá trị tham khảo, Nhà xuất bản Trẻ đã mua bản quyền và nay xin giới thiệu tới bạn đọc bản dịch Việt ngữ của THE WORLD IS FLAT - tác phẩm được xếp vào danh mục sách bán chạy nhất ở Mỹ (kể từ lần xuất bản đầu tiên tháng 4/ 2005 cho đến nay). Đây là bản dịch từ bản sách gốc mới nhất được sửa chữa, cập nhật và bổ sung hai chương mới nhất bởi chính tác giả. Xin trân trọng giới thiệu cùng bạn đọc.', 1, N'D-900', N'100000042.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000043', N'1000014', 1, N'2', 3, N'0', N'Thế Giới Phẳng - Tóm Lược Lịch Sử Thế Giới Thế Kỷ Xxi (Bản Cập Nhật Và Bổ Sung Hai Chương Mới Nhất - 2018)', 720, 279000, 2018, 1, 1, N'Trong xu thế toàn cầu hóa, việc tiếp cận và tham khảo những tri thức đương đại từ những nước đã phát triển về sự chuyển động của thế giới (đang ở bước ngoặt từ “tròn” sang “phẳng”, như cách nói của tác giả) có lẽ sẽ giúp chúng ta có thêm những thông tin bổ ích để có sự chủ động trong quá trình hội nhập. Với mục đích cung cấp và cập nhật những thông tin đang là sự kiện dẫn đầu có giá trị tham khảo, Nhà xuất bản Trẻ đã mua bản quyền và nay xin giới thiệu tới bạn đọc bản dịch Việt ngữ của THE WORLD IS FLAT - tác phẩm được xếp vào danh mục sách bán chạy nhất ở Mỹ (kể từ lần xuất bản đầu tiên tháng 4/ 2005 cho đến nay). Đây là bản dịch từ bản sách gốc mới nhất được sửa chữa, cập nhật và bổ sung hai chương mới nhất bởi chính tác giả. Xin trân trọng giới thiệu cùng bạn đọc.', 1, N'D-900', N'100000043.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000044', N'1000014', 1, N'3', 3, N'0', N'Thế Giới Phẳng - Tóm Lược Lịch Sử Thế Giới Thế Kỷ Xxi (Bản Cập Nhật Và Bổ Sung Hai Chương Mới Nhất - 2018)', 720, 279000, 2018, 1, 1, N'Trong xu thế toàn cầu hóa, việc tiếp cận và tham khảo những tri thức đương đại từ những nước đã phát triển về sự chuyển động của thế giới (đang ở bước ngoặt từ “tròn” sang “phẳng”, như cách nói của tác giả) có lẽ sẽ giúp chúng ta có thêm những thông tin bổ ích để có sự chủ động trong quá trình hội nhập. Với mục đích cung cấp và cập nhật những thông tin đang là sự kiện dẫn đầu có giá trị tham khảo, Nhà xuất bản Trẻ đã mua bản quyền và nay xin giới thiệu tới bạn đọc bản dịch Việt ngữ của THE WORLD IS FLAT - tác phẩm được xếp vào danh mục sách bán chạy nhất ở Mỹ (kể từ lần xuất bản đầu tiên tháng 4/ 2005 cho đến nay). Đây là bản dịch từ bản sách gốc mới nhất được sửa chữa, cập nhật và bổ sung hai chương mới nhất bởi chính tác giả. Xin trân trọng giới thiệu cùng bạn đọc.', 1, N'D-900', N'100000044.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000045', N'1000014', 1, N'4', 3, N'0', N'Thế Giới Phẳng - Tóm Lược Lịch Sử Thế Giới Thế Kỷ Xxi (Bản Cập Nhật Và Bổ Sung Hai Chương Mới Nhất - 2018)', 720, 279000, 2018, 1, 1, N'Trong xu thế toàn cầu hóa, việc tiếp cận và tham khảo những tri thức đương đại từ những nước đã phát triển về sự chuyển động của thế giới (đang ở bước ngoặt từ “tròn” sang “phẳng”, như cách nói của tác giả) có lẽ sẽ giúp chúng ta có thêm những thông tin bổ ích để có sự chủ động trong quá trình hội nhập. Với mục đích cung cấp và cập nhật những thông tin đang là sự kiện dẫn đầu có giá trị tham khảo, Nhà xuất bản Trẻ đã mua bản quyền và nay xin giới thiệu tới bạn đọc bản dịch Việt ngữ của THE WORLD IS FLAT - tác phẩm được xếp vào danh mục sách bán chạy nhất ở Mỹ (kể từ lần xuất bản đầu tiên tháng 4/ 2005 cho đến nay). Đây là bản dịch từ bản sách gốc mới nhất được sửa chữa, cập nhật và bổ sung hai chương mới nhất bởi chính tác giả. Xin trân trọng giới thiệu cùng bạn đọc.', 1, N'D-900', N'100000045.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000046', N'1000014', 1, N'5', 3, N'0', N'Thế Giới Phẳng - Tóm Lược Lịch Sử Thế Giới Thế Kỷ Xxi (Bản Cập Nhật Và Bổ Sung Hai Chương Mới Nhất - 2018)', 720, 279000, 2018, 1, 1, N'Trong xu thế toàn cầu hóa, việc tiếp cận và tham khảo những tri thức đương đại từ những nước đã phát triển về sự chuyển động của thế giới (đang ở bước ngoặt từ “tròn” sang “phẳng”, như cách nói của tác giả) có lẽ sẽ giúp chúng ta có thêm những thông tin bổ ích để có sự chủ động trong quá trình hội nhập. Với mục đích cung cấp và cập nhật những thông tin đang là sự kiện dẫn đầu có giá trị tham khảo, Nhà xuất bản Trẻ đã mua bản quyền và nay xin giới thiệu tới bạn đọc bản dịch Việt ngữ của THE WORLD IS FLAT - tác phẩm được xếp vào danh mục sách bán chạy nhất ở Mỹ (kể từ lần xuất bản đầu tiên tháng 4/ 2005 cho đến nay). Đây là bản dịch từ bản sách gốc mới nhất được sửa chữa, cập nhật và bổ sung hai chương mới nhất bởi chính tác giả. Xin trân trọng giới thiệu cùng bạn đọc.', 1, N'D-900', N'100000046.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000047', N'1000014', 1, N'6', 3, N'0', N'Thế Giới Phẳng - Tóm Lược Lịch Sử Thế Giới Thế Kỷ Xxi (Bản Cập Nhật Và Bổ Sung Hai Chương Mới Nhất - 2018)', 720, 279000, 2018, 1, 1, N'Trong xu thế toàn cầu hóa, việc tiếp cận và tham khảo những tri thức đương đại từ những nước đã phát triển về sự chuyển động của thế giới (đang ở bước ngoặt từ “tròn” sang “phẳng”, như cách nói của tác giả) có lẽ sẽ giúp chúng ta có thêm những thông tin bổ ích để có sự chủ động trong quá trình hội nhập. Với mục đích cung cấp và cập nhật những thông tin đang là sự kiện dẫn đầu có giá trị tham khảo, Nhà xuất bản Trẻ đã mua bản quyền và nay xin giới thiệu tới bạn đọc bản dịch Việt ngữ của THE WORLD IS FLAT - tác phẩm được xếp vào danh mục sách bán chạy nhất ở Mỹ (kể từ lần xuất bản đầu tiên tháng 4/ 2005 cho đến nay). Đây là bản dịch từ bản sách gốc mới nhất được sửa chữa, cập nhật và bổ sung hai chương mới nhất bởi chính tác giả. Xin trân trọng giới thiệu cùng bạn đọc.', 1, N'D-900', N'100000047.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000048', N'1000014', 1, N'7', 3, N'0', N'Thế Giới Phẳng - Tóm Lược Lịch Sử Thế Giới Thế Kỷ Xxi (Bản Cập Nhật Và Bổ Sung Hai Chương Mới Nhất - 2018)', 720, 279000, 2018, 1, 1, N'Trong xu thế toàn cầu hóa, việc tiếp cận và tham khảo những tri thức đương đại từ những nước đã phát triển về sự chuyển động của thế giới (đang ở bước ngoặt từ “tròn” sang “phẳng”, như cách nói của tác giả) có lẽ sẽ giúp chúng ta có thêm những thông tin bổ ích để có sự chủ động trong quá trình hội nhập. Với mục đích cung cấp và cập nhật những thông tin đang là sự kiện dẫn đầu có giá trị tham khảo, Nhà xuất bản Trẻ đã mua bản quyền và nay xin giới thiệu tới bạn đọc bản dịch Việt ngữ của THE WORLD IS FLAT - tác phẩm được xếp vào danh mục sách bán chạy nhất ở Mỹ (kể từ lần xuất bản đầu tiên tháng 4/ 2005 cho đến nay). Đây là bản dịch từ bản sách gốc mới nhất được sửa chữa, cập nhật và bổ sung hai chương mới nhất bởi chính tác giả. Xin trân trọng giới thiệu cùng bạn đọc.', 1, N'D-900', N'100000048.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000049', N'1000014', 1, N'8', 3, N'0', N'Thế Giới Phẳng - Tóm Lược Lịch Sử Thế Giới Thế Kỷ Xxi (Bản Cập Nhật Và Bổ Sung Hai Chương Mới Nhất - 2018)', 720, 279000, 2018, 1, 1, N'Trong xu thế toàn cầu hóa, việc tiếp cận và tham khảo những tri thức đương đại từ những nước đã phát triển về sự chuyển động của thế giới (đang ở bước ngoặt từ “tròn” sang “phẳng”, như cách nói của tác giả) có lẽ sẽ giúp chúng ta có thêm những thông tin bổ ích để có sự chủ động trong quá trình hội nhập. Với mục đích cung cấp và cập nhật những thông tin đang là sự kiện dẫn đầu có giá trị tham khảo, Nhà xuất bản Trẻ đã mua bản quyền và nay xin giới thiệu tới bạn đọc bản dịch Việt ngữ của THE WORLD IS FLAT - tác phẩm được xếp vào danh mục sách bán chạy nhất ở Mỹ (kể từ lần xuất bản đầu tiên tháng 4/ 2005 cho đến nay). Đây là bản dịch từ bản sách gốc mới nhất được sửa chữa, cập nhật và bổ sung hai chương mới nhất bởi chính tác giả. Xin trân trọng giới thiệu cùng bạn đọc.', 1, N'D-900', N'100000049.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000050', N'1000014', 1, N'1', 3, N'0', N'Thế Giới Phẳng - Tóm Lược Lịch Sử Thế Giới Thế Kỷ Xxi (Bản Cập Nhật Và Bổ Sung Hai Chương Mới Nhất - 2018)', 720, 279000, 2018, 1, 1, N'Trong xu thế toàn cầu hóa, việc tiếp cận và tham khảo những tri thức đương đại từ những nước đã phát triển về sự chuyển động của thế giới (đang ở bước ngoặt từ “tròn” sang “phẳng”, như cách nói của tác giả) có lẽ sẽ giúp chúng ta có thêm những thông tin bổ ích để có sự chủ động trong quá trình hội nhập. Với mục đích cung cấp và cập nhật những thông tin đang là sự kiện dẫn đầu có giá trị tham khảo, Nhà xuất bản Trẻ đã mua bản quyền và nay xin giới thiệu tới bạn đọc bản dịch Việt ngữ của THE WORLD IS FLAT - tác phẩm được xếp vào danh mục sách bán chạy nhất ở Mỹ (kể từ lần xuất bản đầu tiên tháng 4/ 2005 cho đến nay). Đây là bản dịch từ bản sách gốc mới nhất được sửa chữa, cập nhật và bổ sung hai chương mới nhất bởi chính tác giả. Xin trân trọng giới thiệu cùng bạn đọc.', 1, N'D-900', N'100000050.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000051', N'1000014', 1, N'2', 3, N'0', N'Thế Giới Phẳng - Tóm Lược Lịch Sử Thế Giới Thế Kỷ Xxi (Bản Cập Nhật Và Bổ Sung Hai Chương Mới Nhất - 2018)', 720, 279000, 2018, 1, 1, N'Trong xu thế toàn cầu hóa, việc tiếp cận và tham khảo những tri thức đương đại từ những nước đã phát triển về sự chuyển động của thế giới (đang ở bước ngoặt từ “tròn” sang “phẳng”, như cách nói của tác giả) có lẽ sẽ giúp chúng ta có thêm những thông tin bổ ích để có sự chủ động trong quá trình hội nhập. Với mục đích cung cấp và cập nhật những thông tin đang là sự kiện dẫn đầu có giá trị tham khảo, Nhà xuất bản Trẻ đã mua bản quyền và nay xin giới thiệu tới bạn đọc bản dịch Việt ngữ của THE WORLD IS FLAT - tác phẩm được xếp vào danh mục sách bán chạy nhất ở Mỹ (kể từ lần xuất bản đầu tiên tháng 4/ 2005 cho đến nay). Đây là bản dịch từ bản sách gốc mới nhất được sửa chữa, cập nhật và bổ sung hai chương mới nhất bởi chính tác giả. Xin trân trọng giới thiệu cùng bạn đọc.', 1, N'D-900', N'100000051.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000052', N'1000016', 1, N'1', 9, N'0', N'The Langmaster - Luyện Kỹ Năng Nghe-Nói-Đọc-Viết Tiếng Anh (Tái Bản 2018)', 312, 76000, 2018, 2, 2, N'The Langmaster - Luyện Kỹ Năng Nghe Nói Đọc Viết Tiếng Anh (Tái Bản 2018)

Học Tiếng Anh là một quá trình liên tục, trong đó 4 kỹ năng Nghe, Nói, Đọc và Viết là 4 kỹ năng bạn cần để giao tiếp hoặc sử dụng thành thạo bất cứ ngôn ngữ nào. Chỉ giỏi một trong những kỹ năng này sẽ không giúp bạn giao tiếp bằng tiếng Anh được. Ví dụ, bạn cần đọc tốt trước khi bạn có thể viết tốt. Bạn cũng cần nghe được trước khi bạn có thể nói được.', 1, N'B-400', N'100000052.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000053', N'1000016', 1, N'2', 9, N'0', N'The Langmaster - Luyện Kỹ Năng Nghe-Nói-Đọc-Viết Tiếng Anh (Tái Bản 2018)', 312, 76000, 2018, 2, 2, N'The Langmaster - Luyện Kỹ Năng Nghe Nói Đọc Viết Tiếng Anh (Tái Bản 2018)

Học Tiếng Anh là một quá trình liên tục, trong đó 4 kỹ năng Nghe, Nói, Đọc và Viết là 4 kỹ năng bạn cần để giao tiếp hoặc sử dụng thành thạo bất cứ ngôn ngữ nào. Chỉ giỏi một trong những kỹ năng này sẽ không giúp bạn giao tiếp bằng tiếng Anh được. Ví dụ, bạn cần đọc tốt trước khi bạn có thể viết tốt. Bạn cũng cần nghe được trước khi bạn có thể nói được.', 1, N'B-400', N'100000053.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000054', N'1000016', 1, N'3', 9, N'0', N'The Langmaster - Luyện Kỹ Năng Nghe-Nói-Đọc-Viết Tiếng Anh (Tái Bản 2018)', 312, 76000, 2018, 2, 2, N'The Langmaster - Luyện Kỹ Năng Nghe Nói Đọc Viết Tiếng Anh (Tái Bản 2018)

Học Tiếng Anh là một quá trình liên tục, trong đó 4 kỹ năng Nghe, Nói, Đọc và Viết là 4 kỹ năng bạn cần để giao tiếp hoặc sử dụng thành thạo bất cứ ngôn ngữ nào. Chỉ giỏi một trong những kỹ năng này sẽ không giúp bạn giao tiếp bằng tiếng Anh được. Ví dụ, bạn cần đọc tốt trước khi bạn có thể viết tốt. Bạn cũng cần nghe được trước khi bạn có thể nói được.', 1, N'B-400', N'100000054.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000055', N'1000016', 1, N'4', 9, N'0', N'The Langmaster - Luyện Kỹ Năng Nghe-Nói-Đọc-Viết Tiếng Anh (Tái Bản 2018)', 312, 76000, 2018, 2, 2, N'The Langmaster - Luyện Kỹ Năng Nghe Nói Đọc Viết Tiếng Anh (Tái Bản 2018)

Học Tiếng Anh là một quá trình liên tục, trong đó 4 kỹ năng Nghe, Nói, Đọc và Viết là 4 kỹ năng bạn cần để giao tiếp hoặc sử dụng thành thạo bất cứ ngôn ngữ nào. Chỉ giỏi một trong những kỹ năng này sẽ không giúp bạn giao tiếp bằng tiếng Anh được. Ví dụ, bạn cần đọc tốt trước khi bạn có thể viết tốt. Bạn cũng cần nghe được trước khi bạn có thể nói được.', 1, N'B-400', N'100000055.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000056', N'1000017', 1, N'1', 6, N'0', N'Enzyme Chống Lão Hóa (Tái Bản 2020)', 209, 120000, 2020, 3, 12, N'Enzyme Chống Lão Hóa

Theo thống kê mới nhất của Bộ Y tế, hiện nay mỗi năm Việt Nam có 70.000 người chết vì ung thư và hơn 200.000 ca mắc bệnh mới. Ngoài ra những bệnh khác như: tiểu đường, tim mạch, huyết áp, đột quỵ, béo phì, Alzheimer ngày một gia tăng và trở thành gánh nặng cho cả gia đình, xã hội. Điều đặc biệt là nguyên nhân dẫn đến hầu hết các căn bệnh này bắt nguồn từ phong cách sống, thói quen ăn uống hàng ngày của từng bệnh nhân.

Trong cuốn sách Điều trị ung thư của bác học Golzen người Đức có đoạn nói rằng: “Ung thư là sự trả thù của tự nhiên, bởi con người sử dụng thức ăn sai lầm. Trong 10.000 trường hợp ung thư thì 9.999 trường hợp là do sự đầu độc từ phân của chính mình. Chỉ có 1 trường hợp là do sự biến đổi thoái hóa mà thôi”.', 1, N'B-300', N'100000056.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000057', N'1000017', 1, N'2', 6, N'0', N'Enzyme Chống Lão Hóa (Tái Bản 2020)', 209, 120000, 2020, 3, 12, N'Enzyme Chống Lão Hóa

Theo thống kê mới nhất của Bộ Y tế, hiện nay mỗi năm Việt Nam có 70.000 người chết vì ung thư và hơn 200.000 ca mắc bệnh mới. Ngoài ra những bệnh khác như: tiểu đường, tim mạch, huyết áp, đột quỵ, béo phì, Alzheimer ngày một gia tăng và trở thành gánh nặng cho cả gia đình, xã hội. Điều đặc biệt là nguyên nhân dẫn đến hầu hết các căn bệnh này bắt nguồn từ phong cách sống, thói quen ăn uống hàng ngày của từng bệnh nhân.

Trong cuốn sách Điều trị ung thư của bác học Golzen người Đức có đoạn nói rằng: “Ung thư là sự trả thù của tự nhiên, bởi con người sử dụng thức ăn sai lầm. Trong 10.000 trường hợp ung thư thì 9.999 trường hợp là do sự đầu độc từ phân của chính mình. Chỉ có 1 trường hợp là do sự biến đổi thoái hóa mà thôi”.', 1, N'B-300', N'100000057.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000058', N'1000017', 1, N'3', 6, N'0', N'Enzyme Chống Lão Hóa (Tái Bản 2020)', 209, 120000, 2020, 3, 12, N'Enzyme Chống Lão Hóa

Theo thống kê mới nhất của Bộ Y tế, hiện nay mỗi năm Việt Nam có 70.000 người chết vì ung thư và hơn 200.000 ca mắc bệnh mới. Ngoài ra những bệnh khác như: tiểu đường, tim mạch, huyết áp, đột quỵ, béo phì, Alzheimer ngày một gia tăng và trở thành gánh nặng cho cả gia đình, xã hội. Điều đặc biệt là nguyên nhân dẫn đến hầu hết các căn bệnh này bắt nguồn từ phong cách sống, thói quen ăn uống hàng ngày của từng bệnh nhân.

Trong cuốn sách Điều trị ung thư của bác học Golzen người Đức có đoạn nói rằng: “Ung thư là sự trả thù của tự nhiên, bởi con người sử dụng thức ăn sai lầm. Trong 10.000 trường hợp ung thư thì 9.999 trường hợp là do sự đầu độc từ phân của chính mình. Chỉ có 1 trường hợp là do sự biến đổi thoái hóa mà thôi”.', 1, N'B-300', N'100000058.jpg', 0)
SET IDENTITY_INSERT [dbo].[TINTUC] ON 

INSERT [dbo].[TINTUC] ([MaTinTuc], [MaLoaiTinTuc], [TieuDe], [MoTaNgan], [NoiDung], [NgayTao], [NguoiLap], [HinhAnh], [SoLuongLuotXem], [HienThiTrangChu], [TinhTrangXoa], [Logo]) VALUES (1, 2, N'Thông báo Lịch nghỉ Tết Dương lịch & Tết Nguyên đán Tân Sửu 2021', N'Căn cứ Thông báo số 975/TB-DCT ngày 02/12/2020 của trường Đại học Công nghiệp Thực phẩm TP. Hồ Chí Minh về việc nghỉ Tết Dương lịch 2021 và Tết Nguyên đán Tân Sửu 2021. ', N'<p>123123123</p>', CAST(0x07420B00 AS Date), 10000001, NULL, 5, 1, 0, N'1.jpg')
INSERT [dbo].[TINTUC] ([MaTinTuc], [MaLoaiTinTuc], [TieuDe], [MoTaNgan], [NoiDung], [NgayTao], [NguoiLap], [HinhAnh], [SoLuongLuotXem], [HienThiTrangChu], [TinhTrangXoa], [Logo]) VALUES (2, 1, N'Giải thưởng dành cho nhà vô địch cuộc thi “Best University Library” – HUFI Library', N'Vượt qua hơn 200 trường Đại học, Cao đẳng trên toàn quốc, Trung tâm Thông tin – Thư viện Trường Đại học Công nghiệp thực phẩm TP. Hồ Chí Minh (HUFI Library) đã chính thức giành quán quân trong cuộc thi “Best University Library – Thư viện được yêu thích nhất năm 2020” được tổ chức từ ngày 20/07/2020 – 18/08/2020 do Top Sinh viên tổ chức với đơn vị bảo trợ là Quỹ Hỗ trợ phát triển Thanh niên (FYE).', N'<p>&nbsp;Sáng ngày 30 tháng 09 năm 2020, Trường Đại học Công nghiệp thực phẩm TP. Hồ Chí Minh vinh dự nhận giải thưởng từ Ban tổ chức cuộc thi “<i>Best University Library</i>”. Giải thưởng bao gồm: 01 chiếc Cup vô cùng ấn tượng và sang trọng dành cho nhà vô địch; 10 ghế đá có biểu tượng của HUFI, logo của Ban tổ chức và các Nhà tài trợ; cùng 300 cuốn sách cực hay và hấp dẫn, hứa hẹn sẽ là nguồn tài liệu tham khảo hữu ích cho sinh viên HUFI trong thời gian tới!</p><p>&nbsp;</p><p>Để vượt qua những vòng bình chọn vô cùng gây cấn, hấp dẫn và tiến tới giành ngôi vô địch, HUFI Library đã nhận được sự ủng hộ hết sức nhiệt tình của tập thể cán bộ, giảng viên và sinh viên trong toàn trường. Tất cả đều không ngần ngại sẵn sàng cùng nhau bàn bạc, thảo luận, thức tới đêm muộn để VOTE cho Thư viện HUFI vượt qua những đối thủ cạnh tranh nặng ký và đạt được thành tích cao nhất; mỗi vòng đấu của cuộc thi đều là những giây phút cực kỳ hồi hộp và đầy ý nghĩa, đặc biệt là vào giờ phút cuối cùng của trận đấu, mọi người cùng háo hức chờ đợi trong không khí vô cùng khẩn trương, đợi đến giờ được công bố tên và bước vào vòng trong. Thực sự cảm giác ấy giống như tất cả đang nín thở để chờ đợi giây phút giao thừa hàng năm – thời khắc chuyển giao giữa năm cũ và năm mới cực kỳ thiêng liêng và xúc động! Và khi tên Thư viện HUFI được xướng lên, tất cả như vỡ òa trong niềm hạnh phúc… Kết quả chung kết của cuộc thi với ngôi vị cao nhất thuộc về HUFI Library minh chứng cho tình đoàn kết, sự đồng lòng, quyết tâm và tình yêu mãnh liệt của mỗi cá nhân dành cho Ngôi nhà chung - Trường Đại học Công nghiệp thực phẩm TP. Hồ Chí Minh và tình yêu ấy như được lan tỏa và đong đầy hơn bao giờ hết. Kết quả này cũng là nguồn động viên xứng đáng cho những nỗ lực, cố gắng của tập thể cán bộ, giảng viên và sinh viên của HUFI. Chính chúng ta là những người đã góp phần to lớn vào kết quả chung cuộc. Một lần nữa, HUFI Library xin gửi lời cảm ơn sâu sắc nhất tới toàn thể cán bộ, giảng viên và sinh viên đã hết lòng ủng hộ, bầu chọn cho Thư viện HUFI trong suốt thời gian qua.</p><p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Giờ đây, khi đã được khoác lên “tấm áo” mới, Thư viện HUFI như đã hoàn toàn “thay da đổi thịt”. HUFI Library không còn là một Thư viện truyền thống đơn thuần, mà đã thực sự trở thành một điểm đến hấp dẫn của cán bộ, giảng viên và sinh viên trong và ngoài trường với không gian học tập rộng rãi, thoáng mát, tiện nghi cùng trang thiết bị hiện đại và được nhiều người ví von là một trung tâm thương mại hiện đại khi về đêm. Điều này cho thấy sự ủng hộ hết mình của mọi người dành cho HUFI Library là vô cùng xứng đáng. Hãy cùng nhìn lại hình ảnh đẹp của Thư viện HUFI và cùng tự hào về ngôi vị quán quân của cuộc thi “<i>Best University Library</i>” nhé!</p>', CAST(0x07420B00 AS Date), 10000001, NULL, 19, 1, 0, N'2.png')
INSERT [dbo].[TINTUC] ([MaTinTuc], [MaLoaiTinTuc], [TieuDe], [MoTaNgan], [NoiDung], [NgayTao], [NguoiLap], [HinhAnh], [SoLuongLuotXem], [HienThiTrangChu], [TinhTrangXoa], [Logo]) VALUES (3, 2, N'Khảo sát lấy ý kiến phản hồi của người sử dụng về hoạt động thư viện', N'Nhằm nâng cao hiệu quả phục vụ, đồng thời đáp ứng ngày càng tốt hơn nhu cầu về tài liệu học tập, nghiên cứu của cán bộ, giảng viên, học viên và sinh viên. Thư viện HUFI tiến hành khảo sát lấy ý kiến phản hồi của người sử dụng về hiện trạng của thư viện.', N'<p>Nhằm nâng cao hiệu quả phục vụ, đồng thời đáp ứng ngày càng tốt hơn nhu cầu về tài liệu học tập, nghiên cứu của cán bộ, giảng viên, học viên và sinh viên. Thư viện HUFI tiến hành khảo sát lấy ý kiến phản hồi của người sử dụng về hiện trạng của thư viện.</p><p>Các ý kiến của người sử dụng sẽ giúp Thư viện cải thiện và nâng cao hiệu quả hoạt động, phục vụ người dùng tốt hơn trong thời gian tới.</p><p>§&nbsp; Thời gian khảo sát: Từ ngày 04/1/2021 đến hết ngày 15/1/202</p><p>§&nbsp; Hình thức khảo sát online:</p><p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;+ Cách 1: Truy cập vào Cổng thông tin thư viện <a href="https://l.facebook.com/l.php?u=https%3A%2F%2Fthuvien.hufi.edu.vn%2F%3Ffbclid%3DIwAR3AUNTcEJ2buapaN2jv2kIra1y7M6DrKUGdsOmed-ZwUz5z9NCOFlDxKdA&amp;h=AT3xlPtkUnrXYIuUd4_VM7trXkMmJF7g5uw31ZT2OANalWZmTSwLatpvCNWYueHvKoBMDgNqgQAY-_HpVUe2cEp8FV66DSVNxA9ZlocqirxiX8iUXOUNEypc8GKSY7mRhygd&amp;__tn__=-UK-R&amp;c%5b0%5d=AT3bOgPwVP5u9MHZosD-zwTXdGoyZeapZ74iBRjnqiIFPQj0J4Vndc2DjfiECeMMBy9ooUUT5Q4O0nh6PcskX3kl1oKM29UaqTz9f7d7vUlGp76uLNDC_kZ-M3QdMLEgUHbYjeKKlGJ-_vWEvnggrhR9uxipYn7fAMtOkPUdt_tjiwLSDdn5xSX1briUOVN15FVGVdPnPbGvA9QW8XTr8_qpmA">https://thuvien.hufi.edu.vn</a> và chọn “ĐÁNH GIÁ THƯ VIỆN”</p><p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;+ Cách 2: Truy cập vào link <a href="https://docs.google.com/forms/d/e/1FAIpQLSesSPtu6M7XYoBTHUZzZEB4JlYh17lqC8lBVGwM-2gc5noC9A/viewform?fbclid=IwAR3IqyWqN_edrw-JL2_M0eryPN69i-Ps2TruCBIJjcjCmUMt4Iapi3_O6Ow">https://docs.google.com/.../1FAIpQLSesSPtu6M7XYo.../viewform</a></p><p>Thư viện HUFI rất mong nhận được sự đóng góp ý kiến từ Quý bạn đọc.</p><p>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;Trân trọng cảm ơn!</p>', CAST(0x07420B00 AS Date), 10000001, NULL, 0, 1, 0, N'3.png')
INSERT [dbo].[TINTUC] ([MaTinTuc], [MaLoaiTinTuc], [TieuDe], [MoTaNgan], [NoiDung], [NgayTao], [NguoiLap], [HinhAnh], [SoLuongLuotXem], [HienThiTrangChu], [TinhTrangXoa], [Logo]) VALUES (4, 2, N'NGUỒN TÀI LIỆU FREE - trợ thủ đắc lực để bạn phát huy năng lực tự học!!!!', N' Trong bối cảnh dịch bệnh viêm phổi do chủng mới vi rút corona (COVID-19) đang diễn biến phức tạp, hưởng ứng các khuyến cáo về an toàn sức khoẻ cho nhân dân của Chính phủ; Hưởng ứng lời kêu gọi của Tổng Bí thư, Chủ tịch nước Nguyễn Phú Trọng, sự chỉ đạo của Đảng, Nhà nước, ngành thư viện cần tích cực góp phần tuyên tuyền về phòng chống dịch bệnh và giúp người đọc có thể sử dụng thời gian ở nhà của mình một cách hiệu quả hữu ích qua việc ', N'<p>ác cơ sở dữ liệu này là trợ thủ đắc lực để các bạn phát huy năng lực tự học. Với dung lượng dữ liệu khổng lồ này sẽ thoả mãn sự tìm tòi khám phá của các bạn.</p><p>Hướng dẫn chi tiết cách đăng nhập cho từng CSDL:</p><p>&nbsp; <i><strong>1.&nbsp; &nbsp;KHAI THÁC TÀI LIỆU TRÊN CỔNG THÔNG TIN THƯ VIỆN HUFI</strong></i></p><p>&nbsp; &nbsp; &nbsp; &nbsp;Địa chỉ truy cập:&nbsp;<a href="http://thuvien.hufi.edu.vn/"><i>http://thuvien.hufi.edu.vn/</i></a>&nbsp;</p><p><i><strong>2.&nbsp; &nbsp;THƯ VIỆN SỐ HUF</strong></i></p><p>&nbsp; &nbsp; &nbsp; Địa chỉ truy cập:&nbsp;<a href="http://thuvienso.cntp.edu.vn/"><i>http://thuvienso.cntp.edu.vn/</i></a>&nbsp;</p><p>-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <i>Tên đăng nhập&nbsp; =&nbsp; Mã số sinh viên;</i></p><p>-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <i>Mật khẩu&nbsp; =&nbsp; Mã số sinh viên</i></p><p><i><strong>3.&nbsp; &nbsp;CƠ SỞ DỮ LIỆU KHOA HỌC VÀ CÔNG NGHỆ STINET</strong></i></p><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Địa chỉ truy cập:&nbsp;<a href="http://stinet.gov.vn/"><i>http://stinet.gov.vn/</i></a>&nbsp;<br>&nbsp;</p><h4><i>&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; (Người sử dụng truy cập đến các tài liệu toàn văn&nbsp;theo&nbsp;cơ chế mở, hoàn toàn miễn phí)</i></h4><p><i><strong>4.&nbsp;&nbsp; CƠ SỞ DỮ LIỆU&nbsp;CỦA CỤC THÔNG TIN KHOA HỌC VÀ CÔNG NGHỆ QUỐC GIA</strong></i></p><p>&nbsp; &nbsp; &nbsp; Địa chỉ truy cập:<strong>&nbsp;</strong><a href="http://db.vista.gov.vn/"><i>http://db.vista.gov.vn/</i></a>&nbsp;&nbsp;</p><p>-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <i>Tên đăng nhập&nbsp; =&nbsp; vansang;</i></p><p>-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <i>Mật khẩu&nbsp; =&nbsp; library</i></p><p><i>(Đây là tài khoản chung cho tất cả người sử dụng, vui lòng không thay đổi mật khẩu)</i></p><p><i><strong>5.&nbsp;&nbsp; CƠ SỞ DỮ LIỆU&nbsp;TẠP CHÍ&nbsp; CHUYÊN NGÀNH KHOA HỌC VÀ CÔNG NGHỆ TRONG NƯỚC</strong></i></p><p>&nbsp; &nbsp; &nbsp;Địa chỉ truy cập:<strong>&nbsp;</strong><a href="http://www.cesti.gov.vn/thu-vien/7/tap-chi-chuyen-nganh-khcn"><i>http://www.cesti.gov.vn/thu-vien/7/tap-chi-chuyen-nganh-khcn</i></a>&nbsp;&nbsp;</p><p>-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <i>Tên đăng nhập&nbsp; <strong>=&nbsp; </strong>hufilib;</i></p><p>-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <i>Mật khẩu&nbsp;&nbsp; <strong>=&nbsp; </strong>library</i></p><p><i><strong>6.&nbsp;&nbsp; CƠ SỞ DỮ LIỆU&nbsp;PHÁP LUẬT VIỆT NAM</strong></i></p><p>&nbsp; &nbsp; &nbsp; Địa chỉ truy cập:<i>&nbsp;</i><a href="https://thuvienphapluat.vn/"><i>https://thuvienphapluat.vn/</i></a>&nbsp;&nbsp;</p><p>-&nbsp; &nbsp; &nbsp; &nbsp;<i>Tên đăng nhập&nbsp; <strong>=&nbsp; </strong>hufilib;</i></p><p>-&nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<i>Mật khẩu&nbsp;&nbsp; <strong>=&nbsp; </strong>library</i></p><p><i><strong>7.&nbsp;&nbsp; CƠ SỞ DỮ LIỆU TIÊU CHUẨN VIỆT NAM</strong></i></p><p>Địa chỉ truy cập:<i>&nbsp;</i><a href="http://cesti.gov.vn/thu-vien/4/tieu-chuan"><i>http://cesti.gov.vn/thu-vien/4/tieu-chuan</i></a></p><p>-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <i>Tên đăng nhập&nbsp; <strong>=&nbsp; </strong>dhspkt;</i></p><p>-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <i>Mật khẩu&nbsp;&nbsp; <strong>=&nbsp; </strong>dhspkt</i></p><p><i><strong>8.&nbsp;&nbsp; KHO SÁCH EBOOK UTE</strong></i></p><p>Địa chỉ truy cập<i>:&nbsp;</i><a href="https://sachweb.com/dang-nhap.html"><i>https://sachweb.com/dang-nhap.html</i></a></p><p>-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <i>Tên đăng nhập <strong>= </strong>daihocsuphamkythuat;</i></p><p>-&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <i>Mật khẩu <strong>=&nbsp; </strong>daihocsuphamkythuat</i></p><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; (<i>Lưu ý</i> <i>cài đặt phần mềm hỗ trợ Flash để đọc online trên thiết bị)</i></p><p><i><strong>9.&nbsp;&nbsp; WEBSITE HỌC LIỆU MỞ NƯỚC NGOÀI</strong></i></p><p>Địa chỉ truy cập:<strong>&nbsp;</strong><a href="http://thuvien.hufi.edu.vn/Page/website-hoc-lieu-mo-nuoc-ngoai"><i>http://thuvien.hufi.edu.vn/Page/website-hoc-lieu-mo-nuoc-ngoai</i></a></p><p><i><strong>10.&nbsp;&nbsp; WEBSITE HỌC LIỆU MỞ TRONG NƯỚC</strong></i></p><p>&nbsp;Địa chỉ truy cập:<strong>&nbsp;</strong><a href="http://thuvien.hufi.edu.vn/Page/website-hoc-lieu-mo-trong-nuoc"><i>http://thuvien.hufi.edu.vn/Page/website-hoc-lieu-mo-trong-nuoc</i></a></p><p><i><strong>11.&nbsp;&nbsp; WEBSITE HỌC LIỆU MỞ CÁC TRƯỜNG ĐH TRÊN THẾ GIỚI</strong></i></p><p>Địa chỉ truy cập:<strong>&nbsp;</strong><a href="http://thuvien.hufi.edu.vn/Page/website-hoc-lieu-mo-cac-truong-dh-tren-the-gioi"><i>http://thuvien.hufi.edu.vn/Page/website-hoc-lieu-mo-cac-truong-dh-tren-the-gioi</i></a></p><p><strong>&nbsp;</strong></p><p><br>&nbsp;</p><p>§&nbsp; <strong>Trách nhiệm của người sử dụng</strong></p><p>-&nbsp;&nbsp; Tài liệu điện tử chỉ phục vụ mục đích học tập, nghiên cứu khoa học, mở mang tầm hiểu biết, giải trí lành mạnh,&nbsp;không được sử dụng vì các mục đích khác.</p><p>-&nbsp;&nbsp;&nbsp; Khi khai thác nguồn tài liệu điện tử phải tuân theo luật bản quyền.</p><p>-&nbsp;&nbsp;&nbsp; Không thay đổi Mật khẩu (Password) đã được cấp.</p><p>-&nbsp;&nbsp;&nbsp; Không được sử dụng các phần mềm để tải (download) dữ liệu một cách có hệ thống với số lượng lớn dưới bất kì mục đích nào.</p><p><br>&nbsp;</p><p>§&nbsp; <strong>Thông tin hỗ trợ</strong></p><p>-&nbsp;&nbsp;&nbsp; Điện thoại:<i>&nbsp;<strong>097 117 3837</strong></i>&nbsp;</p><p>-&nbsp; &nbsp; Email:<strong> </strong><i><strong>thuvien@hufi.edu.vn</strong></i></p>', CAST(0x07420B00 AS Date), 10000001, NULL, 0, 1, 0, N'4.png')
INSERT [dbo].[TINTUC] ([MaTinTuc], [MaLoaiTinTuc], [TieuDe], [MoTaNgan], [NoiDung], [NgayTao], [NguoiLap], [HinhAnh], [SoLuongLuotXem], [HienThiTrangChu], [TinhTrangXoa], [Logo]) VALUES (5, 2, N'Thông báo thời gian mở cửa phục vụ tại Thư viện vào đầu năm học 2020 - 2021', N'Căn cứ kế hoạch tổ chức nhập học các hệ chính quy năm học 2020 - 2021 của trường Đại học Công nghiệp Thực phẩm TP. HCM tại Thư viện. Thư viện thông báo đến Quý độc giả lịch hoạt động từ ngày  07/9 - 10/10/2020', N'<p>Căn cứ kế hoạch tổ chức nhập học các hệ chính quy năm học 2020 - 2021 của trường Đại học Công nghiệp Thực phẩm TP. HCM tại Thư viện. Thư viện thông báo đến Quý độc giả lịch hoạt động từ ngày&nbsp; 07/9 - 10/10/2020 như sau:</p><p>&nbsp;</p><p>Rất mong các bạn chú ý và sắp xếp thời gian học tập tại Thư viện được thuận lợi và tốt nhất.</p><p>Thư viện hân hạnh phục vụ Quý độc&nbsp;giả!<br>&nbsp;</p>', CAST(0x07420B00 AS Date), 10000001, NULL, 0, 1, 0, N'5.jpeg')
INSERT [dbo].[TINTUC] ([MaTinTuc], [MaLoaiTinTuc], [TieuDe], [MoTaNgan], [NoiDung], [NgayTao], [NguoiLap], [HinhAnh], [SoLuongLuotXem], [HienThiTrangChu], [TinhTrangXoa], [Logo]) VALUES (6, 2, N'Thông báo: Thay đổi thời gian mở cửa phục vụ tại Thư viện', N'Căn cứ vào nhu cầu, ý kiến góp ý của Người sử dụng về việc xin điều chỉnh thời gian phục vụ tại Thư viện. Thư viện thông báo đến toàn thể giảng viên, cán bộ, viên chức, học viên và sinh viên về thời gian mở cửa phục vụ cụ thể như sau:', N'<p>Căn cứ vào nhu cầu, ý kiến góp ý của Người sử dụng về việc xin điều chỉnh thời gian phục vụ tại Thư viện. Thư viện thông báo đến toàn thể giảng viên, cán bộ, viên chức, học viên và sinh viên về thời gian mở cửa phục vụ cụ thể như sau:</p><p>&nbsp;</p><p>Rất mong Người sử dụng chú ý và sắp xếp thời gian học tập tại Thư viện được thuận lợi và tốt nhất.</p>', CAST(0x07420B00 AS Date), 10000001, NULL, 0, 1, 0, N'6.png')
INSERT [dbo].[TINTUC] ([MaTinTuc], [MaLoaiTinTuc], [TieuDe], [MoTaNgan], [NoiDung], [NgayTao], [NguoiLap], [HinhAnh], [SoLuongLuotXem], [HienThiTrangChu], [TinhTrangXoa], [Logo]) VALUES (7, 1, N'HUFI Library - Quán quân cuộc thi Best University Library', N'“Best University Library” là cuộc thi bình chọn trường Đại học, Cao đẳng có thư viện được yêu thích nhất do Top Sinh Viên tổ chức với đơn vị bảo trợ là Quỹ Hỗ trợ Phát triển Thanh niên (FYE) cùng các đơn vị tài trợ như ACCA – Think Ahead (Hiệp hội Kế toán công chứng Anh quốc), Alpha Book,...', N'<p>“Best University Library” là cuộc thi bình chọn trường Đại học, Cao đẳng có thư viện được yêu thích nhất do Top Sinh Viên tổ chức với đơn vị bảo trợ là Quỹ Hỗ trợ Phát triển Thanh niên (FYE) cùng các đơn vị tài trợ như ACCA – Think Ahead (Hiệp hội Kế toán công chứng Anh quốc), Alpha Book,... Với mục đích tạo ra sân chơi bình đẳng, văn minh, lịch sự cho học sinh, sinh viên toàn quốc đồng thời cung cấp thông tin hữu ích của tất cả các trường Đại học đến với mọi người. Cuộc thi đã thu hút hơn 200 trường Đại học, Cao đẳng trên toàn quốc tham gia, trong đó HUFI LIBRARY (Thư viện trường Đại học Công nghiệp thực phẩm TP.HCM) cũng tham gia thi đấu.</p><p>&nbsp; &nbsp; &nbsp; &nbsp; Thư viện trường ĐH Công nghiệp thực phẩm TP.HCM hiện nay được xây dựng với tổng diện tích sử dụng trên 1.700 m2 gồm 4 tầng lầu được thiết kế theo mô hình Không gian học tập chung (Learning Commons) tiện nghi và thân thiện, đáp ứng được môi trường học tập, nghiên cứu chuyên nghiệp dành cho cán bộ viên chức, giảng viên, sinh viên trong trường và có thể phục vụ khoảng 600 người sử dụng cùng lúc.</p><p>&nbsp;</p><p>Với giải pháp quản lý theo công nghệ RFID thông qua việc sử dụng phần mềm quản lý đồng bộ và hệ thống các trang thiết bị hiện đại:<i> </i>hệ thống mượn trả sách tự động, cổng an ninh thư viện, chip RFID cho tài liệu,… Thư viện trường không chỉ hỗ trợ đắc lực trong quá trình kiểm soát lưu thông, mượn/trả tài liệu, sách báo mà còn nâng cao tính tự phục vụ, tạo sự riêng tư và chủ động cho người sử dụng.</p><p>&nbsp;</p><p>&nbsp; &nbsp; Bên cạnh trang thiết bị hiện đại, nội thất thư viện được thiết kế tinh tế, hài hòa với gam màu sáng chủ đạo tạo không gian sang trọng, đầy cảm hứng và sáng tạo… và điểm đặc biệt ở thư viện HUFI người sử dụng có thể tự lựa chọn một không gian lý tưởng dành cho mình từ đọc sách, học tập, làm việc nhóm, hội thảo, thực hành thuyết trình, trải nghiệm văn hóa…</p><p>&nbsp;</p><p>&nbsp;Thêm vào đó, để đáp ứng nhu cầu ngày càng cao của người sử dụng, thư viện đã không ngừng mở rộng nguồn tài nguyên thông tin, liên kết chia sẻ cơ sở dữ liệu trực tuyến trong và ngoài nước,…. giúp người dùng tin chủ động lựa chọn phương thức đọc, mượn tài liệu, nghiên cứu trực tiếp hay làm việc theo nhóm mọi lúc, mọi nơi.</p><p>&nbsp; &nbsp; &nbsp; Với những thế mạnh đó, HUFI LIBRARY tin rằng mình sẽ giành chiến thắng trong cuộc thi “Best University Library”. Cuộc thi không những thu hút nhiều trường Đại học, Cao đẳng tham gia mà còn được đông đảo giảng viên, sinh viên quan tâm bình chọn. Ấn tượng nhất là vòng Bán kết với hơn 18.000 lượt bầu chọn cho các đội thi, đây cũng là vòng đấu gây cấn, hấp dẫn và quan trọng nhất của cuộc thi. Cuối cùng, không ngoài dự liệu HUFI LIBRARY đã giành chiến thắng và trở thành “Thư Viện Được Yêu Thích Nhất Năm 2020”. Để làm nên chiến thắng vẻ vang đó, không thể không kể đến công sức của quý độc giả đã ngày đêm bầu chọn cho HUFI LIBRARY.</p>', CAST(0x07420B00 AS Date), 10000001, NULL, 1, 1, 0, N'7.jpeg')
INSERT [dbo].[TINTUC] ([MaTinTuc], [MaLoaiTinTuc], [TieuDe], [MoTaNgan], [NoiDung], [NgayTao], [NguoiLap], [HinhAnh], [SoLuongLuotXem], [HienThiTrangChu], [TinhTrangXoa], [Logo]) VALUES (8, 1, N'“Hội sách” – Sự kiện tôn vinh giá trị sách và quảng bá hình ảnh của Thư viện Trường ĐH Công nghiệp Thực phẩm TP. HCM', N'Từ ngày 07/05/2019 đến ngày 10/05/2019, Trung tâm Thông tin – Thư viện thuộc trường Đại ', N'<p>Để thực hiện được mục đích đó, Thư viện đã phối hợp cùng với các đơn vị là Công ty Cổ phần XNK &amp; PT Văn hóa CDIMEX và Công ty Cổ phần Sách ALPHA thực hiện việc trưng bày, triễn lãm hơn 1.000 nhan đề sách với khoảng 3.000 đầu sách thuộc nhiều thể loại như sách ngoại ngữ, văn học, khoa học thường thức, kỹ năng mềm ... thu hút hàng ngàn lượt tham quan của quý bạn đọc.</p><p>&nbsp;</p><p>Sáng 07/05/2019, chương trình giao lưu diễn giả chủ đề&nbsp; “Sách – Dám ước mơ, biết thực hiện”nằm trong khuôn khổ chuỗi hoạt động Tuần lễ sách được tổ chức ở hội trường lớn trường Đại học Công nghiệp thực phẩm TP. Hồ Chí Minh, với sự góp mặt của Người đẹp thể thao tại Hoa Hậu Hoàn Vũ 2017 – Ms. Huỳnh Tiên và chuyên gia đào tạo, quản trị nhân sự - Ms. Nông Vương Phi đã mang đến nhiều kiến thức bổ ích cho sinh viên. Thông qua chương trình, các bạn sinh viên được trải lòng nhiều hơn về những khó khăn của bản thân trên hành trình tìm đến ước mơ của mình. Trước những trăn trở của các bạn trẻ, diễn giả đã dành nhiều lời khuyên chân thành để giúp các bạn định hướng được con đường theo đuổi ước mơ. Bên cạnh đó, các bạn sinh viên còn được tiếp cận với nội dung chương trình Youth Leader của John C.Maxwell trên toàn cầu và nhận nhiều phần quà hấp dẫn từ phía Công ty Cổ phần Sách ALPHA.</p><p>&nbsp;</p><p>Hồi tháng 5/2019, trường Đại học Công nghiệp thực phẩm TP. Hồ Chí Minh đã long trọng khánh thành Trung tâm Thông tin – Thư viện mới, bên cạnh mục đích chính là tôn vinh giá trị của sách, Tuần lễ sách lần này cũng được tổ chức với mục đích giới thiệu cơ sở vật chất, không gian tiện ích của Thư viện đến với bạn đọc và mời tham vấn về việc xây dựng mô hình hợp tác giữa giảng viên và thư viện trong công tác giảng dạy, nghiên cứu để tìm ra giải pháp tối ưu nhất, phục vụ bạn đọc đạt hiệu quả cao nhất.</p><p>Song song đó, Tuần lễ sách còn là sân chơi bổ ích dành cho các bạn sinh viên với việc tổ chức cuộc thi xếp sách nghệ thuật, giúp các bạn phát huy được tính sáng tạo, khả năng trình bày, tuyên truyền về ý nghĩa của mô hình sách mà các bạn đã xếp. “Cuộc chiến cân tài cân sức” giữa các đội thi đã mang đến nhiều xúc cảm khó quên, những phút giây hồi hộp rồi vỡ òa hạnh phúc khi tìm ra đội thi xứng đáng nhất cho giải thưởng cao nhất.&nbsp;</p><h4>Không dừng lại ở đó, Tuần lễ sách còn có hoạt động trao tặng, trao đổi hơn 10.000 đầu sách của thư viện cho những bạn đọc có nhu cầu sử dụng. Đây là một hoạt động hết sức ý nghĩa, với mỗi cuốn sách được trao đi Thư viện hy vọng rằng bạn đọc sẽ có thêm nhiều kiến thức để giúp ích cho xã hội, và đặc biệt là luôn nuôi dưỡng một tình yêu với sách. Vì lẽ đó mà hoạt động trao tặng sách của Thư viện không những thu hút các bạn sinh viên mà ngay cả giảng viên nhà trường cũng nhiệt tình hưởng ứng, đó là một&nbsp; tín hiệu đáng mừng để Thư viện tiếp tục phát huy trong những sự kiện tiếp theo vì bạn đọc..&nbsp;</h4>', CAST(0x07420B00 AS Date), 10000001, NULL, 18, 1, 0, N'8.jpeg')
INSERT [dbo].[TINTUC] ([MaTinTuc], [MaLoaiTinTuc], [TieuDe], [MoTaNgan], [NoiDung], [NgayTao], [NguoiLap], [HinhAnh], [SoLuongLuotXem], [HienThiTrangChu], [TinhTrangXoa], [Logo]) VALUES (9, 1, N'Thông báo: Sử dụng mạng liên kết nguồn lực Thông tin KH & CN “STINET”', N'Nhằm hỗ trợ thêm nguồn tài liệu hữu ích phục vụ hoạt động nghiên cứu phát triển và đổi mới sáng tạo.  Hiện nay, Thư viện Trường đã tham gia xây dựng hệ thống liên kết nguồn lực thông tin khoa học và công nghệ TP.HCM tạo điều kiện thuận lợi cho cán bộ nghiên cứu - giảng dạy, sinh viên tiếp cận, khai thác hiệu quả nguồn lực thông tin về kết quả thực hiện nhiệm vụ KH&CN, sách, giáo trình nội bộ, luận văn, luận án, tạp chí chuyên ngành KH&CN, tài liệu hội thảo,... Hiện hệ thống ', N'<p><i><strong>Để sử dụng,&nbsp;bạn đọc truy cập vào&nbsp;địa chỉ website</strong>&nbsp;<strong>thuvien.hufi.edu.vn → chọn&nbsp;mục&nbsp;&nbsp;“THÔNG TIN KH&amp;CN “STINET” hoặc&nbsp;</strong></i><a href="http://www.stinet.gov.vn/"><strong>www.stinet.gov.vn</strong></a></p><p>&nbsp; &nbsp; Đây là nguồn&nbsp;sở dữ liệu đáng tin cậy và ngày càng phát triển bởi&nbsp;30 đơn vị thành viên: Sở Khoa học và Công nghệ, Trung tâm Thông tin và Thống kê KH&amp;CN, các&nbsp;trường đại học, viện nghiên cứu, thư viện,...&nbsp;nhằm chia sẻ thông tin khoa học và công nghệ&nbsp;phục vụ hoạt động nghiên cứu, giảng dạy, học tập của các đơn vị.&nbsp;&nbsp;</p><p><i>Lễ ký kết thỏa thuận tham gia hệ thống liên kết nguồn lực thông tin KH&amp;CN (tháng 05/2019)</i></p><p><br>&nbsp;</p><p>&nbsp;<strong>Thư viện trân trọng thông báo đến Quý thầy cô và các bạn sinh viên được biết!</strong></p><ul><li>Thư viện Đại học Công nghiệp Thực phẩm</li></ul>', CAST(0x07420B00 AS Date), 10000001, NULL, 0, 1, 0, N'9.png')
INSERT [dbo].[TINTUC] ([MaTinTuc], [MaLoaiTinTuc], [TieuDe], [MoTaNgan], [NoiDung], [NgayTao], [NguoiLap], [HinhAnh], [SoLuongLuotXem], [HienThiTrangChu], [TinhTrangXoa], [Logo]) VALUES (10, 1, N'Tham dự tập huấn chủ đề: "Tài nguyên giáo dục mở phục vụ học tập, giảng dạy và nghiên cứu khoa học"', N'THAM DỰ TẬP HUẤN
                                          Chủ đề: “Tài nguyên giáo dục mở phục vụ học tập, giảng dạy và nghiên cứu khoa học”      ', N'<p>Được sự đồng ý của Ban Giám hiệu, đại diện lãnh đạo Thư viện Trường Đại học Công nghiệp Thực phẩm Tp. Hồ Chí Minh đã tham dự Lớp tập huấn chủ đề <strong>“</strong>Tài nguyên giáo dục mở phục vụ học tập, giảng dạy và nghiên cứu khoa học” do Liên Chi hội Thư viện Đại học phía Nam đã phối hợp với Trường Đại học Ngân hàng Tp. Hồ Chí Minh tổ chức Ngày 25 tháng 10 năm 2017 tại Trường Đại học Ngân hàng Tp. Hồ Chí Minh.</p><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Lớp tập huấn đã quy tụ hơn 100 học viên đến từ 52 Thư viện thuộc các Trường Đại học, Cao đẳng khu vực phía Nam. &nbsp;Tài nguyên giáo dục mở - OER (Open Educational Resources) là một vấn đề mới và không dễ để hiện thực hóa trong cuộc sống, nhất là trong điều kiện cụ thể hiện nay trong khu vực giáo dục của Việt Nam. Với tiêu chí thúc đẩy sức mạnh của cả cộng đồng, bất kỳ tác giả nào khi đăng ký tài khoản trên hệ thống đều có thể đóng góp nội dung, cùng góp nên kho tri thức, phục vụ cho việc học tập, giảng dạy và nghiên cứu. Chương trình Tài nguyên giáo dục mở sẽ góp phần không nhỏ vào việc cung cấp giáo trình tham khảo cho việc thực hiện đào tạo đại học theo tín chỉ của các Trường..</p><p>&nbsp; &nbsp; &nbsp; &nbsp; Giảng viên chính, ông Lê Trung Nghĩa – Trung tâm Nghiên cứu và Phát triển Quốc gia về Công nghệ Mở, Bộ Khoa học và Công nghệ. Đến với lớp tập huấn, ông Lê Trung Nghĩa đã chia sẻ một số chủ đề về “Thư viện với việc xây dựng bộ sưu tập và tham gia thế giới nguồn mở để phục vụ nhu cầu học tập suốt đời của người dân” với các nội dung: Giới thiệu về Tài nguyên giáo dục mở; Kỹ năng về Tài nguyên giáo dục mở; Thực hành cấp phép sử dụng Tài nguyên giáo dục mở. Giảng viên và học viên đã cùng nhau thảo luận, trao đổi và tìm hiểu thông tin về nguồn tài nguyên mở vô tận này..</p><p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Khóa tập huấn đã cung cấp một số kỹ năng để nhận biết, sưu tầm, tạo lập, giới thiệu và phổ biến nguồn tài nguyên Giáo dục mở cho cán bộ Thư viện được nâng cao thêm kiến thức của bản thân, để đưa Thư viện phát triển, hướng tới đáp ứng nhu cầu ngày càng phong phú, đa dạng của người dùng tin.</p>', CAST(0x07420B00 AS Date), 10000003, NULL, 0, 0, 0, N'10.png')
SET IDENTITY_INSERT [dbo].[TINTUC] OFF
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [TinhTrangXoa], [Ke]) VALUES (N'A-000', 1, 0, N'000')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [TinhTrangXoa], [Ke]) VALUES (N'A-100', 1, 0, N'100')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [TinhTrangXoa], [Ke]) VALUES (N'A-200', 1, 0, N'200')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [TinhTrangXoa], [Ke]) VALUES (N'B-300', 2, 0, N'300')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [TinhTrangXoa], [Ke]) VALUES (N'B-400', 2, 0, N'400')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [TinhTrangXoa], [Ke]) VALUES (N'B-500', 2, 0, N'500')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [TinhTrangXoa], [Ke]) VALUES (N'C-600', 3, 0, N'600')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [TinhTrangXoa], [Ke]) VALUES (N'C-700', 3, 0, N'600')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [TinhTrangXoa], [Ke]) VALUES (N'C-800', 3, 0, N'800')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [TinhTrangXoa], [Ke]) VALUES (N'D-900', 4, 0, N'900')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [TinhTrangXoa], [Ke]) VALUES (N'D-901', 4, 0, N'901')
ALTER TABLE [dbo].[PHANQUYEN]  WITH CHECK ADD  CONSTRAINT [FK_PHANQUYEN_LOAINHANVIEN1] FOREIGN KEY([MaLoaiNhanVien])
REFERENCES [dbo].[LOAINHANVIEN] ([MaLoaiNhanVien])
GO
ALTER TABLE [dbo].[PHANQUYEN] CHECK CONSTRAINT [FK_PHANQUYEN_LOAINHANVIEN1]
GO
ALTER TABLE [dbo].[PHANQUYEN]  WITH CHECK ADD  CONSTRAINT [FK_PHANQUYEN_MANHINH2] FOREIGN KEY([MaManHinh])
REFERENCES [dbo].[MANHINH] ([MaManHinh])
GO
ALTER TABLE [dbo].[PHANQUYEN] CHECK CONSTRAINT [FK_PHANQUYEN_MANHINH2]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "DOCGIA"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 253
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "KHOA"
            Begin Extent = 
               Top = 136
               Left = 384
               Bottom = 249
               Right = 554
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NGANH"
            Begin Extent = 
               Top = 17
               Left = 591
               Bottom = 130
               Right = 761
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_DOCGIA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_DOCGIA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "NHANVIEN"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 256
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LOAINHANVIEN"
            Begin Extent = 
               Top = 7
               Left = 304
               Bottom = 148
               Right = 515
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_NHANVIEN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_NHANVIEN'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[55] 4[17] 2[10] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CHUDE"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "LOAITAILIEU"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 119
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NGONNGU"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 119
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NHAXUATBAN"
            Begin Extent = 
               Top = 45
               Left = 704
               Bottom = 158
               Right = 878
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TACGIA"
            Begin Extent = 
               Top = 137
               Left = 38
               Bottom = 250
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "TAILIEU"
            Begin Extent = 
               Top = 261
               Left = 368
               Bottom = 391
               Right = 544
            End
            DisplayFlags = 280
            TopColumn = 12
         End
         Begin Table = "VITRI"
            Begin Extent = 
               Top = 209
               Left = 705
               Bottom = 339
               Right = 875
            End
            DisplayFlags = 280' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_TAILIEU'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_TAILIEU'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_TAILIEU'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "VW_TAILIEU"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 19
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_TAILIEUCUNGCHUDE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_TAILIEUCUNGCHUDE'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "VW_TAILIEU"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 252
            End
            DisplayFlags = 280
            TopColumn = 26
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_TAILIEUCUNGTACGIA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_TAILIEUCUNGTACGIA'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[47] 4[14] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CT_PHIEUMUON"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 243
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "CT_PHIEUTRA"
            Begin Extent = 
               Top = 189
               Left = 227
               Bottom = 319
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "PHIEUMUON"
            Begin Extent = 
               Top = 6
               Left = 508
               Bottom = 136
               Right = 678
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "PHIEUTRA"
            Begin Extent = 
               Top = 172
               Left = 0
               Bottom = 302
               Right = 177
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "VW_TAILIEU"
            Begin Extent = 
               Top = 138
               Left = 691
               Bottom = 268
               Right = 867
            End
            DisplayFlags = 280
            TopColumn = 26
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
  ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_TAILIEUDAMUON'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'       Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_TAILIEUDAMUON'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_TAILIEUDAMUON'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "CT_PHIEUMUON"
            Begin Extent = 
               Top = 69
               Left = 367
               Bottom = 199
               Right = 572
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "PHIEUMUON"
            Begin Extent = 
               Top = 26
               Left = 91
               Bottom = 156
               Right = 261
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "VW_TAILIEU"
            Begin Extent = 
               Top = 30
               Left = 622
               Bottom = 160
               Right = 798
            End
            DisplayFlags = 280
            TopColumn = 26
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_TAILIEUDANGMUON'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_TAILIEUDANGMUON'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "TINTUC"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 260
            End
            DisplayFlags = 280
            TopColumn = 5
         End
         Begin Table = "LOAITINTUC"
            Begin Extent = 
               Top = 7
               Left = 308
               Bottom = 126
               Right = 519
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "NHANVIEN"
            Begin Extent = 
               Top = 177
               Left = 390
               Bottom = 340
               Right = 598
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_TINTUC'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VW_TINTUC'
GO
USE [master]
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET  READ_WRITE 
GO
