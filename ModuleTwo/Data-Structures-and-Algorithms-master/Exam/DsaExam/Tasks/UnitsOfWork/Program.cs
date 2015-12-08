namespace UnitsOfWork
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Program
    {
        private static Dictionary<string, Unit> byName;
        private static Dictionary<string, SortedSet<Unit>> unitsByType;
        private static SortedSet<Unit> sortedByPower;

        static void MockInput()
        {
            string input = @"add TheMightyThor God 100
add Artanis Protoss 250
add Fenix Protoss 200
add Spiderman MutatedHuman 180
add XelNaga God 500
add Wolverine MutatedHuman 200
add Zeratul Protoss 300
add Spiderman MutatedHuman 180
add JimRaynor Human 100
power 3
find Protoss
find God
remove Kerrigan
remove XelNaga
power 3
find Kerrigan
find God
find Human
remove JimRaynor
remove Artanis
find Protoss
power 5
find Human
end";

            Console.SetIn(new StringReader(input));
        }

        static void Main(string[] args)
        {
            //MockInput();
            string input = "";
            byName = new Dictionary<string, Unit>();
            unitsByType = new Dictionary<string, SortedSet<Unit>>();
            sortedByPower = new SortedSet<Unit>();

            while (input != "end")
            {
                input = Console.ReadLine();

                string[] data = input.Split(' ').ToArray();
                string operation = data[0];

                switch (operation)
                {
                    case "add":
                        {
                            string name = data[1];
                            string type = data[2];
                            int attack = int.Parse(data[3]);

                            var unit = new Unit(name, type, attack);

                            Add(name, unit);
                            break;
                        }
                    case "remove":
                        {
                            string name = data[1];
                            Remove(name);
                            break;
                        }
                    case "find":
                        {
                            string type = data[1];
                            Find(type);
                            break;
                        }
                    case "power":
                        {
                            int numUnits = int.Parse(data[1]);
                            PrintPower(numUnits);
                            break;
                        }
                }
            }

        }

        public class Unit : IComparable<Unit>
        {
            public Unit(string name, string type, int attack)
            {
                this.Name = name;
                this.Type = type;
                this.Attack = attack;
            }

            public string Name { get; set; }

            public string Type { get; set; }

            public int Attack { get; set; }

            public int CompareTo(Unit other)
            {
                int value = other.Attack.CompareTo(this.Attack);

                if (value == 0)
                {
                    value = this.Name.CompareTo(other.Name);
                }

                return value;
            }

            public override string ToString()
            {
                return string.Format("{0}[{1}]({2})", this.Name, this.Type, this.Attack);
            }
        }

        public static void Add(string name, Unit unit)
        {
            if (byName.ContainsKey(name))
            {
                Console.WriteLine("FAIL: {0} already exists!", name);
                return;
            }

            byName[name] = unit;

            if (!unitsByType.ContainsKey(unit.Type))
            {
                unitsByType[unit.Type] = new SortedSet<Unit>();
            }

            unitsByType[unit.Type].Add(unit);
            sortedByPower.Add(unit);
            Console.WriteLine("SUCCESS: {0} added!", name);
        }

        public static void Remove(string name)
        {
            if (!byName.ContainsKey(name))
            {
                Console.WriteLine("FAIL: {0} could not be found!", name);
                return;
            }

            var unit = byName[name];

            unitsByType[unit.Type].Remove(unit);
            sortedByPower.Remove(unit);
            byName.Remove(name);
            Console.WriteLine("SUCCESS: {0} removed!", name);
        }

        public static void Find(string type)
        {
            if (unitsByType.ContainsKey(type))
            {
                Console.WriteLine("RESULT: {0}", string.Join(", ", unitsByType[type].Take(10)));
            }
            else
            {
                Console.WriteLine("RESULT: ");
            }
        }

        private static void PrintPower(int numUnits)
        {
            Console.WriteLine("RESULT: {0}", string.Join(", ", sortedByPower.Take(numUnits)));
        }
    }
}
