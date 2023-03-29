using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace RGMSystemWinForm
{
    public partial class MembersPage : Form
    {
        public MembersPage()
        {
            InitializeComponent();
            ComboBox box1= new ComboBox();
            box1.Items.Add("India");
            box1.Items.Add("USA");
            box1.Items.Add("China");
            box1.Items.Add("Australia");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactUs getGoods = new ContactUs();
            getGoods.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetGoods getGoods = new GetGoods();
            getGoods.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            GetGoods getGoods = new GetGoods();
            getGoods.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Focus();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Show();
        }
        private void button7_Click(object sender, EventArgs e)
        {
              this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}