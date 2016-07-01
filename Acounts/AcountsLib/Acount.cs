using System;

namespace AcountsLib
{
    public class Acount
    {
        public Acount(int id)
        {
            ID = id;
            Balance = 0;
        }
        public double Balance { get; private set; }

        public int ID { get; }

        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            Balance -= amount;
            if(Balance<0) throw new InsufficientFundsException();
        }

        public void Transfer(Acount a, double amount)
        {
            double beforeBalance=Balance;
            try
            {
                Withdraw(amount);
                a.Deposit(amount);
                Console.WriteLine("Transfer has been made");
            }
            catch (Exception) {}
            finally
            {
                Console.WriteLine($"Balance before: {beforeBalance}");
                Console.WriteLine($"Balance after: {Balance}");
            }
        }
    }
}