using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._02_BankAccounts
{
    class LoanAccount : Account
    {
        public LoanAccount(string customer, int balance, double interestRate, bool isIndividual)
            : base (customer, balance, interestRate, isIndividual)
        {
        }

        public override double CalculateInterestAmmount(int months)
        {
            try
            {
                if (this.IsIndividual)
                {
                    if (months > 3)
                    {
                        months -= 3;
                        return this.InterestRate * months;
                    }
                    else if (months > 0)
                    {
                        return 0;
                    }
                    else throw new ArgumentOutOfRangeException("Months must be a positive number.");
                }
                else
                {
                    if (months > 2)
                    {
                        months -= 2;
                        return this.InterestRate * months;
                    }
                    else if (months >= 0)
                    {
                        return 0;
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
