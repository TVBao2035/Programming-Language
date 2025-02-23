create database NV
go
USE [NV]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 10/09/2024 8:30:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [varchar](10) NOT NULL,
	[Hoten] [nvarchar](50) NULL,
	[Ngaysinh] [datetime] NULL,
	[Diachi] [nvarchar](50) NULL,
	[MaPhong] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHANCONG]    Script Date: 10/09/2024 8:30:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHANCONG](
	[MaNV] [varchar](10) NOT NULL,
	[MaVT] [nchar](10) NOT NULL,
	[Luong] [numeric](18, 0) NULL,
	[Phucap] [numeric](18, 0) NULL,
 CONSTRAINT [PK_PHANCONG] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC,
	[MaVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHONGBAN]    Script Date: 10/09/2024 8:30:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHONGBAN](
	[MaPhong] [varchar](5) NOT NULL,
	[TenPhong] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[VITRIVL]    Script Date: 10/09/2024 8:30:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VITRIVL](
	[MaVT] [nchar](10) NOT NULL,
	[Tenvitri] [nchar](100) NULL,
	[Mucluong] [numeric](18, 0) NULL,
 CONSTRAINT [PK_VITRIVL] PRIMARY KEY CLUSTERED 
(
	[MaVT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Diachi], [MaPhong]) VALUES (N'A001', N'Nguyễn Tâm Đăng', CAST(N'1997-12-07 00:00:00.000' AS DateTime), N'Mỹ Tho Tiền Giang', N'KT')
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Diachi], [MaPhong]) VALUES (N'A002', N'Phan Tâm Đăng', CAST(N'1997-12-07 00:00:00.000' AS DateTime), N'Mỹ Tho Tiền Giang', N'GDTX')
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Diachi], [MaPhong]) VALUES (N'A003', N'Lê Minh Tường', CAST(N'1997-12-07 00:00:00.000' AS DateTime), N'Mỹ Tho Tiền Giang', N'KT')
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Diachi], [MaPhong]) VALUES (N'A004', N'Lê Ngọc Minh Thư', CAST(N'1997-12-07 00:00:00.000' AS DateTime), N'Mỹ Tho Tiền Giang', N'KTDBC')
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Diachi], [MaPhong]) VALUES (N'A005', N'Phan Khánh Nam', CAST(N'1997-12-07 00:00:00.000' AS DateTime), N'Mỹ Tho Tiền Giang', N'GDTX')
INSERT [dbo].[NHANVIEN] ([MaNV], [Hoten], [Ngaysinh], [Diachi], [MaPhong]) VALUES (N'A007', N'Lê Minh Phước ', NULL, NULL, NULL)
INSERT [dbo].[PHANCONG] ([MaNV], [MaVT], [Luong], [Phucap]) VALUES (N'A001', N'CV        ', CAST(6000 AS Numeric(18, 0)), CAST(0 AS Numeric(18, 0)))
INSERT [dbo].[PHANCONG] ([MaNV], [MaVT], [Luong], [Phucap]) VALUES (N'A002', N'GD        ', CAST(15000 AS Numeric(18, 0)), CAST(0 AS Numeric(18, 0)))
INSERT [dbo].[PHANCONG] ([MaNV], [MaVT], [Luong], [Phucap]) VALUES (N'A002', N'PGD       ', CAST(10000 AS Numeric(18, 0)), NULL)
INSERT [dbo].[PHANCONG] ([MaNV], [MaVT], [Luong], [Phucap]) VALUES (N'A003', N'PGD       ', CAST(13000 AS Numeric(18, 0)), NULL)
INSERT [dbo].[PHANCONG] ([MaNV], [MaVT], [Luong], [Phucap]) VALUES (N'A003', N'TP        ', CAST(12000 AS Numeric(18, 0)), NULL)
INSERT [dbo].[PHANCONG] ([MaNV], [MaVT], [Luong], [Phucap]) VALUES (N'A004', N'CVC       ', CAST(7000 AS Numeric(18, 0)), NULL)
INSERT [dbo].[PHANCONG] ([MaNV], [MaVT], [Luong], [Phucap]) VALUES (N'A005', N'PP        ', CAST(8000 AS Numeric(18, 0)), NULL)
INSERT [dbo].[PHONGBAN] ([MaPhong], [TenPhong]) VALUES (N'GDTX', N'Trung tâm GD thường xuyên')
INSERT [dbo].[PHONGBAN] ([MaPhong], [TenPhong]) VALUES (N'KT', N'Phòng Kế toán')
INSERT [dbo].[PHONGBAN] ([MaPhong], [TenPhong]) VALUES (N'KTDBC', N'Trung tâm KT & ĐB chất lượng')
INSERT [dbo].[PHONGBAN] ([MaPhong], [TenPhong]) VALUES (N'TCHC', N'Phòng Tổ chức hành chính')
INSERT [dbo].[PHONGBAN] ([MaPhong], [TenPhong]) VALUES (N'TV', N'Phòng Tài vụ')
INSERT [dbo].[VITRIVL] ([MaVT], [Tenvitri], [Mucluong]) VALUES (N'CV        ', N'Chuyên viên                                                                                         ', CAST(6000 AS Numeric(18, 0)))
INSERT [dbo].[VITRIVL] ([MaVT], [Tenvitri], [Mucluong]) VALUES (N'CVC       ', N'Chuyên viên chính                                                                                   ', CAST(7000 AS Numeric(18, 0)))
INSERT [dbo].[VITRIVL] ([MaVT], [Tenvitri], [Mucluong]) VALUES (N'GD        ', N'Giám đốc                                                                                            ', CAST(15000 AS Numeric(18, 0)))
INSERT [dbo].[VITRIVL] ([MaVT], [Tenvitri], [Mucluong]) VALUES (N'NV        ', N'Nhân viên hợp đồng                                                                                  ', CAST(4500 AS Numeric(18, 0)))
INSERT [dbo].[VITRIVL] ([MaVT], [Tenvitri], [Mucluong]) VALUES (N'PGD       ', N'Phó giám đốc                                                                                        ', CAST(12000 AS Numeric(18, 0)))
INSERT [dbo].[VITRIVL] ([MaVT], [Tenvitri], [Mucluong]) VALUES (N'PP        ', N'Phó phòng                                                                                           ', CAST(8000 AS Numeric(18, 0)))
INSERT [dbo].[VITRIVL] ([MaVT], [Tenvitri], [Mucluong]) VALUES (N'TP        ', N'Trưởng phòng                                                                                        ', CAST(10000 AS Numeric(18, 0)))
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD FOREIGN KEY([MaPhong])
REFERENCES [dbo].[PHONGBAN] ([MaPhong])
GO
/****** Object:  StoredProcedure [dbo].[xemnv]    Script Date: 10/09/2024 8:30:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[xemnv]
as
begin
  Select MaNV, Hoten From NHANVIEN
 end
GO
