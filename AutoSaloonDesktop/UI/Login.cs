using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLibrary.DataModel;
using DataLibrary.EntityModel;
using System.Configuration;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net.Http.Headers;

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
                LoginAction();

            }
        }

        private void LoginAction()
        {
            LoginDataModel loginData = new LoginDataModel();
            loginData.UserName = LoginUserNameTextbox.Text.Trim();
            loginData.Password = LoginPasswordTextBox.Text.Trim();

            string apiUrl = ConfigurationManager.AppSettings.Get("API_END_POINT"); //"http://localhost:26404/api/CustomerAPI";

            //string inputJson = (new JavaScriptSerializer()).Serialize(loginData);
            var inputJson = JsonConvert.SerializeObject(loginData);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(apiUrl);
            client.DefaultRequestHeaders.Accept.Clear();
            var buffer = System.Text.Encoding.UTF8.GetBytes(inputJson);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.PostAsync("api/AutoSaloonAPI/Authenticate", byteContent).Result;
            
            if (response.IsSuccessStatusCode)
            {
                var Json = response.Content.ReadAsStringAsync().Result;//response.Content.ReadAsStringAsync();

                LoginDetail loggedInUserDetails = (new JavaScriptSerializer()).Deserialize<List<LoginDetail>>(Json).FirstOrDefault();

                if (loggedInUserDetails != null)
                {

                }

            }
            else
            {
                MessageBox.Show("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);

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
