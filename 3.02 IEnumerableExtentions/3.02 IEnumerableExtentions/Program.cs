using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._02_IEnumerableExtentions
{
    public static class IEnumerableExtentions
    {
        public static T Sum<T>(this IEnumerable<T> elements) where T : IComparable
        {
            dynamic result = 0;
            foreach (var element in elements)
            {
                result += (dynamic)element;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> elements) where T : IComparable
        {
            dynamic result = 1;
            foreach (var element in elements)
            {
                result *= (dynamic)element;
            }

            return result;
        }

        public static T Min<T>(this IEnumerable<T> elements) where T : IComparable
        {
            dynamic result = int.MaxValue;
            foreach (var element in elements)
            {
                if (element.CompareTo(result) < 0 )
                {
                    result = (dynamic)element;
                }
            }

            return result;
        }

        public static T Max<T>(this IEnumerable<T> elements) where T : IComparable
        {
            dynamic result = int.MaxValue;
            foreach (var element in elements)
            {
                if (result <= element)
                {
                    result = (dynamic)element;
                }
            }
            return result;
        }

        public static T Average<T>(this IEnumerable<T> elements) where T : IComparable
        {
            dynamic average = 0, counter = 0;
            foreach (var c in elements)
            {
                average += c;
                counter++;
            }
            if (counter == 0)
                throw new ArgumentException("The passed collection is empty.");
            return average / counter;
        }
    
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(numbers.Sum());
            Console.WriteLine(numbers.Product());
            Console.WriteLine(numbers.Average());
            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            
        }
    }
}
