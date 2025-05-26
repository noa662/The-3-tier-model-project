using System.ComponentModel.Design.Serialization;
using BlApi;
using BO;
namespace UI
{
    public partial class Seller : Form
    {
        IBl bl = BlApi.Factory.Get();
        string id = "";
        bool favorite = false;
        private Order currentOrder;

        public Seller()
        {
            InitializeComponent();
            currentOrder = new Order(false);
            setStatus(false);
        }

        public void showdata()
        {
            try
            {
                if (currentOrder != null)
                    sum.Text = currentOrder.finalPrice.ToString();
                else
                    sum.Text = "0";
                if (amount.Text == null)
                    amount.Text = "1";

                dataGridView1.Visible = true;
                dataGridView1.DataSource = bl.Product.ReadAll();

                listBox2.Items.Clear();
                listBox1.Items.Clear();

                if (currentOrder != null && currentOrder.productInOrder != null)
                {
                    foreach (var productInOrder in currentOrder.productInOrder)
                    {
                        if (productInOrder != null)
                        {
                            listBox1.Items.Add(productInOrder);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error showing data: {ex.Message}");
            }
        }

        public void setStatus(bool status = false)
        {
            label6.Visible = status;
            textBox1.Visible = status;
            button2.Visible = status;
            label5.Visible = status;
            AddProductBtn.Visible = status;
            label4.Visible = status;
            sum.Visible = status;
            label3.Visible = status;
            label2.Visible = status;
            dataGridView1.Visible = status;
            listBox2.Visible = status;
            listBox1.Visible = status;
            button1.Visible = status;
            label8.Visible = status;
            amount.Visible = status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (currentOrder.finalPrice > 0)
                {
                    bl.Order.DoOrder(currentOrder);
                    MessageBox.Show("הזמנת לקוח בוצעה בהצלחה");
                    setStatus(false);
                    label7.Visible = true;
                    ClientId.Visible = true;
                    button3.Visible = true;
                    listBox1.Items.Clear();
                    listBox2.Items.Clear();
                    sum.Text = string.Empty;
                    amount.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error finalizing order: {ex.Message}");
            }
        }

        private void AddProductBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                DataGridViewRow selectedRow = dataGridView1.CurrentRow;
               
                List<SaleInProduct> sales = bl.Order.AddProductToOrder(currentOrder, int.Parse(selectedRow.Cells[0].Value.ToString()), int.Parse(amount.Text), favorite);

                bool flag = false;
                int i = 0, index = 0;
                foreach (var item in listBox1.Items)
                {
                    i++;
                    if (flag)
                    {
                        string str = item as string;
                        string[] strArr = str.Split(" ");
                        int amountA = int.Parse(strArr[1]);
                        amountA += int.Parse(amount.Text);
                        if (amountA <= bl.Product.Read(int.Parse(selectedRow.Cells[0].Value.ToString())).amount)
                        {
                            listBox1.Items.Insert(i, "סה'כ: " + amountA);
                            listBox1.Items.RemoveAt(i-1);
                        }
                        else
                        { MessageBox.Show("אזל מהלאי"); return; }
                        break;
                    }
                    if (item.ToString() == selectedRow.Cells[1].Value.ToString() + " " + selectedRow.Cells[2].Value.ToString())
                    {
                        flag = true;
                        index = i-1;
                    }
                }

                if (!flag)
                {
                    listBox1.Items.Add(selectedRow.Cells[1].Value.ToString() + " " + selectedRow.Cells[2].Value.ToString());
                    listBox1.Items.Add("סה'כ: " + int.Parse(amount.Text));
                }


                foreach (SaleInProduct s in sales)
                {
                    listBox2.Items.Add(s.ToString());
                }

                if (currentOrder != null)
                    sum.Text = currentOrder.finalPrice.ToString();

                List<BO.Product> products = (List<BO.Product>)dataGridView1.DataSource;

                foreach (var product in products)
                {
                    if (product.id == int.Parse(selectedRow.Cells[0].Value.ToString()))
                        product.amount -= int.Parse(amount.Text);
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = products;
            }
            catch (BLAccessException ex)
            {
                MessageBox.Show($"Error adding product to order: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in AddProductBtn_Click: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                List<SaleInProduct> sales = bl.Order.AddProductToOrder(currentOrder, id, int.Parse(amount.Text), favorite);
                foreach (SaleInProduct s in sales)
                {
                    listBox2.Items.Add(s.ToString());
                }

                BO.Product p = bl.Product.Read(id);
                listBox1.Items.Add(p.name + " " + p.price);
                if (currentOrder != null)
                    sum.Text = currentOrder.finalPrice.ToString();

                dataGridView1.DataSource = bl.Product.ReadAll();
            }
            catch (BLAccessException ex)
            {
                MessageBox.Show($"Error adding product by ID: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error in button2_Click: {ex.Message}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                id = ClientId.Text;
                int id2 = int.Parse(id);
                BO.Client client = null;
                client = bl.Client.Read(id2);
                if (client != null)
                    favorite = true;
                setStatus(true);
                label7.Visible = false;
                ClientId.Visible = false;
                button3.Visible = false;
                showdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing client ID: {ex.Message}");
            }
        }
    }
}