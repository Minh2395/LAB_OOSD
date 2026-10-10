using System.Collections.Generic;
using System.Data;
using LAB5.Data;
using LAB5.Models;

namespace LAB5.Services
{
    public class DangKyKhachLeService
    {
        public List<DiemBanVe> GetDiemBanVe()
        {
            var list = new List<DiemBanVe>();
            foreach (DataRow r in Db.Query("SELECT MaDiemBan, TenDiem, DiaChi FROM DiemBanVe ORDER BY TenDiem").Rows)
                list.Add(new DiemBanVe { MaDiemBan = r.Int("MaDiemBan"), TenDiem = r.Str("TenDiem"), DiaChi = r.Str("DiaChi") });
            return list;
        }

        public DataTable GetDanhSach(string maChuyen = null, string tuKhoa = null)
        {
            return Db.Query("EXEC sp_DKLe_DanhSach @MaChuyen, @TuKhoa", Sql.P("@MaChuyen", maChuyen), Sql.P("@TuKhoa", tuKhoa));
        }

        /// <summary>Đăng ký khách lẻ (BR04): đi theo chuyến, thanh toán tiền vé, không đăng ký trùng.</summary>
        public void DangKy(KhachLe k, string maChuyen, int? maDiemBan, string diemDon, decimal soTien)
        {
            if (string.IsNullOrWhiteSpace(k.TenKhach)) throw new NghiepVuException("Nhập tên khách.");
            if (string.IsNullOrWhiteSpace(k.CCCD)) throw new NghiepVuException("Nhập CCCD.");
            if (string.IsNullOrWhiteSpace(maChuyen)) throw new NghiepVuException("Chọn chuyến.");
            if (soTien < 0) throw new NghiepVuException("Số tiền không hợp lệ.");

            Db.Execute("EXEC sp_DKLe_Them @TenKhach, @CCCD, @DiaChi, @QuocTich, @MaChuyen, @MaDiemBan, @DiemDon, @SoTien",
                Sql.P("@TenKhach", k.TenKhach.Trim()), Sql.P("@CCCD", k.CCCD.Trim()), Sql.P("@DiaChi", k.DiaChi),
                Sql.P("@QuocTich", string.IsNullOrWhiteSpace(k.QuocTich) ? "Việt Nam" : k.QuocTich),
                Sql.P("@MaChuyen", maChuyen), Sql.P("@MaDiemBan", maDiemBan), Sql.P("@DiemDon", diemDon), Sql.P("@SoTien", soTien));
        }
    }
}
