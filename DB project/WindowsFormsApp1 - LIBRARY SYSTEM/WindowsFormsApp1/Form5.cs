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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            this.Hide();
            F.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-F0IDU28;Initial Catalog=LIBRARY;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("update BOOK set S_ID=NULL,RESERVE_DATE=NULL,DUE_DATE=NULL,RETURN_DATE=@RETURN_DATE where ISBN=@ISBN", sqlConnection);
            cmd.Parameters.AddWithValue("@ISBN", ISBN.Text);
            cmd.Parameters.AddWithValue("@S_ID", S_ID.Text);
            cmd.Parameters.AddWithValue("@RESERVE_DATE", RESERVE_DATE.Value);
            cmd.Parameters.AddWithValue("@DUE_DATE", DUE_DATE.Value);
            cmd.Parameters.AddWithValue("@RETURN_DATE", RETURN_DATE.Value);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Your book has been returned successfully.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-F0IDU28;Initial Catalog=LIBRARY;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("update BOOK set S_ID=@S_ID,RESERVE_DATE=@RESERVE_DATE,DUE_DATE=@DUE_DATE,RETURN_DATE=NULL where ISBN=@ISBN", sqlConnection);
            cmd.Parameters.AddWithValue("@ISBN", ISBN.Text);
            cmd.Parameters.AddWithValue("@S_ID", S_ID.Text);
            cmd.Parameters.AddWithValue("@RESERVE_DATE", RESERVE_DATE.Value);
            cmd.Parameters.AddWithValue("@DUE_DATE", DUE_DATE.Value);
            cmd.Parameters.AddWithValue("@RETURN_DATE", RETURN_DATE.Value);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Your book has been reserved successfully.");
            
        }
    }
}
