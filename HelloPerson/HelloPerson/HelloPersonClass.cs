using System;

namespace HelloPerson
{
    //Good work
    public class HelloPersonClass
    {
        public void HelloPersonDo()
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();

            //You used C#'s features. Nice!
            Console.WriteLine($"hello {name}");

            int number;
            GetInput(out number);
            PrintNameStyle(number, name);
        }

        //You extracted this functionality into method, great choice.
        private  void GetInput(out int number)
        {
            bool flag;
            ReadLineAndTryParse(out flag, out number);
            while (!flag || !(number >= 1 && number <= 10))
            {
                ReadLineAndTryParse(out flag, out number);
            }
        }

        //I don't like the fact your are printing Console messaging inside a method that is part of logic validations.
        //though, itis good you have extracted the method too.
        private  void ReadLineAndTryParse(out bool flag, out int number)
        {
            Console.WriteLine("Enter a number from 1 to 10!");
            var input = Console.ReadLine();
            flag = int.TryParse(input, out number);
        }

        //Nice, you have read the MSDN documentation. 
        //Though, you can have used the format of interpolated strings to acheive the same.
        private  void PrintNameStyle(int number, string name)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"{new string(' ', i)}{name}");
            }
        }
    }
}