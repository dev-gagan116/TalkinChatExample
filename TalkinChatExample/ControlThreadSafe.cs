using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalkinChatExample
{
    public static class ControlThreadSafe
    {
        
        public static void UIThread(this Control @this, Action code)
        {
            if (@this.InvokeRequired)
            {
                @this.Invoke(code);
            }
            else
            {
                code.Invoke();
            }
        }
    }
}
