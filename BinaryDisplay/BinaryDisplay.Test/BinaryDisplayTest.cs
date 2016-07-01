using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinaryDisplay.Test
{
    [TestClass]
    public class BinaryDisplayTest
    {
        [TestMethod]
        public void BinaryDisplay_CalculateNumberOf1Positive()
        {
            var num=new BinaryDisplayClass().GetNumberOf1(7);
            Assert.AreEqual(3,num);

            num = new BinaryDisplayClass().GetNumberOf1(0);
            Assert.AreEqual(0,num);
        }
        [TestMethod]
        public void BinaryDisplay_CalculateNumberOf1Negative()
        {
            var num = new BinaryDisplayClass().GetNumberOf1(-7);
            Assert.AreEqual(30, num);

            num = new BinaryDisplayClass().GetNumberOf1(-5);
            Assert.AreEqual(31, num);
        }
        
    }
}
