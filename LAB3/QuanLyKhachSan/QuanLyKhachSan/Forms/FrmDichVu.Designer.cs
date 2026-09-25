namespace QuanLyKhachSan.Forms
{
    partial class FrmDichVu
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblLuot = new System.Windows.Forms.Label();
            this.cboLuot = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblDV = new System.Windows.Forms.Label();
            this.cboDV = new System.Windows.Forms.ComboBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.lblSL = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.lblNV = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.btnGhi = new System.Windows.Forms.Button();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLuot
            // 
            this.lblLuot.AutoSize = true;
            this.lblLuot.Location = new System.Drawing.Point(12, 16);
            this.lblLuot.Name = "lblLuot";
            this.lblLuot.Size = new System.Drawing.Size(127, 20);
            this.lblLuot.TabIndex = 0;
            this.lblLuot.Text = "Lượt đang lưu trú:";
            // 
            // cboLuot
            // 
            this.cboLuot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLuot.FormattingEnabled = true;
            this.cboLuot.Location = new System.Drawing.Point(145, 13);
            this.cboLuot.Name = "cboLuot";
            this.cboLuot.Size = new System.Drawing.Size(160, 28);
            this.cboLuot.TabIndex = 1;
            this.cboLuot.SelectedIndexChanged += new System.EventHandler(this.cboLuot_SelectedIndexChanged);
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(311, 16);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(54, 20);
            this.lblPhong.TabIndex = 2;
            this.lblPhong.Text = "Phòng:";
            // 
            // txtPhong
            // 
            this.txtPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhong.Location = new System.Drawing.Point(385, 11);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(80, 27);
            this.txtPhong.TabIndex = 3;
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.Location = new System.Drawing.Point(486, 16);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(61, 20);
            this.lblDV.TabIndex = 4;
            this.lblDV.Text = "Dịch vụ:";
            // 
            // cboDV
            // 
            this.cboDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDV.FormattingEnabled = true;
            this.cboDV.Location = new System.Drawing.Point(555, 11);
            this.cboDV.Name = "cboDV";
            this.cboDV.Size = new System.Drawing.Size(140, 28);
            this.cboDV.TabIndex = 5;
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Location = new System.Drawing.Point(12, 54);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(47, 20);
            this.lblNgay.TabIndex = 6;
            this.lblNgay.Text = "Ngày:";
            // 
            // dtNgay
            // 
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(59, 50);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(100, 27);
            this.dtNgay.TabIndex = 7;
            // 
            // lblSL
            // 
            this.lblSL.AutoSize = true;
            this.lblSL.Location = new System.Drawing.Point(165, 54);
            this.lblSL.Name = "lblSL";
            this.lblSL.Size = new System.Drawing.Size(72, 20);
            this.lblSL.TabIndex = 8;
            this.lblSL.Text = "Số lượng:";
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(243, 50);
            this.numSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(55, 27);
            this.numSL.TabIndex = 9;
            this.numSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(333, 54);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(32, 20);
            this.lblNV.TabIndex = 10;
            this.lblNV.Text = "NV:";
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(385, 49);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(140, 28);
            this.cboNV.TabIndex = 11;
            // 
            // btnGhi
            // 
            this.btnGhi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGhi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGhi.Location = new System.Drawing.Point(555, 50);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(140, 28);
            this.btnGhi.TabIndex = 12;
            this.btnGhi.Text = "Ghi nhận DV";
            this.btnGhi.UseVisualStyleBackColor = true;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // dgvLichSu
            // 
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLichSu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSu.Location = new System.Drawing.Point(12, 90);
            this.dgvLichSu.Name = "dgvLichSu";
            this.dgvLichSu.RowHeadersWidth = 51;
            this.dgvLichSu.Size = new System.Drawing.Size(683, 309);
            this.dgvLichSu.TabIndex = 13;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(610, 405);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(85, 30);
            this.btnDong.TabIndex = 14;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 447);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvLichSu);
            this.Controls.Add(this.btnGhi);
            this.Controls.Add(this.cboNV);
            this.Controls.Add(this.lblNV);
            this.Controls.Add(this.numSL);
            this.Controls.Add(this.lblSL);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.lblNgay);
            this.Controls.Add(this.cboDV);
            this.Controls.Add(this.lblDV);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.lblPhong);
            this.Controls.Add(this.cboLuot);
            this.Controls.Add(this.lblLuot);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.FrmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLuot;
        private System.Windows.Forms.ComboBox cboLuot;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.ComboBox cboDV;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label lblSL;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.DataGridView dgvLichSu;
        private System.Windows.Forms.Button btnDong;
    }
}