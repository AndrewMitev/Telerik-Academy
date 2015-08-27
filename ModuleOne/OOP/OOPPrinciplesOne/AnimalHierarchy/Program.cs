using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cat> cats = new List<Cat>()
            {
                new Cat("pepi", 3, Sex.Male),
                new Cat("cepi", 5, Sex.Male),
                new Cat("mraka", 1, Sex.Female),
                new Cat("murphy", 8, Sex.Male)
            };

            List<Dog> dogs = new List<Dog>() { 
                new Dog("sharo", 12, Sex.Male),
                new Dog("viki", 8, Sex.Female),
                new Dog("Olive", 4, Sex.Female),
                new Dog("Dolive", 9, Sex.Male)
            };

            List<Frog> frogs = new List<Frog>()
            {
                new Frog("frog1", 1, Sex.Male),
                new Frog("frog2", 1, Sex.Male),
                new Frog("frog3", 3, Sex.Female),
                new Frog("frog4", 4, Sex.Male),
                new Frog("frog5", 1, Sex.Male),
                new Frog("frog6", 2, Sex.Female)
            };

            List<Kitten> kittens = new List<Kitten>()
            {
                new Kitten("Maya", 2),
                new Kitten("Steisy", 4),
                new Kitten("Viki", 1),
                new Kitten("Moley", 6)
            };

            List<Tomcat> tomcats = new List<Tomcat>()
            {
                new Tomcat("tommy", 3),
                new Tomcat("sonny", 2),
                new Tomcat("bonny", 1),
                new Tomcat("ronny", 10),
                new Tomcat("kircho", 6),
                new Tomcat("puffy", 1)
            };

            Console.WriteLine("Average years of all cats: " + Animal.CalculateAverageYears(cats));
            Console.WriteLine("Average years of all dogs: " + Animal.CalculateAverageYears(dogs));
            Console.WriteLine("Average years of all frogs: " + Animal.CalculateAverageYears(frogs));
            Console.WriteLine("Average years of all kittens: " + Animal.CalculateAverageYears(kittens));
            Console.WriteLine("Average years of all tomcats: " + Animal.CalculateAverageYears(tomcats));
        }
    }
}
