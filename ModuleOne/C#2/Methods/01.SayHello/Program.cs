using System;

/*
 * ite a method that asks the user for his name and prints “Hello, <name>”
 * Write a program to test this method.
 */
namespace _01.SayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHello(Console.ReadLine());
        }

        private static void SayHello(string name)
        {
            Console.WriteLine("hello " + name);
        }
    }
}
