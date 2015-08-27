using FurnitureManufacturer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureManufacturer.Models
{
    class ConvertibleChair : Chair, IFurniture, IChair, IConvertibleChair
    {
        private const decimal ConvertedHeight = 0.10m;
        private decimal initialHeight;

        public ConvertibleChair(string model, MaterialType materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs)
        {
            this.IsConverted = false;
            this.initialHeight = height;
        }

        public bool IsConverted { get; set; }

        public void Convert()
        {
            this.IsConverted = !this.IsConverted;

            this.Height = IsConverted ? ConvertedHeight : initialHeight;
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}, State: {6}",
                this.GetType().Name,
                this.Model,
                this.Material,
                this.Price,
                this.Height,
                this.NumberOfLegs,
                this.IsConverted ? "Converted" : "Normal");
        }
    }
}
