# Creational Design Patterns
## * Singleton
- The main purpose of this design pattern is a class to be created that can be instanciated only once.
- It violates the Single Responsibily Principle, as the class have to make sure it has only one instance in addition to it's main function and thus introduces tight coupling.
- Code example in C#

~~~c#
using System;
 
namespace Singleton.Structural
{
  class MainApp
  {
    static void Main()
    {
      Singleton s1 = Singleton.Instance();
      Singleton s2 = Singleton.Instance();
 
      // Test for same instance
      if (s1 == s2)
      {
        Console.WriteLine("Objects are the same instance");
      }
 
      Console.ReadKey();
    }
  }
 
  class Singleton
  {
    private static Singleton _instance;
 
    protected Singleton()
    {
    }
 
    public static Singleton Instance()
    {
      // Uses lazy initialization.
      // Note: this is not thread safe.
      if (_instance == null)
      {
        _instance = new Singleton();
      }
 
      return _instance;
    }
  }
}
~~~

- Diagram
![Singleton Pattern](https://javainsider.files.wordpress.com/2012/10/java-singleton-design-pattern.jpg "Singleton Design Pattern")

## * Factory
- Create objects from a class through method. If we want to make some change in the logic of creation of objects, we do it in one place. Also we can hide the logic of the creation of objects if, for example, is too complex. 
- C# Example

~~~c#

namespace FactoryDesignPattern
{
    using System;

    class Tank : Machine
    {
        public override IMachine CreateMachine()
        {
            return new Tank();
        }
    }
}

~~~

- Diagram
![Abstract Factory Pattern](http://www.dofactory.com/images/diagrams/net/abstract.gif "Abstract Factory Design Pattern UML Diagram")

## * Lazy initialization
- Delay the creation of an instance until the very first time it is used. This is usually the case when implementing the Singleton Design Pattern. 
