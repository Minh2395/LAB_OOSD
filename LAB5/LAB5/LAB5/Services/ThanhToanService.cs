using System;
using System.Data;
using LAB5.Data;
using LAB5.Models;

namespace LAB5.Services
{
    public class ThongTinThanhToan
    {
        public int SoKhach { get; set; }
        public decimal TongTien { get; set; }
        public decimal DaDatCoc { get; set; }
        public decimal CanThu { get { return TongTien - DaDatCoc; } }
    }

    public class ThanhToanService
    {
        public const string KhachLe = "Khách lẻ";
        public const string KhachDoan = "Khách đoàn";

        /// <summary>loaiTour: "Khách lẻ" (ma = MaDK) hoặc "Khách đoàn" (ma = MaDoan).</summary>
        public ThongTinThanhToan TinhTien(string loaiTour, int ma)
        {
            var dt = Db.Query("EXEC sp_TinhTien @LoaiTour, @Ma", Sql.P("@LoaiTour", loaiTour), Sql.P("@Ma", ma));
            if (dt.Rows.Count == 0) throw new NghiepVuException("Không tìm thấy phiếu đăng ký.");
            var r = dt.Rows[0];
            return new ThongTinThanhToan { SoKhach = r.Int("SoKhach"), TongTien = r.Dec("TongTien"), DaDatCoc = r.Dec("DaDatCoc") };
        }

        public static string TaoSoHoaDon() { return "HD" + DateTime.Now.ToString("yyyyMMddHHmmssfff"); }

        /// <summary>Ghi nhận thanh toán. Trả về số hóa đơn. Đoàn: trừ cọc và chỉ quyết toán sau khi kết thúc.</summary>
        public string ThanhToan(string loaiTour, int ma, decimal soTienThu, string phuongThuc)
        {
            var tt = TinhTien(loaiTour, ma);
            decimal canThu = loaiTour == KhachDoan ? tt.CanThu : tt.TongTien;
            if (soTienThu < canThu) throw new NghiepVuException("Số tiền thanh toán chưa đủ (cần " + canThu.ToString("N0") + " đ).");
            if (string.IsNullOrWhiteSpace(phuongThuc)) throw new NghiepVuException("Chọn phương thức thanh toán.");

            string so = TaoSoHoaDon();
            Db.Execute("EXEC sp_ThanhToan @SoHoaDon, @LoaiTour, @Ma, @SoTienThu, @PhuongThuc",
                Sql.P("@SoHoaDon", so), Sql.P("@LoaiTour", loaiTour), Sql.P("@Ma", ma),
                Sql.P("@SoTienThu", soTienThu), Sql.P("@PhuongThuc", phuongThuc));
            return so;
        }

        public bool DaThanhToan(string loaiTour, int ma)
        {
            string col = loaiTour == KhachDoan ? "MaDoan" : "MaDK";
            object n = Db.Scalar("SELECT COUNT(*) FROM HoaDon WHERE " + col + " = @Ma", Sql.P("@Ma", ma));
            return Convert.ToInt32(n) > 0;
        }

        public DataTable GetDanhSachHoaDon()
        {
            return Db.Query("SELECT SoHoaDon, LoaiTour, SoKhach, TongTien, DaDatCoc, SoTienThu, PhuongThuc, NgayThanhToan, TrangThai FROM HoaDon ORDER BY NgayThanhToan DESC");
        }

        public HoaDon GetBienNhan(string soHoaDon)
        {
            var dt = Db.Query("EXEC sp_HoaDon_BienNhan @SoHoaDon", Sql.P("@SoHoaDon", soHoaDon));
            if (dt.Rows.Count == 0) return null;
            var r = dt.Rows[0];
            return new HoaDon
            {
                MaHD = r.Int("MaHD"),
                SoHoaDon = r.Str("SoHoaDon"),
                LoaiTour = r.Str("LoaiTour"),
                MaDK = r.IntN("MaDK"),
                MaDoan = r.IntN("MaDoan"),
                SoKhach = r.Int("SoKhach"),
                TongTien = r.Dec("TongTien"),
                DaDatCoc = r.Dec("DaDatCoc"),
                SoTienThu = r.Dec("SoTienThu"),
                PhuongThuc = r.Str("PhuongThuc"),
                NgayThanhToan = r.Date("NgayThanhToan"),
                TrangThai = r.Str("TrangThai")
            };
        }
    }
}
