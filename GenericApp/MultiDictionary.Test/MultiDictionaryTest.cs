using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GenericApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultiDictionary.Test
{
    [TestClass]
    public class MultiDictionaryTest
    {
        [TestMethod]
        public void MultiDictionary_Add()
        {
            var multiDic =new MultiDictionary<int,string>();
            multiDic.Add(1,"aaa");
            multiDic.Add(1,"bbb");

            Assert.IsTrue(multiDic.Contains(1, "aaa"));
            Assert.IsTrue(multiDic.Contains(1, "bbb"));
        }
        [TestMethod]
        public void MultiDictionary_RemoveKey_success()
        {
            var multiDic = new MultiDictionary<int, string> {{1, "aaa"}, {1, "bbb"}};
            
            Assert.IsTrue(multiDic.Remove(1));
            Assert.IsFalse(multiDic.ContainsKey(1));  
        }
        [TestMethod]
        public void MultiDictionary_RemoveKey_fail()
        {
            var multiDic = new MultiDictionary<int, string> { { 1, "aaa" }, { 1, "bbb" } };
            
            Assert.IsFalse(multiDic.Remove(2));
        }
        [TestMethod]
        public void MultiDictionary_RemoveValue_success()
        {
            var multiDic = new MultiDictionary<int, string> {{1, "aaa"}, {1, "bbb"}};
            
            Assert.IsTrue(multiDic.Remove(1, "aaa"));
            Assert.IsFalse(multiDic.Contains(1,"aaa"));
            Assert.IsTrue(multiDic.Contains(1,"bbb"));
        }
        [TestMethod]
        public void MultiDictionary_RemoveValue_fail()
        {
            var multiDic = new MultiDictionary<int, string> { { 1, "aaa" }, { 1, "bbb" } };

            Assert.IsFalse(multiDic.Remove(1, "ccc"));
            Assert.IsTrue(multiDic.Contains(1, "aaa"));
            Assert.IsTrue(multiDic.Contains(1, "bbb"));
        }
        [TestMethod]
        public void MultiDictionary_Clear()
        {
            var multiDictionary = new MultiDictionary<int, string>
            {
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {1, "ich"},
                {2, "nee"},
                {3, "sun"}
            };

            multiDictionary.Clear();
            Assert.IsTrue(multiDictionary.Count == 0);
            Assert.IsFalse(multiDictionary.ContainsKey(1));
            Assert.IsFalse(multiDictionary.ContainsKey(2));
            Assert.IsFalse(multiDictionary.ContainsKey(2));
        }
        [TestMethod]
        public void MultiDictionary_Contains_false()
        {
            var multiDictionary = new MultiDictionary<int, string>
            {
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {1, "ich"},
                {2, "nee"},
                {3, "sun"}
            };
            Assert.IsFalse(multiDictionary.Contains(1,"three"));
            Assert.IsFalse(multiDictionary.Contains(5, "three"));
        }
        [TestMethod]
        public void MultiDictionary_Contains_true()
        {
            var multiDictionary = new MultiDictionary<int, string>
            {
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {1, "ich"},
                {2, "nee"},
                {3, "sun"}
            };
            Assert.IsTrue(multiDictionary.Contains(1, "one"));
            Assert.IsTrue(multiDictionary.Contains(2, "nee"));
            Assert.IsTrue(multiDictionary.Contains(3, "three"));
        }
        [TestMethod]
        public void MultiDictionary_ContainsKey()
        {
            var multiDictionary = new MultiDictionary<int, string>
            {
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {1, "ich"},
                {2, "nee"},
                {3, "sun"}
            };
            Assert.IsTrue(multiDictionary.ContainsKey(1));
            Assert.IsTrue(multiDictionary.ContainsKey(2));
            Assert.IsTrue(multiDictionary.ContainsKey(3));
            Assert.IsFalse(multiDictionary.ContainsKey(5));
        }
        [TestMethod]
        public void MultiDictionary_Count()
        {
            var multiDictionary = new MultiDictionary<int, string>
            {
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {1, "ich"},
                {2, "nee"},
                {3, "sun"}
            };
            Assert.IsTrue(multiDictionary.Count==6);
            multiDictionary.Clear();
            Assert.IsTrue(multiDictionary.Count==0);
        }
        [TestMethod]
        public void MultiDictionary_Keys()
        {
            var multiDictionary = new MultiDictionary<int, string>
            {
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {1, "ich"},
                {2, "nee"},
                {3, "sun"}
            };
            var keys = new[] {1, 2, 3};
            for (int i = 0; i < 3; i++)
            {
                Assert.IsTrue(keys[i] == multiDictionary.Keys.ToArray()[i]);
            }
        }
        [TestMethod]
        public void MultiDictionary_Values()
        {
            var multiDictionary = new MultiDictionary<int, string>
            {
                {1, "one"},
                {2, "two"},
                {3, "three"},
                {1, "ich"},
                {2, "nee"},
                {3, "sun"}
            };
            var keys = new [] { "one", "ich","two", "nee", "three","sun" };
            for (var i = 0; i < multiDictionary.Values.Count; i++)
            {
                Assert.IsTrue(keys[i].Equals(multiDictionary.Values.ToArray()[i]));
            }
        }
        [TestMethod]
        public void MultiDictionary_Enumerator()
        {
            var multiDictionary = new MultiDictionary<int, string>
            {
                {1, "one"},
                {2, "two"},
                {1, "ich"},
            };
            var l=new LinkedList<KeyValuePair<int, ICollection<string>>>();
            foreach (var valueKey in multiDictionary)
            {
                l.AddLast(valueKey);
            }
            Assert.IsTrue(l.ToArray()[0].Key==1);
            Assert.IsTrue(l.ToArray()[1].Key == 2);
            Assert.IsTrue(l.ToArray()[0].Value.ToArray()[0].Equals("one"));
            Assert.IsTrue(l.ToArray()[0].Value.ToArray()[1].Equals("ich"));
            Assert.IsTrue(l.ToArray()[1].Value.ToArray()[0].Equals("two"));
            Assert.IsTrue(l.Count==2);
        }
    }
}