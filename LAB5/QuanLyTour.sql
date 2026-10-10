/* =====================================================================
   Lab05 - HỆ THỐNG QUẢN LÝ TOUR DU LỊCH  (SQL Server)
   Phần 1: Tạo CSDL + bảng + ràng buộc
   Phần 2: View
   Phần 3: Stored procedure theo từng form
   Phần 4: Dữ liệu mẫu
   ===================================================================== */
IF DB_ID(N'QuanLyTour') IS NULL CREATE DATABASE QuanLyTour;
GO
USE QuanLyTour;
GO

/* ===================== PHẦN 1: BẢNG ===================== */
CREATE TABLE TaiKhoan (                       -- FrmLogin
    TenDangNhap NVARCHAR(50)  PRIMARY KEY,
    MatKhauHash VARBINARY(32) NOT NULL,       -- SHA2_256
    VaiTro      NVARCHAR(50)  NOT NULL
        CHECK (VaiTro IN (N'Lễ tân', N'Nhân viên hướng dẫn du lịch', N'Thanh toán', N'Quản lý tour')),
    MaNV        INT NULL
);

CREATE TABLE PhuongTien (
    MaPT  INT IDENTITY PRIMARY KEY,
    TenPT NVARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE Tour (                           -- FrmTour
    MaTour   VARCHAR(10)   PRIMARY KEY,
    TenTour  NVARCHAR(150) NOT NULL,
    SoNgay   INT NOT NULL CHECK (SoNgay > 0),
    SoDem    INT NOT NULL CHECK (SoDem >= 0),
    DonGia   DECIMAL(18,0) NOT NULL CHECK (DonGia >= 0),  -- giá cho 1 khách
    LuongHDV DECIMAL(18,0) NOT NULL DEFAULT 0,            -- lương HDV cho mỗi lần dẫn tour (BR06)
    CONSTRAINT CK_Tour_NgayDem CHECK (SoDem BETWEEN SoNgay - 1 AND SoNgay)
);

CREATE TABLE Tour_PhuongTien (                -- 1 tour dùng nhiều phương tiện
    MaTour VARCHAR(10) REFERENCES Tour(MaTour) ON DELETE CASCADE,
    MaPT   INT         REFERENCES PhuongTien(MaPT),
    PRIMARY KEY (MaTour, MaPT)
);

CREATE TABLE NoiDungChan (                    -- FrmNoiDungChan
    MaNoi         INT IDENTITY PRIMARY KEY,
    MaTour        VARCHAR(10) NOT NULL REFERENCES Tour(MaTour) ON DELETE CASCADE,
    TenNoi        NVARCHAR(150) NOT NULL,
    DoiPhuongTien BIT NOT NULL DEFAULT 0,
    CoNoiAn       BIT NOT NULL DEFAULT 0,
    CoKhachSan    BIT NOT NULL DEFAULT 0,
    LoaiKhachSan  TINYINT NULL CHECK (LoaiKhachSan BETWEEN 2 AND 5),
    CONSTRAINT CK_NDC_KS CHECK ((CoKhachSan = 1 AND LoaiKhachSan IS NOT NULL) OR (CoKhachSan = 0 AND LoaiKhachSan IS NULL))
);

CREATE TABLE DiemThamQuan (                   -- FrmDiemThamQuan
    MaDiem   VARCHAR(10) PRIMARY KEY,
    TenDiem  NVARCHAR(150) NOT NULL,
    DiaDiem  NVARCHAR(200) NOT NULL,
    NoiDung  NVARCHAR(500) NULL,
    YNghia   NVARCHAR(500) NULL
);

CREATE TABLE Tour_DiemThamQuan (
    MaTour VARCHAR(10) REFERENCES Tour(MaTour) ON DELETE CASCADE,
    MaDiem VARCHAR(10) REFERENCES DiemThamQuan(MaDiem) ON DELETE CASCADE,
    PRIMARY KEY (MaTour, MaDiem)
);

CREATE TABLE NhanVien (                       -- hướng dẫn viên
    MaNV        INT IDENTITY PRIMARY KEY,
    HoTen       NVARCHAR(100) NOT NULL,
    DienThoai   VARCHAR(15) NULL,
    LuongCoBan  DECIMAL(18,0) NOT NULL DEFAULT 0
);
ALTER TABLE TaiKhoan ADD CONSTRAINT FK_TK_NV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV);

CREATE TABLE ChuyenDi (                       -- FrmChuyen (chuyến của khách lẻ)
    MaChuyen  VARCHAR(15) PRIMARY KEY,
    MaTour    VARCHAR(10) NOT NULL REFERENCES Tour(MaTour),
    NgayDi    DATE NOT NULL,
    NgayVe    DATE NOT NULL,
    TinhTrang NVARCHAR(30) NOT NULL DEFAULT N'Chưa khởi hành'
        CHECK (TinhTrang IN (N'Chưa khởi hành', N'Đang diễn ra', N'Đã kết thúc', N'Đã hủy')),
    CONSTRAINT CK_Chuyen_Ngay CHECK (NgayVe >= NgayDi)
);

CREATE TABLE DiemBanVe (
    MaDiemBan INT IDENTITY PRIMARY KEY,
    TenDiem   NVARCHAR(100) NOT NULL,
    DiaChi    NVARCHAR(200) NULL
);

CREATE TABLE KhachLe (
    MaKhach  INT IDENTITY PRIMARY KEY,
    TenKhach NVARCHAR(100) NOT NULL,
    CCCD     VARCHAR(20) NOT NULL UNIQUE,
    DiaChi   NVARCHAR(200) NULL,
    QuocTich NVARCHAR(50) NOT NULL DEFAULT N'Việt Nam'
);

