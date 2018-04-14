using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VikVikLab2.Models.Enities;

namespace VikVikLab2.Models
{
    public abstract class MyArray : IArray
    {
        protected MyItem[] elements;

        public MyArray()
        {
            elements = new MyItem[5];
        }

        public MyArray(int size)
        {
            elements = new MyItem[size];
        }

        public int Count()
        {
            return elements.Count();
        }

        public bool IsEmpty()
        {
            if (elements.Count() == 0) { return true; }
            else { return false; }
        }

        public void AddElement(MyItem item)
        {
            if(elements[0] == null)
            {
                elements[0] = item;
            }
            else
            {
                MyItem prevInfo = elements[0];
                MyItem t;
                for (int i = 1; i < elements.Length; i++)
                {
                    t = elements[i];
                    elements[i] = prevInfo;
                    prevInfo = t;
                }
                elements[0] = item;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in elements)
            {
                if(item != null)
                {
                    sb.Append(" { " + item.ToString() + " } ");
                }
                else
                {
                    sb.Append(" { null }");
                }
            }
            return sb.ToString();
        }

        public void Clear()
        {
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = null;
            }
        }

        public abstract MyItem GetElement();
    }
}
