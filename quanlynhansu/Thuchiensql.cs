using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    class Thuchiensql
    {
        public DataTable cmd(string s)
        {
            //String str = @"Data Source=LAPTOP-TF7GCDAF\SQLEXPRESS;Initial Catalog=HTGQD;User ID=sa;Password=ha14122001";
            String str = @"Data Source=LAPTOP-TF7GCDAF\SQLEXPRESS;Initial Catalog=QuanLyNS_HTG;Integrated Security=True";

            SqlConnection con = new SqlConnection(str);
            con.Open();
            SqlCommand com;
            com = con.CreateCommand();
            com.CommandText = s;
            // com.ExecuteNonQuery();
            SqlDataAdapter ad = new SqlDataAdapter();
            DataTable tb = new DataTable();
            ad.SelectCommand = com;
            ad.Fill(tb);
            con.Close();
            return tb;
        }
    }
}