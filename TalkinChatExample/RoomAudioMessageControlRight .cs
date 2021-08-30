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
    public partial class RoomAudioMessageControlRight : UserControl
    {
        public enum MessageState
        {
            Sending,
            Sent
           
        }
      

        private MessageState currentMsgState = MessageState.Sending;
        private int duration = 0;
        private WindowsMediaPlayer player= new WindowsMediaPlayer();
        private bool isPlaying;

        private string picUrl;
        private string username;
        private string fileUrl;
        private string idColorCode;
        public RoomAudioMessageControlRight(string key)
        {
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
                username = value;
                usernameLbl.UIThread(() => usernameLbl.Text = username);
            }
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

        public string IdColorCode
        {
            get
            {
                return idColorCode;
            }

            set
            {
                idColorCode = value;
                if (!string.IsNullOrWhiteSpace(idColorCode))
                {
                    try
                    {
                        usernameLbl.UIThread(() => usernameLbl.ForeColor = ColorTranslator.FromHtml(idColorCode));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.StackTrace);
                    }
                }

            }

        }

        public string PicUrl
        {
            get
            {
                return picUrl;
            }

            set
            {
                picUrl = value;
                if (!string.IsNullOrWhiteSpace(picUrl))
                {
                    userPic.LoadAsync(picUrl);
                }
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
                durationProgress.UIThread(()=> durationProgress.Style = ProgressBarStyle.Continuous);
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
      

        public MessageState MsgState
        {
            get
            {
                return this.currentMsgState;
            }
            set
            {
                this.currentMsgState = value;
               
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
