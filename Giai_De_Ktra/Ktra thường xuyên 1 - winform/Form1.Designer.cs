
namespace DaoThiHongPhuong212
{
    partial class Form1
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
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoDoanhNghiep = new System.Windows.Forms.RadioButton();
            this.rdoHoGiaDinh = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtChiSoDau = new System.Windows.Forms.TextBox();
            this.txtChiSoCuoi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.dtpNgayNopTien = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListView();
            this.clmMaKH = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDoiTuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmChiSoDau = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmChiSoCuoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSoTienNop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNgayNop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(283, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ TIỀN ĐIỆN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(347, 99);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(464, 30);
            this.txtMaKH.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(347, 142);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(464, 30);
            this.txtHoTen.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoDoanhNghiep);
            this.groupBox1.Controls.Add(this.rdoHoGiaDinh);
            this.groupBox1.Location = new System.Drawing.Point(59, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(752, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đối tượng";
            // 
            // rdoDoanhNghiep
            // 
            this.rdoDoanhNghiep.AutoSize = true;
            this.rdoDoanhNghiep.Location = new System.Drawing.Point(486, 42);
            this.rdoDoanhNghiep.Name = "rdoDoanhNghiep";
            this.rdoDoanhNghiep.Size = new System.Drawing.Size(139, 26);
            this.rdoDoanhNghiep.TabIndex = 0;
            this.rdoDoanhNghiep.Text = "Doanh nghiệp";
            this.rdoDoanhNghiep.UseVisualStyleBackColor = true;
            // 
            // rdoHoGiaDinh
            // 
            this.rdoHoGiaDinh.AutoSize = true;
            this.rdoHoGiaDinh.Checked = true;
            this.rdoHoGiaDinh.Location = new System.Drawing.Point(75, 42);
            this.rdoHoGiaDinh.Name = "rdoHoGiaDinh";
            this.rdoHoGiaDinh.Size = new System.Drawing.Size(123, 26);
            this.rdoHoGiaDinh.TabIndex = 0;
            this.rdoHoGiaDinh.TabStop = true;
            this.rdoHoGiaDinh.Text = "Hộ gia đình";
            this.rdoHoGiaDinh.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chỉ số đầu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chỉ số cuối";
            // 
            // txtChiSoDau
            // 
            this.txtChiSoDau.Location = new System.Drawing.Point(347, 321);
            this.txtChiSoDau.Name = "txtChiSoDau";
            this.txtChiSoDau.Size = new System.Drawing.Size(464, 30);
            this.txtChiSoDau.TabIndex = 2;
            // 
            // txtChiSoCuoi
            // 
            this.txtChiSoCuoi.Location = new System.Drawing.Point(347, 370);
            this.txtChiSoCuoi.Name = "txtChiSoCuoi";
            this.txtChiSoCuoi.Size = new System.Drawing.Size(464, 30);
            this.txtChiSoCuoi.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Số tiền phải nộp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày nộp tiền";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Location = new System.Drawing.Point(347, 418);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.ReadOnly = true;
            this.txtSoTien.Size = new System.Drawing.Size(464, 30);
            this.txtSoTien.TabIndex = 2;
            // 
            // dtpNgayNopTien
            // 
            this.dtpNgayNopTien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayNopTien.Location = new System.Drawing.Point(347, 469);
            this.dtpNgayNopTien.Name = "dtpNgayNopTien";
            this.dtpNgayNopTien.Size = new System.Drawing.Size(464, 30);
            this.dtpNgayNopTien.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(394, 529);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "button1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(618, 529);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(123, 50);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(183, 529);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(123, 50);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(394, 529);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(123, 50);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lstResult
            // 
            this.lstResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmMaKH,
            this.clmHoTen,
            this.clmDoiTuong,
            this.clmChiSoDau,
            this.clmChiSoCuoi,
            this.clmSoTienNop,
            this.clmNgayNop});
            this.lstResult.HideSelection = false;
            this.lstResult.Location = new System.Drawing.Point(0, 594);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(904, 156);
            this.lstResult.TabIndex = 6;
            this.lstResult.UseCompatibleStateImageBehavior = false;
            this.lstResult.View = System.Windows.Forms.View.Details;
            // 
            // clmMaKH
            // 
            this.clmMaKH.Text = "Mã khách hàng";
            this.clmMaKH.Width = 145;
            // 
            // clmHoTen
            // 
            this.clmHoTen.Text = "Họ tên khách hàng";
            this.clmHoTen.Width = 170;
            // 
            // clmDoiTuong
            // 
            this.clmDoiTuong.Text = "Đối tượng";
            this.clmDoiTuong.Width = 109;
            // 
            // clmChiSoDau
            // 
            this.clmChiSoDau.Text = "Chỉ số đầu";
            this.clmChiSoDau.Width = 115;
            // 
            // clmChiSoCuoi
            // 
            this.clmChiSoCuoi.Text = "Chỉ số cuối";
            this.clmChiSoCuoi.Width = 118;
            // 
            // clmSoTienNop
            // 
            this.clmSoTienNop.Text = "Số tiền phải nộp";
            this.clmSoTienNop.Width = 152;
            // 
            // clmNgayNop
            // 
            this.clmNgayNop.Text = "Ngày nộp";
            this.clmNgayNop.Width = 91;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 748);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpNgayNopTien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtChiSoCuoi);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.txtChiSoDau);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Quản lý tiền điện";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoDoanhNghiep;
        private System.Windows.Forms.RadioButton rdoHoGiaDinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtChiSoDau;
        private System.Windows.Forms.TextBox txtChiSoCuoi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.DateTimePicker dtpNgayNopTien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ListView lstResult;
        private System.Windows.Forms.ColumnHeader clmMaKH;
        private System.Windows.Forms.ColumnHeader clmHoTen;
        private System.Windows.Forms.ColumnHeader clmDoiTuong;
        private System.Windows.Forms.ColumnHeader clmChiSoDau;
        private System.Windows.Forms.ColumnHeader clmChiSoCuoi;
        private System.Windows.Forms.ColumnHeader clmSoTienNop;
        private System.Windows.Forms.ColumnHeader clmNgayNop;
    }
}

