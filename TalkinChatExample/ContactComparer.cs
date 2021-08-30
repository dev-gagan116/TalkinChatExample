using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkinChatExample
{
    class ContactComparer : IComparer<ContactItem>
    {

        private bool sortByName;
        public ContactComparer(bool sortByName)
        {
            this.sortByName = sortByName;
        }
        public int Compare(ContactItem x, ContactItem y)
        {


            return 0;
        }
    }
}
