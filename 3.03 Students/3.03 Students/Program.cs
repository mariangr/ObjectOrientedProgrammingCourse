using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._03_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("aaaa", "dddd"));
            students.Add(new Student("Marian", "Graurov"));
            students.Add(new Student("aaaa", "bbbbbb"));
            students.Add(new Student("ffffff", "eeeee"));

            var sortedAlphabetically =
                from student in students
                where student.FirstName.CompareTo(student.LastName) == -1
                select student;

            foreach (var item in sortedAlphabetically)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
            Console.WriteLine();

            var result =
            from student in students
            where student.Age > 18 && student.Age < 24
            select new { student.FirstName, student.LastName };

            foreach (var item in result)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
            Console.WriteLine();


            var resultLambdaExpression = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);

            foreach (var item in resultLambdaExpression)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
            Console.WriteLine();

            var resultLINQExpression =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var item in resultLINQExpression)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.LastName);
            }
            Console.WriteLine();
        }
    }
}
