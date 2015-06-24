namespace _64BitArray
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        static void Main()
        {
            // no need to test
        } 


        private ulong number;

        public int this[int pos]
        {
            get
            {
                return (int)((this.number >> pos) & 1);
            }
            set
            {
                if (pos < 0 || pos > 63)
                {
                    throw new ArgumentOutOfRangeException("0 >= index < 63");
                }
                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("0 or 1 only");
                }
                if (value == 1)
                {
                    this.number = this.number | ((ulong)1 << pos);
                }
                else
                {
                    this.number = this.number & (~((ulong)1 << pos));
                }
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override bool Equals(object obj)
        {
            var num = obj as BitArray64;

            if (num == null)
            {
                return false;
            }

            return this.number == num.number;
        }

        public override int GetHashCode()
        {
            return this.number.GetHashCode() ^ 42;
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !(first.Equals(second));
        }
    }
}
