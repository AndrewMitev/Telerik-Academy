namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Category : ICategory
    {
        private const int MinCategoryNameSymbols = 2;
        private const int MaxCategoryNameSymbols = 15;

        private string name;
        private ICollection<IProduct> listOfProducts;

        public Category(string name)
        {
            this.Name = name;
            this.listOfProducts = new List<IProduct>();
        }

        public string Name
        {
            get { return this.name; }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Name of category"));

                Validator.CheckIfStringLengthIsValid(value, MaxCategoryNameSymbols, MinCategoryNameSymbols, string.Format(GlobalErrorMessages.InvalidStringLength, "Category name", MinCategoryNameSymbols, MaxCategoryNameSymbols));

                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics"));

            this.listOfProducts.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics"));

            if (!this.listOfProducts.Contains(cosmetics))
            {
                throw new InvalidOperationException(string.Format("Product {0} does not exist in category {}!", cosmetics.Name, this.Name));
            }

            this.listOfProducts.Remove(cosmetics);
        }

        public string Print()
        {
            var sortedItems =
                this.listOfProducts
                .OrderBy(p => p.Brand)
                .ThenByDescending(p => p.Price);

            long numberOfItems = sortedItems.Count();
            string pluralWord = numberOfItems == 1 ? "product" : "products";

            StringBuilder builder = new StringBuilder();
            // TODO: Trim??
            builder.AppendLine(string.Format("{0} category - {1} {2} in total", this.Name, numberOfItems, pluralWord));

            foreach (var item in sortedItems)
            {
                builder.AppendLine(item.Print());
            }

            return builder.ToString().TrimEnd();
        }
    }
}
