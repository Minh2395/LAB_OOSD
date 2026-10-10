using System.Data;
using LAB5.Data;
using LAB5.Models;

namespace LAB5.Services
{
    public class DiemThamQuanService
    {
        public DataTable GetDanhSach() { return Db.Query("EXEC sp_Diem_DanhSach"); }

        private static void Validate(DiemThamQuan d)
        {
            if (string.IsNullOrWhiteSpace(d.MaDiem)) throw new NghiepVuException("Mã điểm tham quan không được để trống.");
            if (string.IsNullOrWhiteSpace(d.TenDiem)) throw new NghiepVuException("Tên điểm tham quan không được để trống.");
            if (string.IsNullOrWhiteSpace(d.DiaDiem)) throw new NghiepVuException("Địa điểm tham quan không được để trống.");
        }

        public void Them(DiemThamQuan d, string maTour)
        {
            Validate(d);
            Db.Execute("EXEC sp_Diem_Them @MaDiem, @TenDiem, @DiaDiem, @NoiDung, @YNghia, @MaTour",
                Sql.P("@MaDiem", d.MaDiem.Trim()), Sql.P("@TenDiem", d.TenDiem.Trim()), Sql.P("@DiaDiem", d.DiaDiem.Trim()),
                Sql.P("@NoiDung", d.NoiDung), Sql.P("@YNghia", d.YNghia), Sql.P("@MaTour", maTour));
        }

        public void Sua(DiemThamQuan d, string maTour)
        {
            Validate(d);
            Db.Execute("EXEC sp_Diem_Sua @MaDiem, @TenDiem, @DiaDiem, @NoiDung, @YNghia, @MaTour",
                Sql.P("@MaDiem", d.MaDiem.Trim()), Sql.P("@TenDiem", d.TenDiem.Trim()), Sql.P("@DiaDiem", d.DiaDiem.Trim()),
                Sql.P("@NoiDung", d.NoiDung), Sql.P("@YNghia", d.YNghia), Sql.P("@MaTour", maTour));
        }

        public void Xoa(string maDiem) { Db.Execute("EXEC sp_Diem_Xoa @MaDiem", Sql.P("@MaDiem", maDiem)); }
    }
}
