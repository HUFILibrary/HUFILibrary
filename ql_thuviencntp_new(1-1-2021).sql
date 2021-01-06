USE [master]
GO
/****** Object:  Database [QuanLyThuVienCNTP2]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[CHUDE]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[CT_PHIEUMUON]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[CT_PHIEUNHAP]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[CT_PHIEUTRA]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[CT_XULYVIPHAM]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[HINHTHUCXULY]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[KHOA]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[LOAIDOCGIA]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[LOAINHANVIEN]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[LOAITAILIEU]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[LOAIVIPHAM]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[MANHINH]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[NGANH]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[NGONNGU]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[PHIEUTRA]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[PHIEUXULYVIPHAM]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[TACGIA]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  Table [dbo].[TAILIEU]    Script Date: 1/5/2021 9:57:09 PM ******/
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
	[TenTaiLieu] [nvarchar](max) NULL,
	[SoTrang] [int] NULL,
	[Gia] [float] NULL,
	[NamXuatBan] [int] NULL,
	[MaTacGia] [int] NULL,
	[MaNhaXuatBan] [int] NULL,
	[ThongTinTaiLieu] [nvarchar](max) NULL,
	[MaNgonNgu] [int] NULL,
	[MaViTri] [varchar](50) NOT NULL,
	[HinhAnh] [varchar](50) NULL,
	[TinhTrangXoa] [bit] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VITRI]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  View [dbo].[VW_TAILIEU]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  View [dbo].[VW_TAILIEUDANGMUON]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  View [dbo].[VW_TAILIEUDAMUON]    Script Date: 1/5/2021 9:57:09 PM ******/
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
/****** Object:  View [dbo].[VW_TAILIEUCUNGTACGIA]    Script Date: 1/5/2021 9:57:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_TAILIEUCUNGTACGIA]
AS
SELECT TenTaiLieu, MaTaiLieu, TenTacGia
FROM     dbo.VW_TAILIEU


GO
/****** Object:  View [dbo].[VW_TAILIEUCUNGCHUDE]    Script Date: 1/5/2021 9:57:09 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VW_TAILIEUCUNGCHUDE]
AS
SELECT MaTaiLieu, TenChuDe, TenTaiLieu
FROM     dbo.VW_TAILIEU


GO
/****** Object:  View [dbo].[VW_DOCGIA]    Script Date: 1/5/2021 9:57:09 PM ******/
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
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (8, 4, 0, NULL, N'100000022')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (9, 4, 0, NULL, N'100000026')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (10, 4, 0, NULL, N'100000031')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (11, 5, 0, NULL, N'100000032')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (12, 5, 0, NULL, N'100000035')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (13, 6, 0, NULL, N'100000024')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (14, 7, 0, NULL, N'100000034')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [TinhTrangXoa], [MaVach]) VALUES (15, 8, 0, NULL, N'100000039')
SET IDENTITY_INSERT [dbo].[CT_PHIEUMUON] OFF
SET IDENTITY_INSERT [dbo].[CT_PHIEUNHAP] ON 

INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (1, 1, N'100000000', 1, 1)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (2, 1, N'100000027', 1, 1)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (3, 1, N'100000028', 1, 1)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (4, 2, N'100000037', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (5, 2, N'100000038', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (6, 2, N'100000039', 1, 0)
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
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170018', 1, N'7480201', N'Hứa Tôn Đạt Nhật', N'025895109', CAST(0xBE400B00 AS Date), N'Nam', N'0789163351', N'53/10 Đường 8B, P.BHHA, Quận Bình Tân', N'huatondat1621999@gmail.com', CAST(0x09420B00 AS Date), 0, CAST(0x9B400B00 AS Date), N'2001170018.jpg', N'123123', 0)
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

INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (1, 10000002, CAST(0xEE410B00 AS Date), NULL, 1)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (2, 10000001, CAST(0xEE410B00 AS Date), NULL, 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (3, 10000001, CAST(0xEE410B00 AS Date), NULL, 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (4, 10000002, CAST(0xEE410B00 AS Date), NULL, 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (5, 10000001, CAST(0xEE410B00 AS Date), NULL, 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (6, 10000001, CAST(0xEE410B00 AS Date), NULL, 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (7, 10000001, CAST(0xF2410B00 AS Date), NULL, 0)
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
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000000', N'1000001', 1, N'1', 1, N'0', N'Từ Điển Việt - Hán Hiện Đại', 1440, 120000, 2018, 1, 1, N'T? Ði?n Vi?t - Hán Hi?n Ð?i', 1, N'B-400', N'100000000.jpg', 1)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000001', N'1000002', 1, N'1', 1, N'0', N'Từ Điển Anh Việt - Việt Anh (Tái Bản)', 1600, 115000, 2019, 2, 2, N'Cu?n sách du?c các chuyên gia biên so?n k? lu?ng v?i lu?ng t? phong phú, gi?i thích d? hi?u v?i các t? v?ng thu?ng dùng trong sinh ho?t, giao ti?p h?ng ngày.
Ngoài ra cu?n sách còn c?p nh?t nhi?u t? m?i trong linh v?c kinh t?, khoa h?c, k? thu?t, van hóa, xã h?i… Các m?c t? du?c trình bày rõ ràng d? hi?u tra c?u giúp ngu?i d?c thu?n ti?n khi tham kh?o d?i chi?u nhanh t?i nhà, co quan, tru?ng h?c…', 1, N'B-400', N'100000001.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000002', N'1000003', 1, N'1', 6, N'1', N'
Nhân Tố Enzyme - Minh Họa (Tái Bản 2018)', 99, 64000, 2018, 3, 3, N'Nhân T? Enzyme 4 - Minh H?a nói v? phuong pháp s?ng dúng, s?ng kh?e dã du?c tác gi? dã truy?n t?i h?t trong ba cu?n tru?c c?a b? sách Nhân t? Enzyme, và trong cu?n này, ông tóm t?t l?i các di?m chính. M?i ph?n d?u có kèm theo so d? hay hình ?nh minh h?a d? d?c gi? d? theo dõi. M?i ph?n d?u du?c trình bày trên hai trang m? li?n nhau nên d? d?c, d? theo dõi.

Vi?c d?c l?i toàn b? ba cu?n trong b? sách có th? s? khá v?t v? v?i các b?n, nhung v?i cu?n sách này, b?n ch? c?n 30 phút là có th? d?c xong. Do dó, cu?n sách này có l? s? r?t c?n thi?t cho nh?ng ai mu?n c?ng c? l?i ki?n th?c hay k? c? nh?ng ngu?i m?i b?t d?u d?c.

Sách có 4 ph?n, m?i ph?n d?u nói v? các phuong pháp khác nhau d? có s?c kh?e s?ng trong cu?c s?ng chúng ta:

Ph?n 1: Hãy làm s?ch v? tu?ng, tràng tu?ng.
Ph?n 2: Thói quen an u?ng lành m?nh.
Ph?n 3: Phuong pháp th?i d?c cho co th?.
Ph?n 4: Thói quen t?o cho m?t co th? không b? b?nh.', 1, N'B-500', N'100000002.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000021', N'1000007', 1, N'1', 3, N'0', N'Lotharingia: A Personal History Of Europe''s Lost Country', 528, 192000, 2019, 5, 6, N'In 843 AD, the three surviving grandsons of the great emperor Charlemagne met at Verdun. After years of bitter squabbles over who would inherit the family land, they finally decided to divide the territory and go their separate ways. In a moment of staggering significance, one grandson inherited the area we now know as France, another Germany and the third received the piece in between: Lotharingia.

Lotharingia is a history of in-between Europe; the story of a place between places. In this beguiling and compelling book, Simon Winder retraces the various powers that have tried to overtake the land that stretches from the mouth of the Rhine to the Alps and the might of the peoples who have lived there for centuries.', 2, N'B-300', N'100000021.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000022', N'1000007', 1, N'2', 3, N'0', N'Lotharingia: A Personal History Of Europe''s Lost Country', 528, 192000, 2019, 5, 6, N'In 843 AD, the three surviving grandsons of the great emperor Charlemagne met at Verdun. After years of bitter squabbles over who would inherit the family land, they finally decided to divide the territory and go their separate ways. In a moment of staggering significance, one grandson inherited the area we now know as France, another Germany and the third received the piece in between: Lotharingia.

Lotharingia is a history of in-between Europe; the story of a place between places. In this beguiling and compelling book, Simon Winder retraces the various powers that have tried to overtake the land that stretches from the mouth of the Rhine to the Alps and the might of the peoples who have lived there for centuries.', 2, N'B-300', N'100000022.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000025', N'1000009', 1, N'1', 1, N'0', N'Tiếng Nhật Cho Mọi Người - Sơ Cấp 2 - Bản Tiếng Nhật (Bản Mới 2018)', 310, 138000, 2018, 7, 8, N'Giáo trình d?y ti?ng Nh?t Minna no Nihongo b? m?i', 4, N'B-400', N'100000025.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000026', N'1000009', 1, N'2', 1, N'0', N'Tiếng Nhật Cho Mọi Người - Sơ Cấp 2 - Bản Tiếng Nhật (Bản Mới 2018)', 310, 138000, 2018, 7, 8, N'Giáo trình d?y ti?ng Nh?t Minna no Nihongo b? m?i', 4, N'B-400', N'100000026.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000003', N'1000004', 1, N'1', 6, N'100000002', N'​Nhân Tố Enzyme 2 - Thực Hành (Tái Bản 2018)', 291, 85000, 2018, 3, 3, N'Nhân T? Enzyme - Th?c Hành

Ngày nay, n?n y h?c hi?n d?i dang không ng?ng phát tri?n, th? nhung t?i sao s? ngu?i ph?i ch?ng ch?i v?i b?nh t?t v?n không h? gi?m b?t?

Sau hàng ch?c nam nghiên c?u, bác si Hiromi Shinya nh?n ra r?ng vi?c m?t ngu?i h?p thu lo?i th?c ph?m gì, v?i s? lu?ng bao nhiêu, cung nhu có thói quen sinh ho?t nhu th? nào d?u quan h? m?t thi?t t?i v? tu?ng, tràng tu?ng. Hon n?a, vi?c này còn liên quan t?i c? tình tr?ng s?c kh?e c?a chính ngu?i dó.

T?i các co s? y t?, các bác si cung hu?ng d?n an u?ng d?i v?i m?t s? can b?nh c?n ph?i h?n ch? an u?ng nhu b?nh ti?u du?ng. Tuy nhiên, nh?ng hu?ng d?n dó ch? giúp b?nh tình không tr? n?ng hon. Không quá l?i khi nói r?ng cho d?n nay, nh?ng hu?ng d?n trong cách an u?ng, sinh ho?t d? b?nh nhân không b? b?nh, hay có th? s?ng th? m?t cách kh?e m?nh v?n còn là di?m mù c?a n?n y h?c hi?n d?i.

V?n di co th? con ngu?i có r?t nhi?u h? th?ng phòng v? và co ch? mi?n d?ch b?o v? kh?i b?nh t?t. Do dó, n?u không ph?i là các v?n d? b?m sinh, ch? c?n không làm nh?ng vi?c quá b?t thu?ng thì dù dôi khi vi ph?m m?t hai di?u, b?n v?n s? không b? m?c b?nh.

Nguyên nhân l?n nh?t khi?n co th? v?n có co ch? t? b?o v? b? m?c b?nh chính là do “thói quen an u?ng và sinh ho?t sai l?m” du?c tích luy trong th?i gian dài.

Do ph?n l?n m?i ngu?i không bi?t th?c ph?m nào là t?t, th?c ph?m nào là không t?t d?i v?i co th? con ngu?i nên m?i b? m?c b?nh. V?i tâm nguy?n gi?i thi?u v? thói quen an u?ng và sinh ho?t dúng d?n d? giúp m?i ngu?i có th? duy trì s?c kh?e c?a b?n thân, tác gi? dã cho ra d?i cu?n sách Nhân t? enzyme – Phuong th?cs?ng lành m?nh gi?i thi?u v?i m?i ngu?i v? “b?a an lý tu?ng” và thói quen sinh ho?t lý tu?ng”. Ðã nh?n du?c r?t nhi?u ph?n h?i t? b?n d?c trên th? gi?i.

Nhung n?u nhu Nhân t? enzyme – Phuong th?c s?ng lành m?nh ch? là nh?ng d? xu?t “lý tu?ng”, thì cu?n sách này c?a tác gi? chính là “cu?n th?c hành” d? b?n có th? v?a t?n hu?ng cu?c s?ng, v?a bi?t cách an u?ng, sinh ho?t t?t cho co th? c?a mình. Trong cu?n sách này, tác gi? dã trình bày nhi?u phuong pháp d? b?n có th? bi?t du?c gi?i h?n cho phép c?a b?n thân và có th? th?c hi?n nh?ng thói quen sinh ho?t t?t cho co th? mà không quá hà kh?c.

Hy v?ng r?ng b?n có th? tìm th?y phuong pháp phù h?p v?i l?i s?ng riêng c?a mình d? có th? v?a t?n hu?ng cu?c s?ng, v?a có th? s?ng kh?e m?nh m?i ngày.', 1, N'B-500', N'100000003.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000004', N'1000005', 1, N'1', 6, N'100000003', N'Nhân Tố Enzyme 3 - Trẻ Hóa (Tái Bản 2018)', 175, 65000, 2018, 3, 3, N'Nhân T? Enzyme – Tr? Hóa

Trên thê´ gio´i na`y, không co´ ai tre? hon tuô?i thu?c cu?a mi`nh ca?. Có chang ch? là ngu?i du´ng vo´i tuô?i thu?c va` ngu?i gia` hon tuô?i thu?c ma` thôi.

No´i ca´ch kha´c, nhu~ng nguo`i tre? nhâ´t ma` ba?n thâ´y cu~ng chi? la` nhu~ng nguo`i dang o? tra?ng tha´i du´ng vo´i tuô?i thâ?t cu?a mi`nh. Su? tre? trung khiê´n nguo`i kha´c pha?i ghen ti? thu?c ra cu~ng chi´nh la` da´ng ve? vô´n co´ du´ng vo´i dô? tuô?i cu?a ba?n.

Giu~a thân thê? va` tinh thâ`n cu?a con nguo`i co´ mô?t mô´i quan hê? khang khi´t b?n cha?t không th? tách ro`i. Nê´u ba?n chi? la`m nhu~ng viê?c tô´t cho co thê? hay chi? la`m nhu~ng viê?c tô´t cho tinh thâ`n thi` ba?n không thê? co´ duo?c su? tre? trung thu?c su?. Con nguo`i chi? co´ duo?c su? tre? trung thu?c su? khi dô`ng tho`i thu?c hiê?n ca? hai viê?c la` tre? ho´a co thê? va` tre? ho´a tâm hô`n.

N?m trong b? sách Nhân t? Enzyme, cu?n sách Nhân t? Enzyme – Tr? hóa s? t?p trung vào nh?ng ki?n th?c và bí quy?t giúp b?n d?t du?c di?u dó.', 1, N'B-500', N'100000004.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000023', N'1000008', 1, N'1', 1, N'0', N'Street Of Eternal Happiness: Big City Dreams Along A Shanghai Road', 336, 436000, 2016, 6, 7, N'Street Of Eternal Happiness: Big City Dreams Along A Shanghai Road

''Enjoyable and illuminating . . . Rob Schmitz writes with great affection'' Guardian

Shanghai: a global city in the midst of a renaissance, where dreamers arrive each day to partake in a mad torrent of capital, ideas and opportunity. Rob Schmitz is one of them. He immerses himself in his neighbourhood, forging relationships with ordinary people who see a brighter future in the city''s sleek skyline. There''s Zhao, whose path from factory floor to shopkeeper is sidetracked by her desperate measures to ensure a better future for her sons. Down the street lives Auntie Fu, a fervent capitalist forever trying to improve herself while keeping her sceptical husband at bay. Up a flight of stairs, CK sets up shop to attract young dreamers like himself, but learns he''s searching for something more. As Schmitz becomes increasingly involved in their lives, he makes surprising discoveries which untangle the complexities of modern China: a mysterious box of letters that serve as a portal to a family''s - and country''s - dark past, and an abandoned neighbourhood where fates have been violently altered by unchecked power and greed.

A tale of twenty-first-century China, Street of Eternal Happiness profiles China''s distinct generations through multifaceted characters who illuminate an enlightening, humorous and, at times, heartrending journey along the winding road to the Chinese dream. Each story adds another layer of humanity to modern China, a tapestry also woven with Schmitz''s insight as a foreign correspondent. The result is an intimate and surprising portrait that dispenses with the tired stereotypes of a country we think we know, immersing us instead in the vivid stories of the people who make up one of the world''s most captivating cities.', 1, N'B-300', N'100000023.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000024', N'1000008', 1, N'2', 1, N'0', N'Street Of Eternal Happiness: Big City Dreams Along A Shanghai Road', 336, 436000, 2016, 6, 7, N'Street Of Eternal Happiness: Big City Dreams Along A Shanghai Road

''Enjoyable and illuminating . . . Rob Schmitz writes with great affection'' Guardian

Shanghai: a global city in the midst of a renaissance, where dreamers arrive each day to partake in a mad torrent of capital, ideas and opportunity. Rob Schmitz is one of them. He immerses himself in his neighbourhood, forging relationships with ordinary people who see a brighter future in the city''s sleek skyline. There''s Zhao, whose path from factory floor to shopkeeper is sidetracked by her desperate measures to ensure a better future for her sons. Down the street lives Auntie Fu, a fervent capitalist forever trying to improve herself while keeping her sceptical husband at bay. Up a flight of stairs, CK sets up shop to attract young dreamers like himself, but learns he''s searching for something more. As Schmitz becomes increasingly involved in their lives, he makes surprising discoveries which untangle the complexities of modern China: a mysterious box of letters that serve as a portal to a family''s - and country''s - dark past, and an abandoned neighbourhood where fates have been violently altered by unchecked power and greed.

A tale of twenty-first-century China, Street of Eternal Happiness profiles China''s distinct generations through multifaceted characters who illuminate an enlightening, humorous and, at times, heartrending journey along the winding road to the Chinese dream. Each story adds another layer of humanity to modern China, a tapestry also woven with Schmitz''s insight as a foreign correspondent. The result is an intimate and surprising portrait that dispenses with the tired stereotypes of a country we think we know, immersing us instead in the vivid stories of the people who make up one of the world''s most captivating cities.', 1, N'B-300', N'100000024.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000027', N'1000010', 1, N'1', 6, N'0', N'Data Strategy - Chiến Lược Dữ Liệu', 272, 79000, 2019, 9, 10, N'Data Strategy - Chi?n Lu?c D? Li?u

D? li?u dang thay d?i cách chúng ta s?ng và làm vi?c v?i t?c d? chua t?ng có. Nó là t?t c? d?u v?t ta d? l?i khi lu?t web, mua hàng qua th? tín d?ng, g?i e-mail, ch?p ?nh, d?c báo tr?c tuy?n, th?m chí d?o ph? khi mang theo di?n tho?i di d?ng ho?c di trong khu v?c có h? th?ng .

Nh? vào d? li?u, nhà bán l? Target t?i M? dã d? doán dúng m?t thi?u n? dang mang thai d?a trên thói quen mua hàng c?a cô ?y; Google có th? hi?n th? chính xác qu?ng cáo phù h?p v?i b?n; Facebook bi?t b?n c?a b?n là ai, b?n dang trong m?i quan h? v?i ngu?i nào, d? doán du?c m?i quan h? này kéo dài trong bao lâu, khi nào b?n s? có m?t m?i quan h? tình c?m, th?m chí cho bi?t m?c d? thông minh c?a b?n…

Tuy nhiên, hi?n có chua d?n 0,5% d? li?u du?c phân tích và s? d?ng. Nh?n th?y m?nh d?t màu m? này, Bernard Marr dã cho ra d?i Chi?n Lu?c D? Li?u - noi h?i t? nh?ng ki?n th?c v? d? li?u du?c don gi?n hóa v?i nhi?u ví d? d? hi?u - cung c?p cho b?n cách th?c t?i da hóa s?c m?nh c?a d? li?u bên c?nh vi?c tránh nh?ng r?c r?i liên quan d?n pháp lý, danh ti?ng và tài chính.

T?m quan tr?ng c?a chi?n lu?c d? li?u ngày càng du?c kh?ng d?nh qua thành công c?a các doanh nghi?p ho?t d?ng trên n?n t?ng d? li?u nhu Alphabet, Facebook, Narrative Science, Amazon, Apple… Vi?c có m?t chi?n lu?c d? li?u m?nh và l? trình khoa h?c dã tr? thành m?t ph?n t?t y?u trong ADN c?a m?i t? ch?c. Nó x?ng dáng nh?n du?c s? quan tâm ngang v?i chi?n lu?c marketing, khách hàng, s?n ph?m hay thu hút nhân tài c?a doanh nghi?p.

Chi?n Lu?c D? Li?u không ch? phù h?p cho ngu?i bu?c d?u làm quen v?i d? li?u, mà còn cung c?p nh?p di?u bao quát v? nh?ng thay d?i dang di?n ra trên th? tru?ng và trang b? n?n t?ng ban d?u cho ngu?i dang ch?u trách nhi?m v? m?ng d? li?u c?a doanh nghi?p.', 1, N'A-200', N'100000027.jpg', 1)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000028', N'1000010', 1, N'2', 6, N'0', N'Data Strategy - Chiến Lược Dữ Liệu', 272, 79000, 2019, 9, 10, N'Data Strategy - Chi?n Lu?c D? Li?u

D? li?u dang thay d?i cách chúng ta s?ng và làm vi?c v?i t?c d? chua t?ng có. Nó là t?t c? d?u v?t ta d? l?i khi lu?t web, mua hàng qua th? tín d?ng, g?i e-mail, ch?p ?nh, d?c báo tr?c tuy?n, th?m chí d?o ph? khi mang theo di?n tho?i di d?ng ho?c di trong khu v?c có h? th?ng .

Nh? vào d? li?u, nhà bán l? Target t?i M? dã d? doán dúng m?t thi?u n? dang mang thai d?a trên thói quen mua hàng c?a cô ?y; Google có th? hi?n th? chính xác qu?ng cáo phù h?p v?i b?n; Facebook bi?t b?n c?a b?n là ai, b?n dang trong m?i quan h? v?i ngu?i nào, d? doán du?c m?i quan h? này kéo dài trong bao lâu, khi nào b?n s? có m?t m?i quan h? tình c?m, th?m chí cho bi?t m?c d? thông minh c?a b?n…

Tuy nhiên, hi?n có chua d?n 0,5% d? li?u du?c phân tích và s? d?ng. Nh?n th?y m?nh d?t màu m? này, Bernard Marr dã cho ra d?i Chi?n Lu?c D? Li?u - noi h?i t? nh?ng ki?n th?c v? d? li?u du?c don gi?n hóa v?i nhi?u ví d? d? hi?u - cung c?p cho b?n cách th?c t?i da hóa s?c m?nh c?a d? li?u bên c?nh vi?c tránh nh?ng r?c r?i liên quan d?n pháp lý, danh ti?ng và tài chính.

T?m quan tr?ng c?a chi?n lu?c d? li?u ngày càng du?c kh?ng d?nh qua thành công c?a các doanh nghi?p ho?t d?ng trên n?n t?ng d? li?u nhu Alphabet, Facebook, Narrative Science, Amazon, Apple… Vi?c có m?t chi?n lu?c d? li?u m?nh và l? trình khoa h?c dã tr? thành m?t ph?n t?t y?u trong ADN c?a m?i t? ch?c. Nó x?ng dáng nh?n du?c s? quan tâm ngang v?i chi?n lu?c marketing, khách hàng, s?n ph?m hay thu hút nhân tài c?a doanh nghi?p.

Chi?n Lu?c D? Li?u không ch? phù h?p cho ngu?i bu?c d?u làm quen v?i d? li?u, mà còn cung c?p nh?p di?u bao quát v? nh?ng thay d?i dang di?n ra trên th? tru?ng và trang b? n?n t?ng ban d?u cho ngu?i dang ch?u trách nhi?m v? m?ng d? li?u c?a doanh nghi?p.', 1, N'A-200', N'100000028.jpg', 1)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000029', N'1000010', 1, N'0', 6, N'0', N'Data Strategy - Chiến Lược Dữ Liệu', 272, 79000, 2019, 9, 10, N'Data Strategy - Chi?n Lu?c D? Li?u

D? li?u dang thay d?i cách chúng ta s?ng và làm vi?c v?i t?c d? chua t?ng có. Nó là t?t c? d?u v?t ta d? l?i khi lu?t web, mua hàng qua th? tín d?ng, g?i e-mail, ch?p ?nh, d?c báo tr?c tuy?n, th?m chí d?o ph? khi mang theo di?n tho?i di d?ng ho?c di trong khu v?c có h? th?ng .

Nh? vào d? li?u, nhà bán l? Target t?i M? dã d? doán dúng m?t thi?u n? dang mang thai d?a trên thói quen mua hàng c?a cô ?y; Google có th? hi?n th? chính xác qu?ng cáo phù h?p v?i b?n; Facebook bi?t b?n c?a b?n là ai, b?n dang trong m?i quan h? v?i ngu?i nào, d? doán du?c m?i quan h? này kéo dài trong bao lâu, khi nào b?n s? có m?t m?i quan h? tình c?m, th?m chí cho bi?t m?c d? thông minh c?a b?n…

Tuy nhiên, hi?n có chua d?n 0,5% d? li?u du?c phân tích và s? d?ng. Nh?n th?y m?nh d?t màu m? này, Bernard Marr dã cho ra d?i Chi?n Lu?c D? Li?u - noi h?i t? nh?ng ki?n th?c v? d? li?u du?c don gi?n hóa v?i nhi?u ví d? d? hi?u - cung c?p cho b?n cách th?c t?i da hóa s?c m?nh c?a d? li?u bên c?nh vi?c tránh nh?ng r?c r?i liên quan d?n pháp lý, danh ti?ng và tài chính.

T?m quan tr?ng c?a chi?n lu?c d? li?u ngày càng du?c kh?ng d?nh qua thành công c?a các doanh nghi?p ho?t d?ng trên n?n t?ng d? li?u nhu Alphabet, Facebook, Narrative Science, Amazon, Apple… Vi?c có m?t chi?n lu?c d? li?u m?nh và l? trình khoa h?c dã tr? thành m?t ph?n t?t y?u trong ADN c?a m?i t? ch?c. Nó x?ng dáng nh?n du?c s? quan tâm ngang v?i chi?n lu?c marketing, khách hàng, s?n ph?m hay thu hút nhân tài c?a doanh nghi?p.

Chi?n Lu?c D? Li?u không ch? phù h?p cho ngu?i bu?c d?u làm quen v?i d? li?u, mà còn cung c?p nh?p di?u bao quát v? nh?ng thay d?i dang di?n ra trên th? tru?ng và trang b? n?n t?ng ban d?u cho ngu?i dang ch?u trách nhi?m v? m?ng d? li?u c?a doanh nghi?p.', 1, N'A-200', N'100000029.jpg', 1)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000030', N'1000010', 1, N'0', 6, N'0', N'Data Strategy - Chiến Lược Dữ Liệu', 272, 79000, 2019, 9, 10, N'Data Strategy - Chi?n Lu?c D? Li?u

D? li?u dang thay d?i cách chúng ta s?ng và làm vi?c v?i t?c d? chua t?ng có. Nó là t?t c? d?u v?t ta d? l?i khi lu?t web, mua hàng qua th? tín d?ng, g?i e-mail, ch?p ?nh, d?c báo tr?c tuy?n, th?m chí d?o ph? khi mang theo di?n tho?i di d?ng ho?c di trong khu v?c có h? th?ng .

Nh? vào d? li?u, nhà bán l? Target t?i M? dã d? doán dúng m?t thi?u n? dang mang thai d?a trên thói quen mua hàng c?a cô ?y; Google có th? hi?n th? chính xác qu?ng cáo phù h?p v?i b?n; Facebook bi?t b?n c?a b?n là ai, b?n dang trong m?i quan h? v?i ngu?i nào, d? doán du?c m?i quan h? này kéo dài trong bao lâu, khi nào b?n s? có m?t m?i quan h? tình c?m, th?m chí cho bi?t m?c d? thông minh c?a b?n…

Tuy nhiên, hi?n có chua d?n 0,5% d? li?u du?c phân tích và s? d?ng. Nh?n th?y m?nh d?t màu m? này, Bernard Marr dã cho ra d?i Chi?n Lu?c D? Li?u - noi h?i t? nh?ng ki?n th?c v? d? li?u du?c don gi?n hóa v?i nhi?u ví d? d? hi?u - cung c?p cho b?n cách th?c t?i da hóa s?c m?nh c?a d? li?u bên c?nh vi?c tránh nh?ng r?c r?i liên quan d?n pháp lý, danh ti?ng và tài chính.

T?m quan tr?ng c?a chi?n lu?c d? li?u ngày càng du?c kh?ng d?nh qua thành công c?a các doanh nghi?p ho?t d?ng trên n?n t?ng d? li?u nhu Alphabet, Facebook, Narrative Science, Amazon, Apple… Vi?c có m?t chi?n lu?c d? li?u m?nh và l? trình khoa h?c dã tr? thành m?t ph?n t?t y?u trong ADN c?a m?i t? ch?c. Nó x?ng dáng nh?n du?c s? quan tâm ngang v?i chi?n lu?c marketing, khách hàng, s?n ph?m hay thu hút nhân tài c?a doanh nghi?p.

Chi?n Lu?c D? Li?u không ch? phù h?p cho ngu?i bu?c d?u làm quen v?i d? li?u, mà còn cung c?p nh?p di?u bao quát v? nh?ng thay d?i dang di?n ra trên th? tru?ng và trang b? n?n t?ng ban d?u cho ngu?i dang ch?u trách nhi?m v? m?ng d? li?u c?a doanh nghi?p.', 1, N'A-200', N'100000030.jpg', 1)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000031', N'1000010', 1, N'3', 6, N'0', N'Data Strategy - Chiến Lược Dữ Liệu', 272, 79000, 2019, 9, 10, N'Data Strategy - Chi?n Lu?c D? Li?u

D? li?u dang thay d?i cách chúng ta s?ng và làm vi?c v?i t?c d? chua t?ng có. Nó là t?t c? d?u v?t ta d? l?i khi lu?t web, mua hàng qua th? tín d?ng, g?i e-mail, ch?p ?nh, d?c báo tr?c tuy?n, th?m chí d?o ph? khi mang theo di?n tho?i di d?ng ho?c di trong khu v?c có h? th?ng .

Nh? vào d? li?u, nhà bán l? Target t?i M? dã d? doán dúng m?t thi?u n? dang mang thai d?a trên thói quen mua hàng c?a cô ?y; Google có th? hi?n th? chính xác qu?ng cáo phù h?p v?i b?n; Facebook bi?t b?n c?a b?n là ai, b?n dang trong m?i quan h? v?i ngu?i nào, d? doán du?c m?i quan h? này kéo dài trong bao lâu, khi nào b?n s? có m?t m?i quan h? tình c?m, th?m chí cho bi?t m?c d? thông minh c?a b?n…

Tuy nhiên, hi?n có chua d?n 0,5% d? li?u du?c phân tích và s? d?ng. Nh?n th?y m?nh d?t màu m? này, Bernard Marr dã cho ra d?i Chi?n Lu?c D? Li?u - noi h?i t? nh?ng ki?n th?c v? d? li?u du?c don gi?n hóa v?i nhi?u ví d? d? hi?u - cung c?p cho b?n cách th?c t?i da hóa s?c m?nh c?a d? li?u bên c?nh vi?c tránh nh?ng r?c r?i liên quan d?n pháp lý, danh ti?ng và tài chính.

T?m quan tr?ng c?a chi?n lu?c d? li?u ngày càng du?c kh?ng d?nh qua thành công c?a các doanh nghi?p ho?t d?ng trên n?n t?ng d? li?u nhu Alphabet, Facebook, Narrative Science, Amazon, Apple… Vi?c có m?t chi?n lu?c d? li?u m?nh và l? trình khoa h?c dã tr? thành m?t ph?n t?t y?u trong ADN c?a m?i t? ch?c. Nó x?ng dáng nh?n du?c s? quan tâm ngang v?i chi?n lu?c marketing, khách hàng, s?n ph?m hay thu hút nhân tài c?a doanh nghi?p.

Chi?n Lu?c D? Li?u không ch? phù h?p cho ngu?i bu?c d?u làm quen v?i d? li?u, mà còn cung c?p nh?p di?u bao quát v? nh?ng thay d?i dang di?n ra trên th? tru?ng và trang b? n?n t?ng ban d?u cho ngu?i dang ch?u trách nhi?m v? m?ng d? li?u c?a doanh nghi?p.', 1, N'A-200', N'100000031.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000032', N'1000011', 1, N'1', 5, N'0', N'Định Vị (Tái Bản 2018)', 352, 117000, 2018, 8, 9, N'?nh v? s? cho b?n bi?t:

- Giá th?p nh?t, t?c d? ph?i cao.

- Ai choi gi?i hon, k? dó s? t?n t?i.

- Ð?ng d?i d?u v?i nh?ng k? d?n d?u v?ng vàng.

- S?n ph?m khác bi?t ch? dành cho nh?ng ngu?i khác bi?t.

- Thu?ng xuyên rà soát t?ng th? tru?ng nhu m?t v? tru?ng kh?o sát tr?n d?a.

- B?n c?n t?m nhìn, lòng can d?m, s? khách quan, s? don gi?n nhung không th? thi?u s? tinh t?.', 1, N'B-500', N'100000032.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000033', N'1000011', 1, N'2', 5, N'0', N'Định Vị (Tái Bản 2018)', 352, 117000, 2018, 8, 9, N'?nh v? s? cho b?n bi?t:

- Giá th?p nh?t, t?c d? ph?i cao.

- Ai choi gi?i hon, k? dó s? t?n t?i.

- Ð?ng d?i d?u v?i nh?ng k? d?n d?u v?ng vàng.

- S?n ph?m khác bi?t ch? dành cho nh?ng ngu?i khác bi?t.

- Thu?ng xuyên rà soát t?ng th? tru?ng nhu m?t v? tru?ng kh?o sát tr?n d?a.

- B?n c?n t?m nhìn, lòng can d?m, s? khách quan, s? don gi?n nhung không th? thi?u s? tinh t?.', 1, N'B-500', N'100000033.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000034', N'1000011', 1, N'3', 5, N'0', N'Định Vị (Tái Bản 2018)', 352, 117000, 2018, 8, 9, N'?nh v? s? cho b?n bi?t:

- Giá th?p nh?t, t?c d? ph?i cao.

- Ai choi gi?i hon, k? dó s? t?n t?i.

- Ð?ng d?i d?u v?i nh?ng k? d?n d?u v?ng vàng.

- S?n ph?m khác bi?t ch? dành cho nh?ng ngu?i khác bi?t.

- Thu?ng xuyên rà soát t?ng th? tru?ng nhu m?t v? tru?ng kh?o sát tr?n d?a.

- B?n c?n t?m nhìn, lòng can d?m, s? khách quan, s? don gi?n nhung không th? thi?u s? tinh t?.', 1, N'B-500', N'100000034.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000035', N'1000011', 1, N'4', 5, N'0', N'Định Vị (Tái Bản 2018)', 352, 117000, 2018, 8, 9, N'?nh v? s? cho b?n bi?t:

- Giá th?p nh?t, t?c d? ph?i cao.

- Ai choi gi?i hon, k? dó s? t?n t?i.

- Ð?ng d?i d?u v?i nh?ng k? d?n d?u v?ng vàng.

- S?n ph?m khác bi?t ch? dành cho nh?ng ngu?i khác bi?t.

- Thu?ng xuyên rà soát t?ng th? tru?ng nhu m?t v? tru?ng kh?o sát tr?n d?a.

- B?n c?n t?m nhìn, lòng can d?m, s? khách quan, s? don gi?n nhung không th? thi?u s? tinh t?.', 1, N'B-500', N'100000035.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000036', N'1000011', 1, N'5', 5, N'0', N'Định Vị (Tái Bản 2018)', 352, 117000, 2018, 8, 9, N'?nh v? s? cho b?n bi?t:

- Giá th?p nh?t, t?c d? ph?i cao.

- Ai choi gi?i hon, k? dó s? t?n t?i.

- Ð?ng d?i d?u v?i nh?ng k? d?n d?u v?ng vàng.

- S?n ph?m khác bi?t ch? dành cho nh?ng ngu?i khác bi?t.

- Thu?ng xuyên rà soát t?ng th? tru?ng nhu m?t v? tru?ng kh?o sát tr?n d?a.

- B?n c?n t?m nhìn, lòng can d?m, s? khách quan, s? don gi?n nhung không th? thi?u s? tinh t?.', 1, N'B-500', N'100000036.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000037', N'1000012', 1, N'1', 6, N'0', N'Bí Mật Dotcom', 292, 135000, 2018, 9, 10, N'B?n dang c?m trên tay cu?n sách này, ch?c h?n b?n dang quan tâm tìm hi?u, khám phá nh?ng s?c m?nh và nh?ng ti?m nang vô h?n c?a th? gi?i Dotcom. Và tôi tin r?ng - nh?ng Bí M?t du?c ti?t l? trong cu?n sách này s? làm cho b?n th?a mãn v?i di?u dó. Bí M?t Dotcom là cu?n sách Ð?U TIÊN, chân th?c nh?t ti?t l? cho b?n bi?t v? cách th?c mà các chuyên gia Marketing trên Internet dã ki?m v? hàng tri?u dô t? Internet nhu th? nào. Nh?ng bí m?t này thông thu?ng không du?c ti?t l?. Và b?n cung s? bi?t cách d? áp d?ng nh?ng ki?n th?c này d? thay d?i cu?c s?ng tài chính c?a b?n.

L?n d?u d?c Bí M?t Dotcom tôi dã th?y r?t nhi?u s? khác bi?t và giá tr? c?a cu?n sách mang d?n cho tôi qu? th?c là vô giá. Ch? trong vòng chua d?y m?t tháng tôi dã quy?t d?nh thay d?i toàn b? chi?n lu?c d? áp d?ng theo cách mà tác gi? trình bày trong cu?n sách này. Và b?n có tin, m?i th? trong công vi?c kinh doanh c?a tôi thay d?i. T? d?nh v? l?i giá tr? s?n ph?m c?a mình, thay d?i d?i tu?ng khách hàng m?c tiêu, cách ti?p c?n, cách chào hàng và ch?t don hàng….. m?i th? d?u du?c thay d?i theo nh?ng gì Bí M?t Dotcom hu?ng d?n và k?t qu? tôi nh?n du?c thì trên c? tuy?t v?i.', 1, N'A-200', N'100000037.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000038', N'1000012', 1, N'2', 6, N'0', N'Bí Mật Dotcom', 292, 135000, 2018, 9, 10, N'B?n dang c?m trên tay cu?n sách này, ch?c h?n b?n dang quan tâm tìm hi?u, khám phá nh?ng s?c m?nh và nh?ng ti?m nang vô h?n c?a th? gi?i Dotcom. Và tôi tin r?ng - nh?ng Bí M?t du?c ti?t l? trong cu?n sách này s? làm cho b?n th?a mãn v?i di?u dó. Bí M?t Dotcom là cu?n sách Ð?U TIÊN, chân th?c nh?t ti?t l? cho b?n bi?t v? cách th?c mà các chuyên gia Marketing trên Internet dã ki?m v? hàng tri?u dô t? Internet nhu th? nào. Nh?ng bí m?t này thông thu?ng không du?c ti?t l?. Và b?n cung s? bi?t cách d? áp d?ng nh?ng ki?n th?c này d? thay d?i cu?c s?ng tài chính c?a b?n.

L?n d?u d?c Bí M?t Dotcom tôi dã th?y r?t nhi?u s? khác bi?t và giá tr? c?a cu?n sách mang d?n cho tôi qu? th?c là vô giá. Ch? trong vòng chua d?y m?t tháng tôi dã quy?t d?nh thay d?i toàn b? chi?n lu?c d? áp d?ng theo cách mà tác gi? trình bày trong cu?n sách này. Và b?n có tin, m?i th? trong công vi?c kinh doanh c?a tôi thay d?i. T? d?nh v? l?i giá tr? s?n ph?m c?a mình, thay d?i d?i tu?ng khách hàng m?c tiêu, cách ti?p c?n, cách chào hàng và ch?t don hàng….. m?i th? d?u du?c thay d?i theo nh?ng gì Bí M?t Dotcom hu?ng d?n và k?t qu? tôi nh?n du?c thì trên c? tuy?t v?i.', 1, N'A-200', N'100000038.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000039', N'1000012', 1, N'0', 6, N'0', N'Bí Mật Dotcom', 292, 135000, 2018, 9, 10, N'B?n dang c?m trên tay cu?n sách này, ch?c h?n b?n dang quan tâm tìm hi?u, khám phá nh?ng s?c m?nh và nh?ng ti?m nang vô h?n c?a th? gi?i Dotcom. Và tôi tin r?ng - nh?ng Bí M?t du?c ti?t l? trong cu?n sách này s? làm cho b?n th?a mãn v?i di?u dó. Bí M?t Dotcom là cu?n sách Ð?U TIÊN, chân th?c nh?t ti?t l? cho b?n bi?t v? cách th?c mà các chuyên gia Marketing trên Internet dã ki?m v? hàng tri?u dô t? Internet nhu th? nào. Nh?ng bí m?t này thông thu?ng không du?c ti?t l?. Và b?n cung s? bi?t cách d? áp d?ng nh?ng ki?n th?c này d? thay d?i cu?c s?ng tài chính c?a b?n.

L?n d?u d?c Bí M?t Dotcom tôi dã th?y r?t nhi?u s? khác bi?t và giá tr? c?a cu?n sách mang d?n cho tôi qu? th?c là vô giá. Ch? trong vòng chua d?y m?t tháng tôi dã quy?t d?nh thay d?i toàn b? chi?n lu?c d? áp d?ng theo cách mà tác gi? trình bày trong cu?n sách này. Và b?n có tin, m?i th? trong công vi?c kinh doanh c?a tôi thay d?i. T? d?nh v? l?i giá tr? s?n ph?m c?a mình, thay d?i d?i tu?ng khách hàng m?c tiêu, cách ti?p c?n, cách chào hàng và ch?t don hàng….. m?i th? d?u du?c thay d?i theo nh?ng gì Bí M?t Dotcom hu?ng d?n và k?t qu? tôi nh?n du?c thì trên c? tuy?t v?i.', 1, N'A-200', N'100000039.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000040', N'1000013', 1, N'1', 6, N'0', N'Moonwalking with Einstein: The Art and Science of Remembering Everything', 307, 267000, 2012, 10, 11, N'The blockbuster phenomenon that charts an amazing journey of the mind while revolutionizing our concept of memory 

An instant bestseller that is poised to become a classic, Moonwalking with Einstein recounts Joshua Foer''s yearlong quest to improve his memory under the tutelage of top -mental athletes.- He draws on cutting-edge research, a surprising cultural history of remembering, and venerable tricks of the mentalist''s trade to transform our understanding of human memory. From the United States Memory Championship to deep within the author''s own mind, this is an electrifying work of journalism that reminds us that, in every way that matters, we are the sum of our memories.', 1, N'B-500', N'100000040.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000041', N'1000013', 1, N'2', 6, N'0', N'Moonwalking with Einstein: The Art and Science of Remembering Everything', 307, 267000, 2012, 10, 11, N'The blockbuster phenomenon that charts an amazing journey of the mind while revolutionizing our concept of memory 

An instant bestseller that is poised to become a classic, Moonwalking with Einstein recounts Joshua Foer''s yearlong quest to improve his memory under the tutelage of top -mental athletes.- He draws on cutting-edge research, a surprising cultural history of remembering, and venerable tricks of the mentalist''s trade to transform our understanding of human memory. From the United States Memory Championship to deep within the author''s own mind, this is an electrifying work of journalism that reminds us that, in every way that matters, we are the sum of our memories.', 1, N'B-500', N'100000041.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000042', N'1000014', 3, N'1', 4, N'0', N'Video- Báo cáo đồ án tốt nghiệp 2020 LibraryHUFI', 1, 15000, 2019, 7, 1, N'Báo cáo d? án t?t nghi?p c?a sinh viên Nh?t Lâm và Tôn Ð?t d? tài qu?n lý thu vi?n HUFI', 1, N'A-000', N'100000042.jpg', 0)
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
USE [master]
GO
ALTER DATABASE [QuanLyThuVienCNTP2] SET  READ_WRITE 
GO
