using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AcountsLib
{
   public static class AcountsFactory
    {
        public static Acount CreateAccount(double initialBalance)
        {
            Acount a=new Acount(Thread.CurrentThread.ManagedThreadId);
            a.Deposit(initialBalance);
            return a;
        }
    }
}
