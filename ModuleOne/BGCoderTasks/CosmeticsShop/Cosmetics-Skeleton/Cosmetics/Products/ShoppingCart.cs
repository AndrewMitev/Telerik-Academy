namespace Cosmetics.Products
{
    using Cosmetics.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingCart : IShoppingCart
    {
        private ICollection<IProduct> shoppingCartList;

        public ShoppingCart()
        {
            this.shoppingCartList = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {
            this.shoppingCartList.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {
            this.shoppingCartList.Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.shoppingCartList.Contains(product);
        }

        public decimal TotalPrice()
        {
            return this.shoppingCartList.Sum(i => i.Price);
        }
    }
}
