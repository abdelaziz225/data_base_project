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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-F0IDU28;Initial Catalog=LIBRARY;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            SqlCommand cmd = new SqlCommand("update BOOK set TITLE=@TITLE,A_ID=@A_ID,ID=@ID,EDITION=@EDITION,SHELF_NO=@SHELF_NO,FLOOR_NO=@FLOOR_NO WHERE ISBN=@ISBN", sqlConnection);
            cmd.Parameters.AddWithValue("@ISBN", ISBN.Text);
            cmd.Parameters.AddWithValue("@TITLE", TITLE.Text);
            cmd.Parameters.AddWithValue("@A_ID", A_ID.Text);
            cmd.Parameters.AddWithValue("@ID", ID.Text);
            cmd.Parameters.AddWithValue("@EDITION", EDITION.Text);
            cmd.Parameters.AddWithValue("@SHELF_NO", SHELF_NO.Text);
            cmd.Parameters.AddWithValue("@FLOOR_NO", FLOOR_NO.Text);

            cmd.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Your book has been updated successfully.");
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
