using BlApi;
using BO;

namespace UI
{
    public partial class ProductManager : Form
    {
        IBl bl = BlApi.Factory.Get();
        public ProductManager()
        {
            InitializeComponent();
            category.DataSource = Enum.GetValues(typeof(Category)).Cast<Category>().ToList();
            category2.DataSource = Enum.GetValues(typeof(Category)).Cast<Category>().ToList();
            categoryFilter.DataSource = Enum.GetValues(typeof(Category)).Cast<Category>().ToList();
            dataGridView1.Visible = true;
            dataGridView1.DataSource = bl.Product.ReadAll();
        }

        private void add_product_Click(object sender, EventArgs e)
        {
            if (bl.Product.Create(new BO.Product(0, nameProduct.Text, (double)price.Value, (int)amount.Value, (Category)category.SelectedItem)) > 0)
            {
                added.Visible = true;
                MessageBox.Show("המוצר נוסף בהצלחה");
                added.Visible = false;
                nameProduct.Text = string.Empty;
                price.Text = string.Empty;
                amount.Text = string.Empty;
                category.SelectedIndex = 0;
                dataGridView1.DataSource = bl.Product.ReadAll();
            }
            else
                MessageBox.Show("לא הוכנסו כל הנתונים!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericUpDown1.Text.Length > 0)
                {
                    bl.Product.Delete(int.Parse(numericUpDown1.Text));
                    deleted_Click(sender, e);
                    numericUpDown1.Text = string.Empty;
                    dataGridView1.DataSource = bl.Product.ReadAll();
                }
                else
                {
                    MessageBox.Show("הכנס id למחיקה");
                }
            }
            catch
            {
                MessageBox.Show("מוצר לא קיים");
            }

        }

        private void deleted_Click(object sender, EventArgs e)
        {
            deleted.Visible = true;
            MessageBox.Show("המוצר נמחק בהצלחה!");
            deleted.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (productId.Text != string.Empty)
                {
                    int productId1 = int.Parse(productId.Text);
                    var productData = bl.Product.Read(productId1);
                    string name = productData.name;
                    double? price = productData.price;
                    int? amount = productData.amount;
                    BO.Category category = productData.category;
                    BO.Product p = new BO.Product(
                        productId1,
                        string.IsNullOrEmpty(nameProduct1.Text) ? name : nameProduct1.Text,
                        price1.Value > 0 ? (double)price1.Value : (double)price,
                        amount1.Value > 0 ? (int)amount1.Value : (int)amount,
                        category2.SelectedItem != null ? (BO.Category)category2.SelectedItem : category
                    );
                    bl.Product.Update(p);
                    label11.Visible = true;
                    MessageBox.Show("המוצר עודכן בהצלחה!");
                    label11.Visible = false;
                    nameProduct1.Text = string.Empty;
                    price1.Value = 0;
                    amount1.Value = 0;
                    category2.SelectedItem = null;
                    productId.Text = string.Empty;
                    dataGridView1.DataSource = bl.Product.ReadAll();
                }
                else
                {
                    MessageBox.Show("יש להכניס קוד מוצר");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (categoryFilter != null && categoryFilter.SelectedValue != null)
            {
                Category selectedCategory = (Category)categoryFilter.SelectedValue;
                dataGridView1.DataSource = bl.Product.ReadAll(p => p.category == selectedCategory);
            }
            else
            {
                dataGridView1.DataSource = bl.Product.ReadAll();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bl.Product.ReadAll();
        }
    }
}
