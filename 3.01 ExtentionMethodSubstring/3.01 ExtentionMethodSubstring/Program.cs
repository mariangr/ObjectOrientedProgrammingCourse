using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._01_ExtentionMethodSubstring
{
    static class SubstringExtention
    {
        public static StringBuilder Substring(this StringBuilder list, int index, int length)
        {
            StringBuilder result = new StringBuilder();
            result.Append(list.ToString().Substring(index, length));
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder list = new StringBuilder();
            StringBuilder newList = new StringBuilder();
            list.Append("abcdefghijklmnopqrstuvwxyz");
            newList = list.Substring(1, 5);
            Console.WriteLine(newList.ToString());
        }
    }

    
        
    
}
