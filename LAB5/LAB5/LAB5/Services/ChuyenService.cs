using System.Collections.Generic;
using System.Data;
using LAB5.Data;
using LAB5.Models;

namespace LAB5.Services
{
    public class ChuyenService
    {
        public static readonly string[] TinhTrangs = { "Chưa khởi hành", "Đang diễn ra", "Đã kết thúc", "Đã hủy" };

        private static ChuyenDi Map(DataRow r)
        {
            return new ChuyenDi
            {
                MaChuyen = r.Str("MaChuyen"),
                MaTour = r.Str("MaTour"),
                NgayDi = r.Date("NgayDi"),
                NgayVe = r.Date("NgayVe"),
                TinhTrang = r.Str("TinhTrang"),
                SoKhach = r.Int("SoKhach")
            };
        }

        public DataTable GetDanhSach() { return Db.Query("EXEC sp_Chuyen_DanhSach"); }

        /// <summary>Các chuyến còn nhận đăng ký (dùng cho ComboBox ở FrmDangKyKhachLe).</summary>
        public List<ChuyenDi> GetChuyenChuaKhoiHanh()
        {
            var list = new List<ChuyenDi>();
            foreach (DataRow r in Db.Query("SELECT * FROM ChuyenDi WHERE TinhTrang = N'Chưa khởi hành' ORDER BY NgayDi").Rows)
                list.Add(Map(r));
            return list;
        }

        public List<ChuyenDi> GetAll()
        {
            var list = new List<ChuyenDi>();
            foreach (DataRow r in Db.Query("EXEC sp_Chuyen_DanhSach").Rows) list.Add(Map(r));
            return list;
        }

        private static void Validate(ChuyenDi c)
        {
            if (string.IsNullOrWhiteSpace(c.MaChuyen)) throw new NghiepVuException("Mã chuyến không được để trống.");
            if (string.IsNullOrWhiteSpace(c.MaTour)) throw new NghiepVuException("Chọn tour.");
            if (c.NgayVe.Date < c.NgayDi.Date) throw new NghiepVuException("Ngày về phải sau hoặc bằng ngày đi.");
        }

        public void Them(ChuyenDi c)
        {
            Validate(c);
            Db.Execute("EXEC sp_Chuyen_Them @MaChuyen, @MaTour, @NgayDi, @NgayVe, @TinhTrang",
                Sql.P("@MaChuyen", c.MaChuyen.Trim()), Sql.P("@MaTour", c.MaTour), Sql.P("@NgayDi", c.NgayDi.Date),
                Sql.P("@NgayVe", c.NgayVe.Date), Sql.P("@TinhTrang", c.TinhTrang ?? TinhTrangs[0]));
        }

        public void Sua(ChuyenDi c)
        {
            Validate(c);
            Db.Execute("EXEC sp_Chuyen_Sua @MaChuyen, @MaTour, @NgayDi, @NgayVe, @TinhTrang",
                Sql.P("@MaChuyen", c.MaChuyen.Trim()), Sql.P("@MaTour", c.MaTour), Sql.P("@NgayDi", c.NgayDi.Date),
                Sql.P("@NgayVe", c.NgayVe.Date), Sql.P("@TinhTrang", c.TinhTrang));
        }

        public void Xoa(string maChuyen) { Db.Execute("EXEC sp_Chuyen_Xoa @MaChuyen", Sql.P("@MaChuyen", maChuyen)); }
    }
}
