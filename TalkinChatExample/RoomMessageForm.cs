using TalkinChatExample.Properties;
using MaterialSkin;
using MaterialSkin.Controls;
using Shaping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using TalkinClient;
using TalkinClient.ChatMessage;
using TalkinClient.MultiUserChat;
using TheArtOfDev.HtmlRenderer.WinForms;

namespace TalkinChatExample
{
    public partial class RoomMessageForm : MaterialSkin.Controls.MaterialForm
    {
        private TalkinChat talkin;
        private MainForm main;
        private int currentUsers=0;
        private int maxUsers=0;
        public RoomMessageForm()
        {
            InitializeComponent();
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green500, Primary.Green600, Accent.LightGreen200, TextShade.WHITE);
            this.talkin = MainForm.Instance.Talkin;
            this.main = MainForm.Instance;
            talkin.OnMucUserPresence += OnMucUserPresence;
            talkin.OnMucUserRoleChanged += OnMucUserRoleChanged;
            talkin.OnMucBoost += OnMucBoost;
            talkin.OnMucMessage += OnMucMessage;
            talkin.OnMucSubjectChanged += OnMucSubjectChanged;


        }
        private void OnMucSubjectChanged(TalkinChat talkin, MucSubject subject)
        {
            if (subject != null)
            {
                if (subject.MucName==this.Name)
                {
                    sujectChanged(subject);
                }
            }
        }
        private void OnMucMessage(TalkinChat talkin, MucMessage message)
        {
            if (message != null)
            {
                if (message.MucName ==this.Name)
                {
                    newMessage(message);
                }
            }
        }

        private void OnMucBoost(TalkinChat talkin, MucBoost mucBoost)
        {
            if (mucBoost != null)
            {
                if (mucBoost.MucName==this.Name)
                {
                    roomBoosted(mucBoost);
                }
            }
        }

        private void OnMucUserRoleChanged(TalkinChat talkin, MucRole mucRole)
        {
            if (mucRole != null)
            {
                if (mucRole.MucName==this.Name)
                {
                    userRoleChanged(mucRole);
                }
            }
        }

        private void OnMucUserPresence(TalkinChat talkin, MucUser mucUser)
        {
            if (mucUser != null)
            {
                if (mucUser.MucName==this.Name)
                {
                    roomPres(mucUser);
                }
            }
        }
        public int CurrentUsers
        {
            get
            {
                return currentUsers;
            }
            set
            {
                this.currentUsers = value;
                if (maxUsers == 0)
                {
                    currentUsersLbl.UIThread(() => this.currentUsersLbl.Text = "Current Users: " + currentUsers);

                }
                else
                {
                    currentUsersLbl.UIThread(() => this.currentUsersLbl.Text = "Current Users: (" + currentUsers + "/" + maxUsers + ")");

                }
                

            }
        }

