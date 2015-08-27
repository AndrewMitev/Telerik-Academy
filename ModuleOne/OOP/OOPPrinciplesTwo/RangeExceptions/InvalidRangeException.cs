using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeExceptions
{
    class InvalidRangeException<T> : ApplicationException
        where T : IComparable<T>
    {
        public InvalidRangeException(string msg, T start, T end)
            : base(String.Format("{0}\nParameter should be in range [{1} - {2}]", msg, start, end))
        { 
            
        }
    }
}
