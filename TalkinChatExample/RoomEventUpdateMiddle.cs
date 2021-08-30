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
    public partial class RoomEventUpdateMiddle : UserControl
    {
       

        private string eventMsg;
        public RoomEventUpdateMiddle(string key)
        {
            InitializeComponent();
            this.Name = key;
           
        }

        public string EventMsg
        {
            get
            {
                return eventMsg;
            }
            set
            {
                eventMsg = value;
                eventMsgLbl.UIThread(() => eventMsgLbl.Text = eventMsg);
            }
        }

        public Color EventColor
        {
            set
            {
                eventMsgLbl.UIThread(() => eventMsgLbl.ForeColor = value);
            }
        }

       
      
       
       

    }
}
