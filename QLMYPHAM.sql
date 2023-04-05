CREATE DATABASE BTLQUANLYMYPHAM
GO
USE BTLQUANLYMYPHAM
GO

CREATE TABLE tblNHANVIEN(
	iMaNV varchar(20) PRIMARY KEY,
	sHoTen NVARCHAR(50),
	dNgaySinh DATETIME,
	sGioiTinh NVARCHAR(20),
	fPhuCap FLOAT,
	fLuongCB FLOAT,
	sDienThoai NVARCHAR(20)
)

INSERT INTO tblNHANVIEN (iMaNV, sHoTen, dNgaySinh, sGioiTinh, fPhuCap, fLuongCB, sDienThoai)
VALUES
('1', N'Minh Ngọc', '11/12/1999', N'Nữ', 20000, 6000000, N'0985675366'),
('2', N'Hoàng Thùy', '01/23/1997', N'Nữ', 50000, 7000000, N'0934123543'),
('3', N'Đặng Khánh', '10/1/2000', N'Nam', 70000, 8000000, N'0987852145'),
('4', N'Thành Đạt', '08/27/2002', N'Nam', 50000, 7000000, N'0956875432'),
('5', N'Diễm Quỳnh', '07/16/2001', N'Nữ', 80000, 9000000, N'0978995345')

SELECT * FROM tblNHANVIEN


CREATE TABLE tblKHACHHANG(
	iMaKH varchar(20) PRIMARY KEY,
	sHoTen NVARCHAR(50),
	sDienThoai NVARCHAR(15),
	sDiaChi NVARCHAR(30),
)

INSERT INTO tblKHACHHANG(iMaKH, sHoTen, sDienThoai, sDiaChi)
VALUES
('1', N'Thu Trang', '0975345233', N'Hà Nội'),
('2', N'Tiến Thành', '0976567899', N'Bắc Ninh'),
('3', N'Huy Hoàng', '0943234322', N'Đà Nẵng'),
('4', N'Phương Vy', '0943563333', N'TP HCM'),
('5', N'Ngọc Hà', '0956767767', N'Hà Nội')

SELECT * FROM tblKHACHHANG

CREATE TABLE tblNHACC(
	iMaNCC varchar(20) PRIMARY KEY,
	sTenNCC NVARCHAR(30),
	sDiaChi NVARCHAR(30),
	sSDT NVARCHAR(15),
)

INSERT INTO tblNHACC(iMaNCC, sTenNCC, sDiaChi, sSDT)
VALUES
(1, N'Dior', N'Pháp', '0978987987'),
(2, N'Maybelline', N'Mỹ', '0945454543'),
(3, N'Loreal', N'Hàn Quốc', '0923212121'),
(4, N'Chanel', N'Anh', '0967656565'),
(6, N'Ohui', N'Hàn Quốc', '0974343232')

SELECT * FROM tblNHACC

CREATE TABLE tblLOAISP(
	sMaLoaiSP NVARCHAR(10) PRIMARY KEY,
	sTenLoaiSP NVARCHAR(50)
)

INSERT INTO tblLOAISP(sMaLoaiSP, sTenLoaiSP)
VALUES
(N'L01', N'Trang điểm'),
(N'L02', N'Chăm sóc da mặt'),
(N'L03', N'Chăm sóc tóc'),
(N'L04', N'Chăm sóc toàn thân')

SELECT * FROM tblLOAISP

CREATE TABLE tblSANPHAM(
	sMaSP NVARCHAR(30) PRIMARY KEY,
	sMaLoaiSP NVARCHAR(10) NOT NULL REFERENCES tblLOAISP (sMaLoaiSP),
	sTenSP NVARCHAR(50),
	iMaNCC varchar(20) NOT NULL REFERENCES tblNHACC (iMaNCC),
	sHangSX NVARCHAR(30),
	MauSac NVARCHAR(30),
	sDungTich NVARCHAR(30),
	iSoLuong INT,
	fGiaHang FLOAT
)


INSERT INTO tblSANPHAM(sMaSP, sMaLoaiSP, sTenSP, iMaNCC, sHangSX, MauSac, sDungTich, iSoLuong, fGiaHang)
VALUES
(N'SP1', N'L01', N'Son Dior', '1', N'Dior', N'Đỏ nâu', N'5g', 20, 1000000),
(N'SP2', N'L01', N'Son Chanel', '4', N'Chanel', N'Nâu Đất', N'10g', 10, 8000000),
(N'SP3', N'L01', N'Kem nền Maybelline', '2', N'Maybelline', N'Trong suốt', N'20g', 15, 400000),
(N'SP4', N'L02', N'Tẩy trang Loreal', '3', N'Loreal', N'Nước', N'100ml', 50, 90000),
(N'SP5', N'L02', N'Kem dưỡng Ohui', '1', N'Ohui', N'Không mùi', N'50ml', 5, 1500000)

SELECT * FROM tblSANPHAM

