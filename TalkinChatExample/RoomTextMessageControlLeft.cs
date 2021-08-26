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
using System.Threading;

namespace TalkinChatExample
{
    public partial class RoomTextMessageControlLeft : UserControl
    {
       

        private string picUrl;
        private string username;
        private string body;
        private string idColorCode;

        public RoomTextMessageControlLeft(string key)
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

        public string Body
        {
            get
            {
                return body;
            }

            set
            {
                body = value;
                textMsgLbl.UIThread(() => textMsgLbl.Text = body);
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
     
       
        protected override void OnPaint(PaintEventArgs e)
        {
            
            this.MinimumSize = new Size(0, msgContainer.Height + 10 + 15);
            this.Height = msgContainer.Height + 10 + 15;
            GraphicsPath gr = RoundedRectangle.Create(panel2.ClientRectangle, 16, RoundedRectangle.RectangleCorners.All);
            panel2.Region = new Region(gr);

            GraphicsPath gr1 = RoundedRectangle.Create(userPic.ClientRectangle, 16, RoundedRectangle.RectangleCorners.All);
            userPic.Region = new Region(gr1);

            GraphicsPath path = RoundedRectangle.Create(msgContainer.ClientRectangle, 5, RoundedRectangle.RectangleCorners.All);
            msgContainer.Region = new Region(path);

            base.OnPaint(e);
        }

    }
}
