using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._02_BankAccounts
{
    class MortgageAccount : Account
    {
        public MortgageAccount(string customer, int balance, double interestRate, bool isIndividual)
            : base (customer, balance, interestRate, isIndividual)
        {
        }

        public override double CalculateInterestAmmount(int months)
        {
            try
            {
                if (this.IsIndividual)
                {
                    if (months > 6)
                    {
                        months -= 6;
                    }
                    else
                    {
                        return 0;
                    }
                    return this.InterestRate * months;
                }
                else
                {
                    if (months <= 12 && months >= 0)
                    {
                        return this.InterestRate * months / 2;
                    }
                    else if (months > 12)
                    {
                        return (this.InterestRate * 12 / 2) + (this.InterestRate * (months - 12));
                    }
                    else throw new ArgumentOutOfRangeException("Months must be a positive number.");
                }
            }
            catch (ArgumentOutOfRangeException aoore)
            {
                Console.WriteLine(aoore.Message);
                return int.MinValue;
            }
        }
    }
}
