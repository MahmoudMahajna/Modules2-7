using System;
using AcountsLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acounts.Test
{
    [TestClass]
    public class AcountsTest
    {
        [TestMethod]
        public void Acount_Deposite()
        {
            Acount a = AcountsFactory.CreateAccount(15);
            a.Deposit(100);

            Assert.AreEqual(115,a.Balance);
        }

        [TestMethod]
        public void Acount_Withdraw()
        {
            Acount a = AcountsFactory.CreateAccount(15);
            a.Withdraw(100);

            Assert.AreEqual(-85, a.Balance);
        }

        [TestMethod]
        public void Acount_Transfer()
        {
            Acount a = AcountsFactory.CreateAccount(15);
            Acount b = AcountsFactory.CreateAccount(100);

            b.Transfer(a,35);

            double TOLERANCE=0.0000000001;
            Assert.IsTrue(Math.Abs(50 - a.Balance) < TOLERANCE && Math.Abs(65 - b.Balance) < TOLERANCE);
        }

        [TestMethod]
        public void AcountsFactory_create()
        {
            Acount a = AcountsFactory.CreateAccount(30);
            
            Assert.AreEqual(30,a.Balance);
        }
    }
}
