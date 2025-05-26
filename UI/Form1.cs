namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Menu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Option menu = new Option();
            menu.Show();
            this.Hide();//הסתרת המסך הנוכחי
            menu.FormClosed += Menu_FormClosed;//רישום לאירוע של סגירת המסך המשני
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Seller menu = new Seller();
            menu.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}