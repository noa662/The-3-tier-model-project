using BlApi;
using BO;
namespace UI
{
    public partial class SaleManager : Form
    {
        IBl bl = BlApi.Factory.Get();
        public SaleManager()
        {
            InitializeComponent();
            dataGridView1.Visible = true;
            dataGridView1.DataSource = bl.Sale.ReadAll();
        }

        private void add_product_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Sale s = new BO.Sale((int)productId.Value, (int)amount.Value, (double)priceInSale.Value, onlyForClub.Checked, DateStart.Value, DateEnd.Value);
                added.Visible = true;
                MessageBox.Show("המבצע נוסף בהצלחה!");
                added.Visible = false;
                productId.Value = 0;
                amount.Value = 0;
                priceInSale.Value = 0;
                onlyForClub.Text = string.Empty;
                DateStart.Text = string.Empty;
                DateEnd.Text = string.Empty;
                dataGridView1.DataSource = bl.Sale.ReadAll();
                MessageBox.Show("לא הוכנסו כל הנתונים!");
            }
            catch (BLAlreadyExistsException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDown1.Text != string.Empty || numericUpDown1.Text == "0")
                {
                    if (bl.Sale.Read((int)numericUpDown1.Value) != null)
                    {
                        bl.Sale.Delete((int)numericUpDown1.Value);
                        deleted.Visible = true;
                        MessageBox.Show("המבצע נמחק בהצלחה!");
                        deleted.Visible = false;
                        numericUpDown1.Value = 0;
                        dataGridView1.DataSource = bl.Sale.ReadAll();
                    }
                    else
                        MessageBox.Show("לא קיים מבצע זה.");
                }
                else
                    MessageBox.Show("הכנס ID", "שגיאת קלט", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (BLNotFoundException ex) { MessageBox.Show(ex.Message); }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //BO.Sale s = new BO.Sale(1, (int)productId.Value, (int)amount.Value, (double)priceInSale.Value, onlyForClub.Checked, DateStart.Value, DateEnd.Value);
            //bl.Sale.Update(s);
            //added.Visible = true;
            //MessageBox.Show("המוצר עודכן בהצלחה!");
            //added.Visible = false;
            //productId.Value = 0;
            //amount.Value = 0;
            //priceInSale.Value = 0;
            //DateStart.Text = string.Empty;
            //DateEnd.Text = string.Empty;
            //dataGridView1.DataSource = bl.Sale.ReadAll();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                int saleId1 = int.Parse(saleId.Text);
                BO.Sale s = new BO.Sale(
                    saleId1,
                    (int)productId1.Value,
                    (int)amount1.Value,
                    (double)priceInSale1.Value,
                    onlyForClub1.Checked,
                    DateStart1.Value,
                    DateEnd1.Value);

                bl.Sale.Update(s);
                updated.Visible = true;
                MessageBox.Show("המוצר עודכן בהצלחה!");
            }
            catch (BLAccessException ex)
            {
                MessageBox.Show($"Error updating sale: {ex.Message}");
            }
            catch (FormatException)
            {
                MessageBox.Show("נא להקיש מספר נכון לזיהוי המבצע.", "שגיאת קלט", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error updating sale: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                bool filter = forClub.Checked;
                dataGridView1.DataSource = bl.Sale.ReadAll(p => p.onlyClub == filter);
            }
            catch (BLNotFoundException ex) { MessageBox.Show(ex.Message, "Error"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = bl.Sale.ReadAll();
            }
            catch (BLNotFoundException ex) { MessageBox.Show(ex.Message, "Error"); }
        }
    }
}