CREATE TABLE tblHOADONBAN(
	iMaHDB varchar(20) PRIMARY KEY,
	iMaNV varchar(20) NOT NULL REFERENCES tblNHANVIEN(iMaNV),
	iMaKH varchar(20) NOT NULL REFERENCES tblKHACHHANG(iMaKH),
	dNgayDat DATETIME,
	dNgayGiao DATETIME,
	sDiaChiGiao NVARCHAR(30)
)

INSERT INTO tblHOADONBAN(iMaHDB, iMaNV, iMaKH, dNgayDat, dNgayGiao, sDiaChiGiao)
VALUES
('1', '1', '1', '2/2/2022','2/10/2022', N'Thanh Xuân - Hà Nội'),
('2', '2', '2', '2/1/2023','2/13/2023', N'Quận 1 - HCM'),
('3', '3', '3', '3/2/2023','3/25/2023', N'Đống Đa - Hà Nội'),
('4', '4', '4', '1/8/2023','1/15/2022', N'Hoàng Mai - Hà Nội'),
('5', '5', '5', '2/1/2022','2/12/2022', N'Quận 7 - HCM')

SELECT * FROM tblHOADONBAN

CREATE TABLE tblHOADONNHAP(
	iMaHDN varchar(20) PRIMARY KEY,
	iMaNV varchar(20) NOT NULL REFERENCES tblNHANVIEN (iMaNV),
	dNgayNhap DATETIME
)

INSERT INTO tblHOADONNHAP(iMaHDN, iMaNV, dNgayNhap)
VALUES
('1', '1', '12/12/2022'),
('2', '2', '11/11/2022'),
('3', '3', '10/2/2022'),
('4', '4', '9/15/2022'),
('5', '5', '8/10/2022')

SELECT * FROM tblHOADONNHAP

CREATE TABLE tblCT_HDB(
	iMaHDB varchar(20) REFERENCES tblHOADONBAN (iMaHDB),
	sMaSP NVARCHAR(30) NOT NULL REFERENCES tblSANPHAM (sMaSP),
	fGiaBan FLOAT,
	iSoLuong INT,
	CONSTRAINT PK_CT_HDB PRIMARY KEY (iMaHDB, sMaSP) 
)

INSERT INTO tblCT_HDB(iMaHDB, sMaSP, fGiaBan, iSoLuong)
VALUES
('1', N'SP1', 1100000, 1),
('2', N'SP2', 8200000, 2),
('3', N'SP3', 500000, 3),
('4', N'SP4', 100000, 4),
('5', N'SP5', 1800000, 2)

SELECT * FROM tblCT_HDB

CREATE TABLE tblCT_HDN(
	iMaHDN varchar(20) REFERENCES tblHOADONNHAP (iMaHDN),
	sMaSP NVARCHAR(30) NOT NULL REFERENCES tblSANPHAM (sMaSP),
	fGiaNhap FLOAT,
	iSoLuong INT,
	CONSTRAINT PK_CT_HDN PRIMARY KEY (iMaHDN, sMaSP) 
)

INSERT INTO tblCT_HDN(iMaHDN, sMaSP, fGiaNhap, iSoLuong)
VALUES
(1, N'SP1', 1000000, 20),
(2, N'SP2', 8000000, 10),
(3, N'SP3', 400000, 15),
(4, N'SP4', 900000, 50),
(5, N'SP5', 1500000, 5)

SELECT * FROM tblCT_HDN


-- Tạo bảng Người dùng
CREATE TABLE tblUsers (
    ID VARCHAR(20) PRIMARY KEY ,
    Username NVARCHAR(50) NOT NULL,
    Passwords NVARCHAR(50) NOT NULL,
    FullName NVARCHAR(50),
    Email NVARCHAR(50),
    Phone NVARCHAR(20),
    RoleID VARCHAR(20) FOREIGN KEY REFERENCES tblRoles(ID)
);

-- Tạo bảng Vai trò
CREATE TABLE tblRoles (
    ID VARCHAR(20) PRIMARY KEY ,
    Name NVARCHAR(50) NOT NULL
);

-- Tạo bảng Phân quyền
CREATE TABLE tblPermission (
    ID VARCHAR(20) PRIMARY KEY ,
    UserID VARCHAR(20) FOREIGN KEY REFERENCES tblUsers(ID),
    RoleID VARCHAR(20) FOREIGN KEY REFERENCES tblRoles(ID)
);
--thêm dữ liệu
INSERT INTO tblRoles(ID,Name)
VALUES 
('1',N'ADMINMP'),
('2',N'USER1')

INSERT INTO tblUsers(ID,Username,Passwords,FullName,Email,Phone,RoleID)
VALUES
('1',N'ADMIN',N'admin',N'Đắc Quyết',N'luuphuongvy0209@gmail.com',N'0879817410','1'),
('2',N'Tramy',N'123',N'Trà My',N'tramy1102@gmail.com',N'0879817411','2')

