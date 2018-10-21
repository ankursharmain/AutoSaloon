namespace AutoSaloonDesktop.UI
{
    partial class Home
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.LoggedInUserNameLabel = new System.Windows.Forms.Label();
            this.FranchiseDetailButton = new System.Windows.Forms.Button();
            this.ProductCatalogButton = new System.Windows.Forms.Button();
            this.PackageCatalogButton = new System.Windows.Forms.Button();
            this.MyCustomerButton = new System.Windows.Forms.Button();
            this.InvoiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.Location = new System.Drawing.Point(36, 22);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(122, 29);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome";
            // 
            // LoggedInUserNameLabel
            // 
            this.LoggedInUserNameLabel.AutoSize = true;
            this.LoggedInUserNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInUserNameLabel.Location = new System.Drawing.Point(164, 22);
            this.LoggedInUserNameLabel.Name = "LoggedInUserNameLabel";
            this.LoggedInUserNameLabel.Size = new System.Drawing.Size(0, 29);
            this.LoggedInUserNameLabel.TabIndex = 1;
            // 
            // FranchiseDetailButton
            // 
            this.FranchiseDetailButton.BackColor = System.Drawing.Color.Honeydew;
            this.FranchiseDetailButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FranchiseDetailButton.Location = new System.Drawing.Point(31, 123);
            this.FranchiseDetailButton.Name = "FranchiseDetailButton";
            this.FranchiseDetailButton.Size = new System.Drawing.Size(127, 92);
            this.FranchiseDetailButton.TabIndex = 2;
            this.FranchiseDetailButton.Text = "Franchise Detail";
            this.FranchiseDetailButton.UseVisualStyleBackColor = false;
            this.FranchiseDetailButton.Click += new System.EventHandler(this.FranchiseDetailButton_Click);
            // 
            // ProductCatalogButton
            // 
            this.ProductCatalogButton.BackColor = System.Drawing.Color.Honeydew;
            this.ProductCatalogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCatalogButton.Location = new System.Drawing.Point(254, 123);
            this.ProductCatalogButton.Name = "ProductCatalogButton";
            this.ProductCatalogButton.Size = new System.Drawing.Size(127, 92);
            this.ProductCatalogButton.TabIndex = 3;
            this.ProductCatalogButton.Text = "Product Catalog";
            this.ProductCatalogButton.UseVisualStyleBackColor = false;
            this.ProductCatalogButton.Click += new System.EventHandler(this.ProductCatalogButton_Click);
            // 
            // PackageCatalogButton
            // 
            this.PackageCatalogButton.BackColor = System.Drawing.Color.Honeydew;
            this.PackageCatalogButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PackageCatalogButton.Location = new System.Drawing.Point(489, 123);
            this.PackageCatalogButton.Name = "PackageCatalogButton";
            this.PackageCatalogButton.Size = new System.Drawing.Size(127, 92);
            this.PackageCatalogButton.TabIndex = 4;
            this.PackageCatalogButton.Text = "Package Catalog";
            this.PackageCatalogButton.UseVisualStyleBackColor = false;
            this.PackageCatalogButton.Click += new System.EventHandler(this.PackageCatalogButton_Click);
            // 
            // MyCustomerButton
            // 
            this.MyCustomerButton.BackColor = System.Drawing.Color.Honeydew;
            this.MyCustomerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyCustomerButton.Location = new System.Drawing.Point(705, 123);
            this.MyCustomerButton.Name = "MyCustomerButton";
            this.MyCustomerButton.Size = new System.Drawing.Size(127, 92);
            this.MyCustomerButton.TabIndex = 5;
            this.MyCustomerButton.Text = "My Customer";
            this.MyCustomerButton.UseVisualStyleBackColor = false;
            this.MyCustomerButton.Click += new System.EventHandler(this.MyCustomerButton_Click);
            // 
            // InvoiceButton
            // 
            this.InvoiceButton.BackColor = System.Drawing.Color.Honeydew;
            this.InvoiceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceButton.Location = new System.Drawing.Point(31, 269);
            this.InvoiceButton.Name = "InvoiceButton";
            this.InvoiceButton.Size = new System.Drawing.Size(127, 92);
            this.InvoiceButton.TabIndex = 6;
            this.InvoiceButton.Text = "Invoice";
            this.InvoiceButton.UseVisualStyleBackColor = false;
            this.InvoiceButton.Click += new System.EventHandler(this.InvoiceButton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AutoSaloonDesktop.Properties.Resources.LoginBack;
            this.ClientSize = new System.Drawing.Size(1136, 602);
            this.Controls.Add(this.InvoiceButton);
            this.Controls.Add(this.MyCustomerButton);
            this.Controls.Add(this.PackageCatalogButton);
            this.Controls.Add(this.ProductCatalogButton);
            this.Controls.Add(this.FranchiseDetailButton);
            this.Controls.Add(this.LoggedInUserNameLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label LoggedInUserNameLabel;
        private System.Windows.Forms.Button FranchiseDetailButton;
        private System.Windows.Forms.Button ProductCatalogButton;
        private System.Windows.Forms.Button PackageCatalogButton;
        private System.Windows.Forms.Button MyCustomerButton;
        private System.Windows.Forms.Button InvoiceButton;
    }
}