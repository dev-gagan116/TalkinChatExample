using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalkinClient;
using System.Reflection;

namespace TalkinChatExample
{
    public partial class LoginControl : UserControl
    {
        private TalkinChat talkin;
        private MainForm main;
            

        public LoginControl()
        {
            InitializeComponent();
            this.main = MainForm.Instance;
        }
       
        private void loginMe()
        {
            statusLbl.UIThread(() => statusLbl.Text = "Connecting...");
            MainTabControl tabControl = new MainTabControl();
            tabControl.Dock = DockStyle.Fill;
            talkin = main.Talkin;
            talkin.AutoReconnect = true;
            talkin.ReconnectInterval = 10000;
           /* talkin.OnWrite += (sender, str) =>
            {
                Console.WriteLine("WRITE: " + str);
                Console.WriteLine();
            };
            talkin.OnRead += (sender, str) =>
            {
                Console.WriteLine("READ: " + str);
                Console.WriteLine();
            };*/
            talkin.OnLogin += (talkin, authCode) =>
            {
                switch (authCode)
                {
                    case TalkinClient.User.AuthCode.Success:
                        this.UIThread(() => {

                            usernameTextBox.Enabled = false;
                            passTextBox.Enabled = false;
                            loginBtn.Enabled = false;
                            statusLbl.Text = "Login Success.";
                            statusLbl.ForeColor = Color.Green;
                            main.BaseContainer.Controls.Add(tabControl);
                            main.BaseContainer.Controls["LoginControl"].SendToBack();

                        });

                      
                        break;

                    case TalkinClient.User.AuthCode.Failed:
                        this.UIThread(() => {

                            usernameTextBox.Enabled = true;
                            passTextBox.Enabled = true;
                            loginBtn.Enabled = true;
                            statusLbl.Text = "Wrong Password.";
                            statusLbl.ForeColor = Color.Red;

                        });
                        break;

                    case TalkinClient.User.AuthCode.Disabled:
                        this.UIThread(() => {

                            usernameTextBox.Enabled = true;
                            passTextBox.Enabled = true;
                            loginBtn.Enabled = true;
                            statusLbl.Text = "Account has been disabled.";
                            statusLbl.ForeColor = Color.Black;

                        });
                        
                        break;
                    case TalkinClient.User.AuthCode.Error:
                        this.UIThread(() => {

                            usernameTextBox.Enabled = true;
                            passTextBox.Enabled = true;
                            loginBtn.Enabled = true;
                            statusLbl.Text = "Unable to login.";
                            statusLbl.ForeColor = Color.Black;

                        });
                        break;
                    default:
                        break;

                }


            };

            talkin.OnLogout += (talkin) =>
            {
                this.UIThread(() => {

                    usernameTextBox.Enabled = true;
                    passTextBox.Enabled = true;
                    loginBtn.Enabled = true;
                    statusLbl.Text = "Logged out.";
                    statusLbl.ForeColor = Color.Black;

                });
               
            };
            talkin.OnClose += (talkin) =>
            {
                this.UIThread(() => {

                    usernameTextBox.Enabled = true;
                    passTextBox.Enabled = true;
                    if(talkin.AutoReconnect)
                    {
                        loginBtn.Enabled = false;
                        statusLbl.Text = "Reconnecting...";
                    }
                    else
                    {
                        loginBtn.Enabled = true;
                        statusLbl.Text = "Disconnected";
                    }
                    loginBtn.Enabled = true;
                    statusLbl.ForeColor = Color.Black;

                });
               
            };
            talkin.OnError += (talkin, error) =>
            {
                this.UIThread(() => {

                    usernameTextBox.Enabled = true;
                    passTextBox.Enabled = true;
                    loginBtn.Enabled = true;
                    statusLbl.Text = "Error: "+error;
                    statusLbl.ForeColor = Color.Black;

                });
              
            };
           
 
            if (!string.IsNullOrWhiteSpace(usernameTextBox.Text) && !string.IsNullOrWhiteSpace(passTextBox.Text))
            {
                talkin.Login(usernameTextBox.Text, passTextBox.Text);
            }


        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (loginBtn.Text == "Sign In")
            {
                loginBtn.Enabled = false;
                loginMe();

            }
            else
            {
                if (talkin != null)
                {
                    talkin.Logout();
                    talkin = null;
                }
            }
        }
    }
}