CREATE TABLE DangKyKhachLe (                  -- FrmDangKyKhachLe (BR04)
    MaDK       INT IDENTITY PRIMARY KEY,
    MaChuyen   VARCHAR(15) NOT NULL REFERENCES ChuyenDi(MaChuyen),
    MaKhach    INT NOT NULL REFERENCES KhachLe(MaKhach),
    MaDiemBan  INT NULL REFERENCES DiemBanVe(MaDiemBan),
    DiemDon    NVARCHAR(200) NULL,
    SoTien     DECIMAL(18,0) NOT NULL CHECK (SoTien >= 0),
    NgayDangKy DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT UQ_DKLe UNIQUE (MaChuyen, MaKhach)           -- chống đăng ký trùng
);

CREATE TABLE DoanKhach (                      -- FrmDangKyDoan (BR02, BR03)
    MaDoan       INT IDENTITY PRIMARY KEY,
    TenCoQuan    NVARCHAR(150) NOT NULL,
    DiaChi       NVARCHAR(200) NOT NULL,
    DienThoai    VARCHAR(15)  NOT NULL,
    NguoiDaiDien NVARCHAR(100) NOT NULL,
    MaTour       VARCHAR(10) NOT NULL REFERENCES Tour(MaTour),
    NgayDi       DATE NOT NULL,
    NgayVe       DATE NOT NULL,
    SoNguoi      INT  NOT NULL CHECK (SoNguoi > 12),        -- BR01 (đúng 12 chưa quy định)
    DiaDiemDon   NVARCHAR(200) NULL,
    CoBaoHiem    BIT NOT NULL DEFAULT 0,
    SoNguoiBaoHiem INT NOT NULL DEFAULT 0,
    TienDatCoc   DECIMAL(18,0) NOT NULL CHECK (TienDatCoc > 0),
    TrangThai    NVARCHAR(30) NOT NULL DEFAULT N'Đã đặt cọc'
        CHECK (TrangThai IN (N'Đã đặt cọc', N'Đã hủy (mất cọc)', N'Đã kết thúc', N'Đã quyết toán')),
    CONSTRAINT CK_Doan_Ngay CHECK (NgayVe >= NgayDi),
    CONSTRAINT CK_Doan_BH   CHECK (SoNguoiBaoHiem <= SoNguoi AND (CoBaoHiem = 1 OR SoNguoiBaoHiem = 0))
);

CREATE TABLE NguoiDiDoan (                    -- danh sách người đi (bắt buộc nếu mua bảo hiểm)
    MaNguoi  INT IDENTITY PRIMARY KEY,
    MaDoan   INT NOT NULL REFERENCES DoanKhach(MaDoan) ON DELETE CASCADE,
    HoTen    NVARCHAR(100) NOT NULL,
    CCCD     VARCHAR(20) NULL,
    MuaBaoHiem BIT NOT NULL DEFAULT 0
);

CREATE TABLE PhanCong (                       -- FrmPhanCongHDV (BR05, BR10)
    MaPC     INT IDENTITY PRIMARY KEY,
    MaNV     INT NOT NULL REFERENCES NhanVien(MaNV),
    MaChuyen VARCHAR(15) NULL REFERENCES ChuyenDi(MaChuyen),
    MaDoan   INT NULL REFERENCES DoanKhach(MaDoan),
    TuNgay   DATE NOT NULL,
    DenNgay  DATE NOT NULL,
    CONSTRAINT CK_PC_Ngay CHECK (DenNgay >= TuNgay),
    CONSTRAINT CK_PC_Loai CHECK ((MaChuyen IS NOT NULL AND MaDoan IS NULL) OR (MaChuyen IS NULL AND MaDoan IS NOT NULL))
);
-- Mỗi chuyến khách lẻ chỉ có 1 HDV
CREATE UNIQUE INDEX UX_PhanCong_Chuyen ON PhanCong(MaChuyen) WHERE MaChuyen IS NOT NULL;

CREATE TABLE HoaDon (                         -- FrmThanhToanVe
    MaHD          INT IDENTITY PRIMARY KEY,
    SoHoaDon      VARCHAR(20) NOT NULL UNIQUE,
    LoaiTour      NVARCHAR(20) NOT NULL CHECK (LoaiTour IN (N'Khách lẻ', N'Khách đoàn')),
    MaDK          INT NULL REFERENCES DangKyKhachLe(MaDK),
    MaDoan        INT NULL REFERENCES DoanKhach(MaDoan),
    SoKhach       INT NOT NULL CHECK (SoKhach > 0),
    TongTien      DECIMAL(18,0) NOT NULL,
    DaDatCoc      DECIMAL(18,0) NOT NULL DEFAULT 0,
    SoTienThu     DECIMAL(18,0) NOT NULL,
    PhuongThuc    NVARCHAR(30) NOT NULL CHECK (PhuongThuc IN (N'Tiền mặt', N'Chuyển khoản', N'Thẻ')),
    NgayThanhToan DATETIME NOT NULL DEFAULT GETDATE(),
    TrangThai     NVARCHAR(30) NOT NULL DEFAULT N'Đã thanh toán',
    CONSTRAINT CK_HD_Loai CHECK ((LoaiTour = N'Khách lẻ' AND MaDK IS NOT NULL AND MaDoan IS NULL)
                              OR (LoaiTour = N'Khách đoàn' AND MaDoan IS NOT NULL AND MaDK IS NULL))
);

CREATE TABLE BangLuong (                      -- FrmLuong
    MaNV          INT NOT NULL REFERENCES NhanVien(MaNV),
    Thang         TINYINT NOT NULL CHECK (Thang BETWEEN 1 AND 12),
    Nam           SMALLINT NOT NULL,
    LuongCoBan    DECIMAL(18,0) NOT NULL,
    SoTour        INT NOT NULL,
    LuongTheoTour DECIMAL(18,0) NOT NULL,
    TongLuong     AS (LuongCoBan + LuongTheoTour) PERSISTED,
    PRIMARY KEY (MaNV, Thang, Nam)
);

