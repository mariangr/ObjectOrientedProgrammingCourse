using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._02_StudentsAndWorkers
{
    class Program
    {
        static string[] firstNames = { "Tora", "Suber", "Fern", "Linares", "Donita", "Brodersen", "Stefanie", "Mcroy", "Elmo", "Aron", "Edris", "Abram", "Jennifer", "Morlan", "Monica", "Buesing", "Leann", "Moralez", "Belinda", "Mcabee" };

        static string[] lastNames = { "Owen", "Trammel", "Bobbie", "Felberbaum", "Susan", "Dinapoli", "Elvina", "Sawtelle", "Paola", "Granados", "Hazel", "Devore", "Stacia", "Soderberg", "Ricki", "Fortenberry", "Tien", "Derossett", "Chia", "Bozarth" };

        static Random randomGenerator = new Random();

        const int GROUPS_COUNT = 10;

        static void Main()
        {

            List<Student> students = new List<Student>();
            for (int i = 0; i < GROUPS_COUNT; i++)
            {
                Student currentStudent = new Student();

                currentStudent.FirstName = firstNames[randomGenerator.Next(0, firstNames.Length - 1)];
                currentStudent.Lastname = lastNames[randomGenerator.Next(0, lastNames.Length - 1)];
                currentStudent.Grade = randomGenerator.Next(1, 12);
                students.Add(currentStudent);
            }

            List<Worker> workers = new List<Worker>();
            for (int i = 0; i < GROUPS_COUNT; i++)
            {
                Worker currentWorker = new Worker();
                currentWorker.FirstName = firstNames[randomGenerator.Next(0, firstNames.Length - 1)];
                currentWorker.Lastname = lastNames[randomGenerator.Next(0, lastNames.Length - 1)];
                currentWorker.WeekSalary = randomGenerator.Next(500, 10000);
                currentWorker.WorkHoursPerDay = randomGenerator.Next(1, 12);
                workers.Add(currentWorker);
            }

            var lambdaSortedStudents = students.OrderBy(x => x.Grade).ToList();

            Console.WriteLine("Students sorted\n ");

            foreach (var item in lambdaSortedStudents)
            {
                Console.WriteLine("{0} {1} {2}", item.Grade, item.FirstName, item.Lastname);
            }
            Console.WriteLine();

            var lambdaSortedWorkers = workers.OrderByDescending(x => x.MoneyPerHour()).ToList();

            Console.WriteLine();
            Console.WriteLine("Workers sorted\n");

            foreach (var item in lambdaSortedWorkers)
            {
                Console.WriteLine("{0} {1} {2}", item.MoneyPerHour(), item.FirstName, item.Lastname);
            }

            Console.WriteLine();
        }
    }
}
