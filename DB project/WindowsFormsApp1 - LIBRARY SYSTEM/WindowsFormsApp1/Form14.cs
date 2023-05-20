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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lIBRARYDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.lIBRARYDataSet.STUDENT);
            // TODO: This line of code loads data into the 'lIBRARYDataSet.BOOK' table. You can move, or remove it, as needed.
            this.bOOKTableAdapter.Fill(this.lIBRARYDataSet.BOOK);

            SqlConnection s = new SqlConnection("Data Source=DESKTOP-F0IDU28;Initial Catalog=LIBRARY;Integrated Security=True");
            s.Open();
            SqlDataAdapter a = new SqlDataAdapter("SELECT ISBN,TITLE,EDITION,STUDENT.S_ID,S_NAME,DEPT,S_PHONE_NO,S_EMAIL,RESERVE_DATE,DUE_DATE,RETURN_DATE FROM BOOK inner join STUDENT On BOOK.S_ID=STUDENT.S_ID", s);
            DataTable t = new DataTable();
            a.Fill(t);
            dataGridView1.DataSource = t;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            this.Hide();
            F.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
