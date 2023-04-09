
namespace QuanLyNhanSu
{
    partial class quanlynhansu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btds = new System.Windows.Forms.Button();
            this.cbkhenthuong = new System.Windows.Forms.ComboBox();
            this.cbkyluat = new System.Windows.Forms.ComboBox();
            this.SLBKyLuat = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btma = new System.Windows.Forms.Button();
            this.btten = new System.Windows.Forms.Button();
            this.txttk = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btResset = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.cbphongban = new System.Windows.Forms.ComboBox();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.dtns = new System.Windows.Forms.DateTimePicker();
            this.cbgt = new System.Windows.Forms.ComboBox();
            this.txtht = new System.Windows.Forms.TextBox();
            this.txtmans = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridnhansu = new System.Windows.Forms.DataGridView();
            this.MaNS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLDKhenThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridnhansu)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btds);
            this.panel1.Controls.Add(this.cbkhenthuong);
            this.panel1.Controls.Add(this.cbkyluat);
            this.panel1.Controls.Add(this.SLBKyLuat);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btma);
            this.panel1.Controls.Add(this.btten);
            this.panel1.Controls.Add(this.txttk);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btResset);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtchucvu);
            this.panel1.Controls.Add(this.txtdiachi);
            this.panel1.Controls.Add(this.cbphongban);
            this.panel1.Controls.Add(this.txtluong);
            this.panel1.Controls.Add(this.dtns);
            this.panel1.Controls.Add(this.cbgt);
            this.panel1.Controls.Add(this.txtht);
            this.panel1.Controls.Add(this.txtmans);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 335);
            this.panel1.TabIndex = 0;
            // 
            // btds
            // 
            this.btds.Location = new System.Drawing.Point(653, 298);
            this.btds.Name = "btds";
            this.btds.Size = new System.Drawing.Size(181, 23);
            this.btds.TabIndex = 32;
            this.btds.Text = "Ds Nhân Sự có thành tích tốt";
            this.btds.UseVisualStyleBackColor = true;
            this.btds.Click += new System.EventHandler(this.btds_Click);
            // 
            // cbkhenthuong
            // 
            this.cbkhenthuong.FormattingEnabled = true;
            this.cbkhenthuong.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbkhenthuong.Location = new System.Drawing.Point(265, 194);
            this.cbkhenthuong.Name = "cbkhenthuong";
            this.cbkhenthuong.Size = new System.Drawing.Size(41, 23);
            this.cbkhenthuong.TabIndex = 31;
            // 
            // cbkyluat
            // 
            this.cbkyluat.FormattingEnabled = true;
            this.cbkyluat.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbkyluat.Location = new System.Drawing.Point(501, 197);
            this.cbkyluat.Name = "cbkyluat";
            this.cbkyluat.Size = new System.Drawing.Size(43, 23);
            this.cbkyluat.TabIndex = 30;
            // 
            // SLBKyLuat
            // 
            this.SLBKyLuat.AutoSize = true;
            this.SLBKyLuat.Location = new System.Drawing.Point(434, 197);
            this.SLBKyLuat.Name = "SLBKyLuat";
            this.SLBKyLuat.Size = new System.Drawing.Size(61, 15);
            this.SLBKyLuat.TabIndex = 29;
            this.SLBKyLuat.Text = "SLBKyLuat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(164, 197);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "SLDKhenThuong";
            // 
            // btma
            // 
            this.btma.Location = new System.Drawing.Point(467, 299);
            this.btma.Name = "btma";
            this.btma.Size = new System.Drawing.Size(126, 23);
            this.btma.TabIndex = 26;
            this.btma.Text = "Tìm Kiếm Theo Mã";
            this.btma.UseVisualStyleBackColor = true;
            this.btma.Click += new System.EventHandler(this.btma_Click);
            // 
            // btten
            // 
            this.btten.Location = new System.Drawing.Point(294, 299);
            this.btten.Name = "btten";
            this.btten.Size = new System.Drawing.Size(117, 23);
            this.btten.TabIndex = 25;
            this.btten.Text = "Tìm Kiếm Theo Tên ";
            this.btten.UseVisualStyleBackColor = true;
            this.btten.Click += new System.EventHandler(this.btten_Click);
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(113, 299);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(152, 23);
            this.txttk.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(36, 299);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 15);
            this.label11.TabIndex = 23;
            this.label11.Text = "Tìm Kiếm";
            // 
            // btResset
            // 
            this.btResset.Location = new System.Drawing.Point(576, 242);
            this.btResset.Name = "btResset";
            this.btResset.Size = new System.Drawing.Size(75, 23);
            this.btResset.TabIndex = 22;
            this.btResset.Text = "Reset";
            this.btResset.UseVisualStyleBackColor = true;
            this.btResset.Click += new System.EventHandler(this.btResset_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(420, 242);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 23);
            this.btXoa.TabIndex = 21;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(278, 242);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 23);
            this.btSua.TabIndex = 20;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(136, 242);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 19;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(576, 141);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(100, 23);
            this.txtemail.TabIndex = 18;
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(576, 98);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(100, 23);
            this.txtchucvu.TabIndex = 17;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(576, 56);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(100, 23);
            this.txtdiachi.TabIndex = 16;
            // 
            // cbphongban
            // 
            this.cbphongban.FormattingEnabled = true;
            this.cbphongban.Items.AddRange(new object[] {
            "Công nghệ thông tin ",
            "Kế toán ",
            "Hành chính"});
            this.cbphongban.Location = new System.Drawing.Point(373, 141);
            this.cbphongban.Name = "cbphongban";
            this.cbphongban.Size = new System.Drawing.Size(101, 23);
            this.cbphongban.TabIndex = 15;
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(373, 98);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(100, 23);
            this.txtluong.TabIndex = 14;
            this.txtluong.TextChanged += new System.EventHandler(this.txtluong_TextChanged);
            // 
            // dtns
            // 
            this.dtns.CustomFormat = "yyyy/MM/dd";
            this.dtns.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtns.Location = new System.Drawing.Point(373, 53);
            this.dtns.Name = "dtns";
            this.dtns.Size = new System.Drawing.Size(101, 23);
            this.dtns.TabIndex = 13;
            // 
            // cbgt
            // 
            this.cbgt.FormattingEnabled = true;
            this.cbgt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbgt.Location = new System.Drawing.Point(113, 142);
            this.cbgt.Name = "cbgt";
            this.cbgt.Size = new System.Drawing.Size(110, 23);
            this.cbgt.TabIndex = 12;
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(113, 98);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(110, 23);
            this.txtht.TabIndex = 11;
            // 
            // txtmans
            // 
            this.txtmans.Location = new System.Drawing.Point(113, 53);
            this.txtmans.Name = "txtmans";
            this.txtmans.Size = new System.Drawing.Size(110, 23);
            this.txtmans.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(527, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(518, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "Chức Vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(525, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Địa Chỉ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Phòng Ban";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Lương";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "GioiTinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "HoTen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã NS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(278, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Nhân Sự";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridnhansu);
            this.panel2.Location = new System.Drawing.Point(5, 353);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 314);
            this.panel2.TabIndex = 1;
            // 
            // dataGridnhansu
            // 
            this.dataGridnhansu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridnhansu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNS,
            this.HoTen,
            this.GioiTinh,
            this.NgaySinh,
            this.Luong,
            this.PhongBan,
            this.DiaChi,
            this.ChucVu,
            this.Email,
            this.SLDKhenThuong,
            this.extBoxColumn1});
            this.dataGridnhansu.Location = new System.Drawing.Point(0, 7);
            this.dataGridnhansu.Name = "dataGridnhansu";
            this.dataGridnhansu.RowTemplate.Height = 25;
            this.dataGridnhansu.Size = new System.Drawing.Size(945, 307);
            this.dataGridnhansu.TabIndex = 0;
            this.dataGridnhansu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridnhansu_CellContentClick);
            // 
            // MaNS
            // 
            this.MaNS.DataPropertyName = "MaNS";
            this.MaNS.HeaderText = "Mã NS";
            this.MaNS.Name = "MaNS";
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới Tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // Luong
            // 
            this.Luong.DataPropertyName = "Luong";
            this.Luong.HeaderText = "Lương";
            this.Luong.Name = "Luong";
            // 
            // PhongBan
            // 
            this.PhongBan.DataPropertyName = "PhongBan";
            this.PhongBan.HeaderText = "Phòng Ban";
            this.PhongBan.Name = "PhongBan";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức Vụ";
            this.ChucVu.Name = "ChucVu";
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // SLDKhenThuong
            // 
            this.SLDKhenThuong.DataPropertyName = "SLDKhenThuong";
            this.SLDKhenThuong.HeaderText = "Khen Thưởng";
            this.SLDKhenThuong.Name = "SLDKhenThuong";
            // 
            // extBoxColumn1
            // 
            this.extBoxColumn1.DataPropertyName = "SLBKyLuat";
            this.extBoxColumn1.HeaderText = "Kỷ Luật";
            this.extBoxColumn1.Name = "extBoxColumn1";
            // 
            // quanlynhansu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 672);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "quanlynhansu";
            this.Text = "Quản Lý Nhân Sự";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.quanlynhansu_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.quanlynhansu_FormClosed);
            this.Load += new System.EventHandler(this.quanlynhansu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridnhansu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btResset;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.ComboBox cbphongban;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.DateTimePicker dtns;
        private System.Windows.Forms.ComboBox cbgt;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.TextBox txtmans;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridnhansu;
        private System.Windows.Forms.Button btma;
        private System.Windows.Forms.Button btten;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbkhenthuong;
        private System.Windows.Forms.ComboBox cbkyluat;
        private System.Windows.Forms.Label SLBKyLuat;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btds;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLDKhenThuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn extBoxColumn1;
    }
}

