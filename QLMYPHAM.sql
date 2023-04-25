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
ALTER TABLE tblHOADONBAN add sTrangThai nvarchar(30)

INSERT INTO tblHOADONBAN(iMaHDB, iMaNV, iMaKH, dNgayDat, dNgayGiao, sDiaChiGiao,sTrangThai)
VALUES
('1', '1', '1', '2/2/2022','2/10/2022', N'Thanh Xuân - Hà Nội',N'Đã thanh toán'),
('2', '2', '2', '2/1/2023','2/13/2023', N'Quận 1 - HCM',N'Chưa thanh toán'),
('3', '3', '3', '3/2/2023','3/25/2023', N'Đống Đa - Hà Nội',N'Đã thanh toán'),
('4', '4', '4', '1/8/2023','1/15/2022', N'Hoàng Mai - Hà Nội',N'Đã thanh toán'),
('5', '5', '5', '2/1/2022','2/12/2022', N'Quận 7 - HCM',N'Chưa thanh toán')

SELECT * FROM tblHOADONBAN

CREATE TABLE tblHOADONNHAP(
	iMaHDN varchar(20) PRIMARY KEY,
	iMaNV varchar(20) NOT NULL REFERENCES tblNHANVIEN (iMaNV),
	dNgayNhap DATETIME
)
alter table tblHOADONNHAP add sTrangThai nvarchar(30)
INSERT INTO tblHOADONNHAP(iMaHDN, iMaNV, dNgayNhap,sTrangThai)
VALUES
('1', '1', '12/12/2022',N'Đã xử lý'),
('2', '2', '11/11/2022',N'Chưa xử lý'),
('3', '3', '10/2/2022',N'Đã xử lý'),
('4', '4', '9/15/2022',N'Chưa xử lý'),
('5', '5', '8/10/2022',N'Đã xử lý')

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


--proc sản phẩm


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


CREATE PROC xoaSP 
(
	@sMaSP NVARCHAR(30)
)
AS
BEGIN
	DELETE FROM tblSANPHAM WHERE sMaSP = @sMaSP
END

CREATE PROC suaSP 
(
	@sMaSP NVARCHAR(30),
	@sMaLoaiSP NVARCHAR(10),
	@sTenSP NVARCHAR(50),
	@iMaNCC varchar(20),
	@sHangSX NVARCHAR(30),
	@MauSac NVARCHAR(30),
	@sDungTich NVARCHAR(30),
	@iSoLuong INT,
	@fGiaHang FLOAT
)
AS
BEGIN
	UPDATE tblSANPHAM 
	SET sMaLoaiSP = @sMaLoaiSP, 
		sTenSP = @sTenSP, 
		iMaNCC = @iMaNCC, 
		sHangSX = @sHangSX, 
		MauSac = @MauSac, 
		sDungTich = @sDungTich, 
		iSoLuong = @iSoLuong, 
		fGiaHang = @fGiaHang
	WHERE sMaSP = @sMaSP
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
CREATE PROCEDURE themNCC
    @iMaNCC varchar(20),
    @sTenNCC nvarchar(30),
    @sDiaChi nvarchar(30),
    @sSDT nvarchar(15)
AS
BEGIN
    INSERT INTO tblNHACC (iMaNCC, sTenNCC, sDiaChi, sSDT)
    VALUES (@iMaNCC, @sTenNCC, @sDiaChi, @sSDT)
END

CREATE or ALTER PROCEDURE suaNCC
    @iMaNCC varchar(20),
    @sTenNCC NVARCHAR(30),
    @sDiaChi NVARCHAR(30),
    @sSDT NVARCHAR(15)
AS
BEGIN
    IF EXISTS (SELECT * FROM tblNHACC WHERE iMaNCC = @iMaNCC)
    BEGIN
        UPDATE tblNHACC
        SET sTenNCC = @sTenNCC, sDiaChi = @sDiaChi, sSDT = @sSDT
        WHERE iMaNCC = @iMaNCC
    END
    ELSE
    BEGIN
        RAISERROR ('Không tìm thấy mã nhà cung cấp.', 16, 1)
    END
END
CREATE PROCEDURE xoaNCC
    @iMaNCC varchar(20)
