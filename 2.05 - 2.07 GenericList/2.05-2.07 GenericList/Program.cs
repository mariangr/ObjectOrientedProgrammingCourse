using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._05_2._07_GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            list.AddNewElement(0);
            list.AddNewElement(1);
            list.AddNewElement(4);
            list.AddNewElement(6);
            list.AddElementAt(5, 0);
            list.AddElementAt(5, 1);
            //list.AddElementAt(20, 20);
            Console.WriteLine(list.GetElementAt(0));
            list.RemoveElementAt(20);
            Console.WriteLine(list.GetElementAt(2));

            Console.WriteLine(list.GetElementAt(20));


        }
    }
}
