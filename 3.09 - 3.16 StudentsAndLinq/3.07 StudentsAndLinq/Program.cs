using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._07_StudentsAndLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstMarks = new List<int> { 2 };
            Group firstGroup = new Group(3, "Mathematics");
            Student first = new Student("Marian", "Graurov", "61506", firstGroup, "0883556788", "marian.graurov@abv.bg", firstMarks);
            List<int> secondMarks = new List<int>{6,5,5,6,6,6,6};
            Group secondGroup = new Group(2, "Mathematics");
            Student second = new Student("Marian2", "Graurov1", "61568", secondGroup, "02883356758", "marian.graurov@abv.com", secondMarks);
            List<int> thirdMarks = new List<int> { 3, 6 };
            Group thirdGroup = new Group(2, "Biology");
            Student third = new Student("Marian1", "Graurov3", "615006", thirdGroup, "021883558798", null, thirdMarks);
            Group fourthGroup = new Group(3, "Chemistry");
            Student fourth = new Student("Marian3", "Graurov2", "612006", fourthGroup, null, "marian.graurov@abv.bg");

            Student[] students = new Student[] { first, second, third, fourth };

            var studentsFromSecondGroup = students.GetByGroupNumber(2);
            var orderedStudentsFromSecondGroup = students.OrderByFirstName();
            Extensions.PrintStudentConsole(studentsFromSecondGroup);
            
            Console.WriteLine("Ordered:");
            Extensions.PrintStudentConsole(orderedStudentsFromSecondGroup);

            Console.WriteLine("Using abv.bg:");
            var allStudentsThatUseABV = students.GetByEmail("abv.bg");
            Extensions.PrintStudentConsole(allStudentsThatUseABV);

            Console.WriteLine("In Sofia: ");
            var allStudentsThatAreInSofia = students.GetByPhoneCode("02");
            Extensions.PrintStudentConsole(allStudentsThatAreInSofia);

            Console.WriteLine("Students that have 6: ");
            var allStudentsWithGrades = students.HaveGrades();
            var newAnonimousClass = from student in allStudentsWithGrades where student.Marks.IsThereThisGrade(6) select new { FullName = student.FirstName + " " + student.LastName, Marks = student.Marks.ListToString() };
            foreach (var item in newAnonimousClass)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine();
            Console.WriteLine("Students that have two grades: ");
            var allStudentsWithTwoGrades = students.HaveNGrades(2);
            Extensions.PrintStudentConsole(allStudentsWithTwoGrades);

            Console.WriteLine("Students' grades from 2006: ");

            var allGrades2006 = from student in allStudentsWithGrades where student.IsFromYear2006() select new { Marks = student.Marks.ListToString() };
            foreach (var item in allGrades2006)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine();
            Console.WriteLine("Students from the mathematics department: ");

            var allStudentsFromMathematics = from student in students where student.IsFromDepartment("Mathematics") select student.FirstName + " " + student.LastName;
            String allStudentsFromMathematicsDepartment = string.Join(",", allStudentsFromMathematics);
            Console.WriteLine(allStudentsFromMathematicsDepartment);
        }
    }
}
