CREATE Database QLNV
GO
use QLNV
GO
CREATE TABLE PhongBan(MaPhong nVarChar(10), TenPhong nVarChar(50),
constraint PK_Phong primary key (MaPhong)
);

Go

CREATE TABLE NhanVien(MaNV nVarChar(10), HoTen nVarChar(50), NgaySinh Date, DiaChi nvarchar(50), MaPhong nvarchar(10),
constraint PK_nhanvien primary key (MaNV)
);

Go

-------------------Tao Khoa ngoai---------------------
ALTER TABLE NhanVien ADD CONSTRAINT FK_nvphong FOREIGN KEY (MaPhong) REFERENCES PhongBan(MaPhong)
------Them du lieu--------------
-- Phong ban
go
INSERT INTO PhongBan([MaPhong], [TenPhong])VALUES('P001',N'Phòng kế hoạch')
INSERT INTO PhongBan([MaPhong], [TenPhong])VALUES('P002',N'Phòng đào tạo')
INSERT INTO PhongBan([MaPhong], [TenPhong])VALUES('P003',N'Phòng tổ chức')
INSERT INTO PhongBan([MaPhong], [TenPhong])VALUES('P004',N'Phòng hành chính')
INSERT INTO PhongBan([MaPhong], [TenPhong])VALUES('P005',N'Phòng công tác sinh viên')
go
----Nhà nhân viên
INSERT INTO NhanVien([MaNV], [HoTen], [NgaySinh], [DiaChi] , [MaPhong])VALUES('NV0001',N'Nguyễn Phú Lâm','12/1/1987', N'Tiền Giang','P001')
INSERT INTO NhanVien([MaNV], [HoTen], [NgaySinh], [DiaChi] , [MaPhong])VALUES('NV0002',N'Trần Thanh Liêm','2/15/1980', N'Long An','P001')
INSERT INTO NhanVien([MaNV], [HoTen], [NgaySinh], [DiaChi] , [MaPhong])VALUES('NV0003',N'Võ Thanh Hiền','7/25/1988', N'Bến Tre','P002')
INSERT INTO NhanVien([MaNV], [HoTen], [NgaySinh], [DiaChi] , [MaPhong])VALUES('NV0004',N'Nguyễn Thị Hoa','5/10/1981', N'Vĩnh Long','P002')
INSERT INTO NhanVien([MaNV], [HoTen], [NgaySinh], [DiaChi] , [MaPhong])VALUES('NV0005',N'Nguyễn Chí Thanh','12/21/1980', N'Tiền Giang','P003')
INSERT INTO NhanVien([MaNV], [HoTen], [NgaySinh], [DiaChi] , [MaPhong])VALUES('NV0006',N'Ngô Thanh Mộng','9/18/1982', N'Bến Tre','P003')
