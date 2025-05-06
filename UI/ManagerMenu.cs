using BlImplementation;
using BlApi;
namespace UI
{
    public partial class ManagerMenu : Form
    {
        public IProduct bl = new ProductImplementation();
        public ManagerMenu()
        {
            InitializeComponent();
            dataGridView1.Visible = true;
            dataGridView1.DataSource = bl.ReadAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bl.Delete((int)numericUpDown1.Value);
            deleted_Click(sender, e);
            dataGridView1.DataSource = bl.ReadAll();

        }

        private void deleted_Click(object sender, EventArgs e)
        {
            deleted.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }
        private void add_product_Click(object sender, EventArgs e)
        {
            // Retrieve selected category correctly
            BO.Category selectedCategory = (BO.Category)category.SelectedItem; // Ensure this is the correct object type.

            if (selectedCategory != null)
            {
                bl.Create(new BO.Product(nameProduct.Text, (double)price.Value, (int)amount.Value, selectedCategory));
                added.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select a valid category.");
            }
        }
    }
}
