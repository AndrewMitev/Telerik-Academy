namespace FurnitureManufacturer.Engine.Factories
{
    using FurnitureManufacturer.Common;
    using FurnitureManufacturer.Interfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Company : ICompany
    {
        private string name;

        private string registrationNumber;

        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;

            this.RegistrationNumber = registrationNumber;

            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get { return this.name; }

            protected set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, "Name cannot be null or empty.");

                if (value.Length < 5)
                {
                    throw new ArgumentException("Name cannot be less than five symbols.");
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }

            protected set
            {
                if (value.Length != 10 || value == null)
                {
                    throw new ArgumentException("Registration number cannot be null and must be ten digits.");
                }

                if (!this.ContainsOnlyDigits(value))
                {
                    throw new ArgumentException("Registration number must contain only digits!");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.Furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            return this.furnitures.FirstOrDefault(x =>
                x.Model.ToLower() == model.ToLower());
        }

        public string Catalog()
        {
            var sortedFurniture = this.Furnitures
                .OrderBy(x => x.Price)
                .ThenBy(x => x.Model);

            StringBuilder builder = new StringBuilder();

            string numberOfFurniture = this.Furnitures.Count() == 0 ? "no" : this.Furnitures.Count().ToString();
            string fWord = this.Furnitures.Count == 1 ? "furniture" : "furnitures";
            builder.AppendLine(string.Format("{0} - {1} - {2} {3}", this.Name, this.RegistrationNumber, numberOfFurniture, fWord));

            foreach (var item in sortedFurniture)
            {
                builder.AppendLine(item.ToString());
            }

            return builder.ToString().TrimEnd();
        }

        private bool ContainsOnlyDigits(string item)
        {
            foreach (var symbol in item)
            {
                if (!char.IsDigit(symbol))
                {
                    return false;
                }

            }
            return true;
        }
    }
}
