using System;

namespace AnimalHierarchy
{
    internal class Tomcat : Animal
    {
        public Tomcat(string name, sbyte age)
            : base(name, age, Sex.Male)
        { 
            
        }

        public override void MakeSound()
        {
            Console.WriteLine("Tomcat sound!");
        }
    }
}
