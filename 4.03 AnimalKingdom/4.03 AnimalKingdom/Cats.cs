using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._03_AnimalKingdom
{
    class Cats : Animals
    {
        public Cats()
        { 
        
        }

        public override void MakeSound()
        {
            Console.WriteLine("Prrrr.");
        }
    }
}
