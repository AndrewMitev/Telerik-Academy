using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Common
{
    public static class Validator
    {
        public static void CheckIfStringIsNullOrEmpty(string someString, string msg)
        {
            if (string.IsNullOrEmpty(someString))
            {
                throw new ArgumentException(msg);
            }

        }
    }
}
