using BlApi;
using BlImplementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ClientManager : Form
    {
        IBl bl = BlApi.Factory.Get();
        public ClientManager()
        {
            InitializeComponent();
            dataGridView1.Visible = true;
            dataGridView1.DataSource = bl.Client.ReadAll();
        }

        private void add_product_Click(object sender, EventArgs e)
        {
            if (id.Text != "")
            {
                int clientId = int.Parse(id.Text);
                BO.Client c = new BO.Client(clientId, nameClient.Text, address.Text, phone.Text);
                if (bl.Client.ReadAll(cl => clientId == cl.id).Count() > 0)
                {
                    MessageBox.Show("id כבר קיים");
                    return;
                }
                if (c != null)
                {
                    bl.Client.Create(c);
                    added.Visible = true;
                    MessageBox.Show("הלקוח נוסף בהצלחה");
                }
                else
                {
                    MessageBox.Show("שגיאה בהוספת לקוח - הכנס מחדש את כל הנתונים");
                }
                added.Visible = false;
                dataGridView1.DataSource = bl.Client.ReadAll();
                nameClient.Text = string.Empty;
                address.Text = string.Empty;
                phone.Text = string.Empty;
                id.Text = string.Empty;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (clientId23.Text != string.Empty)
            {
                int clientId = int.Parse(clientId23.Text);
                var clientData = bl.Client.Read(clientId);
                if (clientData != null)
                {
                    string name = clientData.name;
                    string address2 = clientData.address;
                    string phone2 = clientData.phone;

                    BO.Client c = new BO.Client(
                        clientId,
                        string.IsNullOrEmpty(nameClient1.Text) ? name : nameClient1.Text,
                        string.IsNullOrEmpty(address1.Text) ? address2 : address1.Text,
                        string.IsNullOrEmpty(phone1.Text) ? phone2 : phone1.Text
                    );

                    bl.Client.Update(c);
                    updated.Visible = true;
                    MessageBox.Show("הלקוח עודכן בהצלחה");
                    updated.Visible = false;
                    dataGridView1.DataSource = bl.Client.ReadAll();
                    nameClient1.Text = string.Empty;
                    address1.Text = string.Empty;
                    phone1.Text = string.Empty;
                }
                else
                    MessageBox.Show("לקוח לא קיים!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = (int)numericUpDown1.Value;
                if (bl.Client.Read(id) != null)
                {
                    bl.Client.Delete(id);
                    deleted.Visible = true;
                    MessageBox.Show("הלקוח נמחק בהצלחה");
                    deleted.Visible = false;
                    dataGridView1.DataSource = bl.Client.ReadAll();
                }
                else
                    MessageBox.Show("לא קיים לקוח זה");
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void deleted_Click(object sender, EventArgs e)
        {


        }

        private void filterClient_Click(object sender, EventArgs e)
        {
            string adress1 = inputAdress.Text;
            dataGridView1.DataSource = bl.Client.ReadAll(c => c.address.Equals(adress1));

        }

        private void cencel_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bl.Client.ReadAll();
            inputAdress.Text = string.Empty;
        }
    }
}
