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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-F0IDU28;Initial Catalog=LIBRARY;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("update STUDENT set S_NAME=@S_NAME,S_EMAIL=@S_EMAIL,S_PHONE_NO=@S_PHONE_NO,DEPT=@DEPT WHERE S_ID=@S_ID", sqlConnection);
            cmd.Parameters.AddWithValue("@S_ID", S_ID.Text);
            cmd.Parameters.AddWithValue("@S_NAME", S_NAME.Text);
            cmd.Parameters.AddWithValue("@S_EMAIL", S_EMAIL.Text);
            cmd.Parameters.AddWithValue("@S_PHONE_NO", S_PHONE_NO.Text);
            cmd.Parameters.AddWithValue("@DEPT", DEPT.Text);

            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Your student has been updated successfully.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            this.Hide();
            F.Show();
            this.Close();
        }
    }
}
