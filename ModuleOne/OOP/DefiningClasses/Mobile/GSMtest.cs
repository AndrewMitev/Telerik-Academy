using System;


namespace Mobile
{
    public class GSMtest
    {
        static void Main(string[] args)
        {
            GSM[] phones = { new GSM("nokia lumia", "nokia"), new GSM("galaxy s6", "samsung", 2000), new GSM("xperia", "sony", 700) };



            foreach (var phone in phones)
            {
                Console.WriteLine(phone.ToString());

            }
            Console.WriteLine("\n\n" + GSM.iphone4s);
        }
    }
}
