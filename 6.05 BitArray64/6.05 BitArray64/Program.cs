using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._05_BitArray64
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray64 number = new BitArray64(6846465465465365569);
            BitArray64 number1 = new BitArray64(6846465465465365569);
            Console.WriteLine(number.ToString());
            Console.WriteLine(number.GetHashCode());
            Console.WriteLine(number == number1);
            Console.WriteLine(number != number1);
            Console.WriteLine("number[5]: " + number[5]);
        }
    }
}
