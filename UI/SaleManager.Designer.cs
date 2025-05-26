namespace UI
{
    partial class SaleManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleManager));
            label1 = new Label();
            tabPage4 = new TabPage();
            forClub = new CheckBox();
            button4 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            tabPage3 = new TabPage();
            deleted = new Label();
            button1 = new Button();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            tabPage2 = new TabPage();
            label5 = new Label();
            saleId = new TextBox();
            label4 = new Label();
            onlyForClub1 = new CheckBox();
            priceInSale1 = new NumericUpDown();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            DateEnd1 = new DateTimePicker();
            DateStart1 = new DateTimePicker();
            button2 = new Button();
            amount1 = new NumericUpDown();
            label15 = new Label();
            productId1 = new NumericUpDown();
            label16 = new Label();
            updated = new Label();
            tabPage1 = new TabPage();
            label11 = new Label();
            onlyForClub = new CheckBox();
            priceInSale = new NumericUpDown();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            DateEnd = new DateTimePicker();
            DateStart = new DateTimePicker();
            added = new Label();
            add_sale = new Button();
            amount = new NumericUpDown();
            label7 = new Label();
            productId = new NumericUpDown();
            label6 = new Label();
            tabControl1 = new TabControl();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceInSale1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amount1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productId1).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)priceInSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productId).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(332, 22);
            label1.Name = "label1";
            label1.Size = new Size(155, 30);
            label1.TabIndex = 4;
            label1.Text = "תפריט מבצעים";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(forClub);
            tabPage4.Controls.Add(button4);
            tabPage4.Controls.Add(button3);
            tabPage4.Controls.Add(dataGridView1);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(746, 333);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "הצג הכל";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // forClub
            // 
            forClub.AutoSize = true;
            forClub.Location = new Point(56, 241);
            forClub.Name = "forClub";
            forClub.Size = new Size(15, 14);
            forClub.TabIndex = 32;
            forClub.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(77, 267);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.Yes;
            button4.Size = new Size(49, 27);
            button4.TabIndex = 10;
            button4.Text = "ביטול";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(77, 234);
            button3.Name = "button3";
            button3.RightToLeft = RightToLeft.Yes;
            button3.Size = new Size(51, 27);
            button3.TabIndex = 9;
            button3.Text = "מועדון";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            deleted.Location = new Point(236, 221);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(299, 83);
            label2.Name = "label2";
            label2.Size = new Size(142, 25);
            label2.TabIndex = 1;
            label2.Text = "בחר Id למחיקה";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(335, 119);
            numericUpDown1.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(65, 23);
            numericUpDown1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(saleId);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(onlyForClub1);
            tabPage2.Controls.Add(priceInSale1);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(DateEnd1);
            tabPage2.Controls.Add(DateStart1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(amount1);
            tabPage2.Controls.Add(label15);
            tabPage2.Controls.Add(productId1);
            tabPage2.Controls.Add(label16);
            tabPage2.Controls.Add(updated);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(746, 333);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "עדכון";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(582, 71);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(113, 21);
            label5.TabIndex = 34;
            label5.Text = "הכנס id לעדכון";
            // 
            // saleId
            // 
            saleId.Location = new Point(456, 73);
            saleId.Name = "saleId";
            saleId.Size = new Size(120, 23);
            saleId.TabIndex = 33;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(367, 141);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(51, 21);
            label4.TabIndex = 32;
            label4.Text = "מועדון";
            // 
            // onlyForClub1
            // 
            onlyForClub1.AutoSize = true;
            onlyForClub1.Location = new Point(284, 148);
            onlyForClub1.Name = "onlyForClub1";
            onlyForClub1.Size = new Size(15, 14);
            onlyForClub1.TabIndex = 31;
            onlyForClub1.UseVisualStyleBackColor = true;
            // 
            // priceInSale1
            // 
            priceInSale1.Location = new Point(456, 171);
            priceInSale1.Name = "priceInSale1";
            priceInSale1.Size = new Size(120, 23);
            priceInSale1.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(605, 168);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(90, 21);
            label12.TabIndex = 29;
            label12.Text = "מחיר מבצע";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(329, 109);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.No;
            label13.Size = new Size(89, 21);
            label13.TabIndex = 28;
            label13.Text = "תאריך סיום";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(305, 75);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.No;
            label14.Size = new Size(113, 21);
            label14.TabIndex = 27;
            label14.Text = "תאריך התחלה";
            // 
            // DateEnd1
            // 
            DateEnd1.Location = new Point(99, 111);
            DateEnd1.Name = "DateEnd1";
            DateEnd1.Size = new Size(200, 23);
            DateEnd1.TabIndex = 26;
            // 
            // DateStart1
            // 
            DateStart1.Location = new Point(99, 75);
            DateStart1.Name = "DateStart1";
            DateStart1.Size = new Size(200, 23);
            DateStart1.TabIndex = 25;
            // 
            // button2
            // 
            button2.Location = new Point(175, 207);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.Yes;
            button2.Size = new Size(103, 46);
            button2.TabIndex = 24;
            button2.Text = "עדכן מבצע";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // amount1
            // 
            amount1.Location = new Point(456, 138);
            amount1.Name = "amount1";
            amount1.Size = new Size(120, 23);
            amount1.TabIndex = 23;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(595, 135);
            label15.Name = "label15";
            label15.Size = new Size(100, 21);
            label15.TabIndex = 22;
            label15.Text = "כמות למבצע";
            // 
            // productId1
            // 
            productId1.Location = new Point(456, 107);
            productId1.Name = "productId1";
            productId1.Size = new Size(120, 23);
            productId1.TabIndex = 21;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(590, 103);
            label16.Name = "label16";
            label16.Size = new Size(105, 21);
            label16.TabIndex = 20;
            label16.Text = "בחר קוד מוצר";
            // 
            // updated
            // 
            updated.AutoSize = true;
            updated.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            updated.ForeColor = Color.Red;
            updated.Location = new Point(61, 269);
            updated.Name = "updated";
            updated.RightToLeft = RightToLeft.Yes;
            updated.Size = new Size(217, 30);
            updated.TabIndex = 7;
            updated.Text = "העדכון בוצע בהצלחה!";
            updated.Visible = false;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label11);
            tabPage1.Controls.Add(onlyForClub);
            tabPage1.Controls.Add(priceInSale);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(DateEnd);
            tabPage1.Controls.Add(DateStart);
            tabPage1.Controls.Add(added);
            tabPage1.Controls.Add(add_sale);
            tabPage1.Controls.Add(amount);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(productId);
            tabPage1.Controls.Add(label6);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(746, 333);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "הוספה";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(288, 136);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(51, 21);
            label11.TabIndex = 17;
            label11.Text = "מועדון";
            // 
            // onlyForClub
            // 
            onlyForClub.AutoSize = true;
            onlyForClub.Location = new Point(233, 142);
            onlyForClub.Name = "onlyForClub";
            onlyForClub.Size = new Size(15, 14);
            onlyForClub.TabIndex = 16;
            onlyForClub.UseVisualStyleBackColor = true;
            // 
            // priceInSale
            // 
            priceInSale.Location = new Point(390, 142);
            priceInSale.Name = "priceInSale";
            priceInSale.Size = new Size(120, 23);
            priceInSale.TabIndex = 15;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(534, 141);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(90, 21);
            label10.TabIndex = 14;
            label10.Text = "מחיר מבצע";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(278, 100);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(89, 21);
            label9.TabIndex = 13;
            label9.Text = "תאריך סיום";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(254, 63);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(113, 21);
            label8.TabIndex = 12;
            label8.Text = "תאריך התחלה";
            // 
            // DateEnd
            // 
            DateEnd.Location = new Point(48, 99);
            DateEnd.Name = "DateEnd";
            DateEnd.Size = new Size(200, 23);
            DateEnd.TabIndex = 11;
            // 
            // DateStart
            // 
            DateStart.Location = new Point(48, 61);
            DateStart.Name = "DateStart";
            DateStart.Size = new Size(200, 23);
            DateStart.TabIndex = 10;
            // 
            // added
            // 
            added.AutoSize = true;
            added.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            added.ForeColor = Color.Red;
            added.Location = new Point(5, 291);
            added.Name = "added";
            added.RightToLeft = RightToLeft.Yes;
            added.Size = new Size(226, 30);
            added.TabIndex = 9;
            added.Text = "המבצע נוסף בהצלחה!!";
            added.Visible = false;
            // 
            // add_sale
            // 
            add_sale.Location = new Point(128, 217);
            add_sale.Name = "add_sale";
            add_sale.RightToLeft = RightToLeft.Yes;
            add_sale.Size = new Size(103, 46);
            add_sale.TabIndex = 8;
            add_sale.Text = "הוסף מבצע";
            add_sale.UseVisualStyleBackColor = true;
            add_sale.Click += add_product_Click;
            // 
            // amount
            // 
            amount.Location = new Point(390, 104);
            amount.Name = "amount";
            amount.Size = new Size(120, 23);
            amount.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(523, 104);
            label7.Name = "label7";
            label7.Size = new Size(100, 21);
            label7.TabIndex = 4;
            label7.Text = "כמות למבצע";
            // 
            // productId
            // 
            productId.Location = new Point(390, 67);
            productId.Name = "productId";
            productId.Size = new Size(120, 23);
            productId.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(521, 67);
            label6.Name = "label6";
            label6.Size = new Size(105, 21);
            label6.TabIndex = 2;
            label6.Text = "בחר קוד מוצר";
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
            tabControl1.Size = new Size(754, 361);
            tabControl1.TabIndex = 5;
            // 
            // SaleManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Name = "SaleManager";
            Text = "SaleManager";
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceInSale1).EndInit();
            ((System.ComponentModel.ISupportInitialize)amount1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productId1).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)priceInSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)amount).EndInit();
            ((System.ComponentModel.ISupportInitialize)productId).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabPage tabPage4;
        private DataGridView dataGridView1;
        private TabPage tabPage3;
        private Label deleted;
        private Button button1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private TabPage tabPage2;
        private Label updated;
        private TabPage tabPage1;
        private Label label11;
        private CheckBox onlyForClub;
        private NumericUpDown priceInSale;
        private Label label10;
        private Label label9;
        private Label label8;
        private DateTimePicker DateEnd;
        private DateTimePicker DateStart;
        private Label added;
        private Button add_sale;
        private NumericUpDown amount;
        private Label label7;
        private NumericUpDown productId;
        private Label label6;
        private TabControl tabControl1;
        private Label label4;
        private CheckBox onlyForClub1;
        private NumericUpDown priceInSale1;
        private Label label12;
        private Label label13;
        private Label label14;
        private DateTimePicker DateEnd1;
        private DateTimePicker DateStart1;
        private Button button2;
        private NumericUpDown amount1;
        private Label label15;
        private NumericUpDown productId1;
        private Label label16;
        private Label label5;
        private TextBox saleId;
        private Button button3;
        private Button button4;
        private CheckBox forClub;
    }
}