        public int MaxUsers
        {
            get
            {
                return maxUsers;
            }
            set
            {
                this.maxUsers = value;
                currentUsersLbl.UIThread(() => this.currentUsersLbl.Text = "Current Users: (" + currentUsers + "/" + maxUsers + ")");

                

            }
        }
        public string RoomSuject
        {
           
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    chatPanel.UIThread(() => {
                        WebBrowser subject = new WebBrowser();
                        subject.Dock = DockStyle.Top;
                        subject.ScrollBarsEnabled = false;
                        subject.DocumentText = value;
                        chatPanel.Controls.Add(subject);
                    });


                }
               
                
            }
        }
        public string RoomName
        {
            get
            {
                return this.Name;
            }
            set
            {
                this.Name = value;
                roomNameLbl.UIThread(()=>this.roomNameLbl.Text = value);

            }
        }

        private void sujectChanged(MucSubject subject)
        {
            RoomSuject = subject.Message;
            RoomEventUpdateMiddle @event = new RoomEventUpdateMiddle(subject.Author);
            if (subject.Author == talkin.Username)
            {
                @event.EventMsg = "Subject published successfully.";
            }
            else
            {
                @event.EventMsg = "Subject published by " + subject.Author + ".";
            }
            chatPanel.UIThread(()=> chatPanel.Controls.Add(@event));
        }
        public void roomJoined(Muc muc)
        {
            if(muc!=null)
            {
                for (int i = 0; i < muc.MucUsers.Count; i++)
                {
                    MucUser user = muc.MucUsers.ElementAt(i).Value;
                    if (user != null)
                    {
                        RoomEventUpdateMiddle @event = new RoomEventUpdateMiddle(user.Username);
                        if (user.Username == talkin.Username)
                        {
                            @event.EventMsg = "you joined as " + user.Role + ".";
                        }
                        else
                        {
                            @event.EventMsg = user.Username + " is in room as " + user.Role + ".";
                        }
                        chatPanel.UIThread(()=>chatPanel.Controls.Add(@event));

                        if (roomUserPanel.Controls.ContainsKey(user.Username))
                        {
                            RoomUserItem item = (RoomUserItem)roomUserPanel.Controls[user.Username];
                            switch (user.Role)
                            {
                                case RoleType.creator:
                                    item.Tag = 0;
                                    item.IdColor = Color.OrangeRed;

                                    break;
                                case RoleType.owner:
                                    item.Tag = 1;
                                    item.IdColor = Color.Red;
                                    break;
                                case RoleType.admin:
                                    item.Tag = 2;
                                    item.IdColor = Color.Blue;
                                    break;
                                case RoleType.member:
                                    item.Tag = 3;
                                    item.IdColor = Color.Green;
                                    break;
                                case RoleType.none:
                                    item.Tag = 4;
                                    item.IdColor = Color.FromKnownColor(KnownColor.ControlText);
                                    break;
                                default:
                                    item.Tag = 5;
                                    item.IdColor = Color.FromKnownColor(KnownColor.DarkGray);
                                    break;
                            }
                            item.Username = user.Username;
                            item.Role = user.Role.ToString();

                        }
                        else
                        {
                            RoomUserItem item = new RoomUserItem(user.Username);
                            switch (user.Role)
                            {
                                case RoleType.creator:
                                    item.Tag = 0;
                                    item.IdColor = Color.OrangeRed;

                                    break;
                                case RoleType.owner:
                                    item.Tag = 1;
                                    item.IdColor = Color.Red;
                                    break;
                                case RoleType.admin:
                                    item.Tag = 2;
                                    item.IdColor = Color.Blue;
                                    break;
                                case RoleType.member:
                                    item.Tag = 3;
                                    item.IdColor = Color.Green;
                                    break;
                                case RoleType.none:
                                    item.Tag = 4;
                                    item.IdColor = Color.FromKnownColor(KnownColor.ControlText);
                                    break;
                                default:
                                    item.Tag = 5;
                                    item.IdColor = Color.FromKnownColor(KnownColor.DarkGray);
                                    break;
                            }

                            item.Username = user.Username;
                            item.Role = user.Role.ToString();
                            roomUserPanel.UIThread(()=>roomUserPanel.Controls.Add(item));

                        }


                    }
                }
                roomUserPanel.UIThread(() =>
                {

                    RoomUserItem[] itemArray = roomUserPanel.Controls.Cast<RoomUserItem>().OrderBy(x => x.Key).ToArray();
                    itemArray = roomUserPanel.Controls.Cast<RoomUserItem>().OrderBy(x => x.Tag).ToArray();
                    roomUserPanel.Controls.AddRange(itemArray);
                    talkin.GetMucInfo(muc.Name);

                });
            }

            
           
            
        }

        private void roomPres(MucUser user)
        {
            if (user != null)
            {
                RoomEventUpdateMiddle @event = new RoomEventUpdateMiddle(user.PacketID);
                if (user.Username == talkin.Username)
                {
                    if (user.IsJoined)
                    {
                        @event.EventMsg = "you joined as " + user.Role + ".";

                    }
                    else
                    {
                        @event.EventMsg = "you left.";
                    }
                }
                else
                {
                    if (user.IsJoined)
                    {
                        @event.EventMsg = user.Username + " is joined room as " + user.Role + ".";
                    }
                    else
                    {
                        @event.EventMsg = user.Username + " is left.";
                    }

                }
                chatPanel.UIThread(() => chatPanel.Controls.Add(@event));

                if (roomUserPanel.Controls.ContainsKey(user.Username))
                {
                    RoomUserItem item = (RoomUserItem)roomUserPanel.Controls[user.Username];
                    switch (user.Role)
                    {
                        case RoleType.creator:
                            item.Tag = 0;
                            item.IdColor = Color.OrangeRed;

                            break;
                        case RoleType.owner:
                            item.Tag = 1;
                            item.IdColor = Color.Red;
                            break;
                        case RoleType.admin:
                            item.Tag = 2;
                            item.IdColor = Color.Blue;
                            break;
                        case RoleType.member:
                            item.Tag = 3;
                            item.IdColor = Color.Green;
                            break;
                        case RoleType.none:
                            item.Tag = 4;
                            item.IdColor = Color.FromKnownColor(KnownColor.ControlText);
                            break;
                        default:
                            item.Tag = 5;
                            item.IdColor = Color.FromKnownColor(KnownColor.DarkGray);
                            break;
                    }
                    item.Username = user.Username;
                    item.Role = user.Role.ToString();

                }
                else
                {
                    RoomUserItem item = new RoomUserItem(user.Username);
                    switch (user.Role)
                    {
                        case RoleType.creator:
                            item.Tag = 0;
                            item.IdColor = Color.OrangeRed;

                            break;
                        case RoleType.owner:
                            item.Tag = 1;
                            item.IdColor = Color.Red;
                            break;
                        case RoleType.admin:
                            item.Tag = 2;
                            item.IdColor = Color.Blue;
                            break;
                        case RoleType.member:
                            item.Tag = 3;
                            item.IdColor = Color.Green;
                            break;
                        case RoleType.none:
                            item.Tag = 4;
                            item.IdColor = Color.FromKnownColor(KnownColor.ControlText);
                            break;
                        default:
                            item.Tag = 5;
                            item.IdColor = Color.FromKnownColor(KnownColor.DarkGray);
                            break;
                    }
                    item.Username = user.Username;
                    item.Role = user.Role.ToString();
                    roomUserPanel.UIThread(() => roomUserPanel.Controls.Add(item));

                }
                Muc muc = talkin.JoinedMuc(this.roomNameLbl.Text);
                if(muc!=null)
                {
                    CurrentUsers = muc.CurrentUsers.Count;

                }
                roomUserPanel.UIThread(() => {

                    RoomUserItem[] itemArray = roomUserPanel.Controls.Cast<RoomUserItem>().OrderBy(x => x.Key).ToArray();
                    itemArray = roomUserPanel.Controls.Cast<RoomUserItem>().OrderBy(x => x.Tag).ToArray();
                    roomUserPanel.Controls.AddRange(itemArray);

                });

            }
        }

        public void showRoomError(string mucName,string errorMsg)
        {
            this.UIThread(() => MessageBox.Show(errorMsg, mucName, MessageBoxButtons.OK, MessageBoxIcon.Error));

        }

        private void roomBoosted(MucBoost boost)
        {
            if (boost != null)
            {
                RoomEventUpdateMiddle @event = new RoomEventUpdateMiddle(boost.PacketID);
                if (boost.Actor == talkin.Username)
                {
                    @event.EventMsg = "Room boosted successfully.";

                }
                else
                {
                    @event.EventMsg = "Room boosted by " + boost.Actor + ".";


                }
                @event.EventColor = Color.Green;
                chatPanel.UIThread(()=>chatPanel.Controls.Add(@event));


            }
        }
        private void userRoleChanged(MucRole role)
        {
            if(role!=null)
            {
                RoomEventUpdateMiddle @event = new RoomEventUpdateMiddle(role.PacketID);
                if (role.User == talkin.Username)
                {

                    @event.EventMsg = "you are  " + role.NewRole + " by " + role.Actor + ".";
                }
                else
                {
                    if (role.Actor == talkin.Username)
                    {
                        @event.EventMsg = role.User + "is  " + role.NewRole + " by you.";
                    }
                    else
                    {
                        @event.EventMsg = role.User + "is  " + role.NewRole + " by " + role.Actor + ".";
                    }

                }
                chatPanel.UIThread(() => chatPanel.Controls.Add(@event));
                if (role.NewRole == RoleType.outcast)
                {
                    @event.EventColor = Color.Red;
                    if (roomUserPanel.Controls.ContainsKey(role.User))
                    {
                        roomUserPanel.UIThread(()=>roomUserPanel.Controls.RemoveByKey(role.User));
                    }
                }
                else
                if (roomUserPanel.Controls.ContainsKey(role.User))
                {
                    RoomUserItem item = (RoomUserItem)roomUserPanel.Controls[role.User];
                    switch (role.NewRole)
                    {
                        case RoleType.creator:
                            item.Tag = 0;
                            item.IdColor = Color.OrangeRed;

                            break;
                        case RoleType.owner:
                            item.Tag = 1;
                            item.IdColor = Color.Red;
                            break;
                        case RoleType.admin:
                            item.Tag = 2;
                            item.IdColor = Color.Blue;
                            break;
                        case RoleType.member:
                            item.Tag = 3;
                            item.IdColor = Color.Green;
                            break;
                        case RoleType.none:
                            item.Tag = 4;
                            item.IdColor = Color.FromKnownColor(KnownColor.ControlText);
                            break;
                        default:
                            item.Tag = 5;
                            item.IdColor = Color.FromKnownColor(KnownColor.DarkGray);
                            break;
                    }
                    item.Username = role.User;
                    item.Role = role.NewRole.ToString();

                }
                else
                {
                    RoomUserItem item = new RoomUserItem(role.User);
                    switch (role.NewRole)
                    {
                        case RoleType.creator:
                            item.Tag = 0;
                            item.IdColor = Color.OrangeRed;

                            break;
                        case RoleType.owner:
                            item.Tag = 1;
                            item.IdColor = Color.Red;
                            break;
                        case RoleType.admin:
                            item.Tag = 2;
                            item.IdColor = Color.Blue;
                            break;
                        case RoleType.member:
                            item.Tag = 3;
                            item.IdColor = Color.Green;
                            break;
                        case RoleType.none:
                            item.Tag = 4;
                            item.IdColor = Color.FromKnownColor(KnownColor.ControlText);
                            break;
                        default:
                            item.Tag = 5;
                            item.IdColor = Color.FromKnownColor(KnownColor.DarkGray);
                            break;
                    }
                    item.Username = role.User;
                    item.Role = role.NewRole.ToString();
                    roomUserPanel.UIThread(()=>roomUserPanel.Controls.Add(item));

                }
                Muc muc = talkin.JoinedMuc(this.roomNameLbl.Text);
                if (muc != null)
                {
                    CurrentUsers = muc.CurrentUsers.Count;

                }
                roomUserPanel.UIThread(() => {

                    RoomUserItem[] itemArray = roomUserPanel.Controls.Cast<RoomUserItem>().OrderBy(x => x.Key).ToArray();
                    itemArray = roomUserPanel.Controls.Cast<RoomUserItem>().OrderBy(x => x.Tag).ToArray();
                    roomUserPanel.Controls.AddRange(itemArray);

                });
            }
        }
        private void newMessage(MucMessage msg)
        {
            
            if(msg!=null)
            {
                if (msg != null)
                {
                    
                    string from = msg.From;
                    string body = msg.Body;
                    string picUrl = msg.ProfileUrl;
                    string idColor = msg.UserIDColor;
                    bool isAgent = msg.IsAgent;
                    string url = msg.FileUrl;
                    string msgID = msg.PacketID;
                    int length = msg.Length;
                    MessageMediaType mediaType = msg.MediaType;
                    if(!string.IsNullOrWhiteSpace(idColor))
                    {
                        if(roomUserPanel.Controls.ContainsKey(from))
                        {
                            RoomUserItem item = (RoomUserItem)roomUserPanel.Controls[from];
                            item.IdColorCode = idColor;
                        }
                    }

                    if (mediaType == MessageMediaType.text)
                    {

                        if (msg.From == talkin.Username)
                        {
                            if (chatPanel.Controls.ContainsKey(msgID))
                            {
                                RoomTextMessageControlRight right = (RoomTextMessageControlRight)chatPanel.Controls[msgID];
                                right.Username = "you";
                                right.Body = body;
                                right.PicUrl = picUrl;
                                right.IdColorCode = idColor;
                                right.MsgState = RoomTextMessageControlRight.MessageState.Sent;
                            }
                            else
                            {
                                RoomTextMessageControlRight right = new RoomTextMessageControlRight(msgID);
                                right.Username = "you";
                                right.Body = body;
                                right.PicUrl = picUrl;
                                right.IdColorCode = idColor;
                                right.MsgState = RoomTextMessageControlRight.MessageState.Sent;
                                chatPanel.UIThread(()=>chatPanel.Controls.Add(right));
                            }

                        }
                        else
                        {

                            RoomTextMessageControlLeft left = new RoomTextMessageControlLeft(msgID);
                            left.Username = from;
                            left.Body = body;
                            left.PicUrl = picUrl;
                            left.IdColorCode = idColor;
                            chatPanel.UIThread(()=>chatPanel.Controls.Add(left));

                        }
                    }
                    else
                    if (mediaType == MessageMediaType.audio)
                    {
                        if (msg.From == talkin.Username)
                        {
                            if (chatPanel.Controls.ContainsKey(msgID))
                            {
                                RoomAudioMessageControlRight right = (RoomAudioMessageControlRight)chatPanel.Controls[msgID];
                                right.Username = "you";
                                right.PicUrl = picUrl;
                                right.IdColorCode = idColor;
                                right.AudioDuration = length.ToString();
                                right.FileUrl = url;
                                right.MsgState = RoomAudioMessageControlRight.MessageState.Sent;
                            }
                            else
                            {
                                RoomAudioMessageControlRight right = new RoomAudioMessageControlRight(msgID);
                                right.Username = "you";
                                right.PicUrl = picUrl;
                                right.IdColorCode = idColor;
                                right.AudioDuration = length.ToString();
                                right.FileUrl = url;
                                right.MsgState = RoomAudioMessageControlRight.MessageState.Sent;
                                chatPanel.UIThread(()=>chatPanel.Controls.Add(right));
                            }




                        }
                        else
                        {
                            RoomAudioMessageControlLeft left = new RoomAudioMessageControlLeft(msgID);
                            left.Username = from;
                            left.PicUrl = picUrl;
                            left.IdColorCode = idColor;
                            left.AudioDuration = length.ToString();
                            left.FileUrl = url;
                            chatPanel.UIThread(()=>chatPanel.Controls.Add(left));

                        }
                    }
                    else
                    if(mediaType == MessageMediaType.image)
                    {

                        if (msg.From == talkin.Username)
                        {
                            if (chatPanel.Controls.ContainsKey(msgID))
                            {
                                RoomImageMessageControlRight right = (RoomImageMessageControlRight)chatPanel.Controls[msgID];
                                right.Username = "you";
                                right.PicUrl = picUrl;
                                right.IdColorCode = idColor;
                                right.FileUrl = url;
                                right.MsgState = RoomImageMessageControlRight.MessageState.Sent;

                            }
                            else
                            {
                                RoomImageMessageControlRight right = new RoomImageMessageControlRight(msgID);
                                right.Username = "you";
                                right.PicUrl = picUrl;
                                right.IdColorCode = idColor;
                                right.FileUrl = url;
                                right.MsgState = RoomImageMessageControlRight.MessageState.Sent;
                                chatPanel.UIThread(()=>chatPanel.Controls.Add(right));
                            }



                        }
                        else
                        {
                            RoomImageMessageControlLeft left = new RoomImageMessageControlLeft(msgID);
                            left.Username = from;
                            left.PicUrl = picUrl;
                            left.IdColorCode = idColor;
                            left.FileUrl = url;
                            chatPanel.UIThread(()=>chatPanel.Controls.Add(left));

                        }
                    }



                }

            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath gr = RoundedRectangle.Create(sendBtn.ClientRectangle, 24, RoundedRectangle.RectangleCorners.All);
            sendBtn.Region = new Region(gr);

            base.OnPaint(e);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(richTextBox1.Text==string.Empty)
            {
                richTextBox1.Text = "write a message...";
                richTextBox1.ForeColor = Color.DarkGray;
                richTextBox1.Select(0, 0);
                sendBtn.Image = Resources.attachments;
               
            }
            else
            if(richTextBox1.Text!="write a message...")
            {
                richTextBox1.Text = richTextBox1.Text.Replace("write a message...", "");
                richTextBox1.ForeColor = Color.Black;
                richTextBox1.Select(richTextBox1.Text.Length, richTextBox1.Text.Length);
                sendBtn.Image = Resources.send;
                

            }

        }

        private void richTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (richTextBox1.Text == "write a message...")
            {
                richTextBox1.Select(0, 0);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                if (!string.IsNullOrWhiteSpace(richTextBox1.Text) && richTextBox1.Text != "write a message...")
                {
                    talkin.SendMessageState(this.roomNameLbl.Text, StateType.paused);
                    sendMsg();
                }
            }
        }


        private void sendMsg()
        {
            string body = richTextBox1.Text;
            string msgID = "";
          //  long timestamp = (long)(DateTime.Now.Subtract(new DateTime(1970, 1, 1, 2, 30, 0).AddHours(5).AddMinutes(30))).TotalMilliseconds;
            if (!string.IsNullOrWhiteSpace(body))
            {
                if (body.StartsWith("http"))
                {
                    if (body.EndsWith(".png") || body.EndsWith(".jpg") || body.EndsWith(".jpeg") || body.EndsWith(".bmp"))
                    {
                        msgID = talkin.SendImage(roomNameLbl.Text, body,MessageType.MucMessage);
                        RoomImageMessageControlRight right = new RoomImageMessageControlRight(msgID);
                        right.Username = "you";
                        right.IdColorCode = "";
                        right.PicUrl = "";
                        right.FileUrl = body;
                        right.MsgState = RoomImageMessageControlRight.MessageState.Sending;
                        chatPanel.Controls.Add(right);
                    }
                    else
                    if(body.EndsWith(".mp3") || body.EndsWith(".wav")||body.EndsWith(".3gp") || body.EndsWith(".mp4"))
                    {
                        msgID = talkin.SendAudio(roomNameLbl.Text, body,new Random().Next(100,500),MessageType.MucMessage);
                        RoomAudioMessageControlRight right = new RoomAudioMessageControlRight(msgID);
                        right.Username = "you";
                        right.IdColorCode = "";
                        right.PicUrl = "";
                        right.FileUrl = body;
                        right.AudioDuration = 0.ToString();
                        right.MsgState = RoomAudioMessageControlRight.MessageState.Sending;
                        chatPanel.Controls.Add(right);
                    }
                    else
                    {

                        msgID = talkin.SendMessage(roomNameLbl.Text, body,MessageType.MucMessage);
                        RoomTextMessageControlRight right = new RoomTextMessageControlRight(msgID);
                        right.Username = "you";
                        right.IdColorCode = "";
                        right.PicUrl = "";
                        right.Body = body;
                        right.MsgState = RoomTextMessageControlRight.MessageState.Sending;
                        chatPanel.Controls.Add(right);
                    }

                }
                else
                {
                    msgID = talkin.SendMessage(roomNameLbl.Text, body,MessageType.MucMessage);
                    RoomTextMessageControlRight right = new RoomTextMessageControlRight(msgID);
                    right.Username = "you";
                    right.IdColorCode = "";
                    right.PicUrl = "";
                    right.Body = body;
                    right.MsgState = RoomTextMessageControlRight.MessageState.Sending;
                    chatPanel.Controls.Add(right);


                }

            }
        }
        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                richTextBox1.ResetText();
            }
        }

      
        private void chatPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            chatPanel.VerticalScroll.Value = chatPanel.VerticalScroll.Maximum;
        }

        private void RoomMessageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Control control in chatPanel.Controls)
            {
                if (control is AudioMessageControlLeft)
                {
                    RoomAudioMessageControlLeft left = (RoomAudioMessageControlLeft)control;
                    left.Player.controls.stop();

                }
                else
                if (control is AudioMessageControlRight)
                {
                    RoomAudioMessageControlLeft right = (RoomAudioMessageControlLeft)control;
                    right.Player.controls.stop();
                }
            }
            talkin.LeaveMuc(this.roomNameLbl.Text);
            main.removeRoomForm(this.roomNameLbl.Text);
        }
    }
}
