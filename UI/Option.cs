using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ClientManager c = new ClientManager();
            c.Show();
            this.Hide();
            c.FormClosed += Menu_FormClosed;
            c.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductManager p = new ProductManager();
            p.Show();
            this.Hide();
            p.FormClosed += Menu_FormClosed;
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            SaleManager s = new SaleManager();
            s.Show();
            this.Hide();
            s.FormClosed += Menu_FormClosed;
            s.Show();
        }
        private void Menu_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