AS
BEGIN
    DELETE FROM tblNHACC WHERE iMaNCC = @iMaNCC;
END

select *from tblHOADONNHAP
--PROC CHI TIẾT HÓA ĐƠN NHẬP VÀ HÓA ĐƠN NHẬP
--HÓA ĐƠN NHẬP
CREATE or ALTER PROCEDURE themHDN
    @iMaHDN varchar(20),
    @iMaNV varchar(20),
    @dNgayNhap datetime,
	@sTrangThai nvarchar(30)
AS
BEGIN
    DECLARE @count int;
    SELECT @count = COUNT(*) FROM tblHOADONNHAP WHERE iMaHDN = @iMaHDN;
    IF (@count > 0)
    BEGIN
        RAISERROR('Mã hóa đơn nhập đã tồn tại.', 16, 1);
        RETURN;
    END

    INSERT INTO tblHOADONNHAP (iMaHDN, iMaNV, dNgayNhap,sTrangThai) 
    VALUES (@iMaHDN, @iMaNV, @dNgayNhap,@sTrangThai);

    SELECT @@ROWCOUNT AS 'Rows Affected';
END

CREATE or ALTER PROCEDURE suaHDN
    @iMaHDN varchar(20),
    @iMaNV varchar(20),
    @dNgayNhap datetime,@sTrangThai nvarchar(30)
AS
BEGIN
    IF EXISTS (SELECT * FROM tblHOADONNHAP WHERE iMaHDN= @iMaHDN)
    BEGIN
        IF EXISTS (SELECT * FROM tblNHANVIEN WHERE iMaNV = @iMaNV)
        BEGIN
            UPDATE tblHOADONNHAP
            SET iMaNV = @iMaNV,
            dNgayNhap = @dNgayNhap,
			sTrangThai = @sTrangThai
            WHERE iMaHDN = @iMaHDN
        END
        ELSE
        BEGIN
            RAISERROR ('Không tìm thấy mã nhân viên trong database, không thể sửa thông tin.', 16, 1)
        END
    END
    ELSE
    BEGIN
        RAISERROR ('Không tìm thấy mã hóa đơn nhập để sửa.', 16, 1)
    END
END

CREATE OR ALTER PROCEDURE xoaHDN
	@iMaHDN varchar(20)
	AS
	BEGIN
		IF EXISTS (SELECT * FROM tblHOADONNHAP WHERE iMaHDN = @iMaHDN)
			BEGIN
				DELETE FROM tblCT_HDN WHERE iMaHDN = @iMaHDN;
				DELETE FROM tblHOADONNHAP WHERE iMaHDN = @iMaHDN;
			END
		ELSE
			BEGIN
				RAISERROR ('Không tìm thấy mã hóa đơn nhập để xóa.', 16, 1)
			END
	END
--PROC SỬA CHI TIẾT HÓA ĐƠN CỦA 1 HÓA ĐƠN CỤ THỂ CÓ THỂ DÙNG VỚI SỬA CHI TIẾT HÓA ĐƠN NHẬP
CREATE OR ALTER PROCEDURE suaCTHDN
    @iMaHDN varchar(20),
    @sMaSP NVARCHAR(30),
    @fGiaNhap FLOAT,
    @iSoLuong INT
AS
BEGIN
    IF EXISTS (SELECT * FROM tblCT_HDN WHERE iMaHDN = @iMaHDN AND sMaSP = @sMaSP)
    BEGIN
        UPDATE tblCT_HDN
        SET fGiaNhap = @fGiaNhap, iSoLuong = @iSoLuong
        WHERE iMaHDN = @iMaHDN AND sMaSP = @sMaSP
    END
    ELSE
    BEGIN
        RAISERROR ('Không tìm thấy chi tiết hóa đơn nhập để sửa.', 16, 1)
    END
END


--PROC HÓA ĐƠN BÁN VÀ CHI TIẾT HÓA ĐƠN BÁN\
CREATE or ALTER PROCEDURE themHDB
   @iMaHDB varchar(20),
	@iMaNV varchar(20),
	@iMaKH varchar(20),
	@dNgayDat datetime,
	@dNgayGiao datetime,
	@sDiaChiGiao nvarchar(30),@sTrangThai nvarchar(30)
