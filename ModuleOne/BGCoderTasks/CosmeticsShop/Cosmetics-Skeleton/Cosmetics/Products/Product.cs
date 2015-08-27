namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;
    using System.Text;

    public abstract class Product : IProduct
    {

        private const int MinNameSymbols = 3;
        private const int MaxNameSymbols = 10;
        private const int MinBrandSymbols = 2;
        private const int MaxBrandSymbols = 10;

        private string name;
        private string brand;

        protected Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get { return this.name; }

            set 
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product name"));

                Validator.CheckIfStringLengthIsValid(value, MaxNameSymbols, MinNameSymbols, string.Format(GlobalErrorMessages.InvalidStringLength,"Product name", MinNameSymbols, MaxNameSymbols));

                this.name = value;
            }
        }

        public string Brand
        {
            get { return this.brand; }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Product brand"));

                Validator.CheckIfStringLengthIsValid(value, MaxBrandSymbols, MinBrandSymbols, string.Format(GlobalErrorMessages.InvalidStringLength,"Product brand", MinBrandSymbols, MaxBrandSymbols));

                this.brand = value;
            }
        }

        public virtual decimal Price {get; set;}

        public Common.GenderType Gender { get; protected set; }

        public virtual string Print()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine(string.Format("- {0} - {1}:",
                this.Brand, this.Name));

            builder.AppendLine(string.Format("  * Price: ${0}", this.Price));

            builder.AppendLine(string.Format("  * For gender: {0}", this.Gender));

            // TODO: Add trim???
            return builder.ToString().TrimEnd();
        }
    }
}
