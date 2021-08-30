using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Shaping;
using TalkinChatExample.Properties;
using TalkinClient;
using System;
using System.Threading;
using System.Reflection;

namespace TalkinChatExample
{
    public partial class RoomUserItem : UserControl
    {
        private TalkinChat talkin;
        private MainForm main;
        private string picUrl;
        private bool isOnline;
        private string username;
        private string role;
        private string idColorCode;
        private Color idColor;

        public RoomUserItem(string key)
        {
            this.main = MainForm.Instance;
            this.talkin = main.Talkin;

            InitializeComponent();
            this.Name = key;
            
            
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                this.username = value;
                usernameLbl.UIThread(() => usernameLbl.Text=username);
                
            }
        }

        public Color IdColor
        {
            get
            {
                return idColor;
            }
            set
            {
                this.idColor = value;
                usernameLbl.UIThread(() => usernameLbl.ForeColor = idColor);
                
            }
        }
        public string IdColorCode
        {
            get
            {
                return idColorCode;
            }
            set
            {
                this.idColorCode = value;
                if (!string.IsNullOrWhiteSpace(idColorCode))
                {
                    usernameLbl.UIThread(()=>usernameLbl.ForeColor = ColorTranslator.FromHtml(idColorCode));
                }
            }
        }
        public string Role
        {
            get
            {
                return role;
            }
            set
            {
                this.role = value;
                roleLbl.UIThread(() => roleLbl.Text= role);
                
            }
        }
        public string PicUrl
        {
            get
            {
                return this.picUrl;
            }
            set
            {
                this.picUrl = value;
                if (!string.IsNullOrWhiteSpace(value))
                {
                    userPic.LoadAsync(value);
                }
            }
        }
        public bool IsOnline
        {
            get
            {
                return this.isOnline;
            }
            set
            {
                this.isOnline = value;
            }
        }

       
        public string Key
        {
            get
            {
                return this.Name;
            }
           
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath gr = RoundedRectangle.Create(userPic.ClientRectangle, 12, RoundedRectangle.RectangleCorners.All);
            userPic.Region = new Region(gr);
            base.OnPaint(e);
        }

        private void openChatToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            ChatMessageForm form = main.getChatForm(this.usernameLbl.Text);
            if (form == null)
            {
                form = new ChatMessageForm();
                form.usernameLbl.Text = this.usernameLbl.Text;
                form.userStateLbl.Text = isOnline?"online": "offline";
                if (!string.IsNullOrWhiteSpace(picUrl))
                {
                    form.userPic.LoadAsync(picUrl);

                }
            }
            form.Show();
            main.addChatForm(this.usernameLbl.Text, form);
        }

        private void viewProfileToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if(talkin.IsLogged)
            {
                ContactDetail contactDetail = new ContactDetail(usernameLbl.Text);
                contactDetail.Show();
            }
        }

        private void contactsMaterialContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
        
        private void ContactItem_DoubleClick(object sender, EventArgs e)
        {
            ChatMessageForm form = main.getChatForm(this.usernameLbl.Text);
            if (form == null)
            {
                form = new ChatMessageForm();
                form.usernameLbl.Text = this.usernameLbl.Text;
                form.userStateLbl.Text = isOnline ? "online" : "offline";
                if (!string.IsNullOrWhiteSpace(picUrl))
                {
                    form.userPic.LoadAsync(picUrl);

                }

            }
            form.Show();
            main.addChatForm(this.usernameLbl.Text, form);
        }

        private void usernameLbl_TextChanged(object sender, EventArgs e)
        {
            usernameToolTip.SetToolTip(usernameLbl, usernameLbl.Text);
        }
    }
}
