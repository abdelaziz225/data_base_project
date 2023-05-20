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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void STUDENTS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection s = new SqlConnection("Data Source=DESKTOP-F0IDU28;Initial Catalog=LIBRARY;Integrated Security=True");
            s.Open();
            SqlDataAdapter a = new SqlDataAdapter("SELECT ISBN,TITLE,EDITION,SHELF_NO,FLOOR_NO,A_ID,ID,S_ID,RESERVE_DATE,DUE_DATE,RETURN_DATE FROM  BOOK WHERE  TITLE Like '" + TITLE.Text + "'", s);
            DataTable t = new DataTable();
            a.Fill(t);
            dataGridView1.DataSource = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            this.Hide();
            F.Show();
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}
