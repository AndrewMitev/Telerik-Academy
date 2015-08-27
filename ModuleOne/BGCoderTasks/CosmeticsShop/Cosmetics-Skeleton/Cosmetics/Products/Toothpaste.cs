namespace Cosmetics.Products
{
    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class Toothpaste : Product, IProduct, IToothpaste
    {
        private const int MinIngredientLenght = 4;
        private const int MaxIngredientLenght = 12;

        private string ingredients;
        private IList<string> ingredientsList;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.IngredientsList = ingredients;

            this.Ingredients = string.Join(", ", this.IngredientsList);
        }

        public IList<string> IngredientsList
        {
            get { return this.ingredientsList; }

            set
            {
                Validator.CheckIfNull(value, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "List of ingredients"));

                if (value.Any(x => x.Length < 4 || x.Length > 12))
                {
                    throw new ArgumentException(string.Format("Each ingredient must be between {0} and {1} symbols long!", MinIngredientLenght, MaxIngredientLenght));
                }

                this.ingredientsList = value;
            }
        }

        public string Ingredients
        {
            get { return this.ingredients; }

            set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, "Ingredients"));

                this.ingredients = value;
            }
        }

        public override string Print()
        {
            StringBuilder builder = new StringBuilder();

            // TODO: trim?? ml??
            builder.AppendLine(base.Print());

            builder.AppendLine("  * Ingredients: " + this.Ingredients);

            //trim?
            return builder.ToString().TrimEnd();
        }
    }
}
