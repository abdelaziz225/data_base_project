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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try 
            { 
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-F0IDU28;Initial Catalog=LIBRARY;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();
            sqlCommand.CommandText = "INSERT INTO STUDENT (S_ID, S_NAME, S_EMAIL, S_PHONE_NO, DEPT) VALUES('" + ID.Text + "', '" + NAME.Text + "', '" + EMAIL.Text + "', '" + PHONE.Text + "', '" + DEPT.Text + "')";
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Your student has been added successfully.");
            }

            catch
            {
                MessageBox.Show("Error. Either this student has been added already, or your data is incorrect.");
            }
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
