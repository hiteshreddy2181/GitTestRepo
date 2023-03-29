namespace RGMSystemWinForm
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Focus();

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
            this.Hide();
            MembersPage membersPage = new MembersPage();
            membersPage.Show();
        }

    }
}