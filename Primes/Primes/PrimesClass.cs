using System;
using System.Collections;

namespace Primes
{
    public class PrimesClass
    {
        public static void Start()
        {
            int a, b;
            GetNumbers(out a, out b);
            var arr = CalcPrimes(a, b);
            foreach (var prime in arr)
            {
                Console.Write($"{prime} ");
            }
            Console.WriteLine();
        }

        private static void GetNumbers(out int a, out int b)
        {
            a=GetNumber(1);
            b=GetNumber(2);
        }

        private static int GetNumber(int firstOrSecond)
        {
            var str = firstOrSecond == 1 ? "first" : "second";
            Console.WriteLine($"enter the {str} number (integer)");
            int num;
            var flag = GetAndTryParse(out num);
            while (!flag)
            {
                Console.WriteLine($"enter the {str} number (integer)");
                flag = GetAndTryParse(out num);
            }
            return num;
        }
        private static bool GetAndTryParse(out int num)
        {
            var input = Console.ReadLine();
            return int.TryParse(input, out num);
        }
        private static Array CalcPrimes(int a, int b)
        {
            var arr = new ArrayList();
            for (var i = a; i <= b; i++)
            {
                if (IsPrime(i)) arr.Add(i);
            }
            var intArray = new int[arr.Count];
            arr.CopyTo(intArray);
            return intArray;
        }

        private static bool IsPrime(int a)
        {
            for (var i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return a != 1;
        }
    }
}