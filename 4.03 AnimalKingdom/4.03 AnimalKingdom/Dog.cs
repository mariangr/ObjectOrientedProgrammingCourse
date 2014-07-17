using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._03_AnimalKingdom
{
    class Dog : Animals
    {
        public Dog(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;

        }

        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }
}
