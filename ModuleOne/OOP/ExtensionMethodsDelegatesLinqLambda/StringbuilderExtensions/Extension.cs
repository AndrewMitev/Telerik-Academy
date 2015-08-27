using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringbuilderExtensions
{
    public static class Extension
    {
        public static StringBuilder Substring(this StringBuilder builder, int index, int length)
        {
            if (index < 0 || index >= builder.Length)
            {
                throw new IndexOutOfRangeException("Invalid index");
            }

            if (index + length > builder.Length)
            {
                throw new IndexOutOfRangeException("Invalid length");
            }

            StringBuilder newBuilder = new StringBuilder();

            for (int i = index; i < index + length; i++)
            {
                newBuilder.Append(builder[i]);
            }

            return newBuilder;
        }
    }
}
