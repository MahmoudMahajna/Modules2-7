using System;

namespace DollarStairs
{
    public class DollarStairsClass
    {
        public void DollarStairs()
        {
            int num;
            GetInput(out num);
            DrawDollar(num);
        }

        private void GetInput(out int num)
        {
            var flag = GetAndTryParse(out num);
            while (!flag || num < 0)
            {
                flag = GetAndTryParse(out num);
            }
        }

        private bool GetAndTryParse(out int num)
        {
            Console.WriteLine("Enter integer number");
            var input = Console.ReadLine();
            return int.TryParse(input, out num); 
        }
        private  void DrawDollar(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write('$');
                }
                Console.WriteLine();
            }
        }
    }
}