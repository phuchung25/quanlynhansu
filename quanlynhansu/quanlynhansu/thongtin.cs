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
    public partial class thongtin : Form
    {
        string str = @"Data Source=DESKTOP-L6HTM39\SQLEXPRESS;Initial Catalog=qlns;Integrated Security=True";
        SqlConnection conn;
        string tk = "", tennguoidung = "", mk = "", quyen = "";
        public thongtin(string tk, string tennguoidung, string mk, string quyen)
        {
            InitializeComponent();
            this.tk = tk;
            this.tennguoidung = tennguoidung;
            this.mk = mk;
            this.quyen = quyen;
        }
        
        public void Loaddata()
        {
            
            SqlCommand command = new SqlCommand("select * from thongtin", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            dataGridView1.DataSource = tb;
            dataGridView1.Refresh();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtmns.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txthoten.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            cbgt.SelectedItem = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtdc.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtcs.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtcv.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtemail.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
        }

        private void btthoat_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn chọn thoát chương trình ngay !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btreset_Click_1(object sender, EventArgs e)
        {
            txtmns.Text = "";
            txthoten.Text = "";
            txtcs.Text = "";
            txtcv.Text = "";
            txtdc.Text = "";
            cbgt.SelectedItem = "";
            dateTimePicker1.Text = "";
            txtemail.Text = "";
        }

        private void btthem_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO thongtin values('" + txtmns.Text + "','" + txthoten.Text + "','" + dateTimePicker1.Text + "','" + cbgt.SelectedItem + "', '" + txtdc.Text + "','" + txtcs.Text + "', '" + txtcv.Text + "', '" + txtemail.Text + "')";
            command.ExecuteNonQuery();
            Loaddata();
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            SqlCommand comand = conn.CreateCommand();
            comand.CommandText = "delete from thongtin where mns='" + txtmns.Text + "'";
            comand.ExecuteNonQuery();
            Loaddata();
        }

        private void btsua_Click_1(object sender, EventArgs e)
        {
            SqlCommand comand = conn.CreateCommand();
            comand.CommandText = "update thongtin set mns='" + txtmns.Text + "',hoten='" + txthoten.Text + "', ngaysinh='" + dateTimePicker1.Text + "', gioitinh = '" + cbgt.SelectedItem + "', diachi = '" + txtdc.Text + "',coso = '" + txtcs.Text + "', chucvu = '" + txtcv.Text + "',email = '" + txtemail.Text + "'";
            comand.ExecuteNonQuery();
            Loaddata();
        }

        public thongtin()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void thongtin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            conn.Open();
            Loaddata();
        }
    }
}
