using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._04_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person first = new Person("Marian");
            Person second = new Person("Gergana",18);
            Person[] people = { first, second };

            foreach (var item in people)
            {
                Console.WriteLine(item.ToString());
            }
            
        }
    }
}
