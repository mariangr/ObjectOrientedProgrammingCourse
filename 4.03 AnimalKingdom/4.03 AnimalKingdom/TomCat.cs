using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._03_AnimalKingdom
{
    class TomCat : Animals
    {
        public TomCat(string name, int age)
        {
            this.Name = name;
            this.Sex = "male";
            this.Age = age;
        }

        public override string Sex
        {
            get
            {
                return "male";
            }
        }
    }
}