CREATE TABLE KhaoSat (                        -- FrmKhaoSat (BR07)
    MaKS        INT IDENTITY PRIMARY KEY,
    MaChuyen    VARCHAR(15) NULL REFERENCES ChuyenDi(MaChuyen),
    MaDoan      INT NULL REFERENCES DoanKhach(MaDoan),
    TenKhach    NVARCHAR(100) NOT NULL,
    DiemDanhGia TINYINT NOT NULL CHECK (DiemDanhGia BETWEEN 1 AND 5),
    GopY        NVARCHAR(1000) NULL,
    NgayKhaoSat DATE NOT NULL DEFAULT GETDATE(),
    CONSTRAINT CK_KS_Loai CHECK ((MaChuyen IS NOT NULL AND MaDoan IS NULL) OR (MaChuyen IS NULL AND MaDoan IS NOT NULL))
);

CREATE TABLE DenBu (                          -- FrmDenBu (BR08)
    MaDB        INT IDENTITY PRIMARY KEY,
    MaChuyen    VARCHAR(15) NULL REFERENCES ChuyenDi(MaChuyen),
    MaDoan      INT NULL REFERENCES DoanKhach(MaDoan),
    DichVu      NVARCHAR(100) NOT NULL,
    MoTa        NVARCHAR(500) NULL,
    MucDo       NVARCHAR(20) NOT NULL CHECK (MucDo IN (N'Nhẹ', N'Trung bình', N'Nặng')),
    SoTienDenBu DECIMAL(18,0) NOT NULL CHECK (SoTienDenBu >= 0),
    NgayLap     DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT CK_DB_Loai CHECK ((MaChuyen IS NOT NULL AND MaDoan IS NULL) OR (MaChuyen IS NULL AND MaDoan IS NOT NULL))
);
GO

/* ===================== PHẦN 2: VIEW ===================== */
-- Lịch trình chung của chuyến lẻ và đoàn (dùng cho lương, thống kê)
CREATE VIEW vw_LichTrinh AS
SELECT N'Khách lẻ' AS Loai, c.MaChuyen AS Ma, CAST(NULL AS INT) AS MaDoan, c.MaChuyen, c.MaTour, c.NgayDi, c.NgayVe
FROM ChuyenDi c WHERE c.TinhTrang <> N'Đã hủy'
UNION ALL
SELECT N'Khách đoàn', CAST(d.MaDoan AS VARCHAR(15)), d.MaDoan, NULL, d.MaTour, d.NgayDi, d.NgayVe
FROM DoanKhach d WHERE d.TrangThai <> N'Đã hủy (mất cọc)';
GO

/* ===================== PHẦN 3: STORED PROCEDURE ===================== */

/* ---- FrmLogin ---- */
CREATE PROC sp_DangNhap @TenDangNhap NVARCHAR(50), @MatKhau NVARCHAR(100), @VaiTro NVARCHAR(50)
AS
    SELECT TenDangNhap, VaiTro, MaNV FROM TaiKhoan
    WHERE TenDangNhap = @TenDangNhap
      AND MatKhauHash = HASHBYTES('SHA2_256', @MatKhau)
      AND VaiTro = @VaiTro;
GO

/* ---- FrmTour ---- */
CREATE PROC sp_Tour_DanhSach AS
    SELECT t.MaTour, t.TenTour, t.SoNgay, t.SoDem, t.DonGia,
           STUFF((SELECT ', ' + p.TenPT FROM Tour_PhuongTien tp JOIN PhuongTien p ON p.MaPT = tp.MaPT
                  WHERE tp.MaTour = t.MaTour FOR XML PATH('')), 1, 2, '') AS PhuongTien
    FROM Tour t ORDER BY t.MaTour;
GO
CREATE PROC sp_Tour_Them @MaTour VARCHAR(10), @TenTour NVARCHAR(150), @SoNgay INT, @SoDem INT, @DonGia DECIMAL(18,0), @MaPT INT = NULL AS
BEGIN
    SET XACT_ABORT ON; BEGIN TRAN;
    INSERT Tour(MaTour, TenTour, SoNgay, SoDem, DonGia) VALUES (@MaTour, @TenTour, @SoNgay, @SoDem, @DonGia);
    IF @MaPT IS NOT NULL INSERT Tour_PhuongTien VALUES (@MaTour, @MaPT);
    COMMIT;
END
GO
CREATE PROC sp_Tour_Sua @MaTour VARCHAR(10), @TenTour NVARCHAR(150), @SoNgay INT, @SoDem INT, @DonGia DECIMAL(18,0), @MaPT INT = NULL AS
BEGIN
    SET XACT_ABORT ON; BEGIN TRAN;
    UPDATE Tour SET TenTour=@TenTour, SoNgay=@SoNgay, SoDem=@SoDem, DonGia=@DonGia WHERE MaTour=@MaTour;
    DELETE Tour_PhuongTien WHERE MaTour=@MaTour;
    IF @MaPT IS NOT NULL INSERT Tour_PhuongTien VALUES (@MaTour, @MaPT);
    COMMIT;
END
GO
CREATE PROC sp_Tour_Xoa @MaTour VARCHAR(10) AS
BEGIN
    IF EXISTS (SELECT 1 FROM ChuyenDi WHERE MaTour=@MaTour) OR EXISTS (SELECT 1 FROM DoanKhach WHERE MaTour=@MaTour)
    BEGIN RAISERROR(N'Tour đã có chuyến/đoàn đăng ký, không thể xóa.', 16, 1); RETURN; END
    DELETE Tour WHERE MaTour=@MaTour;
