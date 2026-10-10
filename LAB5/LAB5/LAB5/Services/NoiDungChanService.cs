using System.Collections.Generic;
using System.Data;
using LAB5.Data;
using LAB5.Models;

namespace LAB5.Services
{
    public class NoiDungChanService
    {
        public List<NoiDungChan> GetByTour(string maTour)
        {
            var list = new List<NoiDungChan>();
            var dt = Db.Query("EXEC sp_NoiDungChan_DanhSach @MaTour", Sql.P("@MaTour", maTour));
            foreach (DataRow r in dt.Rows)
                list.Add(new NoiDungChan
                {
                    MaNoi = r.Int("MaNoi"),
                    MaTour = r.Str("MaTour"),
                    TenNoi = r.Str("TenNoi"),
                    DoiPhuongTien = r.Bool("DoiPhuongTien"),
                    CoNoiAn = r.Bool("CoNoiAn"),
                    CoKhachSan = r.Bool("CoKhachSan"),
                    LoaiKhachSan = r.ByteN("LoaiKhachSan")
                });
            return list;
        }

        public DataTable GetDanhSach(string maTour = null)
        {
            return Db.Query("EXEC sp_NoiDungChan_DanhSach @MaTour", Sql.P("@MaTour", maTour));
        }

        private static void Validate(NoiDungChan n)
        {
            if (string.IsNullOrWhiteSpace(n.MaTour)) throw new NghiepVuException("Chọn tour.");
            if (string.IsNullOrWhiteSpace(n.TenNoi)) throw new NghiepVuException("Nhập tên nơi dừng chân.");
            if (n.CoKhachSan && (n.LoaiKhachSan == null || n.LoaiKhachSan < 2 || n.LoaiKhachSan > 5))
                throw new NghiepVuException("Loại khách sạn phải từ 2 đến 5 sao.");
        }

        public void Them(NoiDungChan n)
        {
            Validate(n);
            Db.Execute("EXEC sp_NoiDungChan_Them @MaTour, @TenNoi, @DoiPT, @CoAn, @CoKS, @LoaiKS",
                Sql.P("@MaTour", n.MaTour), Sql.P("@TenNoi", n.TenNoi.Trim()), Sql.P("@DoiPT", n.DoiPhuongTien),
                Sql.P("@CoAn", n.CoNoiAn), Sql.P("@CoKS", n.CoKhachSan), Sql.P("@LoaiKS", n.LoaiKhachSan));
        }

        public void Sua(NoiDungChan n)
        {
            Validate(n);
            Db.Execute("EXEC sp_NoiDungChan_Sua @MaNoi, @TenNoi, @DoiPT, @CoAn, @CoKS, @LoaiKS",
                Sql.P("@MaNoi", n.MaNoi), Sql.P("@TenNoi", n.TenNoi.Trim()), Sql.P("@DoiPT", n.DoiPhuongTien),
                Sql.P("@CoAn", n.CoNoiAn), Sql.P("@CoKS", n.CoKhachSan), Sql.P("@LoaiKS", n.LoaiKhachSan));
        }

        public void Xoa(int maNoi) { Db.Execute("EXEC sp_NoiDungChan_Xoa @MaNoi", Sql.P("@MaNoi", maNoi)); }
    }
}
