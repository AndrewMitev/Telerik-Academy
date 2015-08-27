using System;

namespace BankAccounts
{
    class Loan : Account, IIntrest
    {
        public Loan(Customer customer, decimal balance, decimal interest)
            : base(customer, balance, interest)
        { 
        
        }

        public double CalculateInterest(int months)
        {
            double result;
            int subtractor;

            switch (base.Customer.Type)
            {
                case Type.Individual: subtractor = 3; break;
                case Type.Company: subtractor = 2; break;
                default: subtractor = 0; break;
            }
            
                result = (double)base.Interest * (months - subtractor);

                if (result <= 0)
                {
                    result = 0;
                }
        
            return result;
        }
    }
}
