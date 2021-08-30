using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using Shaping;
using TalkinClient;
using System.Reflection;

namespace TalkinChatExample
{
    public partial class RoomItem : UserControl
    {

       
        private TalkinChat talkin;
        private string roomName;
        private char roomPicText;
        private string roomUsers;
        private bool isRoomLocked;
        private bool isRoomMemberOnly;
        private bool isSearchResult;
        public RoomItem(string key)
        {
            InitializeComponent();
            this.Name = key;
            this.talkin = MainForm.Instance.Talkin;
            Random rd = new Random();
            int num = rd.Next(0, 9);
            Color backColor = Color.FromArgb(255, 255, 8, 0);
            Color foreColor = Color.White;
            switch (num)
            {
                case 1:
                    backColor = Color.FromArgb(255, 255, 149, 0);
                    break;
                case 2:
                    backColor = Color.FromArgb(255, 255, 247, 0);
                    foreColor = Color.Black;
                    break;
                case 3:
                    backColor = Color.FromArgb(255, 13, 255, 0);
                    foreColor = Color.Black;
                    break;
                case 4:
                    backColor = Color.FromArgb(255, 0, 255, 251);
                    foreColor = Color.Black;
                    break;
                case 5:
                    backColor = Color.FromArgb(255, 0, 13, 255);
                    break;
                case 6:
                    backColor = Color.FromArgb(255, 255, 0, 247);
                    foreColor = Color.Black;
                    break;
                case 7:
                    backColor = Color.FromArgb(255, 16, 143, 18);
                    break;
                case 8:
                    backColor = Color.FromArgb(255, 14, 116, 117);
                    break;
                case 9:
                    backColor = Color.FromArgb(255, 14, 33, 117);
                    break;
                default:
                    break;

            }
            roomIconLbl.UIThread(() => roomIconLbl.BackColor = backColor);
            roomIconLbl.UIThread(() => roomIconLbl.ForeColor = foreColor);


        }

        public string Key
        {
            get
            {
                return this.Name;
            }
        }

        public string RoomName
        {
            get
            {
                return roomName;
            }

            set
            {
                roomName = value;
                roomNameLbl.UIThread(() => roomNameLbl.Text = roomName);


            }
        }

        public char RoomPicText
        {
            get
            {
                return roomPicText;
            }

            set
            {
                roomPicText = value;
                roomIconLbl.UIThread(() => roomIconLbl.Text = roomPicText.ToString());
            }
        }

        public string RoomUsers
        {
            get
            {
                return roomUsers;
            }

            set
            {
                roomUsers = value;
                roomUsersLbl.UIThread(() => roomUsersLbl.Text = roomUsers);
            }
        }

        public bool IsRoomLocked
        {
            get
            {
                return isRoomLocked;
            }

            set
            {
                isRoomLocked = value;
                roomLockPic.UIThread(() => roomLockPic.Visible = isRoomLocked);
                if(isRoomLocked)
                {
                   this.UIThread(()=> lockedModeToolTip.SetToolTip(roomLockPic, "Room is password protected."));

                }

            }
        }

        public bool IsRoomMemberOnly
        {
            get
            {
                return isRoomMemberOnly;
            }

            set
            {
                isRoomMemberOnly = value;
                roomMemPic.UIThread(() => roomMemPic.Visible = isRoomMemberOnly);
                if(isRoomMemberOnly)
                {
                    this.UIThread(() => membersModeToolTip.SetToolTip(roomMemPic, "Only members can join."));
          
                }
            }
        }

        public bool IsSearchResult
        {
            get
            {
                return isSearchResult;
            }

            set
            {
                isSearchResult = value;

            }
        }

        private void joinRoomStripMenuItem_Click(object sender, EventArgs e)
        {
            if (talkin.IsLogged)
            {
                talkin.JoinMuc(this.roomNameLbl.Text);
                
            }
        }

        private void roomsMaterialContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
			roomsMaterialContextMenuStrip.Items["searchRoomToolStripMenuItem"].Visible = !isSearchResult;
            
        }

        private void searchRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomSearchForm form = new RoomSearchForm();
            form.Show();
        }

        private void roomNameLbl_TextChanged(object sender, EventArgs e)
        {
            roomNameToolTip.SetToolTip(roomNameLbl, roomNameLbl.Text);
        }
    }
}
