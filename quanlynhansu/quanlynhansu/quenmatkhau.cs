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
    public partial class quenmatkhau : Form
    {
        string str = @"Data Source=DESKTOP-L6HTM39\SQLEXPRESS;Initial Catalog=qlns;Integrated Security=True";
        SqlConnection conn;
        
        public quenmatkhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
           
                MessageBox.Show("Bạn đã xác nhận cấp lại mật khẩu của mình !. Vui lòng Email cấp lại mật khẩu của bạn từ bên đội ngũ hỗ trợ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn = new SqlConnection(str);
                SqlCommand command = conn.CreateCommand();
                command.CommandText = "INSERT INTO quenmatkhau values('" + txttentk.Text + "','" + txtmans.Text + "', '" + txttenns.Text + "','" + txtemail1.Text + "')";

          
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void reset_Click(object sender, EventArgs e)
        {
            txttentk.Text = "";
            txttenns.Text = "";
            txtmans.Text = "";
            txtemail1.Text = "";
        }

        private void quenmatkhau_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
        }
    }
}
