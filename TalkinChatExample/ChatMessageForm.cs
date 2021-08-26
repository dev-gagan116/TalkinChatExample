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
using System.Windows.Forms;
using TalkinClient;
using TalkinClient.ChatMessage;


namespace TalkinChatExample
{
    public partial class ChatMessageForm : MaterialSkin.Controls.MaterialForm
    {
        private TalkinChat talkin;
        private MainForm main;
        private Dictionary<string, TabPage> tabs = new Dictionary<string, TabPage>();
        private System.Timers.Timer typingTimer,stateTimer;
        private StateType stateType = StateType.paused;
        public ChatMessageForm()
        {
            InitializeComponent();
            MaterialSkinManager manager = MaterialSkinManager.Instance;
            manager.AddFormToManage(this);
            manager.Theme = MaterialSkinManager.Themes.LIGHT;
            manager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green500, Primary.Green600, Accent.LightGreen200, TextShade.WHITE);
            this.talkin = MainForm.Instance.Talkin;
            this.main = MainForm.Instance;
            typingTimer = new System.Timers.Timer(1000);
            stateTimer = new System.Timers.Timer(1000);
            stateTimer.Elapsed += StateTimer_Elapsed;
            typingTimer.Elapsed += TypingTimer_Elapsed;
            typingTimer.Enabled = false;
            stateTimer.Enabled = false;


        }

