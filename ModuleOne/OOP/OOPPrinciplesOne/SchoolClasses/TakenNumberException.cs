using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClasses
{
    class TakenNumberException : ApplicationException 
    {
        public TakenNumberException(string msg)
            : base(msg)
        { 
            
        }
    }
}
