namespace TextToDescription
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        static void Main(string[] args)
        {
            int receivedNumber = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
            input = input.ToUpper();

            long result = 0;
            int counter = 0;

           while(true)
           {
                if (Char.IsDigit(input[counter]))
                {
                    result *= int.Parse(input[counter].ToString());
                }
                else if (Char.IsLetter(input[counter]))
                {
                    result += (int)input[counter] - 65;
                }
                else
                {
                    result %= receivedNumber;
                }

                counter++;

                if (input[counter] == '@')
                {
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}
