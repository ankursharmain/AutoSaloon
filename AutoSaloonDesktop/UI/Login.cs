using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSaloonDesktop.UI
{
    public partial class Login : Form
    {        
        bool IsFranchiseAdmin { get; set; }
        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (ValidateControls(sender))
            {

            }
        }

        private bool ValidateControls(object sender)
        {
            bool isValid = true;
            string messageString=string.Empty;

            isValid = MarkTextboxRequired(LoginUserNameTextbox, new PaintEventArgs((LoginUserNameTextbox as TextBox).CreateGraphics(), Rectangle.Empty));
            if (!isValid)
            {
                messageString = "UserName is empty.";
            }
            else
            {
                try
                {
                    var eMailValidator = new System.Net.Mail.MailAddress(LoginUserNameTextbox.Text.Trim());
                    isValid = true;
                }
                catch (FormatException ex)
                {
                    isValid = false;
                    messageString = "Invalid UserName. UserName should be registered email address.";
                }
            }


            isValid = MarkTextboxRequired(LoginPasswordTextBox, new PaintEventArgs((LoginPasswordTextBox as TextBox).CreateGraphics(), Rectangle.Empty));
            if (!isValid)
            {
                if (string.IsNullOrWhiteSpace(messageString))
                {
                    messageString = "Password is empty.";
                }
                else
                {
                    messageString = messageString+ "\nPassword is empty.";
                }
                
            }

            if (!string.IsNullOrWhiteSpace(messageString))
            {
                MessageBox.Show(messageString, "Required", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isValid = false;
            }
            return isValid;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to exit the application?", "Application Close", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result.ToString().ToLower().Equals("yes"))
            {
                Application.Exit(new CancelEventArgs(true));
            }
        }

        private bool MarkTextboxRequired(TextBox textBox, PaintEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text.Trim()))
            {
                ControlPaint.DrawBorder(e.Graphics, textBox.ClientRectangle, Color.DarkRed, ButtonBorderStyle.Solid);
                return false;
            }

            textBox.BorderStyle = BorderStyle.FixedSingle;
            return true;
        }
    }
}
