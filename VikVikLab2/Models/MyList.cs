using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VikVikLab2.Models.Enities;

namespace VikVikLab2.Models
{
    public abstract class MyList : IList
    {
        protected class MyListElement
        {
            public MyListElement Next { get; set; }
            public MyItem Item { get; set; }
        }

        protected MyListElement head = null;

        public void AddElement(MyItem item)
        {
            head = new MyListElement
            {
                Item = item,
                Next = head
            }; 
        }

        public int Count()
        {
            int count = 0;
            MyListElement t = head;
            while(t != null)
            {
                count++;
                t = t.Next;
            }
            return count;
        }

        public abstract MyItem GetElement();

        public bool IsEmpty()
        {
            return head == null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            MyListElement el = head;
            while(el != null)
            {
                sb.Append(" { " + el.Item.ToString() + " } ");
                el = el.Next;
            }
            return sb.ToString();
        }

    }
}
