using QuanLyKhachSan.Services;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmDichVu : Form
    {
        readonly DichVuService s = new DichVuService();
        readonly DanhMucService dm = new DanhMucService();

        public FrmDichVu()
        {
            InitializeComponent();
        }

        private void FrmDichVu_Load(object sender, EventArgs e)
        {
            cboLuot.DataSource = s.LayPhieuDangO();
            cboLuot.DisplayMember = "SoPhieuDat";
            cboLuot.ValueMember = "SoPhieuDat";

            cboDV.DataSource = s.LayDichVu();
            cboDV.DisplayMember = "TenDV";
            cboDV.ValueMember = "MaDV";

            cboNV.DataSource = dm.LayNhanVien();
            cboNV.DisplayMember = "HoTen";
            cboNV.ValueMember = "MaNV";

            TaiDuLieu();
        }

        void TaiDuLieu()
        {
            if (cboLuot.SelectedValue != null)
                dgvLichSu.DataSource = s.LayLichSu(cboLuot.SelectedValue.ToString());
        }

        string V(ComboBox c) => c.SelectedValue?.ToString() ?? "";

        private void cboLuot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLuot.SelectedItem is DataRowView r)
                txtPhong.Text = Convert.ToString(r["SoPhong"]);
            TaiDuLieu();
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            var k = s.GhiNhan(V(cboLuot), txtPhong.Text.Trim(), dtNgay.Value, V(cboNV), V(cboDV), (int)numSL.Value);
            MessageBox.Show(k.ThongBao, "Thông báo");
            if (k.ThanhCong) TaiDuLieu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}