namespace UI
{
    partial class Seller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seller));
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            listBox2 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            sum = new Label();
            label5 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            AddProductBtn = new Button();
            label6 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label7 = new Label();
            ClientId = new TextBox();
            button3 = new Button();
            label8 = new Label();
            amount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(345, 18);
            label1.Name = "label1";
            label1.Size = new Size(125, 30);
            label1.TabIndex = 1;
            label1.Text = "תפריט מוכר";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(41, 147);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.Yes;
            listBox1.Size = new Size(146, 244);
            listBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(59, 122);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 3;
            label2.Text = "רשימת מוצרים בהזמנה";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(193, 147);
            listBox2.Name = "listBox2";
            listBox2.RightToLeft = RightToLeft.Yes;
            listBox2.Size = new Size(146, 244);
            listBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(210, 122);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 5;
            label3.Text = "רשימת מבצעים בהזמנה";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(101, 52);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 6;
            label4.Text = "סכום סופי לתשלום";
            // 
            // sum
            // 
            sum.AutoSize = true;
            sum.Location = new Point(57, 52);
            sum.Name = "sum";
            sum.Size = new Size(38, 15);
            sum.TabIndex = 7;
            sum.Text = "label5";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(625, 122);
            label5.Name = "label5";
            label5.Size = new Size(148, 15);
            label5.TabIndex = 9;
            label5.Text = "בחירה מתוך רשימת מוצרים";
            // 
            // button1
            // 
            button1.Location = new Point(306, 406);
            button1.Name = "button1";
            button1.Size = new Size(203, 32);
            button1.TabIndex = 10;
            button1.Text = "ביצוע הזמנה";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(345, 147);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(428, 244);
            dataGridView1.TabIndex = 11;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(434, 118);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(75, 23);
            AddProductBtn.TabIndex = 12;
            AddProductBtn.Text = "הוסף מוצר להזמנה";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Location = new Point(712, 52);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(76, 15);
            label6.TabIndex = 13;
            label6.Text = "בחירה ע\"פ Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(606, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 14;
            // 
            // button2
            // 
            button2.Location = new Point(525, 52);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 15;
            button2.Text = "הוסף מוצר להזמנה";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(363, 82);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.Yes;
            label7.Size = new Size(108, 17);
            label7.TabIndex = 16;
            label7.Text = "הכנס id של לקוח";
            // 
            // ClientId
            // 
            ClientId.Location = new Point(363, 114);
            ClientId.Name = "ClientId";
            ClientId.Size = new Size(112, 23);
            ClientId.TabIndex = 17;
            // 
            // button3
            // 
            button3.Location = new Point(363, 147);
            button3.Name = "button3";
            button3.Size = new Size(108, 37);
            button3.TabIndex = 18;
            button3.Text = "התחל הזמנה";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(631, 84);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.Yes;
            label8.Size = new Size(59, 15);
            label8.TabIndex = 19;
            label8.Text = "בחר כמות";
            // 
            // amount
            // 
            amount.Location = new Point(525, 81);
            amount.Name = "amount";
            amount.Size = new Size(100, 23);
            amount.TabIndex = 20;
            amount.Text = "1";
            // 
            // Seller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(amount);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(ClientId);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Controls.Add(AddProductBtn);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(sum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Seller";
            Text = "Seller";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private ListBox listBox2;
        private Label label3;
        private Label label4;
        private Label sum;
        private Label label5;
        private Button button1;
        private DataGridView dataGridView1;
        private Button AddProductBtn;
        private Label label6;
        private TextBox textBox1;
        private Button button2;
        private Label label7;
        private TextBox ClientId;
        private Button button3;
        private Label label8;
        private TextBox amount;
    }
}