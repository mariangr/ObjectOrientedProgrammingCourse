using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._03_AnimalKingdom
{
    class Animals : ISound
    {
        public Animals()
        {

        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Grrrrr");
        }

        public int Age { set; get; }
        public string Name { set; get; }
        public virtual string Sex { set; get; }

        public static void PrintAverage(Animals[] animals)
        {
            var result =
                from animal in animals
                group animal by animal.GetType();

            foreach (var item in result)
            {
                Console.WriteLine("{0} - {1}", item.Key.Name, item.Average(x => x.Age));
            }
        }

    }
}
