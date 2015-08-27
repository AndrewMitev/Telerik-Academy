using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace BitArray
{
    class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong n)
        {
            this.Number = n;
        }

        public ulong Number
        {
            get { return this.number; }
            set { this.number = value; }
        }

        public int this[int position]
        {
            get
            {
                if (position < 0 || position >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }

                return (int)((this.Number >> position) & 1);
            }
            set
            {
                if (position < 0 || position >= 64)
                {
                    throw new IndexOutOfRangeException("Invalid index.");
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException("Invalid bit value.");
                }

                if ( (int)((this.Number >> position) & 1) != value )
                {
                    this.Number ^= (1ul << position);
                }
            }
        }

        public override bool Equals(object obj)
        {
            return this.Number.Equals((obj as BitArray64).Number);
        }

        public override int GetHashCode()
        {
            return this.Number.GetHashCode();
        }

        public static bool operator ==(object one, object two)
        {
            return one.Equals(two);
        }

        public static bool operator !=(object one, object two)
        {
            return !one.Equals(two);
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int pos = 0; pos < 64; pos++)
            {
                yield return this[pos];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

    }
}
