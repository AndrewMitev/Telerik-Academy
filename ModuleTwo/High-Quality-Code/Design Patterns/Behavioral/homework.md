# Behavioural Patterns Homework

----
## Mediator Pattern

> This pattern is used so that different classes can interact with each other without the explicit need of knowledge of the existance of each one of them. The control of interaction is not direct - class to another class, but is rather class - mediator - targeted class. In this case the first class doesn't have to 'know' almost anything about the targeted class. Great real-world examples of this pattern are the air control tower in airports, dispatcher that taxis use and so on.

> Implementing this pattern makes our code more loosely coupled and makes interaction between classes more easy.

> One disadvantage is that the code in that mediator class could become really large and complex.

----
### Diagram
![Mediator Pattern](http://www.dofactory.com/images/diagrams/net/mediator.gif "Mediator Design Pattern")

###### Mediator example
```c#
using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Mediator.RealWorld
{
  /// <summary>
  /// MainApp startup class for Real-World 
  /// Mediator Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Create chatroom
      Chatroom chatroom = new Chatroom();

      // Create participants and register them
      Participant George = new Beatle("George");
      Participant Paul = new Beatle("Paul");
      Participant Ringo = new Beatle("Ringo");
      Participant John = new Beatle("John");
      Participant Yoko = new NonBeatle("Yoko");

      chatroom.Register(George);
      chatroom.Register(Paul);
      chatroom.Register(Ringo);
      chatroom.Register(John);
      chatroom.Register(Yoko);

      // Chatting participants
      Yoko.Send("John", "Hi John!");
      Paul.Send("Ringo", "All you need is love");
      Ringo.Send("George", "My sweet Lord");
      Paul.Send("John", "Can't buy me love");
      John.Send("Yoko", "My sweet love");

      // Wait for user
      Console.ReadKey();
    }
  }

  /// <summary>
  /// The 'Mediator' abstract class
  /// </summary>
  abstract class AbstractChatroom
  {
    public abstract void Register(Participant participant);
    public abstract void Send(
      string from, string to, string message);
  }

  /// <summary>
  /// The 'ConcreteMediator' class
  /// </summary>
  class Chatroom : AbstractChatroom
  {
    private Dictionary<string,Participant> _participants = 
      new Dictionary<string,Participant>();

    public override void Register(Participant participant)
    {
      if (!_participants.ContainsValue(participant))
      {
        _participants[participant.Name] = participant;
      }

      participant.Chatroom = this;
    }

    public override void Send(
      string from, string to, string message)
    {
      Participant participant = _participants[to];

      if (participant != null)
      {
        participant.Receive(from, message);
      }
    }
  }

  /// <summary>
  /// The 'AbstractColleague' class
  /// </summary>
  class Participant
  {
    private Chatroom _chatroom;
    private string _name;

    // Constructor
    public Participant(string name)
    {
      this._name = name;
    }

    // Gets participant name
    public string Name
    {
      get { return _name; }
    }

    // Gets chatroom
    public Chatroom Chatroom
    {
      set { _chatroom = value; }
      get { return _chatroom; }
    }

    // Sends message to given participant
    public void Send(string to, string message)
    {
      _chatroom.Send(_name, to, message);
    }

    // Receives message from given participant
    public virtual void Receive(
      string from, string message)
    {
      Console.WriteLine("{0} to {1}: '{2}'",
        from, Name, message);
    }
  }

  /// <summary>
  /// A 'ConcreteColleague' class
  /// </summary>
  class Beatle : Participant
  {
    // Constructor
    public Beatle(string name)
      : base(name)
    {
    }

    public override void Receive(string from, string message)
    {
      Console.Write("To a Beatle: ");
      base.Receive(from, message);
    }
  }

  /// <summary>
  /// A 'ConcreteColleague' class
  /// </summary>
  class NonBeatle : Participant
  {
    // Constructor
    public NonBeatle(string name)
      : base(name)
    {
    }

    public override void Receive(string from, string message)
    {
      Console.Write("To a non-Beatle: ");
      base.Receive(from, message);
    }
  }
}
```

----

----
## Iterator Pattern

> The Iterator Design Pattern is used to implement traversion of data structures that are more complex and their traversal is more complex (trees, graphs and so on) and could vary depending on the need. The class that needs to be traversed usually implements interface IEnumerable, that declares method GetEnumerator. The implementation class of the enumeration must implement the IEnumerator interface, that usually consists of the methods MoveNext(), Current(), Reset().

> The interface is usually commonly used and is lightweigh with no major drawbacks to it.

----
### Diagram
![iterator Pattern](https://upload.wikimedia.org/wikipedia/commons/1/13/Iterator_UML_class_diagram.svg "Iterator Design Pattern")

###### Iterator example

	using System;
    using System.Collections;

    class MainApp
    {
    	static void Main()
    	{
      		ConcreteAggregate a = new ConcreteAggregate();
      		a[0] = "Item A";
      		a[1] = "Item B";
      		a[2] = "Item C";
      		a[3] = "Item D";

      		// Create Iterator and provide aggregate 
      		ConcreteIterator i = new ConcreteIterator(a);

      		Console.WriteLine("Iterating over collection:");
 
      		object item = i.First();
      		while (item != null)
      		{
        		Console.WriteLine(item);
        		item = i.Next();
      		} 

      		// Wait for user 
      		Console.Read();
    	}
    }



###### Abstract Aggregate

    abstract class Aggregate
    {
    	public abstract Iterator CreateIterator();
    }

###### Concrete Aggregate

    class ConcreteAggregate : Aggregate
    {
    	private ArrayList items = new ArrayList();

    	public override Iterator CreateIterator()
    	{
      		return new ConcreteIterator(this);
    	}

    	public int Count
    	{
      		get{ return items.Count; }
    	}

    	public object this[int index]
    	{
      		get{ return items[index]; }
      		set{ items.Insert(index, value); }
    	}
    }

###### Abstract Iterator
    
    abstract class Iterator
    {
    	public abstract object First();
    	public abstract object Next();
    	public abstract bool IsDone();
    	public abstract object CurrentItem();
    }

###### Concrete Iterator

    class ConcreteIterator : Iterator
    {
    	private ConcreteAggregate aggregate;
    	private int current = 0;

    	public ConcreteIterator(ConcreteAggregate aggregate)
    	{
      		this.aggregate = aggregate;
    	}

    	public override object First()
    	{
      		return aggregate[0];
    	}

    	public override object Next()
    	{
      		object ret = null;
      		if (current < aggregate.Count - 1)
      		{
        		ret = aggregate[++current];
      		}
 
      		return ret;
    	}

    	public override object CurrentItem()
    	{
      		return aggregate[current];
    	}

    	public override bool IsDone()
    	{
      		return current >= aggregate.Count ? true : false ;
    	}
    }

----
## Template Pattern

> Template method is usually used when there is certain algorithm that is implemented throughout various modules, classes or so on. It defines the steps that are needed to be covered, but doesn't specifically point the exact way that those steps are implemented. Usually relies on inheritacnce and override of virtual methods.

> Another major advantage of the template method is that if some steps are required to be implemented in exact way, this could be done in the template method itself thus avoiding duplication of code (DRY principle is preserved)

----
### Diagram
![Singleton Pattern](http://docs.groovy-lang.org/latest/html/documentation/assets/img/TemplateMethodClasses.gif "Template Design Pattern")

###### Example
```c#
	public class Trip {
        public void performTrip(){
                 travelToDestination();
                 doDayOneActivities();
                 doDayTwoActivities();
                 doDayThreeActivities();
                 travelBack();
        }
        public abstract void travelToDestination();
        public abstract void doDayOneActivities();
        public abstract void doDayTwoActivities();
        public abstract void doDayThreeActivities();
        public abstract void travelBack();
}

public class PackageA : Trip {
        public override void travelToDestination() {
                 Console.WriteLine("The tourists are travelling by plane ...");
        }
        public override void doDayOneActivities() {
                 Console.WriteLine("The tourists are visiting the aquarium ...");
        }
        public override void doDayTwoActivities() {
                 Console.WriteLine("The tourists are going to the beach ...");
        }
        public override void doDayThreeActivities() {
                 Console.WriteLine("The tourists are going to the mountains ...");
        }
        public override void travelBack() {
                 Console.WriteLine("The tourists are travelling back home by plane ...");
        }
}
public class PackageB : Trip {
        public override void travelToDestination() {
                 Console.WriteLine("The tourists are travelling by train ...");
        }
        public override void doDayOneActivities() {
                 Console.WriteLine("The tourists are visiting the museum ...");
        }
        public override void doDayTwoActivities() {
                 Console.WriteLine("The tourists are visiting the medieval castle ...");
        }
        public override void doDayThreeActivities() {
                 Console.WriteLine("The tourists are going to the zoo ...");
        }
        public override void travelBack() {
                 Console.WriteLine("The tourists are travelling home by train ...");
        }
}
```
----
## Strategy Pattern

> The strategy design pattern is actually an implementation of the Dependency Inversion Principle - one of the five SOLID principles when writing code: The main purpose is to decouple classes with one another using higher abstraction introduced through interfaces. In this way different parts of the program can be replaced/changed when needed without the need to change the established structure. This way new functionality could be added relative easy. Different parts can be unit testsed. Classes are more loosly coupled and remain single purposed. 

----
### Diagram
![Strategy Pattern](http://www.dofactory.com/images/diagrams/net/strategy.gif "Strategy Design Pattern")

###### Example
```c#
using System;
using System.Collections.Generic;

namespace DoFactory.GangOfFour.Strategy.RealWorld
{
  /// <summary>
  /// MainApp startup class for Real-World 
  /// Strategy Design Pattern.
  /// </summary>
  class MainApp
  {
    /// <summary>
    /// Entry point into console application.
    /// </summary>
    static void Main()
    {
      // Two contexts following different strategies
      SortedList studentRecords = new SortedList();

      studentRecords.Add("Samual");
      studentRecords.Add("Jimmy");
      studentRecords.Add("Sandra");
      studentRecords.Add("Vivek");
      studentRecords.Add("Anna");

      studentRecords.SetSortStrategy(new QuickSort());
      studentRecords.Sort();

      studentRecords.SetSortStrategy(new ShellSort());
      studentRecords.Sort();

      studentRecords.SetSortStrategy(new MergeSort());
      studentRecords.Sort();

      // Wait for user
      Console.ReadKey();
    }
  }

  /// <summary>
  /// The 'Strategy' abstract class
  /// </summary>
  abstract class SortStrategy
  {
    public abstract void Sort(List<string> list);
  }

  /// <summary>
  /// A 'ConcreteStrategy' class
  /// </summary>
  class QuickSort : SortStrategy
  {
    public override void Sort(List<string> list)
    {
      list.Sort(); // Default is Quicksort
      Console.WriteLine("QuickSorted list ");
    }
  }

  /// <summary>
  /// A 'ConcreteStrategy' class
  /// </summary>
  class ShellSort : SortStrategy
  {
    public override void Sort(List<string> list)
    {
      //list.ShellSort(); not-implemented
      Console.WriteLine("ShellSorted list ");
    }
  }

  /// <summary>
  /// A 'ConcreteStrategy' class
  /// </summary>
  class MergeSort : SortStrategy
  {
    public override void Sort(List<string> list)
    {
      //list.MergeSort(); not-implemented
      Console.WriteLine("MergeSorted list ");
    }
  }

  /// <summary>
  /// The 'Context' class
  /// </summary>
  class SortedList
  {
    private List<string> _list = new List<string>();
    private SortStrategy _sortstrategy;

    public void SetSortStrategy(SortStrategy sortstrategy)
    {
      this._sortstrategy = sortstrategy;
    }

    public void Add(string name)
    {
      _list.Add(name);
    }

    public void Sort()
    {
      _sortstrategy.Sort(_list);

      // Iterate over list and display results
      foreach (string name in _list)
      {
        Console.WriteLine(" " + name);
      }
      Console.WriteLine();
    }
  }
}
```
