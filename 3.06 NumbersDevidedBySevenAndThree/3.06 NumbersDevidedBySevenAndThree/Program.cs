using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._06_NumbersDevidedBySevenAndThree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

            Console.WriteLine(String.Join(",", (from number in array where number % 7 == 0 && number % 3 == 0 select number)));
            Console.WriteLine("klgvf");
            Console.WriteLine(String.Join(",", array.Where(x => x % 7 == 0 && x % 3 == 0)));

        }
    }
}
