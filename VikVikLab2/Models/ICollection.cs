using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VikVikLab2.Models.Enities;

namespace VikVikLab2.Models
{
    public interface ICollection
    {
        void AddElement(MyItem item);
        MyItem GetElement();
        bool IsEmpty();
        int Count();
    }
}
