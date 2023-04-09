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
    public partial class hopdong : Form
    {
        string str = @"Data Source=DESKTOP-LSJ7AKT\SQLEXPRESS;Initial Catalog=qlns;Integrated Security=True";
        SqlConnection conn;
        public void loaddata()
        {

            SqlCommand command = new SqlCommand("select * from hopdong", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
        }
        public hopdong()
        {
            InitializeComponent();
        }

        private void hopdong_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btthoat3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chọn thoát chương trình ngay !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btreset3_Click(object sender, EventArgs e)
        {
            txtmhd.Text = "";
            txttenhd.Text = "";
            txttenns.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
        }

        private void btsua3_Click(object sender, EventArgs e)
        {
            SqlCommand comand = conn.CreateCommand();
            comand.CommandText = "update hopdong set mahopdong='" + txtmhd.Text + "',tenhopdong='" + txttenhd.Text + "', Hoten='" + txttenns.Text + "',ngaygiahan='" + dateTimePicker1.Text + "',ngayhethan='" + dateTimePicker2.Text + "'";
            comand.ExecuteNonQuery();
            loaddata();
        }

        private void btthem3_Click(object sender, EventArgs e)
        {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO hopdong values('" + txtmhd.Text + "','" + txttenhd.Text + "', '" + txttenns.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void btxoa3_Click(object sender, EventArgs e)
        {
            SqlCommand comand = conn.CreateCommand();
            comand.CommandText = "delete from hopdong where mahd='" + txtmhd.Text + "'";
            comand.ExecuteNonQuery();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtmhd.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txttenhd.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txttenns.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            loaddata();
        }
    }
}
