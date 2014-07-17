using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._03_AnimalKingdom
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals[] zoo =
        {
            new Dog("sharo1", "male",10),
            new Dog("sharo2", "male",15),
            new Frog("jabcho1", "male",1),
            new Frog("jabcho2", "male",3),
            new Frog("jabcho3", "male",2),
            new Kitten("kitty1", 5),
            new Kitten("kitty2", 6),
            new Kitten("kitty3", 1),
            new Kitten("kitty4", 51),
            new TomCat("tomcat",3)
        };
            Animals.PrintAverage(zoo);
        }
    }
}
