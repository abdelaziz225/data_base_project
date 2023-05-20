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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-F0IDU28;Initial Catalog=LIBRARY;Integrated Security=True");
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.CommandText = "INSERT INTO BOOK (ISBN, TITLE, EDITION, A_ID, ID, SHELF_NO, FLOOR_NO) VALUES('" + ISBN.Text + "', '" + TITLE.Text + "', '" + ED.Text + "', '" + A_ID.Text + "', '" + STAFF_ID.Text + "', '" + SHELF.Text + "', '" + FLOOR.Text + "')";
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Your book has been added successfully.");

            }

            catch
            {
                MessageBox.Show("Error. Either this book has been added already, or your data is incorrect.");
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

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
