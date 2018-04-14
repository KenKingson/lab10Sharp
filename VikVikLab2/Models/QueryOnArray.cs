using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VikVikLab2.Models.Enities;

namespace VikVikLab2.Models
{
    public class QueryOnArray : MyArray
    {
        public QueryOnArray(int size) : base(size)
        {
        }
        public QueryOnArray() :base()
        {
        }

        public override MyItem GetElement()
        {
            int position = elements.Length-1;
            MyItem item = elements[position];
            while(item == null && position > 0)
            {
                position--;
                item = elements[position];
            }
            Console.WriteLine(position);
            elements[position] = null;
            return item;
        }
    }
}
