namespace UI
{
    partial class ClientManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientManager));
            label1 = new Label();
            updated = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            address = new TextBox();
            phone = new TextBox();
            label12 = new Label();
            id = new TextBox();
            added = new Label();
            add_product = new Button();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            nameClient = new TextBox();
            label5 = new Label();
            tabPage2 = new TabPage();
            address1 = new TextBox();
            phone1 = new TextBox();
            label3 = new Label();
            clientId23 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            label9 = new Label();
            label10 = new Label();
            nameClient1 = new TextBox();
            label13 = new Label();
            tabPage3 = new TabPage();
            deleted = new Label();
            button1 = new Button();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            tabPage4 = new TabPage();
            cencel = new Button();
            filterClient = new Button();
            inputAdress = new TextBox();
            label11 = new Label();
            dataGridView1 = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(335, 22);
            label1.Name = "label1";
            label1.Size = new Size(150, 30);
            label1.TabIndex = 4;
            label1.Text = "רשימת לקוחות";
            // 
            // updated
            // 
            updated.AutoSize = true;
            updated.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            updated.ForeColor = Color.Red;
            updated.Location = new Point(216, 266);
            updated.Name = "updated";
            updated.RightToLeft = RightToLeft.Yes;
            updated.Size = new Size(217, 30);
            updated.TabIndex = 18;
            updated.Text = "העדכון בוצע בהצלחה!";
            updated.Visible = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(26, 68);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(754, 361);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(address);
            tabPage1.Controls.Add(phone);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(id);
            tabPage1.Controls.Add(added);
            tabPage1.Controls.Add(add_product);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(nameClient);
            tabPage1.Controls.Add(label5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(746, 333);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספה";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // address
            // 
            address.Location = new Point(400, 136);
            address.Name = "address";
            address.Size = new Size(100, 23);
            address.TabIndex = 13;
            // 
            // phone
            // 
            phone.Location = new Point(400, 176);
            phone.Name = "phone";
            phone.Size = new Size(100, 23);
            phone.TabIndex = 12;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(532, 176);
            label12.Name = "label12";
            label12.Size = new Size(48, 21);
            label12.TabIndex = 11;
            label12.Text = "טלפון";
            // 
            // id
            // 
            id.Location = new Point(400, 98);
            id.Name = "id";
            id.Size = new Size(100, 23);
            id.TabIndex = 10;
            // 
            // added
            // 
            added.AutoSize = true;
            added.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            added.ForeColor = Color.Red;
            added.Location = new Point(47, 276);
            added.Name = "added";
            added.RightToLeft = RightToLeft.Yes;
            added.Size = new Size(219, 30);
            added.TabIndex = 9;
            added.Text = "הלקוח נוסף בהצלחה!!";
            added.Visible = false;
            // 
            // add_product
            // 
            add_product.Location = new Point(442, 234);
            add_product.Name = "add_product";
            add_product.RightToLeft = RightToLeft.Yes;
            add_product.Size = new Size(89, 36);
            add_product.TabIndex = 8;
            add_product.Text = "הוסף לקוח";
            add_product.UseVisualStyleBackColor = true;
            add_product.Click += add_product_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(523, 133);
            label8.Name = "label8";
            label8.Size = new Size(57, 21);
            label8.TabIndex = 6;
            label8.Text = "כתובת";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(547, 133);
            label7.Name = "label7";
            label7.Size = new Size(0, 21);
            label7.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(547, 95);
            label6.Name = "label6";
            label6.Size = new Size(35, 21);
            label6.TabIndex = 2;
            label6.Text = "ת.ז.";
            // 
            // nameClient
            // 
            nameClient.Location = new Point(400, 61);
            nameClient.Name = "nameClient";
            nameClient.Size = new Size(100, 23);
            nameClient.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(547, 61);
            label5.Name = "label5";
            label5.Size = new Size(34, 21);
            label5.TabIndex = 0;
            label5.Text = "שם";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(address1);
            tabPage2.Controls.Add(phone1);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(clientId23);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(nameClient1);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(updated);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(746, 333);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "עדכון";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // address1
            // 
            address1.Location = new Point(198, 102);
            address1.Name = "address1";
            address1.Size = new Size(100, 23);
            address1.TabIndex = 28;
            // 
            // phone1
            // 
            phone1.Location = new Point(198, 142);
            phone1.Name = "phone1";
            phone1.Size = new Size(100, 23);
            phone1.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(330, 141);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 26;
            label3.Text = "טלפון";
            // 
            // clientId23
            // 
            clientId23.Location = new Point(456, 65);
            clientId23.Name = "clientId23";
            clientId23.Size = new Size(100, 23);
            clientId23.TabIndex = 25;
            // 
            // button2
            // 
            button2.Location = new Point(209, 190);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(89, 36);
            button2.TabIndex = 24;
            button2.Text = "עדכן לקוח";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(321, 99);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 23;
            label4.Text = "כתובת";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(345, 99);
            label9.Name = "label9";
            label9.Size = new Size(0, 21);
            label9.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(573, 65);
            label10.Name = "label10";
            label10.Size = new Size(120, 21);
            label10.TabIndex = 21;
            label10.Text = "הכנס ת'ז לעדכון";
            // 
            // nameClient1
            // 
            nameClient1.Location = new Point(198, 63);
            nameClient1.Name = "nameClient1";
            nameClient1.Size = new Size(100, 23);
            nameClient1.TabIndex = 20;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(345, 63);
            label13.Name = "label13";
            label13.Size = new Size(34, 21);
            label13.TabIndex = 19;
            label13.Text = "שם";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(deleted);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(label2);
            tabPage3.Controls.Add(numericUpDown1);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.RightToLeft = RightToLeft.Yes;
            tabPage3.Size = new Size(746, 333);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "מחיקה";
            // 
            // deleted
            // 
            deleted.AutoSize = true;
            deleted.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            deleted.ForeColor = Color.Red;
            deleted.Location = new Point(249, 224);
            deleted.Name = "deleted";
            deleted.Size = new Size(245, 30);
            deleted.TabIndex = 3;
            deleted.Text = "המחיקה בוצעה בהצלחה!";
            deleted.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(335, 148);
            button1.Name = "button1";
            button1.Size = new Size(65, 31);
            button1.TabIndex = 2;
            button1.Text = "מחק";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(298, 83);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 1;
            label2.Text = "בחר Id למחיקה";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(335, 119);
            numericUpDown1.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 111111, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(65, 23);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.Value = new decimal(new int[] { 111111, 0, 0, 0 });
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(cencel);
            tabPage4.Controls.Add(filterClient);
            tabPage4.Controls.Add(inputAdress);
            tabPage4.Controls.Add(label11);
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(746, 333);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "הצג הכל";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // cencel
            // 
            cencel.Location = new Point(15, 264);
            cencel.Name = "cencel";
            cencel.Size = new Size(75, 23);
            cencel.TabIndex = 4;
            cencel.Text = "ביטול";
            cencel.UseVisualStyleBackColor = true;
            cencel.Click += cencel_Click;
            // 
            // filterClient
            // 
            filterClient.Location = new Point(106, 264);
            filterClient.Name = "filterClient";
            filterClient.Size = new Size(75, 23);
            filterClient.TabIndex = 3;
            filterClient.Text = "סנן";
            filterClient.UseVisualStyleBackColor = true;
            filterClient.Click += filterClient_Click;
            // 
            // inputAdress
            // 
            inputAdress.Location = new Point(15, 235);
            inputAdress.Name = "inputAdress";
            inputAdress.Size = new Size(166, 23);
            inputAdress.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(15, 200);
            label11.Name = "label11";
            label11.Size = new Size(166, 25);
            label11.TabIndex = 1;
            label11.Text = "הכנס כתובת לסינון";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(740, 327);
            dataGridView1.TabIndex = 0;
            // 
            // ClientManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(807, 450);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClientManager";
            Text = "ClientManager";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label updated;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label added;
        private Label label7;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label deleted;
        private Button button1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private TabPage tabPage4;
        private DataGridView dataGridView1;
        private TextBox address;
        private TextBox phone;
        private Label label12;
        private TextBox id;
        private Button add_product;
        private Label label8;
        private Label label6;
        private TextBox nameClient;
        private Label label5;
        private TextBox address1;
        private TextBox phone1;
        private Label label3;
        private TextBox clientId23;
        private Button button2;
        private Label label4;
        private Label label9;
        private Label label10;
        private TextBox nameClient1;
        private Label label13;
        private Label label11;
        private Button cencel;
        private Button filterClient;
        private TextBox inputAdress;
    }
}