using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VikVikLab2.Models.Enities;

namespace VikVikLab2.Models
{
    class StackOnList : MyList
    {
        public override MyItem GetElement()
        {
            MyItem item = head.Item;
            head = head.Next;
            return item;
        }
    }
}
