/* ===== 1. TAO CSDL ===== */
IF DB_ID(N'eShopping') IS NULL CREATE DATABASE eShopping;
GO
USE eShopping;
GO

/* ===== 2. TAO BANG ===== */
CREATE TABLE NhomSanPham (
    MaNhomSP   INT IDENTITY PRIMARY KEY,
    TenNhomSP  NVARCHAR(100) NOT NULL
);

-- Ban sao toi thieu cua san pham (nguon chinh: He thong quan ly san pham)
CREATE TABLE SanPham (
    MaSP        VARCHAR(20)   PRIMARY KEY,
    TenSP       NVARCHAR(200) NOT NULL,
    NhaSanXuat  NVARCHAR(100),
    HinhAnh     NVARCHAR(300),
    MoTa        NVARCHAR(MAX),
    ThongSoKT   NVARCHAR(MAX),
    GiaBan      DECIMAL(18,0) NOT NULL CHECK (GiaBan >= 0),
    CoHang      BIT           NOT NULL DEFAULT 1,
    MaNhomSP    INT           NOT NULL REFERENCES NhomSanPham(MaNhomSP)
);

CREATE TABLE KhachHang (
    MaKhachHang INT IDENTITY PRIMARY KEY,
    HoTen       NVARCHAR(100) NOT NULL,
    NgaySinh    DATE          NOT NULL,
    SoCMND      VARCHAR(20)   NOT NULL UNIQUE,
    DiaChi      NVARCHAR(200) NOT NULL,
    DienThoai   VARCHAR(15)   NOT NULL,
    TenDangNhap VARCHAR(50)   NOT NULL UNIQUE,
    MatKhauHash VARCHAR(200)  NOT NULL,
    Email       VARCHAR(100)  NULL
);

CREATE TABLE ChiTietGioHang (
    MaKhachHang INT         NOT NULL REFERENCES KhachHang(MaKhachHang),
    MaSP        VARCHAR(20) NOT NULL REFERENCES SanPham(MaSP),
    SoLuong     INT         NOT NULL CHECK (SoLuong > 0),
    PRIMARY KEY (MaKhachHang, MaSP)
);

CREATE TABLE KhuVuc (
    MaKhuVuc  INT IDENTITY PRIMARY KEY,
    TenKhuVuc NVARCHAR(100) NOT NULL
);

CREATE TABLE LoaiPhieu (
    MaLoaiPhieu  INT PRIMARY KEY,           -- 1 thuong, 2 nhanh, 3 nhanh trong ngay
    TenLoaiPhieu NVARCHAR(100) NOT NULL,
    ThoiGianXuLy NVARCHAR(100)
);

CREATE TABLE PhiGiaoHang (
    MaKhuVuc    INT NOT NULL REFERENCES KhuVuc(MaKhuVuc),
    MaLoaiPhieu INT NOT NULL REFERENCES LoaiPhieu(MaLoaiPhieu),
    Phi         DECIMAL(18,0) NOT NULL CHECK (Phi >= 0),
    PRIMARY KEY (MaKhuVuc, MaLoaiPhieu)
);

CREATE TABLE LoaiThe (
    MaLoaiThe  INT PRIMARY KEY,
    TenLoaiThe NVARCHAR(50) NOT NULL,       -- VISA, Master, Discover, American Express
    DoDaiSoThe INT NOT NULL,                -- 16 hoac 15
    DoDaiCSV   INT NOT NULL,                -- 3 hoac 4
    LePhi      DECIMAL(18,0) NOT NULL DEFAULT 0
);

CREATE TABLE NguoiNhan (
    MaNguoiNhan INT IDENTITY PRIMARY KEY,
    HoTen       NVARCHAR(100) NOT NULL,
    DiaChi      NVARCHAR(200) NOT NULL,
    DienThoai   VARCHAR(15)   NOT NULL,
    MaKhuVuc    INT NOT NULL REFERENCES KhuVuc(MaKhuVuc)
);

