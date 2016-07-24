using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Test
{
    //The convention of Unittest is: MethodName_descriptionOfTest_expectedResult
    //For example Add_TwoNumbers_3 // The test would be 1 + 2 = 3

     //In overall, great!
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public  void Calculator_Add()
        {
            var res=new CalculatorClass().Calculate(45, 3, '+');
            Assert.AreEqual(48,res);
        }
        [TestMethod]
        public void Calculator_AddNegative()
        {
            var res = new CalculatorClass().Calculate(45, -5, '+');
            Assert.AreEqual(40, res);
        }
        [TestMethod]
        public void Calculator_AddOverFlow()
        {
            var res = new CalculatorClass().Calculate(double.MaxValue, 1, '+');
            Assert.AreEqual(double.MaxValue+1, res);
        }
        [TestMethod]
        public void Calculator_Sub()
        {
            var res = new CalculatorClass().Calculate(1, 1, '-');
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void Calculator_SubNegative()
        {
            var res = new CalculatorClass().Calculate(1, -1, '-');
            Assert.AreEqual(2,res);
            
        }
        [TestMethod]
        public void Calculator_Mul()
        {
            var res = new CalculatorClass().Calculate(5, 5, '*');
            Assert.AreEqual(25, res);
        }
        [TestMethod]
        public void Calculator_MulNegative()
        {
            var res = new CalculatorClass().Calculate(5, -5, '*');
            Assert.AreEqual(-25, res);
        }
        [TestMethod]
        public void Calculator_MulNegativeNegative()
        {
            var res = new CalculatorClass().Calculate(-5, -5, '*');
            Assert.AreEqual(25, res);
        }
        [TestMethod]
        public void Calculator_DivByZiroN()
        {
            var res = new CalculatorClass().Calculate(-5, 0, '/');
            Assert.AreEqual(double.NegativeInfinity, res);
        }
        [TestMethod]
        public void Calculator_DivByZiroP()
        {
            var res = new CalculatorClass().Calculate(5, 0, '/');
            Assert.AreEqual(double.PositiveInfinity, res);
        }
        [TestMethod]
        public void Calculator_Div()
        {
            var res = new CalculatorClass().Calculate(15, 7, '/');
            var x = 15/7.0;
            Assert.AreEqual(x,  res);
        }
    }
}