        private void StateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (stateType == StateType.writing)
            {
                talkin.SendMessageState(this.usernameLbl.Text, StateType.writing);
            }
            else
            if (stateType == StateType.paused)
            {
                talkin.SendMessageState(this.usernameLbl.Text, StateType.paused);
            }
            stateTimer.Stop();
            stateTimer.Enabled = false;
           
        }

        private void TypingTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
           
            if(!stateTimer.Enabled)
            {
                stateTimer.Enabled = true;
                stateTimer.Start();
            }
            stateType = StateType.paused;
            typingTimer.Stop();
            typingTimer.Enabled = false;



        }

        public void sentMsg(string id,long timeStamp)
        {
            if(chatPanel.Controls.ContainsKey(id))
            {

                if(chatPanel.Controls[id] is TextMessageControlRight)
                {
                    TextMessageControlRight right = (TextMessageControlRight)chatPanel.Controls[id];
                    right.MsgState = TextMessageControlRight.MessageState.Sent;
                    right.Time = timeStamp.ToString();

                }
                else
                if (chatPanel.Controls[id] is ImageMessageControlRight)
                {
                    ImageMessageControlRight right = (ImageMessageControlRight)chatPanel.Controls[id];
                    right.MsgState = ImageMessageControlRight.MessageState.Sent;
                    right.Time = timeStamp.ToString();

                }
                else
                if(chatPanel.Controls[id] is AudioMessageControlRight)
                {
                    AudioMessageControlRight right = (AudioMessageControlRight)chatPanel.Controls[id];
                    right.MsgState = AudioMessageControlRight.MessageState.Sent;
                    right.Time = timeStamp.ToString();
                }
            }
        }

        internal void msgState(MessageState state,string mode)
        {
            if(state!=null)
            {
                if (state.Type == StateType.writing)
                {

                    userStateLbl.UIThread(()=>userStateLbl.Text = "typing...");
                }
                else
                {
                    userStateLbl.UIThread(()=>userStateLbl.Text = mode);
                }
            }
        }

        public void msgAck(MessageAck ack)
        {
            string to = ack.To;
            string from = ack.From;
            string msgId = ack.MessageID;
            long timstamp = ack.Timestamp;
            if(to==talkin.Username)
            {

                if (chatPanel.Controls.ContainsKey(msgId))
                {
                    if (chatPanel.Controls[msgId] is TextMessageControlRight)
                    {
                        TextMessageControlRight right = (TextMessageControlRight)chatPanel.Controls[msgId];
                        if (ack.Type == AckType.delivery)
                        {
                            right.MsgState = TextMessageControlRight.MessageState.Delivered;

                        }
                        else
                        if (ack.Type == AckType.seen)
                        {
                            right.MsgState = TextMessageControlRight.MessageState.Read;

                        }
                        else
                        {
                            right.MsgState = TextMessageControlRight.MessageState.Error;

                        }
                        right.Time = timstamp.ToString();

                    }
                    else
                    if (chatPanel.Controls[msgId] is ImageMessageControlRight)
                    {
                        ImageMessageControlRight right = (ImageMessageControlRight)chatPanel.Controls[msgId];
                        if (ack.Type == AckType.delivery)
                        {
                            right.MsgState = ImageMessageControlRight.MessageState.Delivered;

                        }
                        else
                        if (ack.Type == AckType.seen)
                        {
                            right.MsgState = ImageMessageControlRight.MessageState.Read;

                        }
                        else
                        {
                            right.MsgState = ImageMessageControlRight.MessageState.Error;

                        }
                        right.Time = timstamp.ToString();

                    }
                    else
                    if(chatPanel.Controls[msgId] is AudioMessageControlRight)
                    {
                        AudioMessageControlRight right = (AudioMessageControlRight)chatPanel.Controls[msgId];
                        if (ack.Type == AckType.delivery)
                        {
                            right.MsgState = AudioMessageControlRight.MessageState.Delivered;

                        }
                        else
                        if (ack.Type == AckType.seen)
                        {
                            right.MsgState = AudioMessageControlRight.MessageState.Read;

                        }
                        else
                        {
                            right.MsgState = AudioMessageControlRight.MessageState.Error;

                        }
                        right.Time = timstamp.ToString();
                    }
                }
            }
            
            
        }
        public void newMessage(TalkinClient.ChatMessage.Message msg)
        {
            
            if(msg!=null)
            {
                if (msg != null)
                {
                    string to = msg.To;
                    string from = msg.From;
                    string body = msg.Body;
                    string url = msg.FileUrl;
                    string msgID = msg.PacketID;
                    int length = msg.Length;
                    MessageMediaType mediaType = msg.MediaType;

                    if (mediaType == MessageMediaType.text)
                    {

                        if (msg.From == talkin.Username)
                        {
                            TextMessageControlRight right = new TextMessageControlRight(msgID);
                            right.TextMsg = body;
                            right.Time = msg.Timestamp.ToString();
                            right.MsgState = TextMessageControlRight.MessageState.Sending;
                            chatPanel.UIThread(()=>chatPanel.Controls.Add(right));


                        }
                        else
                        {
                            TextMessageControlLeft left = new TextMessageControlLeft(msgID);

                            left.TextMsg = body;
                            left.Time = msg.Timestamp.ToString();
                            chatPanel.UIThread(()=>chatPanel.Controls.Add(left));
                            talkin.SendMessageAck(this.usernameLbl.Text, msgID, AckType.delivery);
                            talkin.SendMessageAck(this.usernameLbl.Text, msgID, AckType.seen);
                        }
                    }
                    else
                    if (mediaType == MessageMediaType.audio)
                    {
                        if (msg.From == talkin.Username)
                        {
                            TextMessageControlRight right = new TextMessageControlRight(msgID);

                            right.TextMsg = url;
                            right.Time = msg.Timestamp.ToString();
                            right.MsgState = TextMessageControlRight.MessageState.Sending;
                            chatPanel.UIThread(()=>chatPanel.Controls.Add(right));


                        }
                        else
                        {
                            AudioMessageControlLeft left = new AudioMessageControlLeft(msgID);

                            left.AudioDuration = length.ToString();
                            left.FileUrl = url;
                            left.Time = msg.Timestamp.ToString();
                            chatPanel.UIThread(()=>chatPanel.Controls.Add(left));
                            talkin.SendMessageAck(this.usernameLbl.Text, msgID, AckType.delivery);
                            talkin.SendMessageAck(this.usernameLbl.Text, msgID, AckType.seen);
                        }
                    }
                    else
                    if (mediaType == MessageMediaType.image)
                    {

                        if (msg.From == talkin.Username)
                        {
                            ImageMessageControlRight right = new ImageMessageControlRight(msgID);

                            right.ImageMsg = url;
                            right.Time = msg.Timestamp.ToString();
                            right.MsgState = ImageMessageControlRight.MessageState.Sending;
                            chatPanel.UIThread(()=>chatPanel.Controls.Add(right));


                        }
                        else
                        {
                            ImageMessageControlLeft left = new ImageMessageControlLeft(msgID);

                            left.FileUrl = url;
                            left.Time = msg.Timestamp.ToString();
                            chatPanel.UIThread(()=>chatPanel.Controls.Add(left));
                            talkin.SendMessageAck(this.usernameLbl.Text, msgID, AckType.delivery);
                            talkin.SendMessageAck(this.usernameLbl.Text, msgID, AckType.seen);
                        }
                    }



                }

            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath gr = RoundedRectangle.Create(userPic.ClientRectangle, 18, RoundedRectangle.RectangleCorners.All);
            userPic.Region = new Region(gr);
            gr = RoundedRectangle.Create(sendBtn.ClientRectangle, 24, RoundedRectangle.RectangleCorners.All);
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
                stateType = StateType.paused;
               
            }
            else
            if(richTextBox1.Text!="write a message...")
            {
                richTextBox1.Text = richTextBox1.Text.Replace("write a message...", "");
                richTextBox1.ForeColor = Color.Black;
                richTextBox1.Select(richTextBox1.Text.Length, richTextBox1.Text.Length);
                sendBtn.Image = Resources.send;
                
                stateType = StateType.writing;
                if(!typingTimer.Enabled)
                {
                    typingTimer.Enabled = true;
                    typingTimer.Start();

                }
                

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
                    talkin.SendMessageState(this.usernameLbl.Text, StateType.paused);
                    sendMsg();
                }
                    
                
            }
        }


        private void sendMsg()
        {
            string body = richTextBox1.Text;
            string msgID = "";
            long timestamp = (long)(DateTime.Now.Subtract(new DateTime(1970, 1, 1, 2, 30, 0).AddHours(5).AddMinutes(30))).TotalMilliseconds;
            if (!string.IsNullOrWhiteSpace(body))
            {
                if (body.StartsWith("http"))
                {
                    if (body.EndsWith(".png") || body.EndsWith(".jpg") || body.EndsWith(".jpeg") || body.EndsWith(".bmp"))
                    {
                        msgID = talkin.SendImage(usernameLbl.Text, body);
                        ImageMessageControlRight right = new ImageMessageControlRight(msgID);
                        
                        right.ImageMsg = body;
                        right.Time = timestamp.ToString();
                        right.MsgState = ImageMessageControlRight.MessageState.Sending;
                        chatPanel.Controls.Add(right);
                    }
                    else
                    if(body.EndsWith(".mp3") || body.EndsWith(".wav")||body.EndsWith(".3gp") || body.EndsWith(".mp4"))
                    {
                        msgID = talkin.SendAudio(usernameLbl.Text, body,new Random().Next(100,500));
                        AudioMessageControlRight right = new AudioMessageControlRight(msgID);
                        
                        right.FileUrl = body;
                        right.AudioDuration = 0.ToString();
                        right.Time = timestamp.ToString();
                        right.MsgState = AudioMessageControlRight.MessageState.Sending;
                        chatPanel.Controls.Add(right);
                    }
                    else
                    {

                        msgID = talkin.SendMessage(usernameLbl.Text, body);
                        TextMessageControlRight right = new TextMessageControlRight(msgID);
                        
                        right.TextMsg = body;
                        right.Time = timestamp.ToString();
                        right.MsgState = TextMessageControlRight.MessageState.Sending;
                        chatPanel.Controls.Add(right);
                    }

                }
                else
                {
                    msgID = talkin.SendMessage(usernameLbl.Text, body);
                    TextMessageControlRight right = new TextMessageControlRight(msgID);
                    
                    right.TextMsg = body;
                    right.Time = timestamp.ToString();
                    right.MsgState = TextMessageControlRight.MessageState.Sending;
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

        private void ChatMessageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Control control in chatPanel.Controls)
            {
                if (control is AudioMessageControlLeft)
                {
                    AudioMessageControlLeft left = (AudioMessageControlLeft)control;
                    left.Player.controls.stop();
         
                }
                else
                if (control is AudioMessageControlRight)
                {
                    AudioMessageControlRight right = (AudioMessageControlRight)control;
                    right.Player.controls.stop();
                }
            }
            main.removeChatForm(this.usernameLbl.Text);
            
        }

        private void chatPanel_ControlAdded(object sender, ControlEventArgs e)
        {
            chatPanel.VerticalScroll.Value = chatPanel.VerticalScroll.Maximum;
        }

        private void ChatMessageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
