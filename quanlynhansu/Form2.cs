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
namespace QuanLyNhanSu
{
    public partial class nhansutn : Form
      {
        String str = @"Data Source=LAPTOP-TF7GCDAF\SQLEXPRESS;Initial Catalog=QuanLyNS_HTG;Integrated Security=True";
        SqlConnection con;
        SqlCommand com;
        Thuchiensql sql = new Thuchiensql();
        public nhansutn()
        {
            InitializeComponent();
        }
        private void quanlynhansu_Load(object sender, EventArgs e)
        {

            Loadnhansu();

        }
        public void Loadnhansu()
        {
            Thuchiensql sql = new Thuchiensql();
            con = new SqlConnection(str);
            con.Open();
            com = con.CreateCommand();
            com.CommandText = "select * from nhansutotnhatthang";
            com.ExecuteNonQuery();
            SqlDataAdapter ad = new SqlDataAdapter();
            DataTable tb = new DataTable();
            ad.SelectCommand = com;
            ad.Fill(tb);
            dataGridnhansu.DataSource = tb;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            com = con.CreateCommand();
            com.CommandText = "select * from NhanSu_HTG where (MaNS like N'%" + textBox1.Text + "%') ";
            com.ExecuteNonQuery();
            SqlDataAdapter adap = new SqlDataAdapter();
            DataTable tb = new DataTable();
            adap.SelectCommand = com;
            adap.Fill(tb);
            dataGridnhansu.DataSource = tb;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btlm_Click(object sender, EventArgs e)
        {
            Loadnhansu();
            textBox1.Clear();
        }
    }
}