END
GO
CREATE PROC sp_Tour_TimKiem @TuKhoa NVARCHAR(150) AS
    SELECT * FROM Tour WHERE MaTour LIKE '%'+@TuKhoa+'%' OR TenTour LIKE N'%'+@TuKhoa+N'%';
GO

/* ---- FrmNoiDungChan ---- */
CREATE PROC sp_NoiDungChan_DanhSach @MaTour VARCHAR(10) = NULL AS
    SELECT n.MaNoi, n.MaTour, n.TenNoi, n.DoiPhuongTien, n.CoNoiAn, n.CoKhachSan, n.LoaiKhachSan
    FROM NoiDungChan n WHERE @MaTour IS NULL OR n.MaTour = @MaTour;
GO
CREATE PROC sp_NoiDungChan_Them @MaTour VARCHAR(10), @TenNoi NVARCHAR(150), @DoiPT BIT, @CoAn BIT, @CoKS BIT, @LoaiKS TINYINT = NULL AS
    INSERT NoiDungChan(MaTour,TenNoi,DoiPhuongTien,CoNoiAn,CoKhachSan,LoaiKhachSan)
    VALUES (@MaTour,@TenNoi,@DoiPT,@CoAn,@CoKS, CASE WHEN @CoKS=1 THEN @LoaiKS END);
GO
CREATE PROC sp_NoiDungChan_Sua @MaNoi INT, @TenNoi NVARCHAR(150), @DoiPT BIT, @CoAn BIT, @CoKS BIT, @LoaiKS TINYINT = NULL AS
    UPDATE NoiDungChan SET TenNoi=@TenNoi, DoiPhuongTien=@DoiPT, CoNoiAn=@CoAn, CoKhachSan=@CoKS,
           LoaiKhachSan = CASE WHEN @CoKS=1 THEN @LoaiKS END WHERE MaNoi=@MaNoi;
GO
CREATE PROC sp_NoiDungChan_Xoa @MaNoi INT AS DELETE NoiDungChan WHERE MaNoi=@MaNoi;
GO

/* ---- FrmDiemThamQuan ---- */
CREATE PROC sp_Diem_DanhSach AS
    SELECT d.MaDiem, d.TenDiem, d.DiaDiem, d.NoiDung, d.YNghia,
           STUFF((SELECT ', ' + t.TenTour FROM Tour_DiemThamQuan x JOIN Tour t ON t.MaTour=x.MaTour
                  WHERE x.MaDiem=d.MaDiem FOR XML PATH('')),1,2,'') AS CacTour
    FROM DiemThamQuan d;
GO
CREATE PROC sp_Diem_Them @MaDiem VARCHAR(10), @TenDiem NVARCHAR(150), @DiaDiem NVARCHAR(200), @NoiDung NVARCHAR(500), @YNghia NVARCHAR(500), @MaTour VARCHAR(10)=NULL AS
BEGIN
    SET XACT_ABORT ON; BEGIN TRAN;
    INSERT DiemThamQuan VALUES (@MaDiem,@TenDiem,@DiaDiem,@NoiDung,@YNghia);
    IF @MaTour IS NOT NULL INSERT Tour_DiemThamQuan VALUES (@MaTour,@MaDiem);
    COMMIT;
END
GO
CREATE PROC sp_Diem_Sua @MaDiem VARCHAR(10), @TenDiem NVARCHAR(150), @DiaDiem NVARCHAR(200), @NoiDung NVARCHAR(500), @YNghia NVARCHAR(500), @MaTour VARCHAR(10)=NULL AS
BEGIN
    SET XACT_ABORT ON; BEGIN TRAN;
    UPDATE DiemThamQuan SET TenDiem=@TenDiem, DiaDiem=@DiaDiem, NoiDung=@NoiDung, YNghia=@YNghia WHERE MaDiem=@MaDiem;
    IF @MaTour IS NOT NULL AND NOT EXISTS (SELECT 1 FROM Tour_DiemThamQuan WHERE MaTour=@MaTour AND MaDiem=@MaDiem)
        INSERT Tour_DiemThamQuan VALUES (@MaTour,@MaDiem);
    COMMIT;
END
GO
CREATE PROC sp_Diem_Xoa @MaDiem VARCHAR(10) AS DELETE DiemThamQuan WHERE MaDiem=@MaDiem;
GO

/* ---- FrmChuyen ---- */
CREATE PROC sp_Chuyen_DanhSach AS
    SELECT c.MaChuyen, c.MaTour, t.TenTour, c.NgayDi, c.NgayVe, c.TinhTrang,
           (SELECT COUNT(*) FROM DangKyKhachLe d WHERE d.MaChuyen=c.MaChuyen) AS SoKhach
    FROM ChuyenDi c JOIN Tour t ON t.MaTour=c.MaTour ORDER BY c.NgayDi DESC;
GO
CREATE PROC sp_Chuyen_Them @MaChuyen VARCHAR(15), @MaTour VARCHAR(10), @NgayDi DATE, @NgayVe DATE, @TinhTrang NVARCHAR(30) AS
    INSERT ChuyenDi VALUES (@MaChuyen,@MaTour,@NgayDi,@NgayVe,@TinhTrang);
GO
CREATE PROC sp_Chuyen_Sua @MaChuyen VARCHAR(15), @MaTour VARCHAR(10), @NgayDi DATE, @NgayVe DATE, @TinhTrang NVARCHAR(30) AS
    UPDATE ChuyenDi SET MaTour=@MaTour, NgayDi=@NgayDi, NgayVe=@NgayVe, TinhTrang=@TinhTrang WHERE MaChuyen=@MaChuyen;