CREATE TABLE DonHang (
    MaDonHang    INT IDENTITY PRIMARY KEY,
    MaKhachHang  INT NOT NULL REFERENCES KhachHang(MaKhachHang),
    MaNguoiNhan  INT NOT NULL REFERENCES NguoiNhan(MaNguoiNhan),
    MaLoaiPhieu  INT NOT NULL REFERENCES LoaiPhieu(MaLoaiPhieu),
    MaLoaiThe    INT NOT NULL REFERENCES LoaiThe(MaLoaiThe),
    SoTheChe     VARCHAR(25)   NOT NULL,    -- chi luu dang che: ****1234
    TenChuThe    NVARCHAR(100) NOT NULL,
    NgayHetHan   DATE          NOT NULL,
    TienHang     DECIMAL(18,0) NOT NULL,
    PhiGiaoHang  DECIMAL(18,0) NOT NULL,
    LePhiThe     DECIMAL(18,0) NOT NULL DEFAULT 0,
    TongTriGia   DECIMAL(18,0) NOT NULL,
    ThoiDiemDat  DATETIME      NOT NULL DEFAULT GETDATE(),
    TrangThai    NVARCHAR(30)  NOT NULL DEFAULT N'Đã đặt'
);

CREATE TABLE ChiTietDonHang (
    MaDonHang INT         NOT NULL REFERENCES DonHang(MaDonHang),
    MaSP      VARCHAR(20) NOT NULL REFERENCES SanPham(MaSP),
    SoLuong   INT         NOT NULL CHECK (SoLuong > 0),
    DonGia    DECIMAL(18,0) NOT NULL,       -- don gia tai thoi diem dat
    PRIMARY KEY (MaDonHang, MaSP)
);
GO

/* ===== 3. DU LIEU MAU ===== */
INSERT INTO NhomSanPham(TenNhomSP) VALUES (N'Máy chụp hình kỹ thuật số'),(N'Đồ chơi'),(N'Thiết bị điện gia dụng'),(N'Thiết bị máy tính');
INSERT INTO LoaiPhieu VALUES (1,N'Phiếu thường',N'3-5 ngày'),(2,N'Chuyển phát nhanh',N'1-2 ngày'),(3,N'Chuyển phát nhanh trong ngày',N'Trong ngày');
INSERT INTO KhuVuc(TenKhuVuc) VALUES (N'Nội thành'),(N'Ngoại thành'),(N'Tỉnh khác');
INSERT INTO PhiGiaoHang VALUES (1,1,20000),(1,2,35000),(1,3,60000),(2,1,30000),(2,2,50000),(2,3,80000),(3,1,45000),(3,2,70000),(3,3,0);
INSERT INTO LoaiThe VALUES (1,N'VISA',16,3,0),(2,N'Master',16,3,0),(3,N'Discover',16,3,0),(4,N'American Express',15,4,0);
GO

/* ===== 4. CAC TRUY VAN CHINH ===== */

-- 4.1 Dang nhap (so khop mat khau da bam o tang ung dung)
-- SELECT MaKhachHang, HoTen, Email FROM KhachHang
-- WHERE TenDangNhap = @TenDangNhap AND MatKhauHash = @MatKhauHash;

-- 4.2 Dang ky tai khoan (UNIQUE se chan trung ten dang nhap / CMND)
-- INSERT INTO KhachHang(HoTen,NgaySinh,SoCMND,DiaChi,DienThoai,TenDangNhap,MatKhauHash,Email)
-- VALUES (@HoTen,@NgaySinh,@SoCMND,@DiaChi,@DienThoai,@TenDangNhap,@MatKhauHash,@Email);

-- 4.3 Danh sach san pham theo nhom
-- SELECT MaSP, TenSP, HinhAnh, GiaBan, CoHang FROM SanPham WHERE MaNhomSP = @MaNhomSP;

-- 4.4 Chi tiet san pham
-- SELECT sp.*, n.TenNhomSP FROM SanPham sp JOIN NhomSanPham n ON n.MaNhomSP = sp.MaNhomSP
-- WHERE sp.MaSP = @MaSP;

-- 4.5 Them vao gio (cong don neu da co)
GO
CREATE OR ALTER PROCEDURE sp_ThemVaoGio @MaKhachHang INT, @MaSP VARCHAR(20), @SoLuong INT = 1
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM SanPham WHERE MaSP=@MaSP AND CoHang=1)
    BEGIN RAISERROR(N'Sản phẩm hết hàng hoặc không tồn tại',16,1); RETURN; END

    MERGE ChiTietGioHang AS t
    USING (SELECT @MaKhachHang AS MaKhachHang, @MaSP AS MaSP) AS s
       ON t.MaKhachHang=s.MaKhachHang AND t.MaSP=s.MaSP
    WHEN MATCHED THEN UPDATE SET SoLuong = t.SoLuong + @SoLuong
    WHEN NOT MATCHED THEN INSERT(MaKhachHang,MaSP,SoLuong) VALUES(@MaKhachHang,@MaSP,@SoLuong);
END
GO

