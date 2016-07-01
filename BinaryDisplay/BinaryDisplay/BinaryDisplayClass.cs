using System;
using System.Linq;

namespace BinaryDisplay
{
    public class BinaryDisplayClass
    {
        public void BinaryDisplay()
        {
            int num;
            GetInput(out num);
            var binar = Convert.ToString(num, 2);
            Console.WriteLine($"Binary: {binar}");
            var counter = GetNumberOf1(num);
            Console.WriteLine($"number of 1 is:{counter}");
        }

        public  int GetNumberOf1(int num)
        {
            var counter = 0;
            if (num >= 0)
            {
                while (num > 0)
                {
                    counter += num & 1;
                    num >>= 1;
                }
                return counter;
            }
            var binar = Convert.ToString(num, 2);
            return binar.Aggregate(counter, (current, bit) => bit == '1' ? current + 1 : current);
        }
        private  void GetInput(out int num)
        {
            var flag = GetAndTryParse(out num);
            while (!flag)
            {
                flag = GetAndTryParse(out num);
            }
        }

        private bool GetAndTryParse(out int num)
        {
            Console.WriteLine("Enter integer number");
            var input = Console.ReadLine();
            var flag = int.TryParse(input, out num);
            return flag;
        }
    }
}