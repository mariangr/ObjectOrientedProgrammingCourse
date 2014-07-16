using System;

namespace _4._02_StudentsAndWorkers
{
    class Student : Human
    {
        private int grade;

        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }
        public Student()
        {

        }
    }
}