GO
CREATE PROC sp_Chuyen_Xoa @MaChuyen VARCHAR(15) AS
BEGIN
    IF EXISTS (SELECT 1 FROM DangKyKhachLe WHERE MaChuyen=@MaChuyen)
    BEGIN RAISERROR(N'Chuyến đã có khách đăng ký, hãy chuyển sang trạng thái "Đã hủy".',16,1); RETURN; END
    DELETE ChuyenDi WHERE MaChuyen=@MaChuyen;
END
GO

/* ---- FrmDangKyKhachLe (BR04) ---- */
CREATE PROC sp_DKLe_Them @TenKhach NVARCHAR(100), @CCCD VARCHAR(20), @DiaChi NVARCHAR(200), @QuocTich NVARCHAR(50),
                         @MaChuyen VARCHAR(15), @MaDiemBan INT = NULL, @DiemDon NVARCHAR(200) = NULL, @SoTien DECIMAL(18,0) AS
BEGIN
    SET XACT_ABORT ON; BEGIN TRAN;
    IF NOT EXISTS (SELECT 1 FROM ChuyenDi WHERE MaChuyen=@MaChuyen AND TinhTrang=N'Chưa khởi hành')
    BEGIN ROLLBACK; RAISERROR(N'Chuyến không tồn tại hoặc không còn nhận đăng ký.',16,1); RETURN; END

    DECLARE @MaKhach INT = (SELECT MaKhach FROM KhachLe WHERE CCCD=@CCCD);
    IF @MaKhach IS NULL
    BEGIN
        INSERT KhachLe(TenKhach,CCCD,DiaChi,QuocTich) VALUES (@TenKhach,@CCCD,@DiaChi,@QuocTich);
        SET @MaKhach = SCOPE_IDENTITY();
    END
    IF EXISTS (SELECT 1 FROM DangKyKhachLe WHERE MaChuyen=@MaChuyen AND MaKhach=@MaKhach)
    BEGIN ROLLBACK; RAISERROR(N'Khách đã đăng ký chuyến này.',16,1); RETURN; END

    INSERT DangKyKhachLe(MaChuyen,MaKhach,MaDiemBan,DiemDon,SoTien) VALUES (@MaChuyen,@MaKhach,@MaDiemBan,@DiemDon,@SoTien);
    COMMIT;
END
GO
CREATE PROC sp_DKLe_DanhSach @MaChuyen VARCHAR(15) = NULL, @TuKhoa NVARCHAR(100) = NULL AS
    SELECT d.MaDK, k.TenKhach, k.CCCD, k.QuocTich, d.MaChuyen, c.NgayDi, c.NgayVe, b.TenDiem AS DiemBanVe, d.DiemDon, d.SoTien
    FROM DangKyKhachLe d JOIN KhachLe k ON k.MaKhach=d.MaKhach JOIN ChuyenDi c ON c.MaChuyen=d.MaChuyen
         LEFT JOIN DiemBanVe b ON b.MaDiemBan=d.MaDiemBan
    WHERE (@MaChuyen IS NULL OR d.MaChuyen=@MaChuyen)
      AND (@TuKhoa IS NULL OR k.TenKhach LIKE N'%'+@TuKhoa+N'%' OR k.CCCD LIKE '%'+@TuKhoa+'%');
GO

/* ---- FrmDangKyDoan (BR01-BR03) ---- */
CREATE PROC sp_Doan_Them @TenCoQuan NVARCHAR(150), @DiaChi NVARCHAR(200), @DienThoai VARCHAR(15), @NguoiDaiDien NVARCHAR(100),
                         @MaTour VARCHAR(10), @NgayDi DATE, @SoNguoi INT, @DiaDiemDon NVARCHAR(200),
                         @CoBaoHiem BIT, @SoNguoiBaoHiem INT, @TienDatCoc DECIMAL(18,0) AS
BEGIN
    DECLARE @NgayVe DATE = (SELECT DATEADD(DAY, SoNgay-1, @NgayDi) FROM Tour WHERE MaTour=@MaTour);
    IF @NgayVe IS NULL BEGIN RAISERROR(N'Tour không tồn tại.',16,1); RETURN; END
    INSERT DoanKhach(TenCoQuan,DiaChi,DienThoai,NguoiDaiDien,MaTour,NgayDi,NgayVe,SoNguoi,DiaDiemDon,CoBaoHiem,SoNguoiBaoHiem,TienDatCoc)
    VALUES (@TenCoQuan,@DiaChi,@DienThoai,@NguoiDaiDien,@MaTour,@NgayDi,@NgayVe,@SoNguoi,@DiaDiemDon,@CoBaoHiem,@SoNguoiBaoHiem,@TienDatCoc);
    SELECT SCOPE_IDENTITY() AS MaDoan;
END
GO
CREATE PROC sp_Doan_ThemNguoiDi @MaDoan INT, @HoTen NVARCHAR(100), @CCCD VARCHAR(20), @MuaBaoHiem BIT AS
    INSERT NguoiDiDoan(MaDoan,HoTen,CCCD,MuaBaoHiem) VALUES (@MaDoan,@HoTen,@CCCD,@MuaBaoHiem);
GO
CREATE PROC sp_Doan_DanhSach AS
    SELECT d.MaDoan, d.TenCoQuan, d.NguoiDaiDien, d.DienThoai, t.TenTour, d.NgayDi, d.NgayVe, d.SoNguoi, d.TienDatCoc, d.TrangThai
    FROM DoanKhach d JOIN Tour t ON t.MaTour=d.MaTour ORDER BY d.NgayDi DESC;
GO
-- BR03: hủy/không đi => mất cọc
CREATE PROC sp_Doan_Huy @MaDoan INT AS
    UPDATE DoanKhach SET TrangThai=N'Đã hủy (mất cọc)' WHERE MaDoan=@MaDoan AND TrangThai=N'Đã đặt cọc';
