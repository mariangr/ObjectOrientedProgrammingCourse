using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._01_Student
{
    public enum University
    {
        SU, TU, NBU, UNSS
    }

    public enum Faculty
    {
        Philosophy, Law, Mathematics, Phisics, Business, Management, Telecommunications
    }

    public enum Specialty
    {
        Telecommunications, Marketing, Business, Entrepreneurship, Phisics, Mathematics, Informatics, Law, Philosophy
    }

    class Student : ICloneable, IComparable<Student>
    {
        public Student(string firstName, string middleName, string lastName, int SSN, Specialty specialty, University university, Faculty faculty, string permanentAddress = null, string mobilePhone = null, string email = null, string course = null)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = SSN;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;

        }

        public string FirstName { set; get; }
        public string MiddleName { set; get; }
        public string LastName { set; get; }
        public int SSN { set; get; }
        public string PermanentAddress { set; get; }
        public string MobilePhone { set; get; }
        public string Email { set; get; }
        public string Course { set; get; }
        public Specialty Specialty { set; get; }
        public University University { set; get; }
        public Faculty Faculty { set; get; }

        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }
            if (this.FirstName != student.FirstName)
            {
                return false;
            }
            if (this.MiddleName != student.MiddleName)
            {
                return false;
            }
            if (this.LastName != student.LastName)
            {
                return false;
            }
            if (this.SSN != student.SSN)
            {
                return false;
            }
            return true;
        }

        public static bool operator ==(Student student1, Student student2)
        {
            return Student.Equals(student1, student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !(Student.Equals(student1, student2));
        }

        public override int GetHashCode()
        {
            return LastName.GetHashCode() ^ SSN.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("First name: " + FirstName);
            result.Append("Middle name: " + MiddleName);
            result.Append("Last name: " + LastName);
            result.Append("SSN: " + SSN);
            result.Append("Specialty: " + Specialty);
            result.Append("University" + University);
            result.Append("Faculty" + Faculty);
            
            if (this.PermanentAddress != null)
            {
                result.Append("Permanent address: " + PermanentAddress);
            }
            if (this.MobilePhone != null)
            {
                result.Append("Mobile phone" + MobilePhone);
            }
            if (this.Email != null)
            {
                result.Append("Email: " + Email);
            }
            if (this.Course != null)
            {
                result.Append("Course: " + Course);
            }
            
            return result.ToString();
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Specialty, this.University, this.Faculty, this.PermanentAddress, this.MobilePhone, this.Email, this.Course);
        }

        public int CompareTo(Student other)
        {
            if (this.Equals(other))
            {
                return 0;
            }
            else
            {
                string name = this.FirstName + " " + this.MiddleName + " " + this.LastName;
                string otherName = other.FirstName + " " + other.MiddleName + " " + other.LastName;
                if (name == otherName)
                {
                    return this.SSN - other.SSN;
                }
                else
                {
                    return name.CompareTo(otherName);
                }
            }
        }
    }
}
