using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._03_RangeExeption
{
    class InvalidRangeException<T> : ArgumentOutOfRangeException where T : IComparable<T>
    {
        public InvalidRangeException(string message, T start, T end)
            : this(message, start, end, null)
        {
        }

        public InvalidRangeException(string message, T start, T end, Exception innerException)
            : base(message, innerException)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; private set; }
        public T End { get; private set; }

    }
}
