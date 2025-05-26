namespace UI
{
    partial class Option
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Option));
            btnProduct = new Button();
            btnSale = new Button();
            btnClient = new Button();
            SuspendLayout();
            // 
            // btnProduct
            // 
            btnProduct.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduct.Location = new Point(390, 177);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(180, 64);
            btnProduct.TabIndex = 1;
            btnProduct.Text = "מוצרים";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnSale
            // 
            btnSale.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSale.Location = new Point(193, 176);
            btnSale.Name = "btnSale";
            btnSale.Size = new Size(180, 64);
            btnSale.TabIndex = 2;
            btnSale.Text = "מבצעים";
            btnSale.UseVisualStyleBackColor = true;
            btnSale.Click += btnSale_Click;
            // 
            // btnClient
            // 
            btnClient.BackgroundImage = (Image)resources.GetObject("btnClient.BackgroundImage");
            btnClient.Cursor = Cursors.SizeAll;
            btnClient.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnClient.Location = new Point(581, 177);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(180, 64);
            btnClient.TabIndex = 3;
            btnClient.Text = "לקוחות";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // Option
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClient);
            Controls.Add(btnSale);
            Controls.Add(btnProduct);
            Name = "Option";
            Text = "Option";
            ResumeLayout(false);
        }

        #endregion

        private Button btnProduct;
        private Button btnSale;
        private Button btnClient;
    }
}