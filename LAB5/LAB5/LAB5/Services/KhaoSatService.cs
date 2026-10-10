using System;
using System.Data;
using LAB5.Data;
using LAB5.Models;

namespace LAB5.Services
{
    public class KhaoSatService
    {
        public DataTable GetDanhSach() { return Db.Query("EXEC sp_KhaoSat_DanhSach"); }

        /// <summary>Ghi nhận khảo sát sau khi tour kết thúc (BR07).</summary>
        public void Them(KhaoSat k)
        {
            if (string.IsNullOrWhiteSpace(k.TenKhach)) throw new NghiepVuException("Nhập tên khách.");
            if (k.DiemDanhGia < 1 || k.DiemDanhGia > 5) throw new NghiepVuException("Điểm đánh giá từ 1 đến 5.");
            if ((k.MaChuyen == null) == (k.MaDoan == null)) throw new NghiepVuException("Chọn chuyến khách lẻ hoặc đoàn (chỉ một trong hai).");

            Db.Execute("EXEC sp_KhaoSat_Them @MaChuyen, @MaDoan, @TenKhach, @Diem, @GopY, @Ngay",
                Sql.P("@MaChuyen", k.MaChuyen), Sql.P("@MaDoan", k.MaDoan), Sql.P("@TenKhach", k.TenKhach.Trim()),
                Sql.P("@Diem", k.DiemDanhGia), Sql.P("@GopY", k.GopY), Sql.P("@Ngay", k.NgayKhaoSat.Date));
        }

        public void Xoa(int maKS) { Db.Execute("EXEC sp_KhaoSat_Xoa @MaKS", Sql.P("@MaKS", maKS)); }
    }
}
