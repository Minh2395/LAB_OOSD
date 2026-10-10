using System;
using System.Data;
using LAB5.Data;

namespace LAB5.Services
{
    public enum LoaiThongKe
    {
        Tour = 0,
        DichVu = 1,
        SoLuongKhach = 2,
        DoanhThu = 3,
        SoTourNhanVien = 4
    }

    public class ThongKeService
    {
        /// <summary>Thống kê theo khoảng thời gian (BR09). Thứ tự khớp với ComboBox cboLoaiThongKe.</summary>
        public DataTable ThongKe(LoaiThongKe loai, DateTime tuNgay, DateTime denNgay)
        {
            if (denNgay.Date < tuNgay.Date) throw new NghiepVuException("Khoảng thời gian không hợp lệ.");
            return Db.Query("EXEC sp_ThongKe @Loai, @TuNgay, @DenNgay",
                Sql.P("@Loai", (int)loai), Sql.P("@TuNgay", tuNgay.Date), Sql.P("@DenNgay", denNgay.Date));
        }
    }
}
