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
    public partial class Form1 : Form  
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection CNN = new SqlConnection("Data Source=DESKTOP-F0IDU28;Initial Catalog=LIBRARY;Integrated Security=True");
            CNN.Open();
            SqlCommand C = new SqlCommand("Select PASSWORD FROM REG_SYSTEM WHERE LOGIN_ID="+user_id.Text, CNN);
            string P = (string)C.ExecuteScalar(); 

            if(P == password.Text)
            {
                MessageBox.Show("Successfully logged in.");

                Form2 F = new Form2();
                F.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed. Your password is incorrect, please try again.");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void id_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


