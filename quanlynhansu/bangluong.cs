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
    public partial class bangluong : Form
    {
        string str = @"Data Source=DESKTOP-LSJ7AKT\SQLEXPRESS;Initial Catalog=qlns;Integrated Security=True";
        SqlConnection conn;
        public void loaddata()
        {

            SqlCommand command = new SqlCommand("select * from luong", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
        }
        public bangluong()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtmns2.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtten2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtthamnien.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtluong.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            loaddata();
        }

        private void bangluong_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
        }

        private void btthoat2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chọn thoát chương trình ngay !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btreset2_Click(object sender, EventArgs e)
        {
            txtmns2.Text = "";
            txtten2.Text = "";
            txtluong.Text = "";
            txtthamnien.Text = "";
        }

        private void btthem2_Click(object sender, EventArgs e)
        {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO luong values('" + txtmns2.Text + "','" + txtten2.Text + "','" + txtthamnien.Text + "','" + txtluong.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btsua2_Click(object sender, EventArgs e)
        {
            SqlCommand comand = conn.CreateCommand();
            comand.CommandText = "update luong set mns='" + txtmns2.Text + "',hoten='" + txtten2.Text + "', thamnien='" + txtthamnien.Text + "',Luong='" + txtluong.Text + "'";
            comand.ExecuteNonQuery();
            loaddata();
        }

        private void btxoa2_Click(object sender, EventArgs e)
        {
            SqlCommand comand = conn.CreateCommand();
            comand.CommandText = "delete from luong where mns2='" + txtmns2.Text + "'";
            comand.ExecuteNonQuery();
            loaddata();
        }

        private void bttinh_Click(object sender, EventArgs e)
        {
            float luongcoban = Convert.ToInt32(txtlcb.Text);
            float hsl = Convert.ToInt32(txthsl.Text);
            float pc = Convert.ToInt32(txtpc.Text);
            float bh = Convert.ToInt32(txtbh.Text);
            float luong = luongcoban + pc - bh;
            txtluong.Text = luong.ToString();
        }

        private void txtmns2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