GO

/* ---- FrmPhanCongHDV (BR05, BR10) ---- */
CREATE PROC sp_PhanCong_Them @MaNV INT, @MaChuyen VARCHAR(15) = NULL, @MaDoan INT = NULL, @TuNgay DATE, @DenNgay DATE AS
BEGIN
    SET XACT_ABORT ON; BEGIN TRAN;
    IF (@MaChuyen IS NULL AND @MaDoan IS NULL) OR (@MaChuyen IS NOT NULL AND @MaDoan IS NOT NULL)
    BEGIN ROLLBACK; RAISERROR(N'Chọn chuyến khách lẻ hoặc đoàn.',16,1); RETURN; END
    -- BR10: không chồng chéo lịch
    IF EXISTS (SELECT 1 FROM PhanCong WITH (UPDLOCK, HOLDLOCK) WHERE MaNV=@MaNV AND TuNgay<=@DenNgay AND DenNgay>=@TuNgay)
    BEGIN ROLLBACK; RAISERROR(N'Hướng dẫn viên đã có lịch trùng trong khoảng thời gian này.',16,1); RETURN; END
    -- BR05: chuyến lẻ chỉ 1 HDV
    IF @MaChuyen IS NOT NULL AND EXISTS (SELECT 1 FROM PhanCong WHERE MaChuyen=@MaChuyen)
    BEGIN ROLLBACK; RAISERROR(N'Chuyến khách lẻ đã được phân công một hướng dẫn viên.',16,1); RETURN; END
    INSERT PhanCong(MaNV,MaChuyen,MaDoan,TuNgay,DenNgay) VALUES (@MaNV,@MaChuyen,@MaDoan,@TuNgay,@DenNgay);
    COMMIT;
END
GO
CREATE PROC sp_PhanCong_Huy @MaPC INT AS DELETE PhanCong WHERE MaPC=@MaPC;
GO
CREATE PROC sp_PhanCong_DanhSach @MaNV INT = NULL AS
    SELECT p.MaPC, n.HoTen, p.MaChuyen, p.MaDoan, p.TuNgay, p.DenNgay
    FROM PhanCong p JOIN NhanVien n ON n.MaNV=p.MaNV WHERE @MaNV IS NULL OR p.MaNV=@MaNV ORDER BY p.TuNgay;
GO

/* ---- FrmThanhToanVe ---- */
-- Tính tiền: lẻ = số tiền đã đăng ký; đoàn = đơn giá * số người
CREATE PROC sp_TinhTien @LoaiTour NVARCHAR(20), @Ma INT AS
BEGIN
    IF @LoaiTour = N'Khách lẻ'
        SELECT 1 AS SoKhach, d.SoTien AS TongTien, CAST(0 AS DECIMAL(18,0)) AS DaDatCoc
        FROM DangKyKhachLe d WHERE d.MaDK=@Ma;
    ELSE
        SELECT d.SoNguoi AS SoKhach, d.SoNguoi * t.DonGia AS TongTien, d.TienDatCoc AS DaDatCoc
        FROM DoanKhach d JOIN Tour t ON t.MaTour=d.MaTour WHERE d.MaDoan=@Ma;
END
GO
CREATE PROC sp_ThanhToan @SoHoaDon VARCHAR(20), @LoaiTour NVARCHAR(20), @Ma INT, @SoTienThu DECIMAL(18,0), @PhuongThuc NVARCHAR(30) AS
BEGIN
    SET XACT_ABORT ON; BEGIN TRAN;
    DECLARE @T TABLE (SoKhach INT, TongTien DECIMAL(18,0), DaDatCoc DECIMAL(18,0));
    INSERT @T EXEC sp_TinhTien @LoaiTour, @Ma;
    DECLARE @SoKhach INT, @Tong DECIMAL(18,0), @Coc DECIMAL(18,0);
    SELECT @SoKhach=SoKhach, @Tong=TongTien, @Coc=DaDatCoc FROM @T;
    IF @Tong IS NULL BEGIN ROLLBACK; RAISERROR(N'Không tìm thấy phiếu đăng ký.',16,1); RETURN; END

    DECLARE @CanThu DECIMAL(18,0) = CASE WHEN @LoaiTour = N'Khách đoàn' THEN @Tong - @Coc ELSE @Tong END;
    IF @SoTienThu < @CanThu BEGIN ROLLBACK; RAISERROR(N'Số tiền thanh toán chưa đủ.',16,1); RETURN; END
    IF @LoaiTour = N'Khách đoàn' AND NOT EXISTS (SELECT 1 FROM DoanKhach WHERE MaDoan=@Ma AND NgayVe <= CAST(GETDATE() AS DATE))
    BEGIN ROLLBACK; RAISERROR(N'Khách đoàn chỉ quyết toán sau khi kết thúc chuyến đi.',16,1); RETURN; END

    INSERT HoaDon(SoHoaDon,LoaiTour,MaDK,MaDoan,SoKhach,TongTien,DaDatCoc,SoTienThu,PhuongThuc)
    VALUES (@SoHoaDon,@LoaiTour, IIF(@LoaiTour=N'Khách lẻ',@Ma,NULL), IIF(@LoaiTour=N'Khách đoàn',@Ma,NULL),
            @SoKhach,@Tong,@Coc,@SoTienThu,@PhuongThuc);
    IF @LoaiTour = N'Khách đoàn' UPDATE DoanKhach SET TrangThai=N'Đã quyết toán' WHERE MaDoan=@Ma;
    COMMIT;
END
GO
CREATE PROC sp_HoaDon_BienNhan @SoHoaDon VARCHAR(20) AS SELECT * FROM HoaDon WHERE SoHoaDon=@SoHoaDon;
GO

