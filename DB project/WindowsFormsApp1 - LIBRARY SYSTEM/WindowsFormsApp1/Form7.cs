using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* SqlConnection s = new SqlConnection("Data Source=DESKTOP-F0IDU28;Initial Catalog=LIBRARY;Integrated Security=True");
            s.Open();
            SqlDataAdapter a = new SqlDataAdapter("SELECT S_ID,S_NAME,S_EMAIL,S_PHONE,DEPT FROM  STUDENT WHERE  S_ID Like '" + S_ID.Text + "'", s);
            DataTable t = new DataTable();
            a.Fill(t);
            dataGridView1.DataSource = t; */
        }

        private void S_ID_TextChanged(object sender, EventArgs e)
        {
            SqlConnection s = new SqlConnection("Data Source=DESKTOP-F0IDU28;Initial Catalog=LIBRARY;Integrated Security=True");
            s.Open();
            SqlDataAdapter a = new SqlDataAdapter("SELECT S_ID,S_NAME,S_EMAIL,S_PHONE_NO,DEPT FROM  STUDENT WHERE  S_ID Like '" + S_ID.Text + "'", s);
            DataTable t = new DataTable();
            a.Fill(t);
            dataGridView1.DataSource = t;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            this.Hide();
            F.Show();
            this.Close();
        }
    }
}
