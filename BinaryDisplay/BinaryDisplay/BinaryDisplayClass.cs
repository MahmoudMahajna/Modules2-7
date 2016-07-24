using System;
using System.Linq;

namespace BinaryDisplay
{
    //Consider removing the 'Class' postfix
    public class BinaryDisplayClass
    {
        public void BinaryDisplay()
        {
            int num;
            GetInput(out num);

            //I would have prefered you implemented this yourself.
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

            //1. Double converion - which is not good because it isn't efficiont.
            //2. You could have implemented this yourself, eventhough the number is negative. How would this effect your logic?
            //3. Instead of Aggreagete, it might be more elegant to use binar.Sum(c => '1' == c ? 1 : 0)
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