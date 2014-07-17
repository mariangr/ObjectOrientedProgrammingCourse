using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._02_BankAccounts
{
    class DepositAccount : Account
    {
        public DepositAccount(string customer, int balance, double interestRate, bool isIndividual)
            : base (customer, balance, interestRate, isIndividual)
        {
        }

        public int MyProperty { get; set; }

        public void Withdraw(int sum)
        {
            this.Balance -= sum;
        }

        public override double CalculateInterestAmmount(int months)
        {
            try
            {
                if (months >= 0)
                {
                    if (this.Balance >= 0 && this.Balance <= 1000)
                    {
                        return 0;
                    }
                    else
                    {
                        return this.InterestRate * months;
                    }
                }
                else throw new ArgumentOutOfRangeException("Months must be a positive number.");
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine(aoore.Message);
                return int.MinValue;
            }
        }
    }
}
