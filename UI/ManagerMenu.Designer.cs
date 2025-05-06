namespace UI
{
    partial class ManagerMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.add_product = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.nameProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.deleted = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.added = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(333, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "תפריט מנהל";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(24, 77);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 361);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.added);
            this.tabPage1.Controls.Add(this.add_product);
            this.tabPage1.Controls.Add(this.category);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.amount);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.price);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.nameProduct);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "הוספה";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // add_product
            // 
            this.add_product.Location = new System.Drawing.Point(455, 222);
            this.add_product.Name = "add_product";
            this.add_product.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.add_product.Size = new System.Drawing.Size(75, 23);
            this.add_product.TabIndex = 8;
            this.add_product.Text = "הוסף מוצר";
            this.add_product.UseVisualStyleBackColor = true;
            this.add_product.Click += new System.EventHandler(this.add_product_Click);
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Items.AddRange(new object[] {
            "LuxuryBeds",
            "Clothes\t",
            "Food",
            "Accessories",
            "CareProducts"});
            this.category.Location = new System.Drawing.Point(378, 171);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(121, 23);
            this.category.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(517, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "קטגוריה";
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(379, 133);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(120, 23);
            this.amount.TabIndex = 5;
            this.amount.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(538, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "כמות";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(380, 98);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(120, 23);
            this.price.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(535, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = " מחיר";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // nameProduct
            // 
            this.nameProduct.Location = new System.Drawing.Point(400, 61);
            this.nameProduct.Name = "nameProduct";
            this.nameProduct.Size = new System.Drawing.Size(100, 23);
            this.nameProduct.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(550, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "שם";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.numericUpDown2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "עדכון";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(257, 226);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(217, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "העדכון בוצע בהצלחה!";
            this.label3.Visible = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(342, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 31);
            this.button2.TabIndex = 6;
            this.button2.Text = "עדכן";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(300, 81);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "בחר Id לעדכון";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(342, 123);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(65, 23);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.deleted);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabPage3.Size = new System.Drawing.Size(746, 333);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "מחיקה";
            // 
            // deleted
            // 
            this.deleted.AutoSize = true;
            this.deleted.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.deleted.ForeColor = System.Drawing.Color.Red;
            this.deleted.Location = new System.Drawing.Point(244, 218);
            this.deleted.Name = "deleted";
            this.deleted.Size = new System.Drawing.Size(245, 30);
            this.deleted.TabIndex = 3;
            this.deleted.Text = "המחיקה בוצעה בהצלחה!";
            this.deleted.Visible = false;
            this.deleted.Click += new System.EventHandler(this.deleted_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(335, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "מחק";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(293, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "בחר Id למחיקה";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(335, 119);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(65, 23);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(746, 333);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "הצג הכל";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(740, 327);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // added
            // 
            this.added.AutoSize = true;
            this.added.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.added.ForeColor = System.Drawing.Color.Red;
            this.added.Location = new System.Drawing.Point(42, 270);
            this.added.Name = "added";
            this.added.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.added.Size = new System.Drawing.Size(218, 30);
            this.added.TabIndex = 9;
            this.added.Text = "המוצר נוסף בהצלחה!!";
            this.added.Visible = false;
            // 
            // ManagerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Name = "ManagerMenu";
            this.Text = "ManagerMenu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private DataGridView dataGridView1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private Label deleted;
        private Label label3;
        private Button button2;
        private Label label4;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private Label label6;
        private TextBox nameProduct;
        private NumericUpDown amount;
        private Label label7;
        private NumericUpDown price;
        private ComboBox category;
        private Label label8;
        private Button add_product;
        private Label added;
    }
}