using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bank
{
    public class Account : IDeposit
    {
        private Customer customer;
        private decimal balance;
        private decimal interest;
        private int months;

        protected Account(Customer customer, decimal balance, decimal interest)
        {
            this.customer = customer;
            this.balance = balance;
            this.interest = interest;
        }

        public Customer Customer
        {
            get { return this.customer; }
            set { this.customer = value; }
        }

        protected decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        protected decimal Interest
        {
            get { return this.interest; }
        }


        public int Interest
        {
            get
            {
                return months * interest;
            }
            set
            {
            }
        }
    }
}
