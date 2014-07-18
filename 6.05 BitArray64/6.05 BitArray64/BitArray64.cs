using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._05_BitArray64
{
    public class BitArray64 : IEnumerable<int>
    {
        private short[] bits = new short[64];

        public BitArray64(ulong number)
        {
            SetNumber(number);
        }

        public void SetNumber(ulong number)
        {
            int position = 63;
            while (position >= 0 && number != 0)
            {
                bits[position] = (short)(number % 2);
                number /= 2;
                position--;
            }
            
        }

        public short[] Bits 
        { 
            private set {this.bits = value;} 
            get {return this.bits;}
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return bits[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index must be in range [0, 63].");
                }

                return this.bits[index];
            }
            set
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index must be in range [0, 63].");
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentOutOfRangeException("value", "Value must be 0 or 1.");
                }

                this.bits[index] = (short)value;
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            BitArray64 second = obj as BitArray64;
            for (int j = 0; j < 64; j++)
            {
                if (this[j] != second[j])
                {
                    return false;
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return this.bits.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 64; i++)
            {
                result.Append(this[i]);
            }
            return result.ToString();
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            for (int i = 0; i < 64; i++)
            {
                if (first[i] != second[i])
                {
                    return false;
                }
            }
            return true;
        
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            for (int i = 0; i < 64; i++)
            {
                if (first[i] != second[i])
                {
                    return true;
                }
            }
            return false;

        }
    }
}
