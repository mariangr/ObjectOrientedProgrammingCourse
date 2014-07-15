using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._05_2._07_GenericList
{
    class GenericList<T> where T : IComparable
    {
        private IList<T> list;

        public GenericList()
        {
            this.list = new List<T>();
        }

        public void AddNewElement(T element)
        {
            this.list.Add(element);
        }

        public void AddElementAt(T element, int index)
        {
            try
            {
                this.list[index] = element;
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine(aoore.Message);
            }
        }

        public T GetElementAt(int index)
        {
            try
            {
                return this.list[index];
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine(aoore.Message);
                Console.Write("Try again: ");
                return GetElementAt(int.Parse(Console.ReadLine()));
            }
        }

        public void RemoveElementAt(int index)
        {
            try
            {
                this.list.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine(aoore.Message);
                Console.WriteLine("Try again:");
                RemoveElementAt(int.Parse(Console.ReadLine()));
            }
        }

        public void ClearList()
        {
            this.list.Clear();
        }

        public int FindElementByValue(T element)
        {
            int index = -1;
            for (int i = 0; i < this.list.Count; i++)
            {
                if (this.list[i].Equals(element))
                {
                    return i;
                }
            }
            return index;
        }

        public T Min()
        {
            return this.list.Min<T>();

        }

        public T Max()
        {
            return this.list.Max<T>();
        }



        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            foreach (var element in this.list)
            { 
                result.AppendLine(element.ToString()).Append(" ");
            }
                return result.ToString();
        }
    }
}
