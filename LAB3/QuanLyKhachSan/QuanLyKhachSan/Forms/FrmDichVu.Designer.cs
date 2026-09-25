namespace QuanLyKhachSan.Forms
{
    partial class FrmDichVu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvKhu = new System.Windows.Forms.DataGridView();
            this.ColSoPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboLuot = new System.Windows.Forms.ComboBox();
            this.cboDV = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu lưu trú:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày sử dụng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phòng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(648, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dịch vụ:";
            // 
            // dgvKhu
            // 
            this.dgvKhu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhu.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvKhu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSoPhieu,
            this.ColPhong,
            this.ColNgay,
            this.ColDichVu,
            this.ColSoLuong,
            this.ColDonGia,
            this.ColThanhTien});
            this.dgvKhu.GridColor = System.Drawing.SystemColors.WindowText;
            this.dgvKhu.Location = new System.Drawing.Point(15, 187);
            this.dgvKhu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKhu.MultiSelect = false;
            this.dgvKhu.Name = "dgvKhu";
            this.dgvKhu.ReadOnly = true;
            this.dgvKhu.RowHeadersVisible = false;
            this.dgvKhu.RowHeadersWidth = 51;
            this.dgvKhu.RowTemplate.Height = 24;
            this.dgvKhu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKhu.Size = new System.Drawing.Size(970, 415);
            this.dgvKhu.TabIndex = 6;
            // 
            // ColSoPhieu
            // 
            this.ColSoPhieu.HeaderText = "Số phiếu";
            this.ColSoPhieu.MinimumWidth = 6;
            this.ColSoPhieu.Name = "ColSoPhieu";
            this.ColSoPhieu.ReadOnly = true;
            // 
            // ColPhong
            // 
            this.ColPhong.HeaderText = "Phòng";
            this.ColPhong.MinimumWidth = 6;
            this.ColPhong.Name = "ColPhong";
            this.ColPhong.ReadOnly = true;
            // 
            // ColNgay
            // 
            this.ColNgay.HeaderText = "Ngày";
            this.ColNgay.MinimumWidth = 6;
            this.ColNgay.Name = "ColNgay";
            this.ColNgay.ReadOnly = true;
            // 
            // ColDichVu
            // 
            this.ColDichVu.HeaderText = "Dịch vụ";
            this.ColDichVu.MinimumWidth = 6;
            this.ColDichVu.Name = "ColDichVu";
            this.ColDichVu.ReadOnly = true;
            // 
            // ColSoLuong
            // 
            this.ColSoLuong.HeaderText = "Số lượng";
            this.ColSoLuong.MinimumWidth = 6;
            this.ColSoLuong.Name = "ColSoLuong";
            this.ColSoLuong.ReadOnly = true;
            // 
            // ColDonGia
            // 
            this.ColDonGia.HeaderText = "Đơn giá";
            this.ColDonGia.MinimumWidth = 6;
            this.ColDonGia.Name = "ColDonGia";
            this.ColDonGia.ReadOnly = true;
            // 
            // ColThanhTien
            // 
            this.ColThanhTien.HeaderText = "Thành tiền";
            this.ColThanhTien.MinimumWidth = 6;
            this.ColThanhTien.Name = "ColThanhTien";
            this.ColThanhTien.ReadOnly = true;
            // 
            // cboLuot
            // 
            this.cboLuot.FormattingEnabled = true;
            this.cboLuot.Location = new System.Drawing.Point(149, 30);
            this.cboLuot.Name = "cboLuot";
            this.cboLuot.Size = new System.Drawing.Size(121, 30);
            this.cboLuot.TabIndex = 7;
            // 
            // cboDV
            // 
            this.cboDV.FormattingEnabled = true;
            this.cboDV.Location = new System.Drawing.Point(730, 30);
            this.cboDV.Name = "cboDV";
            this.cboDV.Size = new System.Drawing.Size(121, 30);
            this.cboDV.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(479, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(478, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 28);
            this.textBox2.TabIndex = 10;
            // 
            // FrmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cboDV);
            this.Controls.Add(this.cboLuot);
            this.Controls.Add(this.dgvKhu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDichVu";
            this.Text = "Sử dụng dịch vụ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvKhu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThanhTien;
        private System.Windows.Forms.ComboBox cboLuot;
        private System.Windows.Forms.ComboBox cboDV;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}