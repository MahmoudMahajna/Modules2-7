using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Quad.Test
{
    //You could have added more tests.
    //It would be easier to add more tests if you you had an idea to know what is the result of each method/calculation.
    //Because some of your methods do more than one thing (parse and validate, get input, etc...) it is hard to test each one of them
    //It is also hard because you print the failures inside 'logic' methods. So you don't have other indications. At least not trivial or releated to the Lab contract
    [TestClass]
    public class QuadTest
    {
        [TestMethod]
        public void Quad_GetParameters()
        {
            var args=new[]  { "1", "0", "-4" } ;
            double a, b, c;
            var eq=new ExecQuad();
            eq.CheckAndGetParameters(args, out a, out b, out c);
            Assert.AreEqual(1,a);
            Assert.AreEqual(0,b);
            Assert.AreEqual(-4,c);
        }
        [TestMethod]
        public void Quad_TwoSolutions()
        {
            double sol1,sol2;
            var eq = new ExecQuad();
            eq.CalculateAndPritSolution(out sol1,out sol2, 1,  0, -4);
            Assert.AreEqual(2, sol1);
            Assert.AreEqual(-2,sol2);
           
        }
        [TestMethod]
        public void Quad_OneSolution()
        {
            double sol1, sol2;
            var eq = new ExecQuad();
            eq.CalculateAndPritSolution(out sol1, out sol2, 0, 1, -4);
            Assert.AreEqual(4, sol1);
            Assert.AreEqual(double.PositiveInfinity, sol2);
        }
        [TestMethod]
        public void Quad_NoSolution()
        {
            double sol1, sol2;
            var eq = new ExecQuad();
            eq.CalculateAndPritSolution(out sol1, out sol2, 1, 0, 4);
            Assert.AreEqual(double.PositiveInfinity, sol1);
            Assert.AreEqual(double.PositiveInfinity, sol2);
        }
    }
}
