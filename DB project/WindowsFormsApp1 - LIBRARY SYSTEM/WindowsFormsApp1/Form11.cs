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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            this.Hide();
            F.Show();
            this.Close();
        }

        private void B_ISBN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection d = new SqlConnection("Data Source=DESKTOP-F0IDU28;Initial Catalog=LIBRARY;Integrated Security=True");
            d.Open();
            SqlCommand cmd = new SqlCommand("Delete STUDENT where S_ID=@S_ID", d);
            cmd.Parameters.AddWithValue("@S_ID", int.Parse(S_ID.Text));
            cmd.ExecuteNonQuery();
            d.Close();
            MessageBox.Show("Your student has been deleted successfully.");
        }
    }
}
