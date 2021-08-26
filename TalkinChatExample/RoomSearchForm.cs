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
using TalkinClient.MultiUserChat;

namespace TalkinChatExample
{
    public partial class RoomSearchForm : Form
    {
        private TalkinChat talkin;
        public RoomSearchForm()
        {
            InitializeComponent();
            talkin = MainForm.Instance.Talkin;
            talkin.OnMucSearchComplete += OnMucSearchComplete; ;
            
        }

        private void OnMucSearchComplete(TalkinChat talkin, TalkinClient.MultiUserChat.MucType mucType, List<TalkinClient.MultiUserChat.MucInfo> infoList)
        {
            if(mucType==MucType.search)
            {
                if (infoList != null && infoList.Count > 0)
                {
                    for (int i = 0; i < infoList.Count; i++)
                    {
                        MucInfo info = infoList[i];
                        if (info != null)
                        {
                            if (roomsPanel.Controls.ContainsKey(info.Name))
                            {
                                RoomItem item = (RoomItem)roomsPanel.Controls[info.Name];
                                item.RoomUsers = "(" + info.CurrentUsers + "/" + info.MaxUsers + ")";
                                item.IsRoomLocked = info.IsLocked;
                                item.IsRoomMemberOnly = info.IsMemberOnly;

                            }
                            else
                            {
                                RoomItem item = new RoomItem(info.Name);
                                item.RoomName = info.Name;
                                item.RoomPicText = info.Name[0];
                                item.RoomUsers = "(" + info.CurrentUsers + "/" + info.MaxUsers + ")";
                                item.IsRoomLocked = info.IsLocked;
                                item.IsRoomMemberOnly = info.IsMemberOnly;
                                roomsPanel.UIThread(() => roomsPanel.Controls.Add(item));
                            }
                        }

                    }

                }
            }
            
        }
        
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string text = searchTextField.Text;
            if(!string.IsNullOrWhiteSpace(text) && text.Length>=3)
            {
                if(talkin.IsLogged)
                {
                    roomsPanel.Controls.Clear();
                    talkin.SearchMuc(text);
                }
            }
        }
    }
}
