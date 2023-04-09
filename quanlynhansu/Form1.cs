using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class quanlynhansu : Form
    {
        String str = @"Data Source=LAPTOP-TF7GCDAF\SQLEXPRESS;Initial Catalog=QuanLyNS_HTG;Integrated Security=True";
        SqlConnection con;
        SqlCommand com;
        Thuchiensql sql = new Thuchiensql();
        public quanlynhansu()
        {
            InitializeComponent();
        }
       
        private void quanlynhansu_Load(object sender, EventArgs e)
        {
           
            Loadnhansu();
            
        }
        public void resetdata()
        {
            
            Loadnhansu();
        }


        public void Loadnhansu()
        {
            Thuchiensql sql = new Thuchiensql();
            con = new SqlConnection(str);
            con.Open();
            com = con.CreateCommand();
            com.CommandText = "select * from NhanSu_HTG";
            com.ExecuteNonQuery();
            SqlDataAdapter ad = new SqlDataAdapter();
            DataTable tb = new DataTable();
            ad.SelectCommand = com;
            ad.Fill(tb);
            dataGridnhansu.DataSource = tb;
            con.Close();
        }

        

        private void dataGridnhansu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridnhansu.CurrentRow.Index;
            txtmans.Text = dataGridnhansu.Rows[i].Cells[0].Value.ToString();
            txtht.Text = dataGridnhansu.Rows[i].Cells[1].Value.ToString();
            cbgt.Text = dataGridnhansu.Rows[i].Cells[2].Value.ToString();
            dtns.Text = dataGridnhansu.Rows[i].Cells[3].Value.ToString();
            txtluong.Text = dataGridnhansu.Rows[i].Cells[4].Value.ToString();
            cbphongban.Text = dataGridnhansu.Rows[i].Cells[5].Value.ToString();
            txtdiachi.Text = dataGridnhansu.Rows[i].Cells[6].Value.ToString();
            txtchucvu.Text = dataGridnhansu.Rows[i].Cells[7].Value.ToString();
            txtemail.Text = dataGridnhansu.Rows[i].Cells[8].Value.ToString();
            cbkhenthuong.Text = dataGridnhansu.Rows[i].Cells[9].Value.ToString();
            cbkyluat.Text = dataGridnhansu.Rows[i].Cells[10].Value.ToString();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            try
            {
                com = con.CreateCommand();
                com.CommandText = "insert into NhanSu_HTG values(N'" + txtmans.Text + "',N'" + txtht.Text + "',N'" + cbgt.Text + "',N'" + dtns.Text + "',N'" + txtluong.Text + "',N'" + cbphongban.Text + "',N'" + txtdiachi.Text + "',N'" + txtchucvu.Text + "',N'" + txtemail.Text + "',N'" + cbkhenthuong.Text + "',N'" + cbkyluat.Text + "')";
                com.ExecuteNonQuery();
            }
            catch (Exception loi)
            {
                MessageBox.Show($"Thong tin khong hop le, Error: {loi.Message}", "Exception", MessageBoxButtons.OK);
            }
            Loadnhansu();
        }

        
        private void btSua_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            com = con.CreateCommand();
            com.CommandText = "update NhanSu_HTG set HoTen=N'" + txtht.Text + "',GioiTinh=N'" + cbgt.Text + "',NgaySinh=N'" + dtns.Text + "',Luong=N'" + txtluong.Text + "',PhongBan=N'" + cbphongban.Text + "',DiaChi=N'" + txtdiachi.Text + "',ChucVu=N'" + txtchucvu.Text + "',Email=N'" + txtemail.Text +"',SLDKhenThuong = N'" + cbkhenthuong.Text + "',SLBKyLuat = N'" + cbkyluat.Text + "'";
            com.ExecuteNonQuery();
            resetdata();
        }

       

        private void btXoa_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            com = con.CreateCommand();
            com.CommandText = "delete from NhanSu_HTG  where MaNS=N'" + txtmans.Text + "'";
            com.ExecuteNonQuery();
            Loadnhansu();
        }

        private void btResset_Click(object sender, EventArgs e)
        {
            txtmans.Text = "";
            txtht.Text = "";
            cbgt.Text = "";
            dtns.Text = "";
            txtluong.Text = "";
            cbphongban.Text = "";
            txtdiachi.Text = "";
            txtchucvu.Text = "";
            txtemail.Text = "";
        }

        private void btten_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            com = con.CreateCommand();
            com.CommandText = "select * from NhanSu_HTG where (HoTen like N'%" + txttk.Text + "%') ";
            com.ExecuteNonQuery();
            SqlDataAdapter adap = new SqlDataAdapter();
            DataTable tb = new DataTable();
            adap.SelectCommand = com;
            adap.Fill(tb);
            dataGridnhansu.DataSource = tb;
        }

        private void btma_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(str);
            con.Open();
            com = con.CreateCommand();
            com.CommandText = "select * from NhanSu_HTG where (MaNS like N'%" + txttk.Text + "%') ";
            com.ExecuteNonQuery();
            SqlDataAdapter adap = new SqlDataAdapter();
            DataTable tb = new DataTable();
            adap.SelectCommand = com;
            adap.Fill(tb);
            dataGridnhansu.DataSource = tb;
        }

        private void txtluong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btds_Click(object sender, EventArgs e)
        {
            nhansutn fns = new nhansutn();
            fns.Show();
            this.Hide();
        }

        private void quanlynhansu_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void quanlynhansu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }

}
