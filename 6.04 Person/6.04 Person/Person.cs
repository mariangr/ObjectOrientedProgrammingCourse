using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._04_Person
{
    public class Person
    {
        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }


        public string Name { set; get; }
        public int? Age { set; get; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("Name: " + this.Name);
            if (this.Age.HasValue)
            {
                result.AppendLine("Age: " + this.Age.Value);
            }
            else
            {
                result.AppendLine("The Age is not specified");
                
            }
            return result.ToString();
        }
    }

}
