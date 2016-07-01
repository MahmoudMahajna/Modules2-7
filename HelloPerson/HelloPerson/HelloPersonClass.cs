using System;

namespace HelloPerson
{
    public class HelloPersonClass
    {
        public void HelloPersonDo()
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"hello {name}");
            int number;
            GetInput(out number);
            PrintNameStyle(number, name);
        }

        private  void GetInput(out int number)
        {
            bool flag;
            ReadLineAndTryParse(out flag, out number);
            while (!flag || !(number >= 1 && number <= 10))
            {
                ReadLineAndTryParse(out flag, out number);
            }
        }

        private  void ReadLineAndTryParse(out bool flag, out int number)
        {
            Console.WriteLine("Enter a number from 1 to 10!");
            var input = Console.ReadLine();
            flag = int.TryParse(input, out number);
        }

        private  void PrintNameStyle(int number, string name)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{new string(' ', i)}{name}");
            }
        }
    }
}