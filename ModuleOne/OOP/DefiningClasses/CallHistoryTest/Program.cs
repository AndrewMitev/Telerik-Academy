using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobile;

namespace CallHistoryTest
{
    class Program
    {

        static void Main(string[] args)
        {
            GSM nokia = new GSM("lumia", "nokia", 900, "Stoyan", new Battery("Asperji", 30, 0, Battery.BatteryType.NiMH), new Display("366x512", 16000000));
           
            nokia.AddCall(new Call("02.04.2015", "02:22:32", "0884239123", (long)340));
            nokia.AddCall(new Call("01.10.2015", "12:12:42", "0884232345", (long)245));
            nokia.AddCall(new Call("02.04.2015", "15:33:12", "0889123242", (long)45));

            //display info for each call
            foreach (var call in nokia.callHistory)
            {
                Console.WriteLine(call.ToString());
                Console.WriteLine();
            }

            //total price of calls

            Console.WriteLine("Total price of all calls (0.37 per minute) : " + nokia.TotalPriceOfCalls(0.37m));
            Console.WriteLine();

            long? max = 0;
            Call c = new Call();

            foreach (Call call in nokia.callHistory)
            {
                if (call.Duration > max)
                {
                    max = call.Duration;
                    c = call;
                }
            }

            nokia.callHistory.Remove(c);

            Console.WriteLine("Total price of all calls after removal (0.37 per minute) : " + nokia.TotalPriceOfCalls(0.37m));

            nokia.callHistory.Clear();

            //print after removal of all elements
            foreach (var call in nokia.callHistory)
            {
                Console.WriteLine(call);
            }
            Console.WriteLine();
        }
    }
}