AS
BEGIN
    DECLARE @count int;
    SELECT @count = COUNT(*) FROM tblHOADONBAN WHERE iMaHDB = @iMaHDB;
    IF (@count > 0)
    BEGIN
        RAISERROR('Mã hóa đơn nhập đã tồn tại.', 16, 1);
        RETURN;
    END

   INSERT INTO tblHOADONBAN (iMaHDB, iMaNV, iMaKH, dNgayDat, dNgayGiao, sDiaChiGiao,sTrangThai)
		VALUES (@iMaHDB, @iMaNV, @iMaKH, @dNgayDat, @dNgayGiao, @sDiaChiGiao,@sTrangThai)

    SELECT @@ROWCOUNT AS 'Rows Affected';
END
CREATE OR ALTER PROCEDURE suaHDB
    @iMaHDB VARCHAR(20),
    @iMaNV VARCHAR(20),
    @iMaKH VARCHAR(20),
    @dNgayDat DATETIME,
    @dNgayGiao DATETIME,
    @sDiaChiGiao NVARCHAR(30),
	@sTrangThai nvarchar(30)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM tblHOADONBAN WHERE iMaHDB = @iMaHDB)
    BEGIN
        RAISERROR ('Không tìm thấy mã hóa đơn bán để sửa.', 16, 1)
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM tblNHANVIEN WHERE iMaNV = @iMaNV)
    BEGIN
        RAISERROR ('Mã nhân viên không tồn tại.', 16, 1)
        RETURN;
    END

    IF NOT EXISTS (SELECT * FROM tblKHACHHANG WHERE iMaKH = @iMaKH)
    BEGIN
        RAISERROR ('Mã khách hàng không tồn tại.', 16, 1)
        RETURN;
    END

    UPDATE tblHOADONBAN
    SET iMaNV = @iMaNV,
        iMaKH = @iMaKH,
        dNgayDat = @dNgayDat,
        dNgayGiao = @dNgayGiao,
        sDiaChiGiao = @sDiaChiGiao,
		sTrangThai = @sTrangThai
    WHERE iMaHDB = @iMaHDB
END
CREATE OR ALTER PROCEDURE xoaHDB
	@iMaHDB varchar(20)
	AS
	BEGIN
		IF EXISTS (SELECT * FROM tblHOADONBAN WHERE iMaHDB = @iMaHDB)
			BEGIN
				DELETE FROM tblCT_HDB WHERE iMaHDB = @iMaHDB;
				DELETE FROM tblHOADONBAN WHERE iMaHDB = @iMaHDB;
			END
		ELSE
			BEGIN
				RAISERROR ('Không tìm thấy mã hóa đơn nhập để xóa.', 16, 1)
			END
END
--PROC SỬA CHI TIẾT HÓA ĐƠN BÁN
CREATE OR ALTER PROCEDURE suaCTHDB
    @iMaHDB varchar(20),
    @sMaSP NVARCHAR(30),
    @fGiaBan FLOAT,
    @iSoLuong INT
AS
BEGIN
    IF EXISTS (SELECT * FROM tblCT_HDB WHERE iMaHDB = @iMaHDB AND sMaSP = @sMaSP)
    BEGIN
        UPDATE tblCT_HDB
        SET fGiaBan = @fGiaBan,
        iSoLuong = @iSoLuong
        WHERE iMaHDB = @iMaHDB AND sMaSP = @sMaSP
    END
    ELSE
    BEGIN
        RAISERROR ('Không tìm thấy chi tiết hóa đơn bán để sửa.', 16, 1)
    END
END


--PROC CHI TIẾT HÓA ĐƠN BÁN
CREATE OR ALTER PROCEDURE themCTHDB
    @iMaHDB varchar(20),
    @sMaSP nvarchar(30),
    @fGiaBan float,
    @iSoLuong int
AS
BEGIN
    DECLARE @count int;
    SELECT @count = COUNT(*) FROM tblCT_HDB WHERE iMaHDB = @iMaHDB AND sMaSP = @sMaSP;
    IF (@count > 0)
    BEGIN
        RAISERROR('Mã hóa đơn bán và mã sản phẩm đã tồn tại.', 16, 1);
        RETURN;
    END

    INSERT INTO tblCT_HDB (iMaHDB, sMaSP, fGiaBan, iSoLuong)
    VALUES (@iMaHDB, @sMaSP, @fGiaBan, @iSoLuong)

    SELECT @@ROWCOUNT AS 'Rows Affected';
