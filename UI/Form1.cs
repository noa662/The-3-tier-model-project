namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Option menu = new Option();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seller menu = new Seller();
            menu.Show();
        }
    }
}