namespace UI
{
    partial class ProductManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManager));
            dataGridView1 = new DataGridView();
            label2 = new Label();
            added = new Label();
            add_product = new Button();
            label8 = new Label();
            amount = new NumericUpDown();
            label7 = new Label();
            price = new NumericUpDown();
            label6 = new Label();
            nameProduct = new TextBox();
            deleted = new Label();
            button1 = new Button();
            tabPage3 = new TabPage();
            numericUpDown1 = new TextBox();
            label5 = new Label();
            tabPage1 = new TabPage();
            category = new ComboBox();
            tabPage2 = new TabPage();
            productId = new TextBox();
            label12 = new Label();
            category2 = new ComboBox();
            label11 = new Label();
            button2 = new Button();
            label3 = new Label();
            amount1 = new NumericUpDown();
            label4 = new Label();
            price1 = new NumericUpDown();
            label9 = new Label();
            nameProduct1 = new TextBox();
            label10 = new Label();
            tabPage4 = new TabPage();
            button4 = new Button();
            button3 = new Button();
            categoryFilter = new ComboBox();
            tabControl1 = new TabControl();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)price).BeginInit();
            tabPage3.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amount1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)price1).BeginInit();
            tabPage4.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(296, 80);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 1;
            label2.Text = "בחר Id למחיקה";
            // 
            // added
            // 
            added.AutoSize = true;
            added.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            added.ForeColor = Color.Red;
            added.Location = new Point(45, 273);
            added.Name = "added";
            added.RightToLeft = RightToLeft.Yes;
            added.Size = new Size(218, 30);
            added.TabIndex = 9;
            added.Text = "המוצר נוסף בהצלחה!!";
            added.Visible = false;
            // 
            // add_product
            // 
            add_product.Location = new Point(455, 222);
            add_product.Name = "add_product";
            add_product.RightToLeft = RightToLeft.Yes;
            add_product.Size = new Size(91, 37);
            add_product.TabIndex = 8;
            add_product.Text = "הוסף מוצר";
            add_product.UseVisualStyleBackColor = true;
            add_product.Click += add_product_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(520, 176);
            label8.Name = "label8";
            label8.Size = new Size(67, 21);
            label8.TabIndex = 6;
            label8.Text = "קטגוריה";
            // 
            // amount
            // 
            amount.Location = new Point(379, 133);
            amount.Name = "amount";
            amount.Size = new Size(120, 23);
            amount.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(541, 138);
            label7.Name = "label7";
            label7.Size = new Size(46, 21);
            label7.TabIndex = 4;
            label7.Text = "כמות";
            // 
            // price
            // 
            price.Location = new Point(380, 98);
            price.Name = "price";
            price.Size = new Size(120, 23);
            price.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(538, 103);
            label6.Name = "label6";
            label6.Size = new Size(49, 21);
            label6.TabIndex = 2;
            label6.Text = " מחיר";
            // 
            // nameProduct
            // 
            nameProduct.Location = new Point(380, 60);
            nameProduct.Name = "nameProduct";
            nameProduct.Size = new Size(119, 23);
            nameProduct.TabIndex = 1;
            // 
            // deleted
            // 
            deleted.AutoSize = true;
            deleted.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            deleted.ForeColor = Color.Red;
            deleted.Location = new Point(247, 221);
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
            button1.Click += button1_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(numericUpDown1);
            tabPage3.Controls.Add(deleted);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(label2);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.RightToLeft = RightToLeft.Yes;
            tabPage3.Size = new Size(743, 333);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "מחיקה";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(318, 119);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(100, 23);
            numericUpDown1.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(553, 62);
            label5.Name = "label5";
            label5.Size = new Size(34, 21);
            label5.TabIndex = 0;
            label5.Text = "שם";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(category);
            tabPage1.Controls.Add(added);
            tabPage1.Controls.Add(add_product);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(amount);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(price);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(nameProduct);
            tabPage1.Controls.Add(label5);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(743, 333);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספה";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // category
            // 
            category.FormattingEnabled = true;
            category.Location = new Point(378, 174);
            category.Name = "category";
            category.Size = new Size(121, 23);
            category.TabIndex = 10;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(productId);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(category2);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(amount1);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(price1);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(nameProduct1);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(743, 333);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "עדכון";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // productId
            // 
            productId.Location = new Point(501, 72);
            productId.Name = "productId";
            productId.Size = new Size(100, 23);
            productId.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(607, 70);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.Yes;
            label12.Size = new Size(108, 21);
            label12.TabIndex = 20;
            label12.Text = "בחר ID לעדכון";
            // 
            // category2
            // 
            category2.FormattingEnabled = true;
            category2.Location = new Point(186, 178);
            category2.Name = "category2";
            category2.Size = new Size(121, 23);
            category2.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(38, 279);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.Yes;
            label11.Size = new Size(217, 30);
            label11.TabIndex = 18;
            label11.Text = "העדכון בוצע בהצלחה!";
            label11.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(245, 218);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(88, 37);
            button2.TabIndex = 17;
            button2.Text = "עדכן מוצר";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(316, 176);
            label3.Name = "label3";
            label3.Size = new Size(67, 21);
            label3.TabIndex = 15;
            label3.Text = "קטגוריה";
            // 
            // amount1
            // 
            amount1.Location = new Point(187, 140);
            amount1.Name = "amount1";
            amount1.Size = new Size(120, 23);
            amount1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(337, 142);
            label4.Name = "label4";
            label4.Size = new Size(46, 21);
            label4.TabIndex = 13;
            label4.Text = "כמות";
            // 
            // price1
            // 
            price1.Location = new Point(186, 103);
            price1.Name = "price1";
            price1.Size = new Size(120, 23);
            price1.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(334, 105);
            label9.Name = "label9";
            label9.Size = new Size(49, 21);
            label9.TabIndex = 11;
            label9.Text = " מחיר";
            // 
            // nameProduct1
            // 
            nameProduct1.Location = new Point(186, 64);
            nameProduct1.Name = "nameProduct1";
            nameProduct1.Size = new Size(119, 23);
            nameProduct1.TabIndex = 10;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(349, 66);
            label10.Name = "label10";
            label10.Size = new Size(34, 21);
            label10.TabIndex = 9;
            label10.Text = "שם";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(categoryFilter);
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(743, 333);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "הצג הכל";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(27, 262);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.Yes;
            button4.Size = new Size(74, 23);
            button4.TabIndex = 22;
            button4.Text = "ביטול";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(107, 262);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(74, 23);
            button3.TabIndex = 21;
            button3.Text = "סינון";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // categoryFilter
            // 
            categoryFilter.FormattingEnabled = true;
            categoryFilter.Location = new Point(40, 291);
            categoryFilter.Name = "categoryFilter";
            categoryFilter.Size = new Size(121, 23);
            categoryFilter.TabIndex = 20;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(23, 67);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(751, 361);
            tabControl1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(332, 22);
            label1.Name = "label1";
            label1.Size = new Size(147, 30);
            label1.TabIndex = 2;
            label1.Text = "תפריט מוצרים";
            // 
            // ProductManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "ProductManager";
            Text = "ProductManager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)price).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amount1).EndInit();
            ((System.ComponentModel.ISupportInitialize)price1).EndInit();
            tabPage4.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label2;
        private Label added;
        private Button add_product;
        private Label label8;
        private NumericUpDown amount;
        private Label label7;
        private NumericUpDown price;
        private Label label6;
        private TextBox nameProduct;
        private Label deleted;
        private Button button1;
        private TabPage tabPage3;
        private Label label5;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage4;
        private TabControl tabControl1;
        private Label label1;
        private Button button2;
        private Label label3;
        private NumericUpDown amount1;
        private Label label4;
        private NumericUpDown price1;
        private Label label9;
        private TextBox nameProduct1;
        private Label label10;
        private Label label11;
        private ComboBox category;
        private Label label12;
        private TextBox productId;
        private TextBox numericUpDown1;
        private ComboBox category2;
        private ComboBox categoryFilter;
        private Button button3;
        private Button button4;
    }
}