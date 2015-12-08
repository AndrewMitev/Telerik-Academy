namespace LargeCollection
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;

    public class Startup
    {
        private static readonly decimal PRICE = 1.2m;

        public static void Main()
        {
            OrderedBag<Product> bag = new OrderedBag<Product>();
            Random rand = new Random();

            for (int i = 0; i < 500000; i++)
            {
                bag.Add(new Product("name " + i, PRICE + i));
            }

            Console.WriteLine("Products Loaded!");

            for (int i = 0; i < 10000; i++)
            {
                FindInRange(bag, 1.2m , 2m + (rand.Next() / 500000));
                Console.WriteLine("=========New Search==========");
            }

            Console.WriteLine("MY FUCKING EYES HURT!! :D");
        }

        private static void FindInRange(OrderedBag<Product> bag, decimal firstRange, decimal secondRange)
        {
            List<Product> twenty = new List<Product>();

            twenty = bag.FindAll(x => x.Price >= firstRange && x.Price <= secondRange).Take(20).ToList();

            foreach (var item in twenty)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}
