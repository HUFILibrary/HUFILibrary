
USE [QuanLyThuVienCNTP]
GO
/****** Object:  Table [dbo].[CHUDE]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[CT_PHIEUMUON]    Script Date: 12/23/2020 8:13:56 PM ******/
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
	[MaVach] [varchar](50) NULL,
 CONSTRAINT [PK_CT_PHIEUMUON] PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_PHIEUNHAP]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[CT_PHIEUTRA]    Script Date: 12/23/2020 8:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CT_PHIEUTRA](
	[MaChiTietPhieuTra] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuTra] [int] NULL,
	[MaVach] [varchar](50) NULL,
 CONSTRAINT [PK_CT_PHIEUTRA] PRIMARY KEY CLUSTERED 
(
	[MaChiTietPhieuTra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CT_XULYVIPHAM]    Script Date: 12/23/2020 8:13:56 PM ******/
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
	[TienBoiThuong] [float] NULL,
 CONSTRAINT [PK_CT_XULYVIPHAM] PRIMARY KEY CLUSTERED 
(
	[MaChiTietXuLyViPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DOCGIA]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[HINHTHUCXULY]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[KHOA]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[LOAIDOCGIA]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[LOAINHANVIEN]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[LOAITAILIEU]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[LOAIVIPHAM]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[MANHINH]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[NGANH]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[NGONNGU]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[NHAXUATBAN]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[PHANQUYEN]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[PHIEUMUON]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[PHIEUTRA]    Script Date: 12/23/2020 8:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUTRA](
	[MaPhieuTra] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuMuon] [int] NULL,
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
/****** Object:  Table [dbo].[PHIEUXULYVIPHAM]    Script Date: 12/23/2020 8:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUXULYVIPHAM](
	[MaXuLyViPham] [int] NOT NULL,
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
/****** Object:  Table [dbo].[TACGIA]    Script Date: 12/23/2020 8:13:56 PM ******/
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
/****** Object:  Table [dbo].[TAILIEU]    Script Date: 12/23/2020 8:13:56 PM ******/
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
	[ThongTinTaiLieu] [ntext] NULL,
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
/****** Object:  Table [dbo].[VITRI]    Script Date: 12/23/2020 8:13:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[VITRI](
	[MaViTri] [varchar](50) NOT NULL,
	[Tang] [int] NULL,
	[Ke] [varchar](50) NULL,
 CONSTRAINT [PK_VITRI_1] PRIMARY KEY CLUSTERED 
(
	[MaViTri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
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

INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [MaVach]) VALUES (2, 2, 0, N'100000000')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [MaVach]) VALUES (3, 2, 0, N'100000004')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [MaVach]) VALUES (4, 2, 0, N'100000023')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [MaVach]) VALUES (5, 3, 0, N'100000021')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [MaVach]) VALUES (6, 3, 0, N'100000026')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [MaVach]) VALUES (7, 4, 0, N'100000024')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [MaVach]) VALUES (8, 5, 0, N'100000025')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [MaVach]) VALUES (9, 6, 0, N'100000031')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [MaVach]) VALUES (10, 7, 0, N'100000028')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [MaVach]) VALUES (11, 8, 0, N'100000027')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [MaVach]) VALUES (12, 8, 0, N'100000034')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [MaVach]) VALUES (13, 8, 0, N'100000033')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [MaVach]) VALUES (14, 9, 1, N'100000035')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [MaVach]) VALUES (15, 9, 1, N'100000036')
INSERT [dbo].[CT_PHIEUMUON] ([MaChiTietPhieuMuon], [MaPhieuMuon], [TinhTrangTraCT], [MaVach]) VALUES (16, 9, 0, N'100000037')
SET IDENTITY_INSERT [dbo].[CT_PHIEUMUON] OFF
SET IDENTITY_INSERT [dbo].[CT_PHIEUNHAP] ON 

INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (1, 1, N'100000000', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (2, 1, N'100000027', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (3, 1, N'100000028', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (4, 2, N'100000037', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (5, 2, N'100000038', 1, 0)
INSERT [dbo].[CT_PHIEUNHAP] ([MaChiTietPhieuNhap], [MaPhieuNhap], [MaVach], [MaNhaCungCap], [TinhTrangXoa]) VALUES (6, 2, N'100000039', 1, 0)
SET IDENTITY_INSERT [dbo].[CT_PHIEUNHAP] OFF
SET IDENTITY_INSERT [dbo].[CT_PHIEUTRA] ON 

INSERT [dbo].[CT_PHIEUTRA] ([MaChiTietPhieuTra], [MaPhieuTra], [MaVach]) VALUES (1, 1, N'100000035')
INSERT [dbo].[CT_PHIEUTRA] ([MaChiTietPhieuTra], [MaPhieuTra], [MaVach]) VALUES (2, 1, N'100000036')
SET IDENTITY_INSERT [dbo].[CT_PHIEUTRA] OFF
SET IDENTITY_INSERT [dbo].[CT_XULYVIPHAM] ON 

INSERT [dbo].[CT_XULYVIPHAM] ([MaChiTietXuLyViPham], [MaXuLyViPham], [MaLoaiViPham], [MaVach], [TienBoiThuong]) VALUES (1, 0, 1, N'100000035', 4000)
SET IDENTITY_INSERT [dbo].[CT_XULYVIPHAM] OFF
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170001', 1, N'7540106', N'Hứa Tôn Đạt', N'025895109', CAST(N'2020-12-09' AS Date), N'Nữ', N'0789163351', N'Vũng Tàu', N'huatondat@gmail.com', CAST(N'2021-07-17' AS Date), 1, CAST(N'2020-12-12' AS Date), N'2001170001.png', N'2001170001', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170018', 1, N'7480201', N'Hứa Tôn Đạt Nhật', N'025895109', CAST(N'2020-02-16' AS Date), N'Nam', N'0789163351', N'53/10 Đường 8B, P.BHHA, Quận Bình Tân', N'huatondat1621999@gmail.com', CAST(N'2021-01-12' AS Date), 0, CAST(N'2020-01-12' AS Date), N'2001170018.jpg', N'2001170018', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170019', 1, N'7480201', N'Hứa Tôn Đạt Nhật', N'025895109', CAST(N'2020-02-16' AS Date), N'Nam', N'0789163351', N'53/10 Đường 8B, P.BHHA, Quận Bình Tân', N'huatondat1621999@gmail.com', CAST(N'2021-01-12' AS Date), 0, CAST(N'2020-01-12' AS Date), N'2001170018.jpg', N'2001170018', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170020', 1, N'7480201', N'Hứa Tôn Đạt Nhật', N'025895109', CAST(N'2020-02-16' AS Date), N'Nam', N'0789163351', N'53/10 Đường 8B, P.BHHA, Quận Bình Tân', N'huatondat1621999@gmail.com', CAST(N'2021-01-12' AS Date), 0, CAST(N'2020-01-12' AS Date), N'2001170018.jpg', N'2001170018', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170031', 3, N'7480201', N'Trần Ngọc Sinh aa', N'025648885555', CAST(N'2018-12-02' AS Date), N'Nữ', N'0789163355', N'53111 Trần Bình Trọng, Quận 5', N'tranngocsinh@gmail.com', CAST(N'2021-01-12' AS Date), 1, CAST(N'2020-01-12' AS Date), N'2001170031.jpg', N'2001170031', 1)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170033', 1, N'7480201', N'Trần Phương Anh', N'025895109', CAST(N'2020-02-05' AS Date), N'Nam', N'0789163351', N'TP.HCM', N'phuonganh@gmail.com', CAST(N'2021-01-12' AS Date), 0, CAST(N'2020-12-11' AS Date), N'2001170033.jpg', N'2001170033', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170034', 2, N'7480201', N'Nguyễn Nhật Lâm', N'025891654', CAST(N'2020-05-16' AS Date), N'Nữ', N'0789163351', N'5351 3/2, Quận 11', N'nhatlam@gmail.com', CAST(N'2021-01-08' AS Date), 0, CAST(N'2020-01-08' AS Date), N'2001170034.jpg', N'nhatlam', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2001170092', 1, N'7340120', N'Nguyễn Thị Mỹ Duyên', N'0789163351', CAST(N'2020-02-16' AS Date), N'Nữ', N'0789163351', N'53/10 Đường 8B', N'nguyenthimyduyen@gmail.com', CAST(N'2021-01-12' AS Date), 0, CAST(N'2020-01-12' AS Date), N'2001170092.jpg', N'2001170092', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207519', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(N'2020-12-09' AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(N'2020-12-09' AS Date), 0, CAST(N'2020-12-12' AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207520', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(N'2020-12-09' AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(N'2020-12-09' AS Date), 0, CAST(N'2020-12-12' AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207521', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(N'2020-12-09' AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(N'2020-12-09' AS Date), 0, CAST(N'2020-12-12' AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207522', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(N'2020-12-09' AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(N'2020-12-09' AS Date), 0, CAST(N'2020-12-12' AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207523', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(N'2020-12-09' AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(N'2020-12-09' AS Date), 0, CAST(N'2020-12-12' AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207524', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(N'2020-12-09' AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(N'2020-12-09' AS Date), 0, CAST(N'2020-12-12' AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207525', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(N'2020-12-09' AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(N'2020-12-09' AS Date), 0, CAST(N'2020-12-12' AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207526', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(N'2020-12-09' AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(N'2020-12-09' AS Date), 0, CAST(N'2020-12-12' AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207527', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(N'2020-12-09' AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(N'2020-12-09' AS Date), 0, CAST(N'2020-12-12' AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207528', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(N'2020-12-09' AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(N'2020-12-09' AS Date), 0, CAST(N'2020-12-12' AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207529', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(N'2020-12-09' AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(N'2020-12-09' AS Date), 0, CAST(N'2020-12-12' AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207531', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(N'2020-12-09' AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(N'2020-12-09' AS Date), 0, CAST(N'2020-12-12' AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207532', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(N'2020-12-09' AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(N'2020-12-09' AS Date), 0, CAST(N'2020-12-12' AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207533', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(N'2020-12-09' AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(N'2020-12-09' AS Date), 0, CAST(N'2020-12-12' AS Date), N'2033207519.jpg', N'2033207519', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207534', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(N'2020-12-09' AS Date), N'Nữ', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(N'2020-12-09' AS Date), 0, CAST(N'2020-12-12' AS Date), N'2033207534.png', N'2033207534', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'2033207535', 1, N'7480201', N'Nguyễn Phương Anh Nhật', N'025895109', CAST(N'2020-12-09' AS Date), N'Nam', N'0789163351', N'53/10', N'huatondat@gmail.com', CAST(N'2020-12-09' AS Date), 1, CAST(N'2020-12-12' AS Date), N'2033207535.png', N'2033207535', 0)
INSERT [dbo].[DOCGIA] ([MaTheThuVien], [MaLoaiDocGia], [MaNganh], [TenDocGia], [CMND], [NgaySinh], [GioiTinh], [SoDienThoai], [DiaChi], [Email], [HanSuDungTheThuVien], [TinhTrangTheThuVien], [NgayLamThe], [HinhAnh], [MatKhau], [TinhTrangXoa]) VALUES (N'21381723123', 3, N'0', N'ádasdasd', N'123123123', CAST(N'2020-12-23' AS Date), N'Nam', N'123123123', N'12312312', N'12312312', CAST(N'2020-12-23' AS Date), 0, CAST(N'2020-12-23' AS Date), N'21381723123.png', N'21381723123', 0)
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

INSERT [dbo].[NHANVIEN] ([MaNhanVien], [MaLoaiNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SoDienThoai], [CMND], [DiaChi], [NgayVaoLam], [HinhAnh], [TinhTrangTK], [MatKhau], [TinhTrangXoa]) VALUES (10000001, 2, N'Hứa Tôn Đạt', CAST(N'2020-02-16' AS Date), N'Nam', N'0789163351', N'02589510912', N'53/10', CAST(N'2020-12-23' AS Date), N'10000001.png', 1, N'123', 0)
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [MaLoaiNhanVien], [TenNhanVien], [NgaySinh], [GioiTinh], [SoDienThoai], [CMND], [DiaChi], [NgayVaoLam], [HinhAnh], [TinhTrangTK], [MatKhau], [TinhTrangXoa]) VALUES (10000002, 1, N'Nguyễn Nhật Lâm', CAST(N'1999-12-23' AS Date), N'Nam', N'0789163351', N'012345678912', N'123123123123123', CAST(N'2020-12-23' AS Date), N'10000002.png', 1, N'123', 0)
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
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF001', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF002', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF003', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF004', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF005', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF006', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF007', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF008', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (2, N'SF009', 0)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF001', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF002', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF003', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF004', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF005', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF006', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF007', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF008', 1)
INSERT [dbo].[PHANQUYEN] ([MaLoaiNhanVien], [MaManHinh], [CoQuyen]) VALUES (3, N'SF009', 1)
SET IDENTITY_INSERT [dbo].[PHIEUMUON] ON 

INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaTheThuVien], [MaNhanVien], [NgayLap], [ThoiHanMuon], [SoSachMuon], [TinhTrangTra], [PhiCoc], [TinhTrangXoa]) VALUES (2, N'2001170018', 1, CAST(N'2020-12-23' AS Date), CAST(N'2020-01-01' AS Date), 3, 0, 500000, 0)
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaTheThuVien], [MaNhanVien], [NgayLap], [ThoiHanMuon], [SoSachMuon], [TinhTrangTra], [PhiCoc], [TinhTrangXoa]) VALUES (3, N'2001170034', 1, CAST(N'2020-12-23' AS Date), CAST(N'2020-01-01' AS Date), 2, 0, 50000, 0)
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaTheThuVien], [MaNhanVien], [NgayLap], [ThoiHanMuon], [SoSachMuon], [TinhTrangTra], [PhiCoc], [TinhTrangXoa]) VALUES (4, N'2001170034', 1, CAST(N'2020-12-23' AS Date), CAST(N'2020-01-01' AS Date), 1, 0, 555555, 0)
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaTheThuVien], [MaNhanVien], [NgayLap], [ThoiHanMuon], [SoSachMuon], [TinhTrangTra], [PhiCoc], [TinhTrangXoa]) VALUES (5, N'2001170031', 1, CAST(N'2020-12-23' AS Date), CAST(N'2020-01-01' AS Date), 1, 0, 2222, 0)
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaTheThuVien], [MaNhanVien], [NgayLap], [ThoiHanMuon], [SoSachMuon], [TinhTrangTra], [PhiCoc], [TinhTrangXoa]) VALUES (6, N'2001170031', 1, CAST(N'2020-12-23' AS Date), CAST(N'2020-01-01' AS Date), 1, 0, 5555, 0)
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaTheThuVien], [MaNhanVien], [NgayLap], [ThoiHanMuon], [SoSachMuon], [TinhTrangTra], [PhiCoc], [TinhTrangXoa]) VALUES (7, N'2001170031', 1, CAST(N'2020-12-23' AS Date), CAST(N'2020-01-01' AS Date), 1, 0, 555, 0)
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaTheThuVien], [MaNhanVien], [NgayLap], [ThoiHanMuon], [SoSachMuon], [TinhTrangTra], [PhiCoc], [TinhTrangXoa]) VALUES (8, N'2001170092', 1, CAST(N'2020-12-23' AS Date), CAST(N'2020-01-01' AS Date), 3, 0, 55555, 0)
INSERT [dbo].[PHIEUMUON] ([MaPhieuMuon], [MaTheThuVien], [MaNhanVien], [NgayLap], [ThoiHanMuon], [SoSachMuon], [TinhTrangTra], [PhiCoc], [TinhTrangXoa]) VALUES (9, N'2001170019', 1, CAST(N'2020-12-23' AS Date), CAST(N'2021-01-23' AS Date), 3, 0, 5555555, 0)
SET IDENTITY_INSERT [dbo].[PHIEUMUON] OFF
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] ON 

INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (1, 10000002, CAST(N'2020-12-16' AS Date), NULL, 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (2, 10000001, CAST(N'2020-12-16' AS Date), NULL, 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (3, 10000001, CAST(N'2020-12-16' AS Date), NULL, 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (4, 10000002, CAST(N'2020-12-16' AS Date), NULL, 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (5, 10000001, CAST(N'2020-12-16' AS Date), NULL, 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (6, 10000001, CAST(N'2020-12-16' AS Date), NULL, 0)
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [MaNhanVien], [NgayNhap], [TongTien], [TinhTrangXoa]) VALUES (7, 10000001, CAST(N'2020-12-20' AS Date), NULL, 0)
SET IDENTITY_INSERT [dbo].[PHIEUNHAP] OFF
SET IDENTITY_INSERT [dbo].[PHIEUTRA] ON 

INSERT [dbo].[PHIEUTRA] ([MaPhieuTra], [MaPhieuMuon], [MaNhanVien], [NgayLap], [SoLuongSachTra], [TinhTrangXoa]) VALUES (1, 9, 1, CAST(N'2020-12-23' AS Date), 2, 0)
SET IDENTITY_INSERT [dbo].[PHIEUTRA] OFF
INSERT [dbo].[PHIEUXULYVIPHAM] ([MaXuLyViPham], [MaPhieuTra], [MaNhanVien], [NgayLap], [TinhTrangXoa], [TongTienBoiThuong]) VALUES (0, 1, NULL, CAST(N'2020-12-23' AS Date), 0, 4000)
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
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000000', N'1000001', 1, N'1', 1, N'0', N'Từ Điển Việt - Hán Hiện Đại', 1440, 120000, 2018, 1, 1, N'Từ Điển Việt - Hán Hiện Đại', 1, N'B-400', N'100000000.jpg', 0)
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

Chiến Lược Dữ Liệu không chỉ phù hợp cho người bước đầu làm quen với dữ liệu, mà còn cung cấp nhịp điệu bao quát về những thay đổi đang diễn ra trên thị trường và trang bị nền tảng ban đầu cho người đang chịu trách nhiệm về mảng dữ liệu của doanh nghiệp.', 1, N'A-200', N'100000027.jpg', 0)
INSERT [dbo].[TAILIEU] ([MaVach], [MaTaiLieu], [MaLoaiTaiLieu], [MaDauTaiLieu], [MaChuDe], [MaTap], [TenTaiLieu], [SoTrang], [Gia], [NamXuatBan], [MaTacGia], [MaNhaXuatBan], [ThongTinTaiLieu], [MaNgonNgu], [MaViTri], [HinhAnh], [TinhTrangXoa]) VALUES (N'100000028', N'1000010', 1, N'2', 6, N'0', N'Data Strategy - Chiến Lược Dữ Liệu', 272, 79000, 2019, 9, 10, N'Data Strategy - Chiến Lược Dữ Liệu

Dữ liệu đang thay đổi cách chúng ta sống và làm việc với tốc độ chưa từng có. Nó là tất cả dấu vết ta để lại khi lướt web, mua hàng qua thẻ tín dụng, gửi e-mail, chụp ảnh, đọc báo trực tuyến, thậm chí dạo phố khi mang theo điện thoại di động hoặc đi trong khu vực có hệ thống .

Nhờ vào dữ liệu, nhà bán lẻ Target tại Mỹ đã dự đoán đúng một thiếu nữ đang mang thai dựa trên thói quen mua hàng của cô ấy; Google có thể hiển thị chính xác quảng cáo phù hợp với bạn; Facebook biết bạn của bạn là ai, bạn đang trong mối quan hệ với người nào, dự đoán được mối quan hệ này kéo dài trong bao lâu, khi nào bạn sẽ có một mối quan hệ tình cảm, thậm chí cho biết mức độ thông minh của bạn…

Tuy nhiên, hiện có chưa đến 0,5% dữ liệu được phân tích và sử dụng. Nhận thấy mảnh đất màu mỡ này, Bernard Marr đã cho ra đời Chiến Lược Dữ Liệu - nơi hội tụ những kiến thức về dữ liệu được đơn giản hóa với nhiều ví dụ dễ hiểu - cung cấp cho bạn cách thức tối đa hóa sức mạnh của dữ liệu bên cạnh việc tránh những rắc rối liên quan đến pháp lý, danh tiếng và tài chính.

Tầm quan trọng của chiến lược dữ liệu ngày càng được khẳng định qua thành công của các doanh nghiệp hoạt động trên nền tảng dữ liệu như Alphabet, Facebook, Narrative Science, Amazon, Apple… Việc có một chiến lược dữ liệu mạnh và lộ trình khoa học đã trở thành một phần tất yếu trong ADN của mỗi tổ chức. Nó xứng đáng nhận được sự quan tâm ngang với chiến lược marketing, khách hàng, sản phẩm hay thu hút nhân tài của doanh nghiệp.

Chiến Lược Dữ Liệu không chỉ phù hợp cho người bước đầu làm quen với dữ liệu, mà còn cung cấp nhịp điệu bao quát về những thay đổi đang diễn ra trên thị trường và trang bị nền tảng ban đầu cho người đang chịu trách nhiệm về mảng dữ liệu của doanh nghiệp.', 1, N'A-200', N'100000028.jpg', 0)
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
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [Ke]) VALUES (N'A-000', 1, N'000')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [Ke]) VALUES (N'A-100', 1, N'100')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [Ke]) VALUES (N'A-200', 1, N'200')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [Ke]) VALUES (N'B-300', 2, N'300')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [Ke]) VALUES (N'B-400', 2, N'400')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [Ke]) VALUES (N'B-500', 2, N'500')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [Ke]) VALUES (N'C-600', 3, N'600')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [Ke]) VALUES (N'C-700', 3, N'600')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [Ke]) VALUES (N'C-800', 3, N'800')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [Ke]) VALUES (N'D-900', 4, N'900')
INSERT [dbo].[VITRI] ([MaViTri], [Tang], [Ke]) VALUES (N'D-901', 4, N'901')
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