END	

CREATE OR ALTER PROCEDURE xoaCTHDB
    @iMaHDB varchar(20),
    @sMaSP nvarchar(30)
AS
BEGIN
    IF NOT EXISTS (SELECT * FROM tblCT_HDB WHERE iMaHDB = @iMaHDB AND sMaSP = @sMaSP)
    BEGIN
        RAISERROR('Không tìm thấy chi tiết hóa đơn bán với mã hóa đơn và mã sản phẩm đã cho.', 16, 1);
        RETURN;
    END

    DELETE FROM tblCT_HDB WHERE iMaHDB = @iMaHDB AND sMaSP = @sMaSP;

    SELECT @@ROWCOUNT AS 'Rows Affected';
END


--proc loại sản phẩm
CREATE OR ALTER PROCEDURE themLSP
  @sMaLoaiSP NVARCHAR(10),
  @sTenLoaiSP NVARCHAR(50)
AS
BEGIN
    DECLARE @count int;
    SELECT @count = COUNT(*) FROM tblLOAISP WHERE sMaLoaiSP = @sMaLoaiSP;
    IF (@count > 0)
    BEGIN
        RAISERROR('Mã loại sản phẩm đã tồn tại.', 16, 1);
        RETURN;
    END
    ELSE
    BEGIN
        INSERT INTO tblLOAISP (sMaLoaiSP, sTenLoaiSP)
        VALUES (@sMaLoaiSP, @sTenLoaiSP);
        SELECT @@ROWCOUNT AS 'Rows Affected';
    END
END

CREATE OR ALTER PROCEDURE suaLSP
    @sMaLoaiSP NVARCHAR(10),
    @sTenLoaiSP NVARCHAR(50)
AS
BEGIN
    DECLARE @count int;
    SELECT @count = COUNT(*) FROM tblLOAISP WHERE sMaLoaiSP = @sMaLoaiSP;
    IF (@count = 0)
    BEGIN
        RAISERROR('Không tồn tại loại sản phẩm với mã được cập nhật.', 16, 1);
        RETURN;
    END

    UPDATE tblLOAISP
    SET sTenLoaiSP = @sTenLoaiSP
	WHERE sMaLoaiSP = @sMaLoaiSP
END

CREATE OR ALTER PROCEDURE xoaLSP
    @sMaLoaiSP NVARCHAR(10)
AS
BEGIN
    -- Kiểm tra xem loại sản phẩm có tồn tại trong bảng tblLOAISP hay không
    IF NOT EXISTS(SELECT 1 FROM tblLOAISP WHERE sMaLoaiSP = @sMaLoaiSP)
    BEGIN
        RAISERROR('Mã loại sản phẩm không tồn tại.', 16, 1);
        RETURN;
    END

    -- Xóa loại sản phẩm
    DELETE FROM tblLOAISP WHERE sMaLoaiSP = @sMaLoaiSP;
END




select*from tblSANPHAM
--baitap
create or alter proc timSPtheoGia(@giatu int,@giaden int,@tenSP nvarchar(30))
as 
begin
	select sMaSP,sTenSP,iSoLuong,fGiaHang from tblSANPHAM
	where fGiaHang>=@giatu and fGiaHang<=@giaden and sTenSP=@tenSP
end

exec timSPtheoGia @giatu = N'400000',@giaden=N'8000000'


select *from tblHOADONBAN
create or alter proc timHDBtheoNamThang
(@thang int,@nam int,@imaKH int)
as
begin
	select iMaHDB,kh.sHoTen,dNgayDat,kh.iMaKH,dNgayGiao,sDiaChiGiao from tblHOADONBAN hdb join tblKHACHHANG kh on kh.iMaKH=hdb.iMaKH
	where MONTH(hdb.dNgayDat) =@thang and YEAR(hdb.dNgayDat)=@nam and kh.iMaKH=@imaKH
end
exec timHDBtheoNamThang @thang = 02, @nam=2022