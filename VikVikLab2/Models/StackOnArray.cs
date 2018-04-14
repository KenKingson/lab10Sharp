using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VikVikLab2.Models.Enities;

namespace VikVikLab2.Models
{
    public class StackOnArray : MyArray
    {
        public StackOnArray() : base()
        {
        }

        public StackOnArray(int size) : base(size)
        {

        }
        public override MyItem GetElement()
        {
            MyItem item = elements[0];
            for (int i = 0; i< elements.Length; i++)
            {
                elements[i] = elements[i + 1];
            }
            return item;
        }
    }
}
