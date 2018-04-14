using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VikVikLab2.Models.Enities
{
    public class MyItem
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public override string ToString()
        {
            return "Name:" + Name + ", Number:" + Number;
        }
    }
}
