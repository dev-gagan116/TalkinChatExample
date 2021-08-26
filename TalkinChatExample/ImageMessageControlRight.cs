using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Drawing.Drawing2D;
using Shaping;
using TalkinChatExample.Properties;

namespace TalkinChatExample
{
    public partial class ImageMessageControlRight : UserControl
    {
        public enum MessageState
        {
            Sending,
            Sent,
            Delivered,
            Read,
            Error,
           
        }
       
        private MessageState currentMsgState = MessageState.Sending;

        public ImageMessageControlRight(string key)
        {
            InitializeComponent();
            this.Name = key;
            
      
        }



        public string ImageMsg
        {
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    this.imageMsg.LoadAsync(value);
                }
                
            }
        }

     

        public string Time
        {
            get
            {
                return timeLbl.Text;

            }
            set
            {
                if (value.All(Char.IsDigit))
                {
                    try
                    {
                        long timeStamp = 0;
                        long.TryParse(value, out timeStamp);
                        if(currentMsgState==MessageState.Sending)
                        {
                            DateTime dateTime = new DateTime(1970, 1, 1, 2, 30, 0, DateTimeKind.Utc);
                            DateTime time = dateTime.AddMilliseconds(timeStamp).AddHours(5).AddMinutes(30);
                            timeLbl.UIThread(() => timeLbl.Text = time.ToString("hh:mm tt").ToLower());


                        }
                        else
                        {
                            DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                            DateTime time = dateTime.AddMilliseconds(timeStamp).AddHours(5).AddMinutes(30);
                            timeLbl.UIThread(() => timeLbl.Text = time.ToString("hh:mm tt").ToLower());


                        }



                    }
                    catch (Exception)
                    {
                        this.UIThread(() => timeLbl.Text = "");


                    }
                }
            }
        }
       

        public MessageState MsgState
        {
            get
            {
                return this.currentMsgState;
            }
            set
            {
                this.currentMsgState = value;
                setMsgState();
            }
        }
        private void setMsgState()
        {
            switch (currentMsgState)
            {
                case MessageState.Sent:
                    {
                        msgStatePic.UIThread(()=>msgStatePic.Image = Resources.msg_sent);
                        break;
                    }
                case MessageState.Sending:
                    {
                        msgStatePic.UIThread(()=>msgStatePic.Image = Resources.msg_sending);
                        break;
                    }
                case MessageState.Delivered:
                    {
                        msgStatePic.UIThread(()=>msgStatePic.Image = Resources.msg_deliver);
                        break;
                    }
                case MessageState.Read:
                    {
                        msgStatePic.UIThread(()=>msgStatePic.Image = Resources.msg_read);
                        break;
                    }
              
                default:
                    msgStatePic.UIThread(()=>msgStatePic.Image = Resources.msg_error);
                    break;
                   

            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
           
            this.MinimumSize = new Size(0, msgContainer.Height + 10 + 15);
            this.Height = msgContainer.Height + 10 + 15;

            GraphicsPath path = RoundedRectangle.Create(msgContainer.ClientRectangle, 5, RoundedRectangle.RectangleCorners.All);
            msgContainer.Region = new Region(path);


            base.OnPaint(e);
        }
    }
}
