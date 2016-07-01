using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Strings.Test
{
    [TestClass]
    public class StringsTest
    {
        [TestMethod]
        public void Strings_ToString()
        {
            StringsClass sc = new StringsClass("My Name Is Mahmoud");
            Assert.IsTrue(sc.ToString().Equals("My Name Is Mahmoud"));
        }
        [TestMethod]
        public void Strings_Reverse()
        {
            StringsClass sc=new  StringsClass("My Name Is Mahmoud");
            sc.ArrayReverse();
            Assert.IsTrue(sc.ToString().Equals("Mahmoud Is Name My"));
        }
        [TestMethod]
        public void Strings_Sort()
        {
            StringsClass sc = new StringsClass("aa Aa bbb ab");
            sc.ArraySort();
            Assert.IsTrue(sc.ToString().Equals("aa Aa ab bbb"));
        }
        [TestMethod]
        public void Strings_Count()
        {
            StringsClass sc = new StringsClass("aa Aa bbb ab");
            Assert.IsTrue(sc.Count==4);
        }
        [TestMethod]
        public void Strings_EmptyString()
        {
            StringsClass sc = new StringsClass("");
            Assert.IsTrue(sc._words == null);
            sc = new StringsClass(" ");
            Assert.IsTrue(sc._words == null);
        }
    }
}