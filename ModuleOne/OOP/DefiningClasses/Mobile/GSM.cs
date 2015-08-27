using System;
using System.Collections.Generic;

namespace Mobile
{
    public class GSM
    {
        public static readonly string iphone4s = @"The iPhone 4S (retroactively stylized with a lowercase 's' as iPhone 4s as of September 2013[7]) is a touchscreen-based smartphone developed, manufactured, and released by Apple Inc. It is the fifth generation of the iPhone";

        public List<Call> callHistory;

        private string model;

        private string manufacturer;

        private decimal? price;

        private string owner;

        private Battery battery;

        private Display display;

        private List<Call> CallHistory
        {
            get { return this.callHistory; }

            set
            {
                this.callHistory = value; 
            }
        }

        private string Model {set; get;}

        private string Manufacturer { set; get; }

        private decimal? Price
        {
            set 
            {
                if (value >= 0)
                {
                    this.price = value;
                }
            }

            get { return this.price; }

        }
        private string Owner { set; get; }

        private Battery Battery { set; get; }

        private Display Display { set; get; }

        public GSM(string model, string manufact)
        {
            this.Model = model;

            this.Manufacturer = manufact;

            this.Price = null;

            this.Owner = null;

            this.Battery = null;

            this.Display = null;

            this.callHistory = new List<Call>();

        }

        public GSM(string model, string manufact, decimal price)
        {
            this.Model = model;

            this.Manufacturer = manufact;

            this.Price = price;

            this.Owner = null;

            this.Battery = null;

            this.Display = null;

            this.callHistory = new List<Call>();

        }

        public GSM(string model, string manufact, decimal price, string owner)
        {
            this.Model = model;

            this.Manufacturer = manufact;

            this.Price = price;

            this.Owner = owner;

            this.Battery = null;

            this.Display = null;

            this.callHistory = new List<Call>();

        }

        public GSM(string model, string manufact, decimal price, string owner, Battery bat)
        {
            this.Model = model;

            this.Manufacturer = manufact;

            this.Price = price;

            this.Owner = owner;

            this.Battery = bat;

            this.Display = null;

            this.callHistory = new List<Call>();

        }

        public GSM(string model, string manufact, decimal price, string owner, Battery bat, Display disp)
        {
            this.Model = model;

            this.Manufacturer = manufact;

            this.Price = price;

            this.Owner = owner;

            this.Battery = bat;

            this.Display = disp;

            this.callHistory = new List<Call>();
        }

        public override string ToString()
        {
            string batt = "none";
            string disp = "no data";

            if (this.Battery != null)
            {
                batt = this.Battery.ToString();
            }

            if (this.Display != null)
            {
                disp = this.Display.ToString();
            }

            return String.Format("Model => [{0}], Manufacturer => [{1}], Price => [{2}], Owner => [{3}], Battery => [{4}], Display => [{5}]", this.Model ?? "none", this.Manufacturer ?? "none", this.Price ?? 0, this.Owner ?? "none", batt, disp);
        }

        public void AddCall(Call call)
        {
            if (call != null)
            {
                this.callHistory.Add(call);
            }
            else
            {
                Console.WriteLine("Null reference exception");
                Environment.Exit(0);
            }
        }

        public void RemoveCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void EmptyCallHistory()
        {
            this.callHistory.Clear();
        }

        public decimal TotalPriceOfCalls(decimal price)
        {
            long total = 0;

            foreach (Call call in this.callHistory)
            {
                if (call.duration != null)
                {
                    total += (long)call.duration;
                }
            }

            return (total / 60) * price;
        }
        
    }
}
