using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    internal abstract class Account
    {
        private Customer customer;

        private decimal balance;

        private decimal interest;

        public Account(Customer customer, decimal balance, decimal interest)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.Interest = interest;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }
            set
            {
                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public decimal Interest
        {
            get
            {
                return this.interest;
            }
            set
            {
                this.interest = value;
            }
        }

        public void Deposit(decimal sum)
        {
            if (sum > 0)
            {
                this.Balance += sum;
            }
            else
            {
                throw new InvalidOperationException("Negative amount.");
            }
        }
    }
}
