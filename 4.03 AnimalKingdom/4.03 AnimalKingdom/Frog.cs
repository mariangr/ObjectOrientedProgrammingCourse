﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._03_AnimalKingdom
{
    class Frog : Animals
    {
        public Frog(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Frogggg");

        }
    }
}
