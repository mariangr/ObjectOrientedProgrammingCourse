using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._07_StudentsAndLinq
{
    static class Extensions
    {
        public static Student[] OrderByFirstName(this Student[] students)
        {
            var result = students.OrderBy(student => student.FirstName);
            return result.ToArray();
        }
        
        public static Student[] GetByGroupNumber(this Student[] students, int groupNumber)
        {
            var result = from student in students where student.Group.GroupNumber == groupNumber select student;
            return result.ToArray();
        }

        public static Student[] GetByEmail(this Student[] students, string email)
        {
            var array = from student in students where student.Email != null select student;
            var result = from student in array where student.Email.Substring(student.Email.Length - email.Length - 1) == "@" + email select student;
            return result.ToArray();
        }

        public static Student[] GetByPhoneCode(this Student[] students, string code)
        {
            var array = from student in students where student.Tel != null select student;
            var result = from student in array where student.Tel.Substring(0, code.Length) == code select student;
            return result.ToArray();
        }

        public static Student[] GetByGrade(this Student[] students, int grade)
        {
            var result = from student in students where student.Marks.IsThereThisGrade(grade) select student;
            return result.ToArray();
        }

        public static bool IsThereThisGrade(this List<int> marks, int grade)
        {
            bool isThere = false;
            foreach (var mark in marks)
            {
                if (mark == grade)
                {
                    isThere = true;
                }
            }
            return isThere;
        }

        public static string ListToString(this List<int> list)
        {
            StringBuilder result = new StringBuilder();
            string marks = string.Join(",", list.ToArray());
            result.Append("Marks: " + marks + " ");
            return result.ToString();
        }

        public static Student[] HaveGrades(this Student[] students)
        {
            var array = from student in students where student.Marks != null select student;
            return array.ToArray();
            
        }

        public static Student[] HaveNGrades(this Student[] students, int N)
        {
            var array1 = from student in students where student.Marks != null select student;
            var array2 = from student in array1 where student.Marks.Count == N select student;
            return array2.ToArray();
        }

        public static bool IsFromYear2006(this Student student)
        {
            bool isFromYear = false;
            if (student.FN[4] == '0' && student.FN[5] == '6')
            {
                isFromYear = true;
            }
            return isFromYear;

        }

        public static bool IsFromDepartment(this Student student, string groupDepartment)
        {
            bool isFromDepartment = false;
            if (student.Group.DepartmentName == groupDepartment)
            {
                isFromDepartment = true;
            }
            return isFromDepartment;
        }

        public static void PrintStudentConsole(Student[] students)
        {
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
