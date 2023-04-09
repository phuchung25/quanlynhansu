
namespace QuanLyNhanSu
{
    partial class nhansutn
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
            this.dataGridnhansu = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttk = new System.Windows.Forms.Button();
            this.btlm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridnhansu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridnhansu
            // 
            this.dataGridnhansu.AllowDrop = true;
            this.dataGridnhansu.AllowUserToResizeColumns = false;
            this.dataGridnhansu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridnhansu.Location = new System.Drawing.Point(2, 81);
            this.dataGridnhansu.Name = "dataGridnhansu";
            this.dataGridnhansu.RowTemplate.Height = 25;
            this.dataGridnhansu.Size = new System.Drawing.Size(846, 368);
            this.dataGridnhansu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Mã Nhân Sự ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 23);
            this.textBox1.TabIndex = 2;
            // 
            // bttk
            // 
            this.bttk.Location = new System.Drawing.Point(347, 41);
            this.bttk.Name = "bttk";
            this.bttk.Size = new System.Drawing.Size(75, 23);
            this.bttk.TabIndex = 3;
            this.bttk.Text = "Tìm Kiếm ";
            this.bttk.UseVisualStyleBackColor = true;
            this.bttk.Click += new System.EventHandler(this.button1_Click);
            // 
            // btlm
            // 
            this.btlm.Location = new System.Drawing.Point(713, 39);
            this.btlm.Name = "btlm";
            this.btlm.Size = new System.Drawing.Size(75, 23);
            this.btlm.TabIndex = 4;
            this.btlm.Text = "Làm mới";
            this.btlm.UseVisualStyleBackColor = true;
            this.btlm.Click += new System.EventHandler(this.btlm_Click);
            // 
            // nhansutn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btlm);
            this.Controls.Add(this.bttk);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridnhansu);
            this.Name = "nhansutn";
            this.Text = "NhanSu_HTG";
            this.Load += new System.EventHandler(this.quanlynhansu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridnhansu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridnhansu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttk;
        private System.Windows.Forms.Button btlm;
    }
}