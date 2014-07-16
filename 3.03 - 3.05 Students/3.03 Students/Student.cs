using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._03_Students
{
    class Student
    {
        public Student()
        {
        }

        public Student(string firstName, string lastName) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int Age { set; get; }

    }
}
