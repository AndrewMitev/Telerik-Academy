namespace FurnitureManufacturer.Models
{
    using FurnitureManufacturer.Interfaces;
    using System;

    public class Furniture : IFurniture
    {
        private string model;

        private decimal price;

        private decimal height;

        public Furniture(string model, MaterialType materialType, decimal price, decimal height)
        {
            this.Model = model;

            this.MaterialType = materialType;

            this.Price = price;

            this.Height = height;
        }

        public string Model
        {
            get { return this.model; }

            protected set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Model cannot be null or empty.");
                }
                // TODO: create custom exception
                if (value.Length < 3)
                {
                    throw new ArgumentException("Model cannot be with less than 3 symbols");
                }

                this.model = value;
            }
        }

        public MaterialType MaterialType { get; protected set; }

        public string Material
        {
            get
            {
                return this.MaterialType.ToString();
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (0 >= value)
                {
                    throw new ArgumentException("Price cannot be null or negative.");
                }

                this.price = value;
            }
        }

        public decimal Height
        {
            get { return this.height; }

            protected set
            {
                if (0 >= value)
                {
                    throw new ArgumentException("Height cannot be negative or zero.");
                }

                this.height = value;
            }
        }
    }
}
