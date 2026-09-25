namespace QuanLyKhachSan.Forms
{
    partial class FrmDatPhong
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numCoc = new System.Windows.Forms.NumericUpDown();
            this.cboKenh = new System.Windows.Forms.ComboBox();
            this.cboKhach = new System.Windows.Forms.ComboBox();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.ColSoPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKhach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayNhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKenh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChon = new System.Windows.Forms.DataGridView();
            this.ColPhongChon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoNguoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.ColPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(989, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numCoc);
            this.tabPage1.Controls.Add(this.cboKenh);
            this.tabPage1.Controls.Add(this.cboKhach);
            this.tabPage1.Controls.Add(this.txtSoPhieu);
            this.tabPage1.Controls.Add(this.btnLapPhieu);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.dgvPhieu);
            this.tabPage1.Controls.Add(this.dgvChon);
            this.tabPage1.Controls.Add(this.dgvPhong);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(981, 533);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Khách hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numCoc
            // 
            this.numCoc.Location = new System.Drawing.Point(808, 20);
            this.numCoc.Name = "numCoc";
            this.numCoc.Size = new System.Drawing.Size(120, 24);
            this.numCoc.TabIndex = 17;
            // 
            // cboKenh
            // 
            this.cboKenh.FormattingEnabled = true;
            this.cboKenh.Location = new System.Drawing.Point(569, 19);
            this.cboKenh.Name = "cboKenh";
            this.cboKenh.Size = new System.Drawing.Size(121, 26);
            this.cboKenh.TabIndex = 16;
            // 
            // cboKhach
            // 
            this.cboKhach.FormattingEnabled = true;
            this.cboKhach.Location = new System.Drawing.Point(312, 19);
            this.cboKhach.Name = "cboKhach";
            this.cboKhach.Size = new System.Drawing.Size(121, 26);
            this.cboKhach.TabIndex = 15;
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoPhieu.Location = new System.Drawing.Point(106, 20);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(100, 24);
            this.txtSoPhieu.TabIndex = 14;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Location = new System.Drawing.Point(784, 274);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(191, 42);
            this.btnLapPhieu.TabIndex = 13;
            this.btnLapPhieu.Text = "Lập phiếu đặt";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Phiếu đặt phòng:";
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSoPhieu,
            this.ColKhach,
            this.ColNgayNhan,
            this.ColNgayTra,
            this.ColCoc,
            this.ColKenh,
            this.ColTrangThai});
            this.dgvPhieu.Location = new System.Drawing.Point(6, 370);
            this.dgvPhieu.MultiSelect = false;
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.ReadOnly = true;
            this.dgvPhieu.RowHeadersWidth = 51;
            this.dgvPhieu.RowTemplate.Height = 24;
            this.dgvPhieu.Size = new System.Drawing.Size(969, 157);
            this.dgvPhieu.TabIndex = 11;
            // 
            // ColSoPhieu
            // 
            this.ColSoPhieu.HeaderText = "Số phiếu";
            this.ColSoPhieu.MinimumWidth = 6;
            this.ColSoPhieu.Name = "ColSoPhieu";
            this.ColSoPhieu.ReadOnly = true;
            // 
            // ColKhach
            // 
            this.ColKhach.HeaderText = "Khách";
            this.ColKhach.MinimumWidth = 6;
            this.ColKhach.Name = "ColKhach";
            this.ColKhach.ReadOnly = true;
            // 
            // ColNgayNhan
            // 
            this.ColNgayNhan.HeaderText = "Ngày nhận";
            this.ColNgayNhan.MinimumWidth = 6;
            this.ColNgayNhan.Name = "ColNgayNhan";
            this.ColNgayNhan.ReadOnly = true;
            // 
            // ColNgayTra
            // 
            this.ColNgayTra.HeaderText = "Ngày trả dự kiến";
            this.ColNgayTra.MinimumWidth = 6;
            this.ColNgayTra.Name = "ColNgayTra";
            this.ColNgayTra.ReadOnly = true;
            // 
            // ColCoc
            // 
            this.ColCoc.HeaderText = "Cọc";
            this.ColCoc.MinimumWidth = 6;
            this.ColCoc.Name = "ColCoc";
            this.ColCoc.ReadOnly = true;
            // 
            // ColKenh
            // 
            this.ColKenh.HeaderText = "Kênh";
            this.ColKenh.MinimumWidth = 6;
            this.ColKenh.Name = "ColKenh";
            this.ColKenh.ReadOnly = true;
            // 
            // ColTrangThai
            // 
            this.ColTrangThai.HeaderText = "Trạng thái";
            this.ColTrangThai.MinimumWidth = 6;
            this.ColTrangThai.Name = "ColTrangThai";
            this.ColTrangThai.ReadOnly = true;
            // 
            // dgvChon
            // 
            this.dgvChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChon.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPhongChon,
            this.ColSoNguoi,
            this.dataGridViewTextBoxColumn1});
            this.dgvChon.Location = new System.Drawing.Point(520, 71);
            this.dgvChon.MultiSelect = false;
            this.dgvChon.Name = "dgvChon";
            this.dgvChon.ReadOnly = true;
            this.dgvChon.RowHeadersWidth = 51;
            this.dgvChon.RowTemplate.Height = 24;
            this.dgvChon.Size = new System.Drawing.Size(455, 197);
            this.dgvChon.TabIndex = 10;
            // 
            // ColPhongChon
            // 
            this.ColPhongChon.HeaderText = "Phòng chọn";
            this.ColPhongChon.MinimumWidth = 6;
            this.ColPhongChon.Name = "ColPhongChon";
            this.ColPhongChon.ReadOnly = true;
            // 
            // ColSoNguoi
            // 
            this.ColSoNguoi.HeaderText = "Số người";
            this.ColSoNguoi.MinimumWidth = 6;
            this.ColSoNguoi.Name = "ColSoNguoi";
            this.ColSoNguoi.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Đơn giá / ngày";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColPhong,
            this.ColKhu,
            this.ColSucChua,
            this.ColDonGia});
            this.dgvPhong.Location = new System.Drawing.Point(6, 71);
            this.dgvPhong.MultiSelect = false;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.Size = new System.Drawing.Size(455, 197);
            this.dgvPhong.TabIndex = 9;
            // 
            // ColPhong
            // 
            this.ColPhong.HeaderText = "Phòng";
            this.ColPhong.MinimumWidth = 6;
            this.ColPhong.Name = "ColPhong";
            this.ColPhong.ReadOnly = true;
            // 
            // ColKhu
            // 
            this.ColKhu.HeaderText = "Khu";
            this.ColKhu.MinimumWidth = 6;
            this.ColKhu.Name = "ColKhu";
            this.ColKhu.ReadOnly = true;
            // 
            // ColSucChua
            // 
            this.ColSucChua.HeaderText = "Sức chứa";
            this.ColSucChua.MinimumWidth = 6;
            this.ColSucChua.Name = "ColSucChua";
            this.ColSucChua.ReadOnly = true;
            // 
            // ColDonGia
            // 
            this.ColDonGia.HeaderText = "Đơn giá";
            this.ColDonGia.MinimumWidth = 6;
            this.ColDonGia.Name = "ColDonGia";
            this.ColDonGia.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(733, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiền cọc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(493, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kênh đặt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Khách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Số phiếu đặt:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(981, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đặt phòng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(981, 533);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nhận phòng / Người lưu trú";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // FrmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 592);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmDatPhong";
            this.Text = "Khách hàng - Đặt phòng - Nhận phòng";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKhach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKenh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTrangThai;
        private System.Windows.Forms.DataGridView dgvChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhongChon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoNguoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSucChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDonGia;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numCoc;
        private System.Windows.Forms.ComboBox cboKenh;
        private System.Windows.Forms.ComboBox cboKhach;
    }
}