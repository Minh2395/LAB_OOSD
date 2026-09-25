namespace QuanLyKhachSan.Forms
{
    partial class FrmTraPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvKhu = new System.Windows.Forms.DataGridView();
            this.ColHoaDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhieuDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTienPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTienDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKhu
            // 
            this.dgvKhu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColHoaDon,
            this.ColPhieuDat,
            this.ColTienPhong,
            this.ColTienDichVu,
            this.ColTongTien,
            this.ColTrangThai});
            this.dgvKhu.GridColor = System.Drawing.SystemColors.WindowText;
            this.dgvKhu.Location = new System.Drawing.Point(50, 300);
            this.dgvKhu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.dgvKhu.MultiSelect = false;
            this.dgvKhu.Name = "dgvKhu";
            this.dgvKhu.ReadOnly = true;
            this.dgvKhu.RowHeadersVisible = false;
            this.dgvKhu.RowHeadersWidth = 51;
            this.dgvKhu.RowTemplate.Height = 24;
            this.dgvKhu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhu.Size = new System.Drawing.Size(921, 185);
            this.dgvKhu.TabIndex = 7;
            // 
            // ColHoaDon
            // 
            this.ColHoaDon.HeaderText = "Hóa đơn";
            this.ColHoaDon.MinimumWidth = 6;
            this.ColHoaDon.Name = "ColHoaDon";
            this.ColHoaDon.ReadOnly = true;
            // 
            // ColPhieuDat
            // 
            this.ColPhieuDat.HeaderText = "Phiếu đặt";
            this.ColPhieuDat.MinimumWidth = 6;
            this.ColPhieuDat.Name = "ColPhieuDat";
            this.ColPhieuDat.ReadOnly = true;
            // 
            // ColTienPhong
            // 
            this.ColTienPhong.HeaderText = "Tiền phòng";
            this.ColTienPhong.MinimumWidth = 6;
            this.ColTienPhong.Name = "ColTienPhong";
            this.ColTienPhong.ReadOnly = true;
            // 
            // ColTienDichVu
            // 
            this.ColTienDichVu.HeaderText = "Tiền dịch vụ";
            this.ColTienDichVu.MinimumWidth = 6;
            this.ColTienDichVu.Name = "ColTienDichVu";
            this.ColTienDichVu.ReadOnly = true;
            // 
            // ColTongTien
            // 
            this.ColTongTien.HeaderText = "Tổng tiền";
            this.ColTongTien.MinimumWidth = 6;
            this.ColTongTien.Name = "ColTongTien";
            this.ColTongTien.ReadOnly = true;
            // 
            // ColTrangThai
            // 
            this.ColTrangThai.HeaderText = "Trạng thái";
            this.ColTrangThai.MinimumWidth = 6;
            this.ColTrangThai.Name = "ColTrangThai";
            this.ColTrangThai.ReadOnly = true;
            // 
            // FrmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.dgvKhu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmTraPhong";
            this.Text = "FrmTraPhong";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhieuDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTienPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTienDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrangThai;
    }
}