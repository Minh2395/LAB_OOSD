namespace QuanLyKhachSan.Forms
{
    partial class FrmPhongTienNghi
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
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.cboKhu = new System.Windows.Forms.ComboBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.ColPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKhu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnThemTN = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numSTT = new System.Windows.Forms.NumericUpDown();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.txtMaTN = new System.Windows.Forms.TextBox();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.ColMaTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLoaiTN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTTLD = new System.Windows.Forms.TextBox();
            this.txtSoLD = new System.Windows.Forms.TextBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.cboTN = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dgvLD = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.btnLapDat = new System.Windows.Forms.Button();
            this.ColThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhongLD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTinhT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numGia);
            this.tabPage1.Controls.Add(this.numMax);
            this.tabPage1.Controls.Add(this.cboKhu);
            this.tabPage1.Controls.Add(this.txtPhong);
            this.tabPage1.Controls.Add(this.btnThemPhong);
            this.tabPage1.Controls.Add(this.dgvPhong);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Phòng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numGia
            // 
            this.numGia.Location = new System.Drawing.Point(691, 23);
            this.numGia.Name = "numGia";
            this.numGia.Size = new System.Drawing.Size(71, 28);
            this.numGia.TabIndex = 40;
            // 
            // numMax
            // 
            this.numMax.Location = new System.Drawing.Point(484, 23);
            this.numMax.Name = "numMax";
            this.numMax.Size = new System.Drawing.Size(71, 28);
            this.numMax.TabIndex = 39;
            // 
            // cboKhu
            // 
            this.cboKhu.FormattingEnabled = true;
            this.cboKhu.Location = new System.Drawing.Point(268, 23);
            this.cboKhu.Name = "cboKhu";
            this.cboKhu.Size = new System.Drawing.Size(71, 30);
            this.cboKhu.TabIndex = 38;
            // 
            // txtPhong
            // 
            this.txtPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhong.Location = new System.Drawing.Point(104, 23);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(71, 28);
            this.txtPhong.TabIndex = 30;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhong.Location = new System.Drawing.Point(565, 307);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(197, 31);
            this.btnThemPhong.TabIndex = 29;
            this.btnThemPhong.Text = "Lập phiếu";
            this.btnThemPhong.UseVisualStyleBackColor = true;
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
            this.ColDonGia,
            this.colTrangThai});
            this.dgvPhong.Location = new System.Drawing.Point(6, 62);
            this.dgvPhong.MultiSelect = false;
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.ReadOnly = true;
            this.dgvPhong.RowHeadersVisible = false;
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(756, 208);
            this.dgvPhong.TabIndex = 24;
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
            // colTrangThai
            // 
            this.colTrangThai.HeaderText = "Trạng thái";
            this.colTrangThai.MinimumWidth = 6;
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 22);
            this.label4.TabIndex = 23;
            this.label4.Text = "Đơn giá / ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 22;
            this.label3.Text = "Số người tối đa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "Khu vực:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Số phòng:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnThemTN);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.numSTT);
            this.tabPage2.Controls.Add(this.cboLoai);
            this.tabPage2.Controls.Add(this.txtMaTN);
            this.tabPage2.Controls.Add(this.dgvTN);
            this.tabPage2.Controls.Add(this.txtTinhTrang);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tiện nghi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnThemTN
            // 
            this.btnThemTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemTN.Location = new System.Drawing.Point(551, 333);
            this.btnThemTN.Name = "btnThemTN";
            this.btnThemTN.Size = new System.Drawing.Size(197, 31);
            this.btnThemTN.TabIndex = 47;
            this.btnThemTN.Text = "Lập phiếu";
            this.btnThemTN.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 46;
            this.label7.Text = "Số thứ tự:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(394, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 22);
            this.label6.TabIndex = 45;
            this.label6.Text = "Loại tiện nghi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Mã tiện nghi:";
            // 
            // numSTT
            // 
            this.numSTT.Location = new System.Drawing.Point(124, 67);
            this.numSTT.Name = "numSTT";
            this.numSTT.Size = new System.Drawing.Size(176, 28);
            this.numSTT.TabIndex = 43;
            // 
            // cboLoai
            // 
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.Location = new System.Drawing.Point(522, 22);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(176, 30);
            this.cboLoai.TabIndex = 42;
            // 
            // txtMaTN
            // 
            this.txtMaTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaTN.Location = new System.Drawing.Point(124, 24);
            this.txtMaTN.Name = "txtMaTN";
            this.txtMaTN.Size = new System.Drawing.Size(176, 28);
            this.txtMaTN.TabIndex = 41;
            // 
            // dgvTN
            // 
            this.dgvTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTN.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColMaTN,
            this.ColLoaiTN,
            this.ColSTT,
            this.ColTinhTrang});
            this.dgvTN.Location = new System.Drawing.Point(6, 104);
            this.dgvTN.MultiSelect = false;
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.ReadOnly = true;
            this.dgvTN.RowHeadersVisible = false;
            this.dgvTN.RowHeadersWidth = 51;
            this.dgvTN.RowTemplate.Height = 24;
            this.dgvTN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTN.Size = new System.Drawing.Size(756, 208);
            this.dgvTN.TabIndex = 40;
            // 
            // ColMaTN
            // 
            this.ColMaTN.HeaderText = "Mã tiện nghi";
            this.ColMaTN.MinimumWidth = 6;
            this.ColMaTN.Name = "ColMaTN";
            this.ColMaTN.ReadOnly = true;
            // 
            // ColLoaiTN
            // 
            this.ColLoaiTN.HeaderText = "Loại tiện nghi";
            this.ColLoaiTN.MinimumWidth = 6;
            this.ColLoaiTN.Name = "ColLoaiTN";
            this.ColLoaiTN.ReadOnly = true;
            // 
            // ColSTT
            // 
            this.ColSTT.HeaderText = "Số thứ tự";
            this.ColSTT.MinimumWidth = 6;
            this.ColSTT.Name = "ColSTT";
            this.ColSTT.ReadOnly = true;
            // 
            // ColTinhTrang
            // 
            this.ColTinhTrang.HeaderText = "Tình trạng";
            this.ColTinhTrang.MinimumWidth = 6;
            this.ColTinhTrang.Name = "ColTinhTrang";
            this.ColTinhTrang.ReadOnly = true;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTinhTrang.Location = new System.Drawing.Point(522, 67);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(176, 28);
            this.txtTinhTrang.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 22);
            this.label8.TabIndex = 38;
            this.label8.Text = "Tình trạng:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnLapDat);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.dgvLD);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.dtNgay);
            this.tabPage3.Controls.Add(this.txtGhiChu);
            this.tabPage3.Controls.Add(this.txtTTLD);
            this.tabPage3.Controls.Add(this.txtSoLD);
            this.tabPage3.Controls.Add(this.cboNV);
            this.tabPage3.Controls.Add(this.cboPhong);
            this.tabPage3.Controls.Add(this.cboTN);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 391);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Lắp đặt / luân chuyển";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(546, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 22);
            this.label11.TabIndex = 9;
            this.label11.Text = "Số phòng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(301, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 22);
            this.label10.TabIndex = 8;
            this.label10.Text = "Tiện nghi:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 22);
            this.label9.TabIndex = 7;
            this.label9.Text = "Số lượng lắp đặt:";
            // 
            // dtNgay
            // 
            this.dtNgay.CustomFormat = "dd/MM/yyyy";
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgay.Location = new System.Drawing.Point(142, 86);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(142, 28);
            this.dtNgay.TabIndex = 6;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGhiChu.Location = new System.Drawing.Point(89, 309);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(353, 28);
            this.txtGhiChu.TabIndex = 5;
            // 
            // txtTTLD
            // 
            this.txtTTLD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTTLD.Location = new System.Drawing.Point(433, 89);
            this.txtTTLD.Name = "txtTTLD";
            this.txtTTLD.Size = new System.Drawing.Size(108, 28);
            this.txtTTLD.TabIndex = 4;
            // 
            // txtSoLD
            // 
            this.txtSoLD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoLD.Location = new System.Drawing.Point(171, 22);
            this.txtSoLD.Name = "txtSoLD";
            this.txtSoLD.Size = new System.Drawing.Size(100, 28);
            this.txtSoLD.TabIndex = 3;
            // 
            // cboNV
            // 
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(644, 88);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(121, 30);
            this.cboNV.TabIndex = 2;
            // 
            // cboPhong
            // 
            this.cboPhong.FormattingEnabled = true;
            this.cboPhong.Location = new System.Drawing.Point(644, 20);
            this.cboPhong.Name = "cboPhong";
            this.cboPhong.Size = new System.Drawing.Size(121, 30);
            this.cboPhong.TabIndex = 1;
            // 
            // cboTN
            // 
            this.cboTN.FormattingEnabled = true;
            this.cboTN.Location = new System.Drawing.Point(397, 20);
            this.cboTN.Name = "cboTN";
            this.cboTN.Size = new System.Drawing.Size(121, 30);
            this.cboTN.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 22);
            this.label12.TabIndex = 10;
            this.label12.Text = "Ngày lắp đặt:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(301, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 22);
            this.label13.TabIndex = 11;
            this.label13.Text = "Thứ tự lắp đặt:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(546, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 22);
            this.label14.TabIndex = 12;
            this.label14.Text = "Nhân viên:";
            // 
            // dgvLD
            // 
            this.dgvLD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLD.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvLD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColThietBi,
            this.ColPhongLD,
            this.ColNgay,
            this.ColTinhT,
            this.ColNV});
            this.dgvLD.Location = new System.Drawing.Point(9, 124);
            this.dgvLD.MultiSelect = false;
            this.dgvLD.Name = "dgvLD";
            this.dgvLD.ReadOnly = true;
            this.dgvLD.RowHeadersVisible = false;
            this.dgvLD.RowHeadersWidth = 51;
            this.dgvLD.RowTemplate.Height = 24;
            this.dgvLD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLD.Size = new System.Drawing.Size(756, 169);
            this.dgvLD.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 311);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 22);
            this.label15.TabIndex = 42;
            this.label15.Text = "Ghi chú:";
            // 
            // btnLapDat
            // 
            this.btnLapDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapDat.Location = new System.Drawing.Point(550, 308);
            this.btnLapDat.Name = "btnLapDat";
            this.btnLapDat.Size = new System.Drawing.Size(197, 31);
            this.btnLapDat.TabIndex = 48;
            this.btnLapDat.Text = "Lập phiếu";
            this.btnLapDat.UseVisualStyleBackColor = true;
            // 
            // ColThietBi
            // 
            this.ColThietBi.HeaderText = "Thiết bị";
            this.ColThietBi.MinimumWidth = 6;
            this.ColThietBi.Name = "ColThietBi";
            this.ColThietBi.ReadOnly = true;
            // 
            // ColPhongLD
            // 
            this.ColPhongLD.HeaderText = "Phòng";
            this.ColPhongLD.MinimumWidth = 6;
            this.ColPhongLD.Name = "ColPhongLD";
            this.ColPhongLD.ReadOnly = true;
            // 
            // ColNgay
            // 
            this.ColNgay.HeaderText = "Ngày";
            this.ColNgay.MinimumWidth = 6;
            this.ColNgay.Name = "ColNgay";
            this.ColNgay.ReadOnly = true;
            // 
            // ColTinhT
            // 
            this.ColTinhT.HeaderText = "Tình trạng";
            this.ColTinhT.MinimumWidth = 6;
            this.ColTinhT.Name = "ColTinhT";
            this.ColTinhT.ReadOnly = true;
            // 
            // ColNV
            // 
            this.ColNV.HeaderText = "Nhân viên";
            this.ColNV.MinimumWidth = 6;
            this.ColNV.Name = "ColNV";
            this.ColNV.ReadOnly = true;
            // 
            // FrmPhongTienNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPhongTienNghi";
            this.Text = "Phòng - Tiện nghi - Phiếu lắp đặt";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSucChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMax;
        private System.Windows.Forms.ComboBox cboKhu;
        private System.Windows.Forms.NumericUpDown numGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numSTT;
        private System.Windows.Forms.ComboBox cboLoai;
        private System.Windows.Forms.TextBox txtMaTN;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThemTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLoaiTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTinhTrang;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.ComboBox cboPhong;
        private System.Windows.Forms.ComboBox cboTN;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTTLD;
        private System.Windows.Forms.TextBox txtSoLD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvLD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnLapDat;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhongLD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTinhT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNV;
    }
}