namespace QuanLyKhachSan.Forms
{
    partial class FrmThongKe
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
            this.lblTu = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnTK = new System.Windows.Forms.Button();
            this.lblTongHop = new System.Windows.Forms.Label();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();
            this.lblDV = new System.Windows.Forms.Label();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(14, 18);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(80, 25);
            this.lblTu.TabIndex = 0;
            this.lblTu.Text = "Từ ngày:";
            // 
            // dtTu
            // 
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(89, 12);
            this.dtTu.Name = "dtTu";
            this.dtTu.Size = new System.Drawing.Size(120, 31);
            this.dtTu.TabIndex = 1;
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(215, 18);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(92, 25);
            this.lblDen.TabIndex = 2;
            this.lblDen.Text = "Đến ngày:";
            // 
            // dtDen
            // 
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(299, 13);
            this.dtDen.Name = "dtDen";
            this.dtDen.Size = new System.Drawing.Size(120, 31);
            this.dtDen.TabIndex = 3;
            // 
            // btnTK
            // 
            this.btnTK.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTK.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnTK.Location = new System.Drawing.Point(425, 11);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(115, 30);
            this.btnTK.TabIndex = 4;
            this.btnTK.Text = "Xem thống kê";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // lblTongHop
            // 
            this.lblTongHop.AutoSize = true;
            this.lblTongHop.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTongHop.Location = new System.Drawing.Point(14, 55);
            this.lblTongHop.Name = "lblTongHop";
            this.lblTongHop.Size = new System.Drawing.Size(189, 25);
            this.lblTongHop.TabIndex = 5;
            this.lblTongHop.Text = "Thống kê tổng hợp:";
            // 
            // dgvTongHop
            // 
            this.dgvTongHop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTongHop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTongHop.Location = new System.Drawing.Point(14, 78);
            this.dgvTongHop.Name = "dgvTongHop";
            this.dgvTongHop.RowHeadersWidth = 51;
            this.dgvTongHop.Size = new System.Drawing.Size(810, 100);
            this.dgvTongHop.TabIndex = 6;
            // 
            // lblDV
            // 
            this.lblDV.AutoSize = true;
            this.lblDV.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDV.Location = new System.Drawing.Point(14, 195);
            this.lblDV.Name = "lblDV";
            this.lblDV.Size = new System.Drawing.Size(250, 25);
            this.lblDV.TabIndex = 7;
            this.lblDV.Text = "Thống kê dịch vụ đã dùng:";
            // 
            // dgvDV
            // 
            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDV.Location = new System.Drawing.Point(14, 218);
            this.dgvDV.Name = "dgvDV";
            this.dgvDV.RowHeadersWidth = 51;
            this.dgvDV.Size = new System.Drawing.Size(810, 220);
            this.dgvDV.TabIndex = 8;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(724, 450);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 494);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.dgvDV);
            this.Controls.Add(this.lblDV);
            this.Controls.Add(this.dgvTongHop);
            this.Controls.Add(this.lblTongHop);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.dtDen);
            this.Controls.Add(this.lblDen);
            this.Controls.Add(this.dtTu);
            this.Controls.Add(this.lblTu);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.DateTimePicker dtTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.DateTimePicker dtDen;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Label lblTongHop;
        private System.Windows.Forms.DataGridView dgvTongHop;
        private System.Windows.Forms.Label lblDV;
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.Button btnDong;
    }
}