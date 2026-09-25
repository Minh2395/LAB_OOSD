namespace QuanLyKhachSan.Forms
{
    partial class FrmDatPhong
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
            this.gbKhach = new System.Windows.Forms.GroupBox();
            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.btnThemKhach = new System.Windows.Forms.Button();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtQT = new System.Windows.Forms.TextBox();
            this.lblQT = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.lblTenKH = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.gbDatPhong = new System.Windows.Forms.GroupBox();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.btnBoPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.numSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.lblSoNguoi = new System.Windows.Forms.Label();
            this.dgvChon = new System.Windows.Forms.DataGridView();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.numCoc = new System.Windows.Forms.NumericUpDown();
            this.lblCoc = new System.Windows.Forms.Label();
            this.cboKenh = new System.Windows.Forms.ComboBox();
            this.lblKenh = new System.Windows.Forms.Label();
            this.dtTra = new System.Windows.Forms.DateTimePicker();
            this.lblTra = new System.Windows.Forms.Label();
            this.dtNhan = new System.Windows.Forms.DateTimePicker();
            this.lblNhan = new System.Windows.Forms.Label();
            this.dtLap = new System.Windows.Forms.DateTimePicker();
            this.lblLap = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.cboKhach = new System.Windows.Forms.ComboBox();
            this.lblKhach = new System.Windows.Forms.Label();
            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.lblSoPhieu = new System.Windows.Forms.Label();
            this.gbNhanPhong = new System.Windows.Forms.GroupBox();
            this.btnNoShow = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.btnThemNguoi = new System.Windows.Forms.Button();
            this.txtNguoiQT = new System.Windows.Forms.TextBox();
            this.lblNguoiQT = new System.Windows.Forms.Label();
            this.txtNguoiCMND = new System.Windows.Forms.TextBox();
            this.lblNguoiCMND = new System.Windows.Forms.Label();
            this.txtNguoiTen = new System.Windows.Forms.TextBox();
            this.lblNguoiTen = new System.Windows.Forms.Label();
            this.txtNguoiPhong = new System.Windows.Forms.TextBox();
            this.lblNguoiPhong = new System.Windows.Forms.Label();
            this.txtPhieuChon = new System.Windows.Forms.TextBox();
            this.lblPhieuChon = new System.Windows.Forms.Label();
            this.dgvNguoi = new System.Windows.Forms.DataGridView();
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.btnDong = new System.Windows.Forms.Button();
            this.gbKhach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            this.gbDatPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).BeginInit();
            this.gbNhanPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            this.SuspendLayout();
            // 
            // gbKhach
            // 
            this.gbKhach.Controls.Add(this.dgvKhach);
            this.gbKhach.Controls.Add(this.btnThemKhach);
            this.gbKhach.Controls.Add(this.txtSDT);
            this.gbKhach.Controls.Add(this.lblSDT);
            this.gbKhach.Controls.Add(this.txtQT);
            this.gbKhach.Controls.Add(this.lblQT);
            this.gbKhach.Controls.Add(this.txtCMND);
            this.gbKhach.Controls.Add(this.lblCMND);
            this.gbKhach.Controls.Add(this.txtTenKH);
            this.gbKhach.Controls.Add(this.lblTenKH);
            this.gbKhach.Controls.Add(this.txtMaKH);
            this.gbKhach.Controls.Add(this.lblMaKH);
            this.gbKhach.Location = new System.Drawing.Point(12, 12);
            this.gbKhach.Name = "gbKhach";
            this.gbKhach.Size = new System.Drawing.Size(960, 160);
            this.gbKhach.TabIndex = 0;
            this.gbKhach.TabStop = false;
            this.gbKhach.Text = "1. Quản lý khách hàng";
            // 
            // dgvKhach
            // 
            this.dgvKhach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhach.Location = new System.Drawing.Point(370, 16);
            this.dgvKhach.Name = "dgvKhach";
            this.dgvKhach.RowHeadersWidth = 51;
            this.dgvKhach.Size = new System.Drawing.Size(580, 135);
            this.dgvKhach.TabIndex = 11;
            // 
            // btnThemKhach
            // 
            this.btnThemKhach.Location = new System.Drawing.Point(235, 115);
            this.btnThemKhach.Name = "btnThemKhach";
            this.btnThemKhach.Size = new System.Drawing.Size(120, 30);
            this.btnThemKhach.TabIndex = 10;
            this.btnThemKhach.Text = "Thêm khách";
            this.btnThemKhach.UseVisualStyleBackColor = true;
            this.btnThemKhach.Click += new System.EventHandler(this.btnThemKhach_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSDT.Location = new System.Drawing.Point(235, 80);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(120, 27);
            this.txtSDT.TabIndex = 9;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(195, 84);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(39, 20);
            this.lblSDT.TabIndex = 8;
            this.lblSDT.Text = "SĐT:";
            // 
            // txtQT
            // 
            this.txtQT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQT.Location = new System.Drawing.Point(85, 80);
            this.txtQT.Name = "txtQT";
            this.txtQT.Size = new System.Drawing.Size(110, 27);
            this.txtQT.TabIndex = 7;
            this.txtQT.Text = "Việt Nam";
            // 
            // lblQT
            // 
            this.lblQT.AutoSize = true;
            this.lblQT.Location = new System.Drawing.Point(10, 84);
            this.lblQT.Name = "lblQT";
            this.lblQT.Size = new System.Drawing.Size(75, 20);
            this.lblQT.TabIndex = 6;
            this.lblQT.Text = "Quốc tịch:";
            // 
            // txtCMND
            // 
            this.txtCMND.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCMND.Location = new System.Drawing.Point(235, 48);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(120, 27);
            this.txtCMND.TabIndex = 5;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(180, 52);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(50, 20);
            this.lblCMND.TabIndex = 4;
            this.lblCMND.Text = "CCCD:";
            // 
            // txtTenKH
            // 
            this.txtTenKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKH.Location = new System.Drawing.Point(75, 48);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(100, 27);
            this.txtTenKH.TabIndex = 3;
            // 
            // lblTenKH
            // 
            this.lblTenKH.AutoSize = true;
            this.lblTenKH.Location = new System.Drawing.Point(10, 52);
            this.lblTenKH.Name = "lblTenKH";
            this.lblTenKH.Size = new System.Drawing.Size(57, 20);
            this.lblTenKH.TabIndex = 2;
            this.lblTenKH.Text = "Họ tên:";
            // 
            // txtMaKH
            // 
            this.txtMaKH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaKH.Location = new System.Drawing.Point(75, 19);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 27);
            this.txtMaKH.TabIndex = 1;
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(10, 23);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(57, 20);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã KH:";
            // 
            // gbDatPhong
            // 
            this.gbDatPhong.Controls.Add(this.btnLapPhieu);
            this.gbDatPhong.Controls.Add(this.btnBoPhong);
            this.gbDatPhong.Controls.Add(this.btnThemPhong);
            this.gbDatPhong.Controls.Add(this.numSoNguoi);
            this.gbDatPhong.Controls.Add(this.lblSoNguoi);
            this.gbDatPhong.Controls.Add(this.dgvChon);
            this.gbDatPhong.Controls.Add(this.dgvPhong);
            this.gbDatPhong.Controls.Add(this.numCoc);
            this.gbDatPhong.Controls.Add(this.lblCoc);
            this.gbDatPhong.Controls.Add(this.cboKenh);
            this.gbDatPhong.Controls.Add(this.lblKenh);
            this.gbDatPhong.Controls.Add(this.dtTra);
            this.gbDatPhong.Controls.Add(this.lblTra);
            this.gbDatPhong.Controls.Add(this.dtNhan);
            this.gbDatPhong.Controls.Add(this.lblNhan);
            this.gbDatPhong.Controls.Add(this.dtLap);
            this.gbDatPhong.Controls.Add(this.lblLap);
            this.gbDatPhong.Controls.Add(this.cboNV);
            this.gbDatPhong.Controls.Add(this.lblNV);
            this.gbDatPhong.Controls.Add(this.cboKhach);
            this.gbDatPhong.Controls.Add(this.lblKhach);
            this.gbDatPhong.Controls.Add(this.txtSoPhieu);
            this.gbDatPhong.Controls.Add(this.lblSoPhieu);
            this.gbDatPhong.Location = new System.Drawing.Point(12, 180);
            this.gbDatPhong.Name = "gbDatPhong";
            this.gbDatPhong.Size = new System.Drawing.Size(960, 250);
            this.gbDatPhong.TabIndex = 1;
            this.gbDatPhong.TabStop = false;
            this.gbDatPhong.Text = "2. Lập phiếu đặt phòng";
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLapPhieu.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnLapPhieu.Location = new System.Drawing.Point(790, 200);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(160, 40);
            this.btnLapPhieu.TabIndex = 22;
            this.btnLapPhieu.Text = "XÁC NHẬN ĐẶT";
            this.btnLapPhieu.UseVisualStyleBackColor = true;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // btnBoPhong
            // 
            this.btnBoPhong.Location = new System.Drawing.Point(535, 140);
            this.btnBoPhong.Name = "btnBoPhong";
            this.btnBoPhong.Size = new System.Drawing.Size(50, 30);
            this.btnBoPhong.TabIndex = 21;
            this.btnBoPhong.Text = "<<";
            this.btnBoPhong.UseVisualStyleBackColor = true;
            this.btnBoPhong.Click += new System.EventHandler(this.btnBoPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(535, 95);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(50, 30);
            this.btnThemPhong.TabIndex = 20;
            this.btnThemPhong.Text = ">>";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // numSoNguoi
            // 
            this.numSoNguoi.Location = new System.Drawing.Point(535, 60);
            this.numSoNguoi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoNguoi.Name = "numSoNguoi";
            this.numSoNguoi.Size = new System.Drawing.Size(50, 27);
            this.numSoNguoi.TabIndex = 19;
            this.numSoNguoi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoNguoi
            // 
            this.lblSoNguoi.AutoSize = true;
            this.lblSoNguoi.Location = new System.Drawing.Point(535, 40);
            this.lblSoNguoi.Name = "lblSoNguoi";
            this.lblSoNguoi.Size = new System.Drawing.Size(50, 20);
            this.lblSoNguoi.TabIndex = 18;
            this.lblSoNguoi.Text = "Số ng:";
            // 
            // dgvChon
            // 
            this.dgvChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChon.Location = new System.Drawing.Point(595, 20);
            this.dgvChon.Name = "dgvChon";
            this.dgvChon.RowHeadersWidth = 51;
            this.dgvChon.Size = new System.Drawing.Size(355, 170);
            this.dgvChon.TabIndex = 17;
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(235, 20);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.Size = new System.Drawing.Size(290, 220);
            this.dgvPhong.TabIndex = 16;
            // 
            // numCoc
            // 
            this.numCoc.DecimalPlaces = 2;
            this.numCoc.Location = new System.Drawing.Point(90, 213);
            this.numCoc.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numCoc.Name = "numCoc";
            this.numCoc.Size = new System.Drawing.Size(125, 27);
            this.numCoc.TabIndex = 15;
            // 
            // lblCoc
            // 
            this.lblCoc.AutoSize = true;
            this.lblCoc.Location = new System.Drawing.Point(10, 219);
            this.lblCoc.Name = "lblCoc";
            this.lblCoc.Size = new System.Drawing.Size(67, 20);
            this.lblCoc.TabIndex = 14;
            this.lblCoc.Text = "Tiền cọc:";
            // 
            // cboKenh
            // 
            this.cboKenh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKenh.FormattingEnabled = true;
            this.cboKenh.Location = new System.Drawing.Point(90, 186);
            this.cboKenh.Name = "cboKenh";
            this.cboKenh.Size = new System.Drawing.Size(125, 28);
            this.cboKenh.TabIndex = 13;
            // 
            // lblKenh
            // 
            this.lblKenh.AutoSize = true;
            this.lblKenh.Location = new System.Drawing.Point(10, 189);
            this.lblKenh.Name = "lblKenh";
            this.lblKenh.Size = new System.Drawing.Size(71, 20);
            this.lblKenh.TabIndex = 12;
            this.lblKenh.Text = "Kênh đặt:";
            // 
            // dtTra
            // 
            this.dtTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTra.Location = new System.Drawing.Point(90, 156);
            this.dtTra.Name = "dtTra";
            this.dtTra.Size = new System.Drawing.Size(125, 27);
            this.dtTra.TabIndex = 11;
            // 
            // lblTra
            // 
            this.lblTra.AutoSize = true;
            this.lblTra.Location = new System.Drawing.Point(10, 161);
            this.lblTra.Name = "lblTra";
            this.lblTra.Size = new System.Drawing.Size(69, 20);
            this.lblTra.TabIndex = 10;
            this.lblTra.Text = "Ngày trả:";
            // 
            // dtNhan
            // 
            this.dtNhan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNhan.Location = new System.Drawing.Point(90, 128);
            this.dtNhan.Name = "dtNhan";
            this.dtNhan.Size = new System.Drawing.Size(125, 27);
            this.dtNhan.TabIndex = 9;
            // 
            // lblNhan
            // 
            this.lblNhan.AutoSize = true;
            this.lblNhan.Location = new System.Drawing.Point(10, 133);
            this.lblNhan.Name = "lblNhan";
            this.lblNhan.Size = new System.Drawing.Size(83, 20);
            this.lblNhan.TabIndex = 8;
            this.lblNhan.Text = "Ngày nhận:";
            // 
            // dtLap
            // 
            this.dtLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtLap.Location = new System.Drawing.Point(85, 100);
            this.dtLap.Name = "dtLap";
            this.dtLap.Size = new System.Drawing.Size(130, 27);
            this.dtLap.TabIndex = 7;
            // 
            // lblLap
            // 
            this.lblLap.AutoSize = true;
            this.lblLap.Location = new System.Drawing.Point(10, 105);
            this.lblLap.Name = "lblLap";
            this.lblLap.Size = new System.Drawing.Size(72, 20);
            this.lblLap.TabIndex = 6;
            this.lblLap.Text = "Ngày lập:";
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(85, 74);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(130, 28);
            this.cboNV.TabIndex = 5;
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(10, 77);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(76, 20);
            this.lblNV.TabIndex = 4;
            this.lblNV.Text = "NV Lễ tân:";
            // 
            // cboKhach
            // 
            this.cboKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhach.FormattingEnabled = true;
            this.cboKhach.Location = new System.Drawing.Point(85, 46);
            this.cboKhach.Name = "cboKhach";
            this.cboKhach.Size = new System.Drawing.Size(130, 28);
            this.cboKhach.TabIndex = 3;
            // 
            // lblKhach
            // 
            this.lblKhach.AutoSize = true;
            this.lblKhach.Location = new System.Drawing.Point(10, 49);
            this.lblKhach.Name = "lblKhach";
            this.lblKhach.Size = new System.Drawing.Size(52, 20);
            this.lblKhach.TabIndex = 2;
            this.lblKhach.Text = "Khách:";
            // 
            // txtSoPhieu
            // 
            this.txtSoPhieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoPhieu.Location = new System.Drawing.Point(85, 19);
            this.txtSoPhieu.Name = "txtSoPhieu";
            this.txtSoPhieu.Size = new System.Drawing.Size(130, 27);
            this.txtSoPhieu.TabIndex = 1;
            // 
            // lblSoPhieu
            // 
            this.lblSoPhieu.AutoSize = true;
            this.lblSoPhieu.Location = new System.Drawing.Point(10, 21);
            this.lblSoPhieu.Name = "lblSoPhieu";
            this.lblSoPhieu.Size = new System.Drawing.Size(70, 20);
            this.lblSoPhieu.TabIndex = 0;
            this.lblSoPhieu.Text = "Số phiếu:";
            // 
            // gbNhanPhong
            // 
            this.gbNhanPhong.Controls.Add(this.btnNoShow);
            this.gbNhanPhong.Controls.Add(this.btnNhanPhong);
            this.gbNhanPhong.Controls.Add(this.btnThemNguoi);
            this.gbNhanPhong.Controls.Add(this.txtNguoiQT);
            this.gbNhanPhong.Controls.Add(this.lblNguoiQT);
            this.gbNhanPhong.Controls.Add(this.txtNguoiCMND);
            this.gbNhanPhong.Controls.Add(this.lblNguoiCMND);
            this.gbNhanPhong.Controls.Add(this.txtNguoiTen);
            this.gbNhanPhong.Controls.Add(this.lblNguoiTen);
            this.gbNhanPhong.Controls.Add(this.txtNguoiPhong);
            this.gbNhanPhong.Controls.Add(this.lblNguoiPhong);
            this.gbNhanPhong.Controls.Add(this.txtPhieuChon);
            this.gbNhanPhong.Controls.Add(this.lblPhieuChon);
            this.gbNhanPhong.Controls.Add(this.dgvNguoi);
            this.gbNhanPhong.Controls.Add(this.dgvCT);
            this.gbNhanPhong.Controls.Add(this.dgvPhieu);
            this.gbNhanPhong.Location = new System.Drawing.Point(12, 440);
            this.gbNhanPhong.Name = "gbNhanPhong";
            this.gbNhanPhong.Size = new System.Drawing.Size(960, 250);
            this.gbNhanPhong.TabIndex = 2;
            this.gbNhanPhong.TabStop = false;
            this.gbNhanPhong.Text = "3. Người lưu trú & Nhận phòng / No-show";
            // 
            // btnNoShow
            // 
            this.btnNoShow.Location = new System.Drawing.Point(825, 210);
            this.btnNoShow.Name = "btnNoShow";
            this.btnNoShow.Size = new System.Drawing.Size(125, 30);
            this.btnNoShow.TabIndex = 15;
            this.btnNoShow.Text = "Đánh dấu No-show";
            this.btnNoShow.UseVisualStyleBackColor = true;
            this.btnNoShow.Click += new System.EventHandler(this.btnNoShow_Click);
            // 
            // btnNhanPhong
            // 
            this.btnNhanPhong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNhanPhong.ForeColor = System.Drawing.Color.Blue;
            this.btnNhanPhong.Location = new System.Drawing.Point(695, 210);
            this.btnNhanPhong.Name = "btnNhanPhong";
            this.btnNhanPhong.Size = new System.Drawing.Size(120, 30);
            this.btnNhanPhong.TabIndex = 14;
            this.btnNhanPhong.Text = "NHẬN PHÒNG";
            this.btnNhanPhong.UseVisualStyleBackColor = true;
            this.btnNhanPhong.Click += new System.EventHandler(this.btnNhanPhong_Click);
            // 
            // btnThemNguoi
            // 
            this.btnThemNguoi.Location = new System.Drawing.Point(575, 210);
            this.btnThemNguoi.Name = "btnThemNguoi";
            this.btnThemNguoi.Size = new System.Drawing.Size(110, 30);
            this.btnThemNguoi.TabIndex = 13;
            this.btnThemNguoi.Text = "Thêm người";
            this.btnThemNguoi.UseVisualStyleBackColor = true;
            this.btnThemNguoi.Click += new System.EventHandler(this.btnThemNguoi_Click);
            // 
            // txtNguoiQT
            // 
            this.txtNguoiQT.Location = new System.Drawing.Point(460, 214);
            this.txtNguoiQT.Name = "txtNguoiQT";
            this.txtNguoiQT.Size = new System.Drawing.Size(95, 27);
            this.txtNguoiQT.TabIndex = 12;
            this.txtNguoiQT.Text = "Việt Nam";
            // 
            // lblNguoiQT
            // 
            this.lblNguoiQT.AutoSize = true;
            this.lblNguoiQT.Location = new System.Drawing.Point(430, 218);
            this.lblNguoiQT.Name = "lblNguoiQT";
            this.lblNguoiQT.Size = new System.Drawing.Size(30, 20);
            this.lblNguoiQT.TabIndex = 11;
            this.lblNguoiQT.Text = "QT:";
            // 
            // txtNguoiCMND
            // 
            this.txtNguoiCMND.Location = new System.Drawing.Point(340, 214);
            this.txtNguoiCMND.Name = "txtNguoiCMND";
            this.txtNguoiCMND.Size = new System.Drawing.Size(85, 27);
            this.txtNguoiCMND.TabIndex = 10;
            // 
            // lblNguoiCMND
            // 
            this.lblNguoiCMND.AutoSize = true;
            this.lblNguoiCMND.Location = new System.Drawing.Point(295, 218);
            this.lblNguoiCMND.Name = "lblNguoiCMND";
            this.lblNguoiCMND.Size = new System.Drawing.Size(50, 20);
            this.lblNguoiCMND.TabIndex = 9;
            this.lblNguoiCMND.Text = "CCCD:";
            // 
            // txtNguoiTen
            // 
            this.txtNguoiTen.Location = new System.Drawing.Point(205, 214);
            this.txtNguoiTen.Name = "txtNguoiTen";
            this.txtNguoiTen.Size = new System.Drawing.Size(85, 27);
            this.txtNguoiTen.TabIndex = 8;
            // 
            // lblNguoiTen
            // 
            this.lblNguoiTen.AutoSize = true;
            this.lblNguoiTen.Location = new System.Drawing.Point(155, 218);
            this.lblNguoiTen.Name = "lblNguoiTen";
            this.lblNguoiTen.Size = new System.Drawing.Size(57, 20);
            this.lblNguoiTen.TabIndex = 7;
            this.lblNguoiTen.Text = "Họ tên:";
            // 
            // txtNguoiPhong
            // 
            this.txtNguoiPhong.Location = new System.Drawing.Point(95, 214);
            this.txtNguoiPhong.Name = "txtNguoiPhong";
            this.txtNguoiPhong.Size = new System.Drawing.Size(55, 27);
            this.txtNguoiPhong.TabIndex = 6;
            // 
            // lblNguoiPhong
            // 
            this.lblNguoiPhong.AutoSize = true;
            this.lblNguoiPhong.Location = new System.Drawing.Point(35, 218);
            this.lblNguoiPhong.Name = "lblNguoiPhong";
            this.lblNguoiPhong.Size = new System.Drawing.Size(54, 20);
            this.lblNguoiPhong.TabIndex = 5;
            this.lblNguoiPhong.Text = "Phòng:";
            // 
            // txtPhieuChon
            // 
            this.txtPhieuChon.Location = new System.Drawing.Point(115, 181);
            this.txtPhieuChon.Name = "txtPhieuChon";
            this.txtPhieuChon.ReadOnly = true;
            this.txtPhieuChon.Size = new System.Drawing.Size(100, 27);
            this.txtPhieuChon.TabIndex = 4;
            // 
            // lblPhieuChon
            // 
            this.lblPhieuChon.AutoSize = true;
            this.lblPhieuChon.Location = new System.Drawing.Point(6, 184);
            this.lblPhieuChon.Name = "lblPhieuChon";
            this.lblPhieuChon.Size = new System.Drawing.Size(105, 20);
            this.lblPhieuChon.TabIndex = 3;
            this.lblPhieuChon.Text = "Phiếu đã chọn:";
            // 
            // dgvNguoi
            // 
            this.dgvNguoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNguoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoi.Location = new System.Drawing.Point(620, 20);
            this.dgvNguoi.Name = "dgvNguoi";
            this.dgvNguoi.RowHeadersWidth = 51;
            this.dgvNguoi.Size = new System.Drawing.Size(330, 150);
            this.dgvNguoi.TabIndex = 2;
            // 
            // dgvCT
            // 
            this.dgvCT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCT.Location = new System.Drawing.Point(370, 20);
            this.dgvCT.Name = "dgvCT";
            this.dgvCT.RowHeadersWidth = 51;
            this.dgvCT.Size = new System.Drawing.Size(240, 150);
            this.dgvCT.TabIndex = 1;
            // 
            // dgvPhieu
            // 
            this.dgvPhieu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieu.Location = new System.Drawing.Point(10, 20);
            this.dgvPhieu.Name = "dgvPhieu";
            this.dgvPhieu.RowHeadersWidth = 51;
            this.dgvPhieu.Size = new System.Drawing.Size(350, 150);
            this.dgvPhieu.TabIndex = 0;
            this.dgvPhieu.SelectionChanged += new System.EventHandler(this.dgvPhieu_SelectionChanged);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(870, 700);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 30);
            this.btnDong.TabIndex = 3;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 741);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.gbNhanPhong);
            this.Controls.Add(this.gbDatPhong);
            this.Controls.Add(this.gbKhach);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đặt phòng - Nhận phòng";
            this.Load += new System.EventHandler(this.FrmDatPhong_Load);
            this.gbKhach.ResumeLayout(false);
            this.gbKhach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            this.gbDatPhong.ResumeLayout(false);
            this.gbDatPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).EndInit();
            this.gbNhanPhong.ResumeLayout(false);
            this.gbNhanPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbKhach;
        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.Button btnThemKhach;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtQT;
        private System.Windows.Forms.Label lblQT;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label lblTenKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.GroupBox gbDatPhong;
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.Label lblSoPhieu;
        private System.Windows.Forms.ComboBox cboKhach;
        private System.Windows.Forms.Label lblKhach;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.DateTimePicker dtLap;
        private System.Windows.Forms.Label lblLap;
        private System.Windows.Forms.DateTimePicker dtNhan;
        private System.Windows.Forms.Label lblNhan;
        private System.Windows.Forms.DateTimePicker dtTra;
        private System.Windows.Forms.Label lblTra;
        private System.Windows.Forms.ComboBox cboKenh;
        private System.Windows.Forms.Label lblKenh;
        private System.Windows.Forms.NumericUpDown numCoc;
        private System.Windows.Forms.Label lblCoc;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridView dgvChon;
        private System.Windows.Forms.NumericUpDown numSoNguoi;
        private System.Windows.Forms.Label lblSoNguoi;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnBoPhong;
        private System.Windows.Forms.Button btnLapPhieu;
        private System.Windows.Forms.GroupBox gbNhanPhong;
        private System.Windows.Forms.DataGridView dgvPhieu;
        private System.Windows.Forms.DataGridView dgvCT;
        private System.Windows.Forms.DataGridView dgvNguoi;
        private System.Windows.Forms.TextBox txtPhieuChon;
        private System.Windows.Forms.Label lblPhieuChon;
        private System.Windows.Forms.TextBox txtNguoiPhong;
        private System.Windows.Forms.Label lblNguoiPhong;
        private System.Windows.Forms.TextBox txtNguoiTen;
        private System.Windows.Forms.Label lblNguoiTen;
        private System.Windows.Forms.TextBox txtNguoiCMND;
        private System.Windows.Forms.Label lblNguoiCMND;
        private System.Windows.Forms.TextBox txtNguoiQT;
        private System.Windows.Forms.Label lblNguoiQT;
        private System.Windows.Forms.Button btnThemNguoi;
        private System.Windows.Forms.Button btnNhanPhong;
        private System.Windows.Forms.Button btnNoShow;
        private System.Windows.Forms.Button btnDong;
    }
}