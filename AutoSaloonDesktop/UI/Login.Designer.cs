namespace AutoSaloonDesktop.UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginPicture = new System.Windows.Forms.PictureBox();
            this.LoginUserNameTextbox = new System.Windows.Forms.TextBox();
            this.UserNamePicture = new System.Windows.Forms.PictureBox();
            this.LoginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNamePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPicture
            // 
            this.LoginPicture.BackColor = System.Drawing.Color.Transparent;
            this.LoginPicture.BackgroundImage = global::AutoSaloonDesktop.Properties.Resources.loginImage;
            this.LoginPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.LoginPicture.Location = new System.Drawing.Point(4, 98);
            this.LoginPicture.Name = "LoginPicture";
            this.LoginPicture.Size = new System.Drawing.Size(400, 380);
            this.LoginPicture.TabIndex = 0;
            this.LoginPicture.TabStop = false;
            // 
            // LoginUserNameTextbox
            // 
            this.LoginUserNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginUserNameTextbox.Location = new System.Drawing.Point(518, 172);
            this.LoginUserNameTextbox.MaxLength = 100;
            this.LoginUserNameTextbox.Multiline = true;
            this.LoginUserNameTextbox.Name = "LoginUserNameTextbox";
            this.LoginUserNameTextbox.Size = new System.Drawing.Size(429, 35);
            this.LoginUserNameTextbox.TabIndex = 1;
            // 
            // UserNamePicture
            // 
            this.UserNamePicture.BackgroundImage = global::AutoSaloonDesktop.Properties.Resources.UserName;
            this.UserNamePicture.Location = new System.Drawing.Point(481, 168);
            this.UserNamePicture.MaximumSize = new System.Drawing.Size(36, 38);
            this.UserNamePicture.MinimumSize = new System.Drawing.Size(36, 38);
            this.UserNamePicture.Name = "UserNamePicture";
            this.UserNamePicture.Size = new System.Drawing.Size(36, 38);
            this.UserNamePicture.TabIndex = 2;
            this.UserNamePicture.TabStop = false;
            // 
            // LoginPasswordTextBox
            // 
            this.LoginPasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPasswordTextBox.Location = new System.Drawing.Point(518, 256);
            this.LoginPasswordTextBox.MaxLength = 100;
            this.LoginPasswordTextBox.Multiline = true;
            this.LoginPasswordTextBox.Name = "LoginPasswordTextBox";
            this.LoginPasswordTextBox.PasswordChar = '*';
            this.LoginPasswordTextBox.Size = new System.Drawing.Size(429, 35);
            this.LoginPasswordTextBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AutoSaloonDesktop.Properties.Resources.UserPassword;
            this.pictureBox1.Location = new System.Drawing.Point(481, 256);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(36, 38);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(36, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 38);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(120)))), ((int)(((byte)(175)))));
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginButton.Location = new System.Drawing.Point(777, 318);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(170, 35);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Signin";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(109)))), ((int)(((byte)(171)))));
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(898, 571);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 27);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::AutoSaloonDesktop.Properties.Resources.LoginBack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(973, 598);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LoginPasswordTextBox);
            this.Controls.Add(this.UserNamePicture);
            this.Controls.Add(this.LoginUserNameTextbox);
            this.Controls.Add(this.LoginPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(991, 645);
            this.MinimumSize = new System.Drawing.Size(991, 645);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.LoginPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserNamePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginPicture;
        private System.Windows.Forms.TextBox LoginUserNameTextbox;
        private System.Windows.Forms.PictureBox UserNamePicture;
        private System.Windows.Forms.TextBox LoginPasswordTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

