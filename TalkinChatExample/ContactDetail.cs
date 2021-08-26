using Shaping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalkinClient;

namespace TalkinChatExample
{
    public partial class ContactDetail : Form
    {

        public ContactDetail(string username)
        {
            InitializeComponent();
            usernameLbl.Text="@" + username;
            TalkinChat chat = MainForm.Instance.Talkin;
            chat.OnGetUserProfile += OnGetUserProfile;
            chat.GetProfile(username);
        }

       
        private void OnGetUserProfile(TalkinChat talkin, TalkinClient.User.UserProfile profile)
        {
            if(profile!=null)
            {
                
                this.UIThread(() =>
                {
                    messageLbl.Text = profile.Status;
                    maleLbl.Text = profile.Gender.ToString();
                    ageLbl.Text = profile.Age.ToString();
                    friendsLbl.Text = profile.TotalRoster.ToString();
                    activityLbl.Text = profile.LastActivity;
                    createdLbl.Text = profile.RegistrationDate;

                 });
                if(profile.IsAgent)
                {
                    merchantLbl.UIThread(()=>merchantLbl.Visible= true);
                }
                else
                {
                    merchantLbl.UIThread(()=>merchantLbl.Visible= false);
                }

                if (string.IsNullOrWhiteSpace(profile.Country))
                {
                    countryLabel.UIThread(()=>countryLabel.Text= "N/A");
                }
                else
                {
                    try
                    {
                        RegionInfo region = new RegionInfo(profile.Country);
                        if (region != null)
                        {
                            countryLabel.UIThread(()=>countryLabel.Text= region.EnglishName);

                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                        Console.WriteLine("EX: " + ex.Message);
                    }
                   

                }
                if (profile.Gender==TalkinClient.User.Gender.NA)
                {
                    maleLbl.UIThread(()=>maleLbl.Text= "N/A");
                }
                if (string.IsNullOrWhiteSpace(profile.Age))
                {
                    ageLbl.UIThread(()=>ageLbl.Text= "N/A");
                }
                if (string.IsNullOrWhiteSpace(profile.LastActivity))
                {
                    activityLbl.UIThread(()=>activityLbl.Text= "N/A");
                }
                if(!string.IsNullOrWhiteSpace(profile.PhotoUrl))
                {
                    profilePicBox.LoadAsync(profile.PhotoUrl);
                }
                

            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath gr = RoundedRectangle.Create(profilePicBox.ClientRectangle, 36, RoundedRectangle.RectangleCorners.All);
            profilePicBox.Region = new Region(gr);


            base.OnPaint(e);
        }

        private void usernameLbl_TextChanged(object sender, EventArgs e)
        {
            usernameToolTip.SetToolTip(usernameLbl, usernameLbl.Text);
        }
    }
}
