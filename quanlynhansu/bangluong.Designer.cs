﻿
namespace quanlynhansu
{
    partial class bangluong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bangluong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btthoat2 = new System.Windows.Forms.Button();
            this.btreset2 = new System.Windows.Forms.Button();
            this.btxoa2 = new System.Windows.Forms.Button();
            this.btsua2 = new System.Windows.Forms.Button();
            this.btthem2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttinh = new System.Windows.Forms.Button();
            this.txtbh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txthsl = new System.Windows.Forms.TextBox();
            this.txtlcb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txtthamnien = new System.Windows.Forms.TextBox();
            this.txtten2 = new System.Windows.Forms.TextBox();
            this.txtmns2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btthoat2);
            this.groupBox1.Controls.Add(this.btreset2);
            this.groupBox1.Controls.Add(this.btxoa2);
            this.groupBox1.Controls.Add(this.btsua2);
            this.groupBox1.Controls.Add(this.btthem2);
            this.groupBox1.Location = new System.Drawing.Point(685, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 266);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // btthoat2
            // 
            this.btthoat2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthoat2.Location = new System.Drawing.Point(174, 153);
            this.btthoat2.Name = "btthoat2";
            this.btthoat2.Size = new System.Drawing.Size(99, 44);
            this.btthoat2.TabIndex = 4;
            this.btthoat2.Text = "Thoát";
            this.btthoat2.UseVisualStyleBackColor = true;
            this.btthoat2.Click += new System.EventHandler(this.btthoat2_Click);
            // 
            // btreset2
            // 
            this.btreset2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btreset2.Location = new System.Drawing.Point(174, 81);
            this.btreset2.Name = "btreset2";
            this.btreset2.Size = new System.Drawing.Size(99, 44);
            this.btreset2.TabIndex = 3;
            this.btreset2.Text = "Reset";
            this.btreset2.UseVisualStyleBackColor = true;
            this.btreset2.Click += new System.EventHandler(this.btreset2_Click);
            // 
            // btxoa2
            // 
            this.btxoa2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa2.Location = new System.Drawing.Point(20, 192);
            this.btxoa2.Name = "btxoa2";
            this.btxoa2.Size = new System.Drawing.Size(107, 46);
            this.btxoa2.TabIndex = 2;
            this.btxoa2.Text = "Xóa";
            this.btxoa2.UseVisualStyleBackColor = true;
            this.btxoa2.Click += new System.EventHandler(this.btxoa2_Click);
            // 
            // btsua2
            // 
            this.btsua2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsua2.Location = new System.Drawing.Point(20, 118);
            this.btsua2.Name = "btsua2";
            this.btsua2.Size = new System.Drawing.Size(107, 42);
            this.btsua2.TabIndex = 1;
            this.btsua2.Text = "Sửa";
            this.btsua2.UseVisualStyleBackColor = true;
            this.btsua2.Click += new System.EventHandler(this.btsua2_Click);
            // 
            // btthem2
            // 
            this.btthem2.BackColor = System.Drawing.SystemColors.Menu;
            this.btthem2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btthem2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btthem2.Location = new System.Drawing.Point(20, 45);
            this.btthem2.Name = "btthem2";
            this.btthem2.Size = new System.Drawing.Size(107, 44);
            this.btthem2.TabIndex = 0;
            this.btthem2.Text = "Thêm";
            this.btthem2.UseVisualStyleBackColor = false;
            this.btthem2.Click += new System.EventHandler(this.btthem2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttinh);
            this.groupBox2.Controls.Add(this.txtbh);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtpc);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txthsl);
            this.groupBox2.Controls.Add(this.txtlcb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtluong);
            this.groupBox2.Controls.Add(this.txtthamnien);
            this.groupBox2.Controls.Add(this.txtten2);
            this.groupBox2.Controls.Add(this.txtmns2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(33, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 266);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // bttinh
            // 
            this.bttinh.BackColor = System.Drawing.SystemColors.Menu;
            this.bttinh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttinh.ForeColor = System.Drawing.SystemColors.MenuText;
            this.bttinh.Location = new System.Drawing.Point(172, 228);
            this.bttinh.Name = "bttinh";
            this.bttinh.Size = new System.Drawing.Size(83, 32);
            this.bttinh.TabIndex = 5;
            this.bttinh.Text = "Tính";
            this.bttinh.UseVisualStyleBackColor = false;
            this.bttinh.Click += new System.EventHandler(this.bttinh_Click);
            // 
            // txtbh
            // 
            this.txtbh.Location = new System.Drawing.Point(455, 192);
            this.txtbh.Name = "txtbh";
            this.txtbh.Size = new System.Drawing.Size(98, 22);
            this.txtbh.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(327, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Bảo hiểm";
            // 
            // txtpc
            // 
            this.txtpc.Location = new System.Drawing.Point(455, 129);
            this.txtpc.Name = "txtpc";
            this.txtpc.Size = new System.Drawing.Size(98, 22);
            this.txtpc.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(327, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phụ cấp";
            // 
            // txthsl
            // 
            this.txthsl.Location = new System.Drawing.Point(455, 81);
            this.txthsl.Name = "txthsl";
            this.txthsl.Size = new System.Drawing.Size(98, 22);
            this.txthsl.TabIndex = 10;
            // 
            // txtlcb
            // 
            this.txtlcb.Location = new System.Drawing.Point(455, 42);
            this.txtlcb.Name = "txtlcb";
            this.txtlcb.Size = new System.Drawing.Size(98, 22);
            this.txtlcb.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 19);
            this.label6.TabIndex = 8;
            this.label6.Text = "HSL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lương cơ bản";
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(163, 191);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(133, 22);
            this.txtluong.TabIndex = 6;
            this.txtluong.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtthamnien
            // 
            this.txtthamnien.Location = new System.Drawing.Point(163, 138);
            this.txtthamnien.Name = "txtthamnien";
            this.txtthamnien.Size = new System.Drawing.Size(133, 22);
            this.txtthamnien.TabIndex = 5;
            // 
            // txtten2
            // 
            this.txtten2.Location = new System.Drawing.Point(163, 91);
            this.txtten2.Name = "txtten2";
            this.txtten2.Size = new System.Drawing.Size(133, 22);
            this.txtten2.TabIndex = 4;
            // 
            // txtmns2
            // 
            this.txtmns2.Location = new System.Drawing.Point(163, 42);
            this.txtmns2.Name = "txtmns2";
            this.txtmns2.Size = new System.Drawing.Size(133, 22);
            this.txtmns2.TabIndex = 3;
            this.txtmns2.TextChanged += new System.EventHandler(this.txtmns2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "Thâm niên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên nhân sự";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lương tháng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân sự";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(94, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(864, 295);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bangluong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 609);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bangluong";
            this.Text = "Bảng Lương ";
            this.Load += new System.EventHandler(this.bangluong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txtthamnien;
        private System.Windows.Forms.TextBox txtten2;
        private System.Windows.Forms.TextBox txtmns2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btthoat2;
        private System.Windows.Forms.Button btreset2;
        private System.Windows.Forms.Button btxoa2;
        private System.Windows.Forms.Button btsua2;
        private System.Windows.Forms.Button btthem2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txthsl;
        private System.Windows.Forms.TextBox txtlcb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttinh;
    }
}