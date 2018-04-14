using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VikVikLab2.Models;
using VikVikLab2.Models.Enities;

namespace VikVikLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            StackOnList arr = new StackOnList();
            arr.AddElement(new MyItem { Name = "Fedor", Number = 15 });
            arr.AddElement(new MyItem { Name = "Misha", Number = 13 });
            arr.AddElement(new MyItem { Name = "Vova", Number = 10 });
            Console.WriteLine(arr);
            Console.WriteLine(arr.GetElement());
            Console.WriteLine(arr);
            
            arr.AddElement(new MyItem { Name = "Kirill", Number = 22 });
            Console.ReadLine();
        }
    }
}