-- 4.6 Xem gio hang
-- SELECT g.MaSP, sp.TenSP, sp.GiaBan, g.SoLuong, sp.GiaBan*g.SoLuong AS ThanhTien
-- FROM ChiTietGioHang g JOIN SanPham sp ON sp.MaSP=g.MaSP WHERE g.MaKhachHang=@MaKhachHang;

-- 4.7 Cap nhat so luong / xoa khoi gio
-- UPDATE ChiTietGioHang SET SoLuong=@SoLuong WHERE MaKhachHang=@MaKhachHang AND MaSP=@MaSP;
-- DELETE FROM ChiTietGioHang WHERE MaKhachHang=@MaKhachHang AND MaSP=@MaSP;

-- 4.8 Tinh phi giao hang (mien phi: nhanh >= 1.000.000; trong ngay >= 5.000.000)
GO
CREATE OR ALTER FUNCTION fn_PhiGiaoHang (@MaKhuVuc INT, @MaLoaiPhieu INT, @TienHang DECIMAL(18,0))
RETURNS DECIMAL(18,0)
AS
BEGIN
    IF (@MaLoaiPhieu = 2 AND @TienHang >= 1000000) OR (@MaLoaiPhieu = 3 AND @TienHang >= 5000000)
        RETURN 0;
    RETURN ISNULL((SELECT Phi FROM PhiGiaoHang WHERE MaKhuVuc=@MaKhuVuc AND MaLoaiPhieu=@MaLoaiPhieu), 0);
END
GO

-- 4.9 Ghi nhan don hang (goi SAU KHI he thong thanh toan xac nhan the thanh cong)
CREATE OR ALTER PROCEDURE sp_DatHang
    @MaKhachHang INT, @MaNguoiNhan INT, @MaLoaiPhieu INT,
    @MaLoaiThe INT, @SoTheChe VARCHAR(25), @TenChuThe NVARCHAR(100), @NgayHetHan DATE
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN;

        DECLARE @TienHang DECIMAL(18,0), @MaKhuVuc INT, @Phi DECIMAL(18,0), @LePhi DECIMAL(18,0), @MaDon INT;

        SELECT @TienHang = SUM(sp.GiaBan * g.SoLuong)
        FROM ChiTietGioHang g JOIN SanPham sp ON sp.MaSP = g.MaSP
        WHERE g.MaKhachHang = @MaKhachHang;

        IF @TienHang IS NULL RAISERROR(N'Giỏ hàng trống',16,1);

        SELECT @MaKhuVuc = MaKhuVuc FROM NguoiNhan WHERE MaNguoiNhan = @MaNguoiNhan;
        SET @Phi   = dbo.fn_PhiGiaoHang(@MaKhuVuc, @MaLoaiPhieu, @TienHang);
        SELECT @LePhi = LePhi FROM LoaiThe WHERE MaLoaiThe = @MaLoaiThe;

        INSERT INTO DonHang(MaKhachHang,MaNguoiNhan,MaLoaiPhieu,MaLoaiThe,SoTheChe,TenChuThe,NgayHetHan,
                            TienHang,PhiGiaoHang,LePhiThe,TongTriGia)
        VALUES (@MaKhachHang,@MaNguoiNhan,@MaLoaiPhieu,@MaLoaiThe,@SoTheChe,@TenChuThe,@NgayHetHan,
                @TienHang,@Phi,@LePhi,@TienHang+@Phi+@LePhi);
        SET @MaDon = SCOPE_IDENTITY();

        INSERT INTO ChiTietDonHang(MaDonHang,MaSP,SoLuong,DonGia)
        SELECT @MaDon, g.MaSP, g.SoLuong, sp.GiaBan
        FROM ChiTietGioHang g JOIN SanPham sp ON sp.MaSP = g.MaSP
        WHERE g.MaKhachHang = @MaKhachHang;

        DELETE FROM ChiTietGioHang WHERE MaKhachHang = @MaKhachHang;

        COMMIT TRAN;
        SELECT @MaDon AS MaDonHang;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRAN;
        THROW;
    END CATCH
END
GO

-- 4.10 Xem lai don hang (de gui email xac nhan, KHONG lay thong tin the)
-- SELECT d.MaDonHang, d.ThoiDiemDat, d.TienHang, d.PhiGiaoHang, d.TongTriGia, n.HoTen AS NguoiNhan, n.DiaChi
-- FROM DonHang d JOIN NguoiNhan n ON n.MaNguoiNhan = d.MaNguoiNhan WHERE d.MaDonHang = @MaDonHang;
