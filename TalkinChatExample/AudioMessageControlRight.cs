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
using WMPLib;
using System.Threading;

namespace TalkinChatExample
{
    public partial class AudioMessageControlRight : UserControl
    {
        public enum MessageState
        {
            Sending,
            Sent,
            Delivered,
            Read,
            Error,
           
        }
        private delegate void SetControlPropertyThreadSafeDelegate(Control control, string propertyName, object propertyValue);

     
        private MessageState currentMsgState = MessageState.Sending;
        private int duration = 0;
        private WindowsMediaPlayer player= new WindowsMediaPlayer();
        private bool isPlaying;
        private string fileUrl;

        public AudioMessageControlRight(string key)
        {
            InitializeComponent();
            this.Name = key;
      
        }



        public string FileUrl
        {
            get
            {
                return fileUrl;
            }
            set
            {
                fileUrl = value;
                
            }
        }

        private void Player_PlayStateChange(int NewState)
        {
            if (player.playState == WMPPlayState.wmppsPlaying)
            {
                if(duration==0)
                {
                    duration = (int)player.currentMedia.duration;
                    durationProgress.UIThread(() => durationProgress.Maximum = duration);



                }
                durationProgress.UIThread(()=>durationProgress.Style = ProgressBarStyle.Continuous);
                new Thread(new ThreadStart(() => {

                    int remainTime = duration;
                    for (int i = 1; i <= duration; i++)
                    {
                        if (isPlaying)
                        {
                            remainTime--;
                            var remainSpan = TimeSpan.FromSeconds(remainTime);
                            durationLbl.UIThread(() => durationLbl.Text = remainSpan.ToString(@"mm\:ss"));
                            durationProgress.UIThread(() => durationProgress.Value = i);
                            Thread.Sleep(1000);
                        }
                        else
                        {
                            break;
                        }


                    }
                    durationProgress.UIThread(() => durationProgress.Value = 0);
                    var timespan = TimeSpan.FromSeconds(duration);
                    durationLbl.UIThread(() => durationLbl.Text = timespan.ToString(@"mm\:ss"));



                })).Start();

            }
            else
            if (player.playState == WMPPlayState.wmppsMediaEnded)
            {
                isPlaying = false;
                player.controls.stop();
                durationProgress.UIThread(() => durationProgress.Style = ProgressBarStyle.Continuous);
                playBtn.UIThread(()=> playBtn.Image = Resources.play_icon);
            }
        }

        public string AudioDuration
        {
            get
            {
                return durationLbl.Text;
            }
            set
            {
                int.TryParse(value, out duration);
                if(duration>0)
                {
                    var timespan = TimeSpan.FromSeconds(duration);
                    durationLbl.UIThread(() => durationLbl.Text = timespan.ToString(@"mm\:ss"));
                    durationProgress.UIThread(() => durationProgress.Maximum = duration);

                }
                else
                {
                    durationLbl.UIThread(() => durationLbl.Text = "");

                }

            }
        }

        public WindowsMediaPlayer Player
        {
            get
            {
                return this.player;
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
                        timeLbl.UIThread(() => timeLbl.Text = "");

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

        private void playBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (isPlaying)
                {
                    isPlaying = false;
                    player.controls.stop();
                    playBtn.Image = Resources.play_icon;
                    durationProgress.Style = ProgressBarStyle.Continuous;
                    durationProgress.Value = 0;
                    player.PlayStateChange -= Player_PlayStateChange;
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(fileUrl))
                    {
                        isPlaying = true;
                        player = new WindowsMediaPlayer();
                        player.settings.autoStart = false;
                        player.URL = fileUrl.Trim();
                        player.PlayStateChange += Player_PlayStateChange;
                        player.controls.play();
                        playBtn.Image = Resources.pause_icon;
                        durationProgress.Style = ProgressBarStyle.Marquee;



                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("EX: " + ex.Message);
            }
        }
    }
}
