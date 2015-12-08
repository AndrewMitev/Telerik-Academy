namespace LargeCollection
{
    using System;

    public class Product : IComparable
    {
        public Product(string n, decimal d)
        {
            this.Name = n;

            this.Price = d;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int CompareTo(object pr)
        {
            return this.Price.CompareTo((pr as Product).Price);
        }

        public override string ToString()
        {
            return this.Name + " : " + this.Price;
        }
    }
}
