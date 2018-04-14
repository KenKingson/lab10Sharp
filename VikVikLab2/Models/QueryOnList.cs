using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VikVikLab2.Models.Enities;

namespace VikVikLab2.Models
{
    public class QueryOnList : MyList
    {
        public override MyItem GetElement()
        {
            MyListElement el = head;
            while(el.Next.Next != null)
            {
                el = el.Next;
            }
            MyItem i = el.Next.Item; ;
            el.Next = null;
            return i;
        }
    }
}
