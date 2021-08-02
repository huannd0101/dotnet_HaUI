
CREATE DATABASE Demo2
GO

USE Demo2
GO

CREATE TABLE HangSX (
	MaHang int primary key, 
	TenHang nvarchar(30)
)

create table SanPham (
	MaSP int primary key, 
	TenSP nvarchar(30),
	SoLuong int, 
	MaHang int foreign key(MaHang) references HangSX(MaHang)
)

insert into HangSX values
(1, N'Thiếu niên'),
(2, N'Nhi Đồng'),
(3, N'Tiền Phong')

insert into SanPham values
(1, N'Bút chì', 2, 1)