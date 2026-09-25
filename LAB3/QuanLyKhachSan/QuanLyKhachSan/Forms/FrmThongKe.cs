using System;
using System.Windows.Forms;
using QuanLyKhachSan.Services;

namespace QuanLyKhachSan.Forms
{
    public partial class FrmThongKe : Form
    {
        readonly ThongKeService s = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            if (dtDen.Value.Date < dtTu.Value.Date)
            {
                MessageBox.Show("Mốc 'Đến ngày' không được trước 'Từ ngày'.", "Lỗi khoảng thời gian");
                return;
            }
            dgvTongHop.DataSource = s.TongHop(dtTu.Value, dtDen.Value);
            dgvDV.DataSource = s.DichVu(dtTu.Value, dtDen.Value);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}