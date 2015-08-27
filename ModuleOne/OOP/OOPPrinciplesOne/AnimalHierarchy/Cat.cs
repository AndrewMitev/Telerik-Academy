using System;

namespace AnimalHierarchy
{
    class Cat : Animal
    {
        public Cat(string name, sbyte age, Sex s)
            : base(name, age, s)
        { 
            
        }

        public override void MakeSound()
        {
            Console.WriteLine("Meowww!");
        }
    }
}
