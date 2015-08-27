using System;
using System.IO;
/*
 * @ Task
 * Write a program that concatenates two text files into another text file.
 */
namespace _02.ConcatenateTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                StreamReader readerOne = new StreamReader("../../fileOne.txt");
                StreamReader readerTwo = new StreamReader("../../fileTwo.txt");

                StreamWriter writer = new StreamWriter("../../thirdFile.txt", true);

                using (writer)
                {
                    string firstText = readerOne.ReadToEnd();
                    string secondText = readerTwo.ReadToEnd();

                    writer.WriteLine(firstText);
                    writer.WriteLine(secondText);

                    Console.WriteLine("Success.");
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Null Pointer Exception");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found exception.");
            }
        }
    }
}
