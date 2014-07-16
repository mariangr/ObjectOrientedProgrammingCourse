using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._07_StudentsAndLinq
{
    class Student
    {
        public Student()
        { 
        
        }

        public Student(string firstName, string lastName, string FN, Group group, string tel = null, string email = null, List<int> marks = null ) : this()
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = FN;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.Group = group;
        }

        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string FN { set; get; }
        public string Tel { set; get; }
        public string Email { set; get; }
        public List<int> Marks { set; get; }
        public Group Group { set; get; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine("First name: " + this.FirstName);
            result.AppendLine("Last name: " + this.LastName);
            result.AppendLine("FN: " + this.FN.ToString());
            if (this.Tel != null)
            {
                result.AppendLine("Tel: " + this.Tel);
            }
            if (this.Email != null)
            {
                result.AppendLine("Email: " + this.Email);
            }
            if (this.Marks != null)
            {
                string marks = string.Join(",", this.Marks.ToArray());
                result.AppendLine("Marks: " + marks);
            }
            result.AppendLine("Group number: " + this.Group.ToString());

            return result.ToString();
        }
    }
}
