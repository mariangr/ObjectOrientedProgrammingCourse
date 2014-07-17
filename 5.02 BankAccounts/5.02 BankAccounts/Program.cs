using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._02_BankAccounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Account individualAccount1 = new DepositAccount("John Smith", 900, 2.3, true);
            Account individualAccount2 = new LoanAccount("Bill Gates", 1000, 0.2, true);
            Account individualAccount3 = new MortgageAccount("Ketty Perry", -200, 5, true);


            Account[] individualAccounts = { individualAccount1, individualAccount2, individualAccount3 };

            Account companyAccount1 = new DepositAccount("John Smith", 1900, 2.3, false);
            Account companyAccount2 = new LoanAccount("Bill Gates", 1000, 0.2, false);
            Account companyAccount3 = new MortgageAccount("Ketty Perry", -200, 5, false);
            Account[] companyAccounts = { companyAccount1, companyAccount2, companyAccount3 };

            foreach (var item in individualAccounts)
            {
                Console.WriteLine("{0} : {1}", item.GetType().Name, item.CalculateInterestAmmount(10));
            }
            Console.WriteLine();
            foreach (var item in companyAccounts)
            {
                Console.WriteLine("{0} : {1}", item.GetType().Name, item.CalculateInterestAmmount(10));
            }
        }
    }
}
