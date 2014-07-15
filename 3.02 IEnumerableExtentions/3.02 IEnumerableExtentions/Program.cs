using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._02_IEnumerableExtentions
{
    public static class IEnumerableExtentions<T> where T : IComparable<T>
    {
        public static T Sum<T>(this IEnumerable<T> elements)
        {
            dynamic result = 0;
            foreach (var element in elements)
            {
                result += (dynamic)element;
            }

            return result;
        }

        public static T Product<T>(this IEnumerable<T> elements)
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
            dynamic result = ulong.MaxValue;
            foreach (var element in elements)
            {
                if (result >= element)
                {
                    result = (dynamic)element;
                }
            }

            return result;
        }

        public static T Max<T>(this IEnumerable<T> elements) where T : IComparable
        {
            dynamic result = ulong.MaxValue;
            foreach (var element in elements)
            {
                if (result <= element)
                {
                    result = (dynamic)element;
                }
            }
            return result;
        }

        public static T Average<T>(this IEnumerable<T> elements)
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
            IEnumerable<int> result = from value in Enumerable.Range(0, 3)
				  select value;

            int a = result.Sum<int>();
            
        }
    }
}
