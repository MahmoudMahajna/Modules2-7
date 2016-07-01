using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcountsLib;

namespace AcountsMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Acount a = AcountsFactory.CreateAccount(1000);
            try
            {
                a.Deposit(2000);
                a.Withdraw(7000);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine(e.Message);
            }
            Acount b = AcountsFactory.CreateAccount(50);
            a.Transfer(b, 1500);
        }
    }
}
