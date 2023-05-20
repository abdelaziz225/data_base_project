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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 F = new Form8();
            F.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 F = new Form3();
            F.Show();
            //this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 F = new Form9();
            this.Hide();
            F.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 F = new Form4();
            //this.Hide();
            F.Show();
            //this.Close();
        }

        private void RES_BOOK_Click(object sender, EventArgs e)
        {
            Form5 F = new Form5();
            this.Hide();
            F.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 F = new Form6();
            F.Show();
            this.Hide();
        }

        private void SEARCH_S_Click(object sender, EventArgs e)
        {
            Form7 F = new Form7();
            F.Show();
            this.Hide();
        }

        private void DEL_B_Click(object sender, EventArgs e)
        {
            Form10 F = new Form10();
            this.Hide();
            F.Show();
            this.Close();
        }

        private void DEL_S_Click(object sender, EventArgs e)
        {
            Form11 F = new Form11();
            this.Hide();
            F.Show();
            this.Close();
        }

        private void UPDATE_B_Click(object sender, EventArgs e)
        {
            Form12 F = new Form12();
            this.Hide();
            F.Show();
            this.Close();
        }

        private void UPDATE_S_Click(object sender, EventArgs e)
        {
            Form13 F = new Form13();
            this.Hide();
            F.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form14 F = new Form14();
            //this.Hide();
            F.Show();
            //this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            this.Hide();
            F.Show();
            this.Close();

            MessageBox.Show("Successfully logged out.");
        }
    }
} 
