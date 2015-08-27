using System;

namespace AnimalHierarchy
{
    class Kitten : Cat
    {
        public Kitten(string name, sbyte age)
            : base(name, age, Sex.Female)
        { 
            
        }

        public override void MakeSound()
        {
            Console.WriteLine("Kitten sound!");
        }
    }
}
