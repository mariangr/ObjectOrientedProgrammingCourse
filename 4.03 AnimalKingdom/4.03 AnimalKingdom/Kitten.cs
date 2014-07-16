using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._03_AnimalKingdom
{
    class Kitten : Cats
    {
        public Kitten()
        {
            this.Sex = "female";
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
