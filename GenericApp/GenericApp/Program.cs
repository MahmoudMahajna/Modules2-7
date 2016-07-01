using System;
using System.Collections.Generic;

namespace GenericApp
{
    class Program
    {
        static void Main(string[] args)
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
            DisplayMultiDictionary(multiDictionary);
        }

        public static void DisplayMultiDictionary(MultiDictionary<int,string> multiDictionary)
        {
            foreach (var valueKey in multiDictionary)
            {
                DisplayValuesByKey(valueKey);
                Console.WriteLine();
            }
        }

        private static void DisplayValuesByKey(KeyValuePair<int,ICollection<string>> keyValue)
        {
            Console.Write($"{keyValue.Key}: ");
            foreach (var value in keyValue.Value)
            {
                Console.Write($"{value}, ");
            }
        }
    }
}
