using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGMSystemWinForm
{
    public partial class GetGoods : Form
    {
        public GetGoods()
        {
            InitializeComponent();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
