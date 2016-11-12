using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace adonet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        System.Data.SqlClient.SqlConnection con;
        System.Data.SqlClient.SqlCommand cmd;
        System.Data.SqlClient.SqlDataReader reader;
        private void button1_Click(object sender, EventArgs e)
        {
            con = new System.Data.SqlClient.SqlConnection("Data Source=ISS-PC\\SQLEXPRESS;user id=sa;pwd=iss;database=rohithdb");
            con.Open();
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandText="insert into studentinfo values(1000,'rohithrao',7400,'c')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con = new System.Data.SqlClient.SqlConnection("Data Source=ISS-PC\\SQLEXPRESS;user id=sa;pwd=iss;database=rohithdb");
            con.Open();
            cmd = new System.Data.SqlClient.SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from studentinfo";
            reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                MessageBox.Show(string.Format("{0} {1} {2} {3}", reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3)));
            }
            reader.Close();
            con.Close();
        }
    }
}
