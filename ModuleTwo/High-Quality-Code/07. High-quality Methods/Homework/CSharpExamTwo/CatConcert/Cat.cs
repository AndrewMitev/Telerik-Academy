namespace CatConcert
{
    using System;
    using System.Collections.Generic;

    internal class Cat
    {
        public Cat(int id)
        {
            this.Id = id;
            this.Songs = new HashSet<int>();
        }

        public int Id { get; set; }

        public HashSet<int> Songs { get; set; }
    }
}
