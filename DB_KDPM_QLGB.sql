create database DB_KDPM_QLGB
go
use DB_KDPM_QLGB

create table NhanVien
(
	MaNV int identity(1,1),
	TenNV nvarchar(100),
	GioiTinh nvarchar(5),
	DiaChi nvarchar(100),
	SDT varchar(10),
	constraint PK_NhanVien primary key (MaNV)
)

create table KhachHang
(
	MaKH int identity(1,1),
	TenKH nvarchar(100),
	Email nvarchar(100),
	DiaChi nvarchar(100),
	SDT varchar(10),
	constraint PK_KhachHang primary key (MaKH)
)

create table PhanQuyen
(
	MaQuyen int identity(1,1),
	TenQuyen nvarchar(100),
	GhiChu nvarchar(100),
	constraint PK_PhanQuyen primary key (MaQuyen)
)

create table TaiKhoan
(	
	MaTaiKhoan int identity(1,1),
	TenDangNhap nvarchar(100),
	MatKhau nvarchar(100),
	MaNV int unique,
	MaQuyen int,
	TinhTrang bit,
	constraint PK_TaiKhoan primary key (MaTaiKhoan)
)

create table LoaiBao
(
	MaLoaiBao int identity(1,1),
	TenLoaiBao nvarchar(100),
	GiaTien float,
	constraint PK_LoaiBao primary key (MaLoaiBao)
)

create table DatBao
(
	MaDatBao int identity(1,1),
	NgayDat datetime,
	MaKH int,
	MaNV int,
	TongTien float,
	TinhTrang bit,
	constraint PK_DatBao primary key (MaDatBao)
)

create table ChiTietDatBao
(
	MaDatBao int,
	MaLoaiBao int,
	SoKy int,
	SoLuong int,
	ThanhTien float,
	constraint PK_ChiTietDatBao primary key (MaDatBao, MaLoaiBao)
)
 
alter table TaiKhoan add
constraint FK_TaiKhoan_NhanVien foreign key (MaNV) references NhanVien (MaNV),
constraint FK_TaiKhoan_PhanQuyen foreign key (MaQuyen) references PhanQuyen (MaQuyen)

alter table DatBao add
constraint FK_DatBao_NhanVien foreign key (MaNV) references NhanVien (MaNV),
constraint FK_DatBao_KhachHang foreign key (MaKH) references KhachHang (MaKH)

alter table ChiTietDatBao add
constraint FK_CTDB_DatBao foreign key (MaDatBao) references DatBao (MaDatBao),
constraint FK_CTDB_LoaiBao foreign key (MaLoaiBao) references LoaiBao (MaLoaiBao)

insert into PhanQuyen values
(N'Nhân viên quản lý', N''),
(N'Nhân viên giao báo', N''),
(N'Nhân viên đặt báo', N'')

insert into NhanVien values
(N'Hồ Đăng Trí', N'Nam', N'Huế', '0912345678'),
(N'Nguyễn Văn A', N'Nam', N'Hà Nội', '0123456789'),
(N'Nguyễn Văn B', N'Nam', N'Hải Phòng', '0987654321'),
(N'Nguyễn Văn C', N'Nam', N'Đà Nẵng', '0111123456'),
(N'Trần Thị D', N'Nữ', N'Tuy Hòa', '0999123999'),
(N'Trần Thị E', N'Nữ', N'Hà Nội', '0999444999'),
(N'Trần Thị F', N'Nữ', N'TP.HCM', '0999444555')

insert into TaiKhoan values
(N'dangtri', N'dangtri123', 1, 1, 1),
(N'vana', N'vana123', 2, 1, 3),
(N'vanb', N'vanb123', 3, 1, 2),
(N'vanc', N'vanc123', 4, 1, 3),
(N'thid', N'thid123', 5, 1, 1),
(N'thie', N'thie123', 6, 1, 2),
(N'thif', N'thif123', 7, 1, 2)

insert into KhachHang values
(N'Trần Đức Nhân', N'ducnhan@gmail.com', N'81 Phạm Văn Hai, Phường 15, Quận 1, TP.HCM', '0912371278'),
(N'Lê Thành Công', N'thanhcong@gmail.com', N'291/23/1 Đồng Đen, Phường 1, Quận Tân Bình, TP.HCM', '0992173782'),
(N'Nguyễn Ái Nhi', N'ainhiz@gmail.com', N'42 Đội Cấn, Xã Thành Thái, Hà Nội', '0901971138')

insert into LoaiBao values
(N'Nhật báo Buổi Sáng', 5500),
(N'Buổi Sáng Cuối Tuần', 14500)