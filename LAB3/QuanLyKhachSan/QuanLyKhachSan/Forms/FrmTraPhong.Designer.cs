namespace QuanLyKhachSan.Forms
{
    partial class FrmTraPhong
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
            this.lblDat = new System.Windows.Forms.Label();
            this.cboDat = new System.Windows.Forms.ComboBox();
            this.gbDenBu = new System.Windows.Forms.GroupBox();
            this.btnLapDB = new System.Windows.Forms.Button();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblNV = new System.Windows.Forms.Label();
            this.dgvDBChon = new System.Windows.Forms.DataGridView();
            this.btnThemDB = new System.Windows.Forms.Button();
            this.numDenBu = new System.Windows.Forms.NumericUpDown();
            this.lblDenBu = new System.Windows.Forms.Label();
            this.txtMucDo = new System.Windows.Forms.TextBox();
            this.lblMucDo = new System.Windows.Forms.Label();
            this.txtSoDB = new System.Windows.Forms.TextBox();
            this.lblSoDB = new System.Windows.Forms.Label();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.gbHoaDon = new System.Windows.Forms.GroupBox();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.numTienTT = new System.Windows.Forms.NumericUpDown();
            this.lblTienTT = new System.Windows.Forms.Label();
            this.cboHT = new System.Windows.Forms.ComboBox();
            this.lblHT = new System.Windows.Forms.Label();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.lblMaTT = new System.Windows.Forms.Label();
            this.txtHDChon = new System.Windows.Forms.TextBox();
            this.lblHDChon = new System.Windows.Forms.Label();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.cboNV2 = new System.Windows.Forms.ComboBox();
            this.lblNV2 = new System.Windows.Forms.Label();
            this.numSoNgay = new System.Windows.Forms.NumericUpDown();
            this.lblSoNgay = new System.Windows.Forms.Label();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.lblSoHD = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.gbDenBu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.gbHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDat
            // 
            this.lblDat.AutoSize = true;
            this.lblDat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblDat.Location = new System.Drawing.Point(14, 15);
            this.lblDat.Name = "lblDat";
            this.lblDat.Size = new System.Drawing.Size(146, 21);
            this.lblDat.TabIndex = 0;
            this.lblDat.Text = "Chọn lượt lưu trú:";
            // 
            // cboDat
            // 
            this.cboDat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDat.FormattingEnabled = true;
            this.cboDat.Location = new System.Drawing.Point(193, 7);
            this.cboDat.Name = "cboDat";
            this.cboDat.Size = new System.Drawing.Size(220, 28);
            this.cboDat.TabIndex = 1;
            // 
            // gbDenBu
            // 
            this.gbDenBu.Controls.Add(this.btnLapDB);
            this.gbDenBu.Controls.Add(this.cboNV);
            this.gbDenBu.Controls.Add(this.lblNV);
            this.gbDenBu.Controls.Add(this.dgvDBChon);
            this.gbDenBu.Controls.Add(this.btnThemDB);
            this.gbDenBu.Controls.Add(this.numDenBu);
            this.gbDenBu.Controls.Add(this.lblDenBu);
            this.gbDenBu.Controls.Add(this.txtMucDo);
            this.gbDenBu.Controls.Add(this.lblMucDo);
            this.gbDenBu.Controls.Add(this.txtSoDB);
            this.gbDenBu.Controls.Add(this.lblSoDB);
            this.gbDenBu.Controls.Add(this.dgvTN);
            this.gbDenBu.Controls.Add(this.txtPhong);
            this.gbDenBu.Controls.Add(this.lblPhong);
            this.gbDenBu.Controls.Add(this.dgvPhong);
            this.gbDenBu.Location = new System.Drawing.Point(12, 45);
            this.gbDenBu.Name = "gbDenBu";
            this.gbDenBu.Size = new System.Drawing.Size(985, 275);
            this.gbDenBu.TabIndex = 2;
            this.gbDenBu.TabStop = false;
            this.gbDenBu.Text = "1. Kiểm tra tiện nghi phòng & Phiếu đền bù (nếu có hư hỏng/mất)";
            // 
            // btnLapDB
            // 
            this.btnLapDB.Location = new System.Drawing.Point(845, 233);
            this.btnLapDB.Name = "btnLapDB";
            this.btnLapDB.Size = new System.Drawing.Size(125, 30);
            this.btnLapDB.TabIndex = 14;
            this.btnLapDB.Text = "Lập phiếu đền bù";
            this.btnLapDB.UseVisualStyleBackColor = true;
            this.btnLapDB.Click += new System.EventHandler(this.btnLapDB_Click);
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(695, 237);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(135, 28);
            this.cboNV.TabIndex = 13;
            // 
            // lblNV
            // 
            this.lblNV.AutoSize = true;
            this.lblNV.Location = new System.Drawing.Point(632, 240);
            this.lblNV.Name = "lblNV";
            this.lblNV.Size = new System.Drawing.Size(57, 20);
            this.lblNV.TabIndex = 12;
            this.lblNV.Text = "NV lập:";
            // 
            // dgvDBChon
            // 
            this.dgvDBChon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDBChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDBChon.Location = new System.Drawing.Point(545, 55);
            this.dgvDBChon.Name = "dgvDBChon";
            this.dgvDBChon.RowHeadersWidth = 51;
            this.dgvDBChon.Size = new System.Drawing.Size(425, 170);
            this.dgvDBChon.TabIndex = 11;
            // 
            // btnThemDB
            // 
            this.btnThemDB.Location = new System.Drawing.Point(885, 20);
            this.btnThemDB.Name = "btnThemDB";
            this.btnThemDB.Size = new System.Drawing.Size(85, 28);
            this.btnThemDB.TabIndex = 10;
            this.btnThemDB.Text = "Thêm lỗi";
            this.btnThemDB.UseVisualStyleBackColor = true;
            this.btnThemDB.Click += new System.EventHandler(this.btnThemDB_Click);
            // 
            // numDenBu
            // 
            this.numDenBu.DecimalPlaces = 2;
            this.numDenBu.Location = new System.Drawing.Point(774, 23);
            this.numDenBu.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numDenBu.Name = "numDenBu";
            this.numDenBu.Size = new System.Drawing.Size(105, 27);
            this.numDenBu.TabIndex = 9;
            // 
            // lblDenBu
            // 
            this.lblDenBu.AutoSize = true;
            this.lblDenBu.Location = new System.Drawing.Point(718, 27);
            this.lblDenBu.Name = "lblDenBu";
            this.lblDenBu.Size = new System.Drawing.Size(58, 20);
            this.lblDenBu.TabIndex = 8;
            this.lblDenBu.Text = "Số tiền:";
            // 
            // txtMucDo
            // 
            this.txtMucDo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMucDo.Location = new System.Drawing.Point(614, 23);
            this.txtMucDo.Name = "txtMucDo";
            this.txtMucDo.Size = new System.Drawing.Size(105, 27);
            this.txtMucDo.TabIndex = 7;
            this.txtMucDo.Text = "Hư hỏng nhẹ";
            // 
            // lblMucDo
            // 
            this.lblMucDo.AutoSize = true;
            this.lblMucDo.Location = new System.Drawing.Point(545, 27);
            this.lblMucDo.Name = "lblMucDo";
            this.lblMucDo.Size = new System.Drawing.Size(63, 20);
            this.lblMucDo.TabIndex = 6;
            this.lblMucDo.Text = "Mức độ:";
            // 
            // txtSoDB
            // 
            this.txtSoDB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoDB.Location = new System.Drawing.Point(445, 21);
            this.txtSoDB.Name = "txtSoDB";
            this.txtSoDB.Size = new System.Drawing.Size(95, 27);
            this.txtSoDB.TabIndex = 5;
            // 
            // lblSoDB
            // 
            this.lblSoDB.AutoSize = true;
            this.lblSoDB.Location = new System.Drawing.Point(385, 27);
            this.lblSoDB.Name = "lblSoDB";
            this.lblSoDB.Size = new System.Drawing.Size(53, 20);
            this.lblSoDB.TabIndex = 4;
            this.lblSoDB.Text = "Số ĐB:";
            // 
            // dgvTN
            // 
            this.dgvTN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTN.Location = new System.Drawing.Point(215, 55);
            this.dgvTN.Name = "dgvTN";
            this.dgvTN.RowHeadersWidth = 51;
            this.dgvTN.Size = new System.Drawing.Size(315, 210);
            this.dgvTN.TabIndex = 3;
            // 
            // txtPhong
            // 
            this.txtPhong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhong.Location = new System.Drawing.Point(270, 23);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.ReadOnly = true;
            this.txtPhong.Size = new System.Drawing.Size(95, 27);
            this.txtPhong.TabIndex = 2;
            // 
            // lblPhong
            // 
            this.lblPhong.AutoSize = true;
            this.lblPhong.Location = new System.Drawing.Point(215, 27);
            this.lblPhong.Name = "lblPhong";
            this.lblPhong.Size = new System.Drawing.Size(54, 20);
            this.lblPhong.TabIndex = 1;
            this.lblPhong.Text = "Phòng:";
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(10, 25);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.Size = new System.Drawing.Size(195, 240);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.SelectionChanged += new System.EventHandler(this.dgvPhong_SelectionChanged);
            // 
            // gbHoaDon
            // 
            this.gbHoaDon.Controls.Add(this.btnTraPhong);
            this.gbHoaDon.Controls.Add(this.btnThanhToan);
            this.gbHoaDon.Controls.Add(this.numTienTT);
            this.gbHoaDon.Controls.Add(this.lblTienTT);
            this.gbHoaDon.Controls.Add(this.cboHT);
            this.gbHoaDon.Controls.Add(this.lblHT);
            this.gbHoaDon.Controls.Add(this.txtMaTT);
            this.gbHoaDon.Controls.Add(this.lblMaTT);
            this.gbHoaDon.Controls.Add(this.txtHDChon);
            this.gbHoaDon.Controls.Add(this.lblHDChon);
            this.gbHoaDon.Controls.Add(this.dgvHD);
            this.gbHoaDon.Controls.Add(this.btnLapHD);
            this.gbHoaDon.Controls.Add(this.cboNV2);
            this.gbHoaDon.Controls.Add(this.lblNV2);
            this.gbHoaDon.Controls.Add(this.numSoNgay);
            this.gbHoaDon.Controls.Add(this.lblSoNgay);
            this.gbHoaDon.Controls.Add(this.txtSoHD);
            this.gbHoaDon.Controls.Add(this.lblSoHD);
            this.gbHoaDon.Location = new System.Drawing.Point(12, 330);
            this.gbHoaDon.Name = "gbHoaDon";
            this.gbHoaDon.Size = new System.Drawing.Size(985, 305);
            this.gbHoaDon.TabIndex = 3;
            this.gbHoaDon.TabStop = false;
            this.gbHoaDon.Text = "2. Hóa đơn lưu trú, Thanh toán nhiều phương thức & Hoàn tất trả phòng";
            // 
            // btnTraPhong
            // 
            this.btnTraPhong.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnTraPhong.ForeColor = System.Drawing.Color.Firebrick;
            this.btnTraPhong.Location = new System.Drawing.Point(750, 245);
            this.btnTraPhong.Name = "btnTraPhong";
            this.btnTraPhong.Size = new System.Drawing.Size(220, 48);
            this.btnTraPhong.TabIndex = 17;
            this.btnTraPhong.Text = "HOÀN TẤT TRẢ PHÒNG";
            this.btnTraPhong.UseVisualStyleBackColor = true;
            this.btnTraPhong.Click += new System.EventHandler(this.btnTraPhong_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnThanhToan.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnThanhToan.Location = new System.Drawing.Point(750, 205);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(220, 32);
            this.btnThanhToan.TabIndex = 16;
            this.btnThanhToan.Text = "Ghi nhận thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // numTienTT
            // 
            this.numTienTT.DecimalPlaces = 2;
            this.numTienTT.Location = new System.Drawing.Point(825, 168);
            this.numTienTT.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numTienTT.Name = "numTienTT";
            this.numTienTT.Size = new System.Drawing.Size(145, 27);
            this.numTienTT.TabIndex = 15;
            // 
            // lblTienTT
            // 
            this.lblTienTT.AutoSize = true;
            this.lblTienTT.Location = new System.Drawing.Point(750, 172);
            this.lblTienTT.Name = "lblTienTT";
            this.lblTienTT.Size = new System.Drawing.Size(58, 20);
            this.lblTienTT.TabIndex = 14;
            this.lblTienTT.Text = "Số tiền:";
            // 
            // cboHT
            // 
            this.cboHT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHT.FormattingEnabled = true;
            this.cboHT.Location = new System.Drawing.Point(825, 130);
            this.cboHT.Name = "cboHT";
            this.cboHT.Size = new System.Drawing.Size(145, 28);
            this.cboHT.TabIndex = 13;
            // 
            // lblHT
            // 
            this.lblHT.AutoSize = true;
            this.lblHT.Location = new System.Drawing.Point(750, 134);
            this.lblHT.Name = "lblHT";
            this.lblHT.Size = new System.Drawing.Size(76, 20);
            this.lblHT.TabIndex = 12;
            this.lblHT.Text = "Hình thức:";
            // 
            // txtMaTT
            // 
            this.txtMaTT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaTT.Location = new System.Drawing.Point(825, 92);
            this.txtMaTT.Name = "txtMaTT";
            this.txtMaTT.Size = new System.Drawing.Size(145, 27);
            this.txtMaTT.TabIndex = 11;
            // 
            // lblMaTT
            // 
            this.lblMaTT.AutoSize = true;
            this.lblMaTT.Location = new System.Drawing.Point(750, 96);
            this.lblMaTT.Name = "lblMaTT";
            this.lblMaTT.Size = new System.Drawing.Size(53, 20);
            this.lblMaTT.TabIndex = 10;
            this.lblMaTT.Text = "Mã TT:";
            // 
            // txtHDChon
            // 
            this.txtHDChon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHDChon.Location = new System.Drawing.Point(840, 56);
            this.txtHDChon.Name = "txtHDChon";
            this.txtHDChon.ReadOnly = true;
            this.txtHDChon.Size = new System.Drawing.Size(130, 27);
            this.txtHDChon.TabIndex = 9;
            // 
            // lblHDChon
            // 
            this.lblHDChon.AutoSize = true;
            this.lblHDChon.Location = new System.Drawing.Point(750, 59);
            this.lblHDChon.Name = "lblHDChon";
            this.lblHDChon.Size = new System.Drawing.Size(91, 20);
            this.lblHDChon.TabIndex = 8;
            this.lblHDChon.Text = "Số HĐ chọn:";
            // 
            // dgvHD
            // 
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Location = new System.Drawing.Point(10, 58);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.RowHeadersWidth = 51;
            this.dgvHD.Size = new System.Drawing.Size(725, 235);
            this.dgvHD.TabIndex = 7;
            this.dgvHD.SelectionChanged += new System.EventHandler(this.dgvHD_SelectionChanged);
            // 
            // btnLapHD
            // 
            this.btnLapHD.Location = new System.Drawing.Point(625, 22);
            this.btnLapHD.Name = "btnLapHD";
            this.btnLapHD.Size = new System.Drawing.Size(110, 28);
            this.btnLapHD.TabIndex = 6;
            this.btnLapHD.Text = "Lập hóa đơn";
            this.btnLapHD.UseVisualStyleBackColor = true;
            this.btnLapHD.Click += new System.EventHandler(this.btnLapHD_Click);
            // 
            // cboNV2
            // 
            this.cboNV2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV2.FormattingEnabled = true;
            this.cboNV2.Location = new System.Drawing.Point(471, 24);
            this.cboNV2.Name = "cboNV2";
            this.cboNV2.Size = new System.Drawing.Size(135, 28);
            this.cboNV2.TabIndex = 5;
            // 
            // lblNV2
            // 
            this.lblNV2.AutoSize = true;
            this.lblNV2.Location = new System.Drawing.Point(355, 28);
            this.lblNV2.Name = "lblNV2";
            this.lblNV2.Size = new System.Drawing.Size(110, 20);
            this.lblNV2.TabIndex = 4;
            this.lblNV2.Text = "NV Thanh toán:";
            // 
            // numSoNgay
            // 
            this.numSoNgay.Location = new System.Drawing.Point(286, 24);
            this.numSoNgay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoNgay.Name = "numSoNgay";
            this.numSoNgay.Size = new System.Drawing.Size(60, 27);
            this.numSoNgay.TabIndex = 3;
            this.numSoNgay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSoNgay
            // 
            this.lblSoNgay.AutoSize = true;
            this.lblSoNgay.Location = new System.Drawing.Point(215, 28);
            this.lblSoNgay.Name = "lblSoNgay";
            this.lblSoNgay.Size = new System.Drawing.Size(65, 20);
            this.lblSoNgay.TabIndex = 2;
            this.lblSoNgay.Text = "Số ngày:";
            // 
            // txtSoHD
            // 
            this.txtSoHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoHD.Location = new System.Drawing.Point(65, 24);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(130, 27);
            this.txtSoHD.TabIndex = 1;
            // 
            // lblSoHD
            // 
            this.lblSoHD.AutoSize = true;
            this.lblSoHD.Location = new System.Drawing.Point(10, 28);
            this.lblSoHD.Name = "lblSoHD";
            this.lblSoHD.Size = new System.Drawing.Size(55, 20);
            this.lblSoHD.TabIndex = 0;
            this.lblSoHD.Text = "Số HĐ:";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(895, 645);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(100, 32);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmTraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 686);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.gbHoaDon);
            this.Controls.Add(this.gbDenBu);
            this.Controls.Add(this.cboDat);
            this.Controls.Add(this.lblDat);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmTraPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Trả phòng & Thanh toán";
            this.Load += new System.EventHandler(this.FrmTraPhong_Load);
            this.gbDenBu.ResumeLayout(false);
            this.gbDenBu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.gbHoaDon.ResumeLayout(false);
            this.gbHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDat;
        private System.Windows.Forms.ComboBox cboDat;
        private System.Windows.Forms.GroupBox gbDenBu;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label lblPhong;
        private System.Windows.Forms.DataGridView dgvTN;
        private System.Windows.Forms.TextBox txtSoDB;
        private System.Windows.Forms.Label lblSoDB;
        private System.Windows.Forms.TextBox txtMucDo;
        private System.Windows.Forms.Label lblMucDo;
        private System.Windows.Forms.NumericUpDown numDenBu;
        private System.Windows.Forms.Label lblDenBu;
        private System.Windows.Forms.Button btnThemDB;
        private System.Windows.Forms.DataGridView dgvDBChon;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Label lblNV;
        private System.Windows.Forms.Button btnLapDB;
        private System.Windows.Forms.GroupBox gbHoaDon;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label lblSoHD;
        private System.Windows.Forms.NumericUpDown numSoNgay;
        private System.Windows.Forms.Label lblSoNgay;
        private System.Windows.Forms.ComboBox cboNV2;
        private System.Windows.Forms.Label lblNV2;
        private System.Windows.Forms.Button btnLapHD;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.TextBox txtHDChon;
        private System.Windows.Forms.Label lblHDChon;
        private System.Windows.Forms.TextBox txtMaTT;
        private System.Windows.Forms.Label lblMaTT;
        private System.Windows.Forms.ComboBox cboHT;
        private System.Windows.Forms.Label lblHT;
        private System.Windows.Forms.NumericUpDown numTienTT;
        private System.Windows.Forms.Label lblTienTT;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTraPhong;
        private System.Windows.Forms.Button btnDong;
    }
}