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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection d = new SqlConnection ("Data Source=DESKTOP-F0IDU28;Initial Catalog=LIBRARY;Integrated Security=True");
            d.Open();
            SqlCommand cmd = new SqlCommand("Delete BOOK where ISBN=@ISBN", d);
            cmd.Parameters.AddWithValue("@ISBN", int.Parse(ISBN.Text));
            cmd.ExecuteNonQuery();
            d.Close();
            MessageBox.Show("Your book has been deleted successfully.");

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
