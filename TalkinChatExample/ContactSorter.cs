using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using TalkinClient.User;

namespace TalkinChatExample
{
    public class ContactSorter : IComparer
    {
        private bool sortByName;
        public ContactSorter(bool sortByName)
        {
            this.sortByName = sortByName;
        }
        public int Compare(object x, object y)
        {
            if(x==null && y==null)
            {
                return 0;
            }
            else
            if(x==null)
            {
                return -1;
            }
            else
            if(y==null)
            {
                return 1;
            }
            ListViewItem xitem = (ListViewItem)x;
            ListViewItem yitem = (ListViewItem)y;
            
            if(sortByName)
            {
                return string.Compare(xitem.Text, yitem.Text, false);
            }
            else
            {
                if(xitem.ImageIndex==1)
                {
                    xitem.ForeColor = System.Drawing.Color.Green;
                    return -1;
                }
                else
                if(yitem.ImageIndex==1)
                {
                    yitem.ForeColor = System.Drawing.Color.Green;
                    return 1;
                }
                else
                {
                    xitem.ForeColor = System.Drawing.Color.Black;
                    yitem.ForeColor = System.Drawing.Color.Black;
                    return 0;
                }
                
            }
            
            
        }

       
    }
}