/* ---- FrmLuong (BR06) ---- */
CREATE PROC sp_Luong_Tinh @MaNV INT, @Thang TINYINT, @Nam SMALLINT AS
BEGIN
    DECLARE @Dau DATE = DATEFROMPARTS(@Nam,@Thang,1), @Cuoi DATE = EOMONTH(DATEFROMPARTS(@Nam,@Thang,1));
    SELECT n.LuongCoBan,
           COUNT(l.Ma) AS SoTour,
           ISNULL(SUM(t.LuongHDV),0) AS LuongTheoTour,
           n.LuongCoBan + ISNULL(SUM(t.LuongHDV),0) AS TongLuong
    FROM NhanVien n
    LEFT JOIN PhanCong p ON p.MaNV=n.MaNV
    LEFT JOIN vw_LichTrinh l ON ((p.MaChuyen IS NOT NULL AND l.MaChuyen=p.MaChuyen) OR (p.MaDoan IS NOT NULL AND l.MaDoan=p.MaDoan))
                              AND l.NgayVe BETWEEN @Dau AND @Cuoi          -- tour tính vào tháng kết thúc
    LEFT JOIN Tour t ON t.MaTour=l.MaTour
    WHERE n.MaNV=@MaNV GROUP BY n.LuongCoBan;
END
GO
CREATE PROC sp_Luong_Luu @MaNV INT, @Thang TINYINT, @Nam SMALLINT AS
BEGIN
    DECLARE @T TABLE (LuongCoBan DECIMAL(18,0), SoTour INT, LuongTheoTour DECIMAL(18,0), TongLuong DECIMAL(18,0));
    INSERT @T EXEC sp_Luong_Tinh @MaNV,@Thang,@Nam;
    DELETE BangLuong WHERE MaNV=@MaNV AND Thang=@Thang AND Nam=@Nam;
    INSERT BangLuong(MaNV,Thang,Nam,LuongCoBan,SoTour,LuongTheoTour) SELECT @MaNV,@Thang,@Nam,LuongCoBan,SoTour,LuongTheoTour FROM @T;
END
GO

/* ---- FrmThongKe (BR09) ---- @Loai: 0 Tour | 1 Dịch vụ | 2 Số khách | 3 Doanh thu | 4 Số tour của NV ---- */
CREATE PROC sp_ThongKe @Loai INT, @TuNgay DATE, @DenNgay DATE AS
BEGIN
    IF @Loai = 0   -- số chuyến/đoàn theo tour
        SELECT t.MaTour, t.TenTour, COUNT(l.Ma) AS SoChuyenDoan
        FROM Tour t LEFT JOIN vw_LichTrinh l ON l.MaTour=t.MaTour AND l.NgayDi BETWEEN @TuNgay AND @DenNgay
        GROUP BY t.MaTour, t.TenTour ORDER BY SoChuyenDoan DESC;
    ELSE IF @Loai = 1   -- dịch vụ: khách sạn / nơi ăn / đổi phương tiện đã sử dụng
        SELECT N'Khách sạn ' + CAST(n.LoaiKhachSan AS NVARCHAR(1)) + N' sao' AS DichVu, COUNT(*) AS SoLanSuDung
        FROM NoiDungChan n JOIN vw_LichTrinh l ON l.MaTour=n.MaTour AND l.NgayDi BETWEEN @TuNgay AND @DenNgay
        WHERE n.CoKhachSan=1 GROUP BY n.LoaiKhachSan
        UNION ALL SELECT N'Nơi ăn', COUNT(*) FROM NoiDungChan n JOIN vw_LichTrinh l ON l.MaTour=n.MaTour AND l.NgayDi BETWEEN @TuNgay AND @DenNgay WHERE n.CoNoiAn=1
        UNION ALL SELECT N'Đổi phương tiện', COUNT(*) FROM NoiDungChan n JOIN vw_LichTrinh l ON l.MaTour=n.MaTour AND l.NgayDi BETWEEN @TuNgay AND @DenNgay WHERE n.DoiPhuongTien=1;
    ELSE IF @Loai = 2   -- số lượng khách
        SELECT N'Khách lẻ' AS Loai, COUNT(*) AS SoKhach FROM DangKyKhachLe d JOIN ChuyenDi c ON c.MaChuyen=d.MaChuyen
               WHERE c.NgayDi BETWEEN @TuNgay AND @DenNgay AND c.TinhTrang<>N'Đã hủy'
        UNION ALL SELECT N'Khách đoàn', ISNULL(SUM(SoNguoi),0) FROM DoanKhach
               WHERE NgayDi BETWEEN @TuNgay AND @DenNgay AND TrangThai<>N'Đã hủy (mất cọc)';
    ELSE IF @Loai = 3   -- doanh thu = hóa đơn đã thu + tiền cọc bị mất do hủy
        SELECT N'Hóa đơn' AS Nguon, ISNULL(SUM(SoTienThu),0) AS DoanhThu FROM HoaDon
               WHERE CAST(NgayThanhToan AS DATE) BETWEEN @TuNgay AND @DenNgay
        UNION ALL SELECT N'Cọc bị mất (hủy)', ISNULL(SUM(TienDatCoc),0) FROM DoanKhach
               WHERE TrangThai=N'Đã hủy (mất cọc)' AND NgayDi BETWEEN @TuNgay AND @DenNgay;
    ELSE   -- số tour nhân viên đã thực hiện
        SELECT n.MaNV, n.HoTen, COUNT(l.Ma) AS SoTour
        FROM NhanVien n
        LEFT JOIN PhanCong p ON p.MaNV=n.MaNV
        LEFT JOIN vw_LichTrinh l ON ((p.MaChuyen IS NOT NULL AND l.MaChuyen=p.MaChuyen) OR (p.MaDoan IS NOT NULL AND l.MaDoan=p.MaDoan))
                                  AND l.NgayDi BETWEEN @TuNgay AND @DenNgay
        GROUP BY n.MaNV, n.HoTen ORDER BY SoTour DESC;
