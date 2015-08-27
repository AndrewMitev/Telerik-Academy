using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Display
    {
        internal string Size { set; get; }

        internal long? NumberOfColors { set; get; }

        internal Display()
        {
            this.Size = String.Empty;

            this.NumberOfColors = 0;
        }

        public Display(string s, long colors)
        {
            this.Size = s;

            this.NumberOfColors = colors;
        }
        public override string ToString()
        {
            return String.Format("Size => {0}, NumberOfColors => {1}", this.Size ?? "none", this.NumberOfColors ?? 0);
        }
    }
}
