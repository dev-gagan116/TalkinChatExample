using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Shaping;
using TalkinChatExample.Properties;
using TalkinClient;
using System;
using System.Threading;

namespace TalkinChatExample
{
    public partial class ContactItem : UserControl
    {

        private TalkinChat talkin;
        private MainForm main;
        private string username;
        private string message;
        private string picUrl;
        private bool isOnline;
        private string mode;
        private string lastSeen;
        public ContactItem(string key)
        {
            this.main = MainForm.Instance;
            this.talkin = main.Talkin;

            InitializeComponent();
            this.Name = key;
            
            
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

        public string LastSeen
        {
            get
            {
                return this.lastSeen;
            }
            set
            {
                this.lastSeen = value;
            }
        }

        public string Mode

        {
            get
            {
                return this.mode;
            }
            set
            {
                this.mode = value;
                switch(mode)
                {
                    case "blocked":
                        modePic.UIThread(()=>modePic.Image = Resources.blockedIcon);
                        break;
                    case "pending":
                        modePic.UIThread(() => modePic.Image = Resources.pendingIcon);
                        break;
                    case "offline":
                        modePic.UIThread(() => modePic.Image = Resources.offlineIcon);
                        break;
                    case "online":
                        modePic.UIThread(() => modePic.Image = Resources.onlineIcon);
                        break;
                    default:
                        break;
                }
                
            }

        }
       
        public string Key
        {
            get
            {
                return this.Name;
            }
           
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
                usernameLbl.UIThread(() => usernameLbl.Text = username);
            }
        }

        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
                messageLbl.UIThread(() => messageLbl.Text = message);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath gr = RoundedRectangle.Create(userPic.ClientRectangle, 16, RoundedRectangle.RectangleCorners.All);
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

        private void deleteToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if(talkin.IsLogged)
            {
                talkin.RejectFriendRequest(usernameLbl.Text);
                talkin.DeleteFriend(usernameLbl.Text);
                this.Parent.Controls.RemoveByKey(this.Name);
            }
        }
        private void blockToolStripMenuItem_Click(object sender,System.EventArgs e)
        {
            if(talkin.IsLogged)
            {
                talkin.BlockUser(usernameLbl.Text);
                talkin.GetBlockedList();
            }
        }

        private void contactsMaterialContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {


            if ((int)Tag==-1)
            {
                contactsMaterialContextMenuStrip.Items["acceptReqStripMenuItem"].Visible = true;
                contactsMaterialContextMenuStrip.Items["blockToolStripMenuItem"].Visible = true;
                contactsMaterialContextMenuStrip.Items["openChatToolStripMenuItem"].Visible = true;
                contactsMaterialContextMenuStrip.Items["unblockToolStripMenuItem"].Visible = false;

            }
            else
            if((int)Tag<=-9)
            {
                contactsMaterialContextMenuStrip.Items["acceptReqStripMenuItem"].Visible = false;
                contactsMaterialContextMenuStrip.Items["blockToolStripMenuItem"].Visible = false;
                contactsMaterialContextMenuStrip.Items["openChatToolStripMenuItem"].Visible = false;
                contactsMaterialContextMenuStrip.Items["unblockToolStripMenuItem"].Visible = true;

            }
            else
            {
                contactsMaterialContextMenuStrip.Items["acceptReqStripMenuItem"].Visible = false;
                contactsMaterialContextMenuStrip.Items["blockToolStripMenuItem"].Visible = true;
                contactsMaterialContextMenuStrip.Items["openChatToolStripMenuItem"].Visible = true;
                contactsMaterialContextMenuStrip.Items["unblockToolStripMenuItem"].Visible = false;
            }
        }

        private void acceptReqStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if(talkin.IsLogged)
            {
                talkin.AcceptFriendRequest(usernameLbl.Text);
            }
        }

        private void unblockToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            if (talkin.IsLogged)
            {
                talkin.UnblockUser(usernameLbl.Text);
                
                
            }
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
                    new Thread(new ThreadStart(() => {

                        form.userPic.LoadAsync(picUrl);

                    })).Start();
                }

            }
            form.Show();
            main.addChatForm(this.usernameLbl.Text, form);
        }

        private void usernameLbl_TextChanged(object sender, EventArgs e)
        {
            usernameToolTip.SetToolTip(usernameLbl, usernameLbl.Text);
        }

        private void modePic_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            switch (mode)
            {
                case "blocked":
                    modeToolTip.SetToolTip(modePic, usernameLbl.Text+" is blocked.");
                    break;
                case "pending":
                    modeToolTip.SetToolTip(modePic, "Awaiting Confirmation?");
                    break;
                case "offline":
                    if(string.IsNullOrWhiteSpace(lastSeen))
                    {
                        modeToolTip.SetToolTip(modePic, usernameLbl.Text + " is offline.");

                    }
                    else
                    {
                        modeToolTip.SetToolTip(modePic, "lastseen: "+lastSeen);
                    }
                   
                    break;
                case "online":
                    modeToolTip.SetToolTip(modePic, usernameLbl.Text + " is online.");
                    break;
                default:
                    break;
            }
        }
    }
}
