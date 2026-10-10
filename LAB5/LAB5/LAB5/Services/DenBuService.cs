using System.Data;
using LAB5.Data;
using LAB5.Models;

namespace LAB5.Services
{
    public class DenBuService
    {
        public static readonly string[] MucDos = { "Nhẹ", "Trung bình", "Nặng" };

        public DataTable GetDanhSach() { return Db.Query("EXEC sp_DenBu_DanhSach"); }

        /// <summary>Lập phiếu đền bù theo dịch vụ và mức độ thiệt hại (BR08).</summary>
        public void Them(DenBu d)
        {
            if (string.IsNullOrWhiteSpace(d.DichVu)) throw new NghiepVuException("Chọn dịch vụ.");
            if (System.Array.IndexOf(MucDos, d.MucDo) < 0) throw new NghiepVuException("Mức độ thiệt hại không hợp lệ.");
            if (d.SoTienDenBu < 0) throw new NghiepVuException("Số tiền đền bù không hợp lệ.");
            if ((d.MaChuyen == null) == (d.MaDoan == null)) throw new NghiepVuException("Chọn chuyến khách lẻ hoặc đoàn (chỉ một trong hai).");

            Db.Execute("EXEC sp_DenBu_Them @MaChuyen, @MaDoan, @DichVu, @MoTa, @MucDo, @SoTien",
                Sql.P("@MaChuyen", d.MaChuyen), Sql.P("@MaDoan", d.MaDoan), Sql.P("@DichVu", d.DichVu.Trim()),
                Sql.P("@MoTa", d.MoTa), Sql.P("@MucDo", d.MucDo), Sql.P("@SoTien", d.SoTienDenBu));
        }

        public void Xoa(int maDB) { Db.Execute("EXEC sp_DenBu_Xoa @MaDB", Sql.P("@MaDB", maDB)); }
    }
}