END
GO

/* ---- FrmKhaoSat (BR07) ---- */
CREATE PROC sp_KhaoSat_Them @MaChuyen VARCHAR(15)=NULL, @MaDoan INT=NULL, @TenKhach NVARCHAR(100), @Diem TINYINT, @GopY NVARCHAR(1000), @Ngay DATE AS
BEGIN
    IF @MaChuyen IS NOT NULL AND NOT EXISTS (SELECT 1 FROM ChuyenDi WHERE MaChuyen=@MaChuyen AND TinhTrang=N'Đã kết thúc')
    BEGIN RAISERROR(N'Chỉ khảo sát sau khi tour kết thúc.',16,1); RETURN; END
    INSERT KhaoSat(MaChuyen,MaDoan,TenKhach,DiemDanhGia,GopY,NgayKhaoSat) VALUES (@MaChuyen,@MaDoan,@TenKhach,@Diem,@GopY,@Ngay);
END
GO
CREATE PROC sp_KhaoSat_DanhSach AS SELECT * FROM KhaoSat ORDER BY NgayKhaoSat DESC;
GO
CREATE PROC sp_KhaoSat_Xoa @MaKS INT AS DELETE KhaoSat WHERE MaKS=@MaKS;
GO

/* ---- FrmDenBu (BR08) ---- */
CREATE PROC sp_DenBu_Them @MaChuyen VARCHAR(15)=NULL, @MaDoan INT=NULL, @DichVu NVARCHAR(100), @MoTa NVARCHAR(500), @MucDo NVARCHAR(20), @SoTien DECIMAL(18,0) AS
    INSERT DenBu(MaChuyen,MaDoan,DichVu,MoTa,MucDo,SoTienDenBu) VALUES (@MaChuyen,@MaDoan,@DichVu,@MoTa,@MucDo,@SoTien);
GO
CREATE PROC sp_DenBu_DanhSach AS SELECT * FROM DenBu ORDER BY NgayLap DESC;
GO
CREATE PROC sp_DenBu_Xoa @MaDB INT AS DELETE DenBu WHERE MaDB=@MaDB;
GO

/* ===================== PHẦN 4: DỮ LIỆU MẪU ===================== */
INSERT PhuongTien(TenPT) VALUES (N'Xe du lịch'),(N'Tàu hỏa'),(N'Máy bay'),(N'Tàu thủy');
INSERT NhanVien(HoTen,DienThoai,LuongCoBan) VALUES (N'Nguyễn Văn An','0901000001',8000000),(N'Trần Thị Bình','0901000002',8000000);
INSERT TaiKhoan VALUES
 (N'admin',   HASHBYTES('SHA2_256',N'123456'), N'Quản lý tour', NULL),
 (N'letan',   HASHBYTES('SHA2_256',N'123456'), N'Lễ tân', NULL),
 (N'ketoan',  HASHBYTES('SHA2_256',N'123456'), N'Thanh toán', NULL),
 (N'hdv1',    HASHBYTES('SHA2_256',N'123456'), N'Nhân viên hướng dẫn du lịch', 1);
INSERT Tour(MaTour,TenTour,SoNgay,SoDem,DonGia,LuongHDV) VALUES
 ('T001',N'Hà Nội - Hạ Long',3,2,3500000,500000),('T002',N'Đà Nẵng - Hội An',4,3,5200000,700000);
INSERT Tour_PhuongTien VALUES ('T001',1),('T001',3),('T002',3),('T002',1);
INSERT NoiDungChan(MaTour,TenNoi,DoiPhuongTien,CoNoiAn,CoKhachSan,LoaiKhachSan) VALUES
 ('T001',N'Hạ Long',1,1,1,4),('T002',N'Hội An',0,1,1,3);
INSERT DiemThamQuan VALUES ('D001',N'Vịnh Hạ Long',N'Quảng Ninh',N'Du thuyền, thăm hang động',N'Di sản thiên nhiên thế giới'),
                           ('D002',N'Phố cổ Hội An',N'Quảng Nam',N'Dạo phố cổ',N'Di sản văn hóa thế giới');
INSERT Tour_DiemThamQuan VALUES ('T001','D001'),('T002','D002');
INSERT DiemBanVe(TenDiem,DiaChi) VALUES (N'Quận 1',N'12 Lê Lợi, Q1'),(N'Quận 7',N'45 Nguyễn Thị Thập, Q7');
INSERT ChuyenDi VALUES ('C001','T001','2026-11-05','2026-11-07',N'Chưa khởi hành'),
                       ('C002','T002','2026-09-01','2026-09-04',N'Đã kết thúc');
GO

/* ===================== VÍ DỤ GỌI ===================== */
-- EXEC sp_DangNhap N'admin', N'123456', N'Quản lý tour';
-- EXEC sp_DKLe_Them N'Lê Văn C','079200000001',N'TP.HCM',N'Việt Nam','C001',1,N'12 Lê Lợi',3500000;
-- EXEC sp_Doan_Them N'Công ty ABC',N'Q3, TP.HCM','0281234567',N'Phạm D','T001','2026-12-10',20,N'Trụ sở công ty',1,15,10000000;
-- EXEC sp_PhanCong_Them 1,'C001',NULL,'2026-11-05','2026-11-07';
-- EXEC sp_Luong_Tinh 1, 9, 2026;
-- EXEC sp_ThongKe 3, '2026-01-01', '2026-12-31';