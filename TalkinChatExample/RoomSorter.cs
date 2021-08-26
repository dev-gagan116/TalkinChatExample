using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using TalkinClient.User;

namespace TalkinChatExample
{
    public class RoomSorter : IComparer
    {
        private bool sortByName;
        public RoomSorter(bool sortByName)
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
                
                if(xitem.ImageIndex<yitem.ImageIndex)
                {
                    return 1;
                }
                else
                if(yitem.ImageIndex<xitem.ImageIndex)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
                
            }
            
            
        }

       
    }
}
