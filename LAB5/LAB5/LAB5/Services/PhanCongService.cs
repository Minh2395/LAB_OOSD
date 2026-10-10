using System;
using System.Data;
using LAB5.Data;
using LAB5.Models;

namespace LAB5.Services
{
    public class PhanCongService
    {
        public DataTable GetDanhSach(int? maNV = null)
        {
            return Db.Query("EXEC sp_PhanCong_DanhSach @MaNV", Sql.P("@MaNV", maNV));
        }

        /// <summary>
        /// Phân công HDV (BR05, BR10). Chỉ truyền MỘT trong hai: maChuyen (khách lẻ) hoặc maDoan (đoàn).
        /// Lịch chồng chéo và chuyến lẻ đã có HDV sẽ bị CSDL từ chối.
        /// </summary>
        public void PhanCong(int maNV, string maChuyen, int? maDoan, DateTime tuNgay, DateTime denNgay)
        {
            if (maNV <= 0) throw new NghiepVuException("Chọn hướng dẫn viên.");
            if ((maChuyen == null) == (maDoan == null)) throw new NghiepVuException("Chọn chuyến khách lẻ hoặc đoàn (chỉ một trong hai).");
            if (denNgay.Date < tuNgay.Date) throw new NghiepVuException("Khoảng ngày không hợp lệ.");

            Db.Execute("EXEC sp_PhanCong_Them @MaNV, @MaChuyen, @MaDoan, @TuNgay, @DenNgay",
                Sql.P("@MaNV", maNV), Sql.P("@MaChuyen", maChuyen), Sql.P("@MaDoan", maDoan),
                Sql.P("@TuNgay", tuNgay.Date), Sql.P("@DenNgay", denNgay.Date));
        }

        public void Huy(int maPC) { Db.Execute("EXEC sp_PhanCong_Huy @MaPC", Sql.P("@MaPC", maPC)); }
    }
}
