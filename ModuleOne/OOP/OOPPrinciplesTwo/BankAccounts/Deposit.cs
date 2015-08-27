using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    internal class Deposit : Account, IIntrest
    {
        public Deposit(Customer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        { 
        
        }

        public void Withdraw(decimal sum)
        {
            if (sum < 0)
            {
                throw new InvalidOperationException("Negative amount of money.");
            }

            if (base.Balance - sum < 0)
            {
                throw new InvalidOperationException("Insufficient Balance.");
            }

            base.Balance -= sum;
            Console.WriteLine("Amount successfully withdrawn");
        }

        public double CalculateInterest(int months)
        {
            if (base.Balance > 0 && base.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return (double)base.Interest * months;
            }
        }
    }
}
