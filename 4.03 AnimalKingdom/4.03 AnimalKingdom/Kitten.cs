using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._03_AnimalKingdom
{
    class Kitten : Cats
    {
        public Kitten(string name, int age)
        {
            this.Name = name;
            this.Sex = "female";
            this.Age = age;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Myauuuu");
        }

        public override string Sex
        {
            get
            {
                return "female";
            }
        }

    }
}
