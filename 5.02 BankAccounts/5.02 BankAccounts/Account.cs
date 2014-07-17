using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._02_BankAccounts
{
    public abstract class Account
    {
        public Account(string customer, int balance, double interestRate, bool isIndividual)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.IsIndividual = isIndividual;
        }

        public string Customer { set; get; }
        public int Balance { set; get; }
        public double InterestRate { set; get; }

        public void Deposit(int sum)
        {
            this.Balance += sum;
        }

        public abstract double CalculateInterestAmmount(int months);

        public bool IsIndividual { get; set; }
    }
}
