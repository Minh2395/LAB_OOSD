using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using QuanLyKhachSan.Models;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDatPhong : Form
    {
        readonly DatPhongService s = new DatPhongService();
        readonly DanhMucService dm = new DanhMucService();
        BindingList<PhongDatItem> chon = new BindingList<PhongDatItem>();

        public FrmDatPhong()
        {
            InitializeComponent();
        }

        private void FrmDatPhong_Load(object sender, EventArgs e)
        {
            cboKhach.DataSource = s.LayKhach();
            cboKhach.DisplayMember = "HoTen";
            cboKhach.ValueMember = "MaKhach";

            cboNV.DataSource = dm.LayNhanVien();
            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNV";

            cboKenh.Items.AddRange(new object[] { "Điện thoại", "Website", "Trực tiếp" });
            cboKenh.SelectedIndex = 0;

            dgvChon.DataSource = chon;
            TaiDuLieu();
        }

        void TaiDuLieu()
        {
            dgvKhach.DataSource = s.LayKhach();
            dgvPhong.DataSource = s.LayPhong();
            dgvPhieu.DataSource = s.LayPhieuDat();
        }

        string V(ComboBox c) => c.SelectedValue?.ToString() ?? "";

        void ThongBao(KetQuaXuLy k)
        {
            MessageBox.Show(k.ThongBao, "Thông báo");
            if (k.ThanhCong) TaiDuLieu();
        }

        private void btnThemKhach_Click(object sender, EventArgs e)
        {
            ThongBao(s.ThemKhach(txtMaKH.Text.Trim(), txtTenKH.Text.Trim(), txtCMND.Text.Trim(), txtQT.Text.Trim(), txtSDT.Text.Trim()));
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            if (dgvPhong.CurrentRow == null) return;
            string p = Convert.ToString(dgvPhong.CurrentRow.Cells["SoPhong"].Value);
            foreach (var x in chon)
            {
                if (x.SoPhong == p)
                {
                    MessageBox.Show("Phòng này đã có trong danh sách chọn.");
                    return;
                }
            }
            chon.Add(new PhongDatItem
            {
                SoPhong = p,
                SoNguoi = (int)numSoNguoi.Value,
                DonGiaNgay = Convert.ToDecimal(dgvPhong.CurrentRow.Cells["DonGiaNgay"].Value)
            });
        }

        private void btnBoPhong_Click(object sender, EventArgs e)
        {
            if (dgvChon.CurrentRow != null && dgvChon.CurrentRow.Index < chon.Count)
                chon.RemoveAt(dgvChon.CurrentRow.Index);
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            ThongBao(s.TaoDatPhong(txtSoPhieu.Text.Trim(), V(cboKhach), V(cboNV), dtLap.Value, dtNhan.Value, dtTra.Value, numCoc.Value, cboKenh.Text, new List<PhongDatItem>(chon)));
            chon.Clear();
        }

        private void dgvPhieu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPhieu.CurrentRow == null) return;
            string so = Convert.ToString(dgvPhieu.CurrentRow.Cells["SoPhieuDat"].Value);
            txtPhieuChon.Text = so;
            dgvCT.DataSource = s.LayChiTiet(so);
            dgvNguoi.DataSource = s.LayNguoiLuuTru(so);
        }

        private void btnThemNguoi_Click(object sender, EventArgs e)
        {
            ThongBao(s.ThemNguoiLuuTru(txtPhieuChon.Text.Trim(), txtNguoiPhong.Text.Trim(), txtNguoiTen.Text.Trim(), txtNguoiCMND.Text.Trim(), txtNguoiQT.Text.Trim()));
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            ThongBao(s.NhanPhong(txtPhieuChon.Text.Trim(), DateTime.Now));
        }

        private void btnNoShow_Click(object sender, EventArgs e)
        {
            ThongBao(s.DanhDauNoShow(txtPhieuChon.Text.Trim()));
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}