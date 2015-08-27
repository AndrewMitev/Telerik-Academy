namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;
    using System.Text;

    public class Shampoo : Product, IProduct, IShampoo
    {
        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {
            this.Milliliters = milliliters;
            this.Usage = usage;
        }

        public override decimal Price
        {
            get
            {
                return base.Price * this.Milliliters;
            }
            set
            {
                base.Price = value;
            }
        }

        public uint Milliliters { get; set; }

        public Common.UsageType Usage { get; set; }

        public override string Print()
        {
            StringBuilder builder = new StringBuilder();

            // TODO: trim?? ml??
            builder.AppendLine(base.Print());
            builder.AppendLine(string.Format("  * Quantity: {0} ml", this.Milliliters));
            builder.AppendLine(string.Format("  * Usage: {0}", this.Usage));

            return builder.ToString().TrimEnd();
        }
    }
}
