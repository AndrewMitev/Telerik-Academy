using System;

namespace AnimalHierarchy
{
    class Frog : Animal
    {
        public Frog(string name, sbyte age, Sex s)
            : base(name, age, s)
        { 
            
        }

        public override void MakeSound()
        {
            Console.WriteLine("Frog sound.");
        }
    }
}