INSERT INTO tblPermission(ID,RoleID,UserID)
VALUES
('1','1','1'),
('2','2','2')
--proc nhanvien
CREATE OR ALTER PROC themNV
(
@iMaNV varchar(20),
@sHoTen nvarchar(50),
@dNgaySinh datetime,
@sGioiTinh nvarchar(20),
@fPhuCap float,
@fLuongCB float,
@sDienThoai nvarchar(20)
)
AS
BEGIN
INSERT INTO tblNHANVIEN
VALUES
(
@iMaNV,
@sHoTen,
@dNgaySinh,
@sGioiTinh,
@fPhuCap,
@fLuongCB,
@sDienThoai
)
END
GO
CREATE OR ALTER PROC XoaNhanVien
    @MaNV varchar(20)
AS
BEGIN
    DELETE FROM tblNHANVIEN WHERE iMaNV = @MaNV
END
GO
CREATE OR ALTER PROCEDURE suaNV 
    @iMaNV varchar(20),
    @sHoTen nvarchar(50),
    @dNgaySinh datetime,
    @sGioiTinh nvarchar(20),
    @fPhuCap float,
    @fLuongCB float,
    @sDienThoai nvarchar(20)
AS
BEGIN
    UPDATE tblNHANVIEN 
    SET sHoTen = @sHoTen, 
        dNgaySinh = @dNgaySinh, 
        sGioiTinh = @sGioiTinh,
        fPhuCap = @fPhuCap,
        fLuongCB = @fLuongCB,
        sDienThoai = @sDienThoai
    WHERE iMaNV = @iMaNV;
END

CREATE OR ALTER PROC timNV 
(
    @iMaNV varchar(20)
)
AS
BEGIN
    SELECT * FROM tblNHANVIEN WHERE iMaNV = @iMaNV;
END





CREATE OR ALTER PROC themSP 
(
    @MaSP nvarchar(30),
    @MaLoaiSP nvarchar(10),
    @MaNCC varchar(20),
    @TenSP nvarchar(50),
    @HangSX nvarchar(30),
    @MauSac nvarchar(30),
    @DungTich nvarchar(30),
    @SoLuong int,
    @GiaHang float
)
AS
BEGIN
    IF EXISTS (SELECT * FROM tblLOAISP WHERE sMaLoaiSP = @MaLoaiSP) AND EXISTS (SELECT * FROM tblNHACC WHERE iMaNCC = @MaNCC)
    BEGIN
        INSERT INTO tblSANPHAM (sMaSP, sMaLoaiSP, sTenSP, iMaNCC, sHangSX, MauSac, sDungTich, iSoLuong, fGiaHang)
        VALUES (@MaSP, @MaLoaiSP, @TenSP, @MaNCC, @HangSX, @MauSac, @DungTich, @SoLuong, @GiaHang)
    END
    ELSE
    BEGIN
        RAISERROR ('Khong tim thay MaLoaiSP hoac MaNCC tuong ung.', 16, 1);
    END
END


CREATE OR ALTER PROCEDURE timKiemSanPham
    @tenSP NVARCHAR(50)
AS
BEGIN
    SELECT * FROM tblSANPHAM WHERE sTenSP LIKE '%' + @tenSP + '%'
END

CREATE OR ALTER PROCEDURE TimKiemSanPham
    @MaSP NVARCHAR(30) = NULL,
    @TenSP NVARCHAR(50) = NULL
AS
BEGIN
    SELECT * FROM tblSANPHAM
    WHERE (@MaSP IS NULL OR sMaSP LIKE '%' + @MaSP + '%')
        AND (@TenSP IS NULL OR sTenSP LIKE '%' + @TenSP + '%')
END



--proc khachhang
CREATE or ALTER PROCEDURE themKH 
    @MaKH varchar(20),
    @HoTen nvarchar(50),
    @DienThoai nvarchar(15),
    @DiaChi nvarchar(30)
AS
BEGIN
    SET NOCOUNT ON;

    IF NOT EXISTS (SELECT * FROM tblKHACHHANG WHERE iMaKH = @MaKH)
    BEGIN
        INSERT INTO tblKHACHHANG (iMaKH, sHoTen, sDienThoai, sDiaChi)
        VALUES (@MaKH, @HoTen, @DienThoai, @DiaChi);
    END
END

CREATE or ALTER PROCEDURE xoaKHACHHANG 
    @MaKH varchar(20)
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM tblKHACHHANG
    WHERE iMaKH = @MaKH;
END


CREATE PROCEDURE suaKHACHHANG 
    @MaKH varchar(20),
    @TenKH nvarchar(50),
    @DienThoai nvarchar(15),
    @DiaChi nvarchar(30)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE tblKHACHHANG
    SET sHoTen = @TenKH,
        sDienThoai = @DienThoai,
        sDiaChi = @DiaChi
    WHERE iMaKH = @MaKH;
END

CREATE OR ALTER PROCEDURE timKH
    @MaKH varchar(20) = NULL,
    @HoTen nvarchar(50) = NULL
AS
BEGIN
    SELECT * FROM tblKHACHHANG
    WHERE (@MaKH IS NULL OR iMaKH = @MaKH)
        AND (@HoTen IS NULL OR sHoTen LIKE '%' + @HoTen + '%')
END


--PROC NHA CUNG CAP



