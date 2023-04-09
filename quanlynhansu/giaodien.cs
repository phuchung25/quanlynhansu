using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace quanlynhansu
{
    public partial class giaodien : Form
    {
        string tk = "", tennguoidung = "", mk = "", quyen = "";

        public int i = 10;
        public giaodien()
        {
            InitializeComponent();
        }
        public giaodien(string tk, string tennguoidung, string mk, string quyen)
        {
            InitializeComponent();
            this.tk = tk;
            this.tennguoidung = tennguoidung;
            this.mk = mk;
            this.quyen = quyen;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (quyen == "Admin")
            {
                thongtin tt = new thongtin();
                tt.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập trang này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xem x = new xem();
            x.Show();

        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += i;
            if (label1.Left >= this.Width - label1.Width || label1.Left <= 0)
                i = -i;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin")
            {
                thongtin tt = new thongtin();
                tt.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập trang này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin")
            {
                bangluong bl = new bangluong();
                bl.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập trang này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin")
            {
                hopdong hd = new hopdong();
                hd.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập trang này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            xem x = new xem();
            x.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (quyen == "Admin")
            {
                bangluong bl = new bangluong();
                bl.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập trang này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(quyen == "Admin")
            {
                hopdong hd = new hopdong();
                hd.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập trang này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void giaodien_Load(object sender, EventArgs e)
        {

        }
    }
}
