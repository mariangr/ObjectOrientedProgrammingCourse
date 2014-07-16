using System;

namespace _4._02_StudentsAndWorkers
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string Lastname
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public Human()
        {

        }
    }
}
