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
    public partial class xem : Form
    {
        string str = @"Data Source=DESKTOP-L6HTM39\SQLEXPRESS;Initial Catalog=qlns;Integrated Security=True";
        SqlConnection conn;
        public void Loaddata()
        {

            SqlCommand command = new SqlCommand("select * from thongtin", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
        }
        public void loaddata()
        {

            SqlCommand command = new SqlCommand("select * from luong", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridView2.DataSource = tb;
            dataGridView2.Refresh();
        }
        public void loaddata1()
        {

            SqlCommand command = new SqlCommand("select * from hopdong", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridView3.DataSource = tb;
            dataGridView3.Refresh();
        }
        public xem()
        {
            InitializeComponent();
        }

        private void xem_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            Loaddata();
            loaddata();
            loaddata1();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            loaddata();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
