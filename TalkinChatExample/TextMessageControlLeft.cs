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

namespace TalkinChatExample
{
    public partial class TextMessageControlLeft : UserControl
    {
       
        public TextMessageControlLeft(string key)
        {
            InitializeComponent();
            this.Name = key;
           
        }

        public string TextMsg
        {
            get
            {
                return this.textMsgLbl.Text;
            }
            set
            {
                textMsgLbl.UIThread(() => textMsgLbl.Text = value);
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
                        DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                        DateTime time = dateTime.AddMilliseconds(timeStamp).AddHours(5).AddMinutes(30);
                        timeLbl.UIThread(() => timeLbl.Text = time.ToString("hh:mm tt").ToLower());



                    }
                    catch (Exception)
                    {
                        timeLbl.UIThread(() => timeLbl.Text = "");

                    }
                }
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
