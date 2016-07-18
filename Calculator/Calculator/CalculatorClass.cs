using System;
using System.Linq;

namespace Calculator
{
    public class CalculatorClass
    {
        //Nice
        public void Start()
        {
            double number1, number2;
            GetNumbers(out number1, out number2);
            char op;
            GetOperator(out op);
            var result = Calculate(number1, number2, op);
            Console.WriteLine($"{number1} {op} {number2} = {result}");
        }
        private  void GetNumbers(out double number1, out double number2)
        {
            Console.WriteLine("Enter first number");
            GetLegalNumber(out number1);
            Console.WriteLine("Enter second number");
            GetLegalNumber(out number2);
        }

        //It is good you have extracted this as a seperate method.
        private  void GetLegalNumber(out double number1)
        {
            bool flag;
            ReadLineAndTryParse(out flag, out number1);
            while (!flag)
            {
                Console.WriteLine("Enter a number");
                ReadLineAndTryParse(out flag, out number1);
            }
        }

        //You could have eliminated 'flag' from the out argument and returned it instead as a method result.
        //This is not C/C++ ;)
        private  void ReadLineAndTryParse(out bool flag, out double number1)
        {
            var input = Console.ReadLine();
            flag = double.TryParse(input, out number1);
        }

        private  void GetOperator(out char op)
        {
            bool flag;
            GetAndCheckOperator(out flag, out op);

            //Maybe it was better to define this at the class level.
            var arr =new[] { '+', '-', '*', '/' };
            while (!flag || !arr.Contains(op))
            {
                GetAndCheckOperator(out flag, out op);
            }
        }

        //Did you notice that there is a duplication in writing "+,-,*,/"? Also, if you'll need to add a new operator you would have to add it
        //In more that one place. In the array above (inside GetOperator) and also in each printing message
        private  void GetAndCheckOperator(out bool flag, out char op)
        {
            Console.WriteLine("insert one of these operators +,-,*,/");
            var input = Console.ReadLine();
            flag = char.TryParse(input, out op);
        }

        //It is nice that you have used the 'checked' statement. Though, I don't think double operations will yield Overflow.
        public  double Calculate(double number1, double number2, char op)
        {
            double result = 0;
            switch (op)
            {
                case '+':
                    {
                        checked
                        {
                            result = number1 + number2;
                            break;
                        }
                    }
                case '-':
                    //Why didn't you use 'checked'. You used it in + and *. An Underflow could still happen with '/'
                    result = number1 - number2;
                    break;
                case '*':
                    {
                        checked
                        {
                            result = number1 * number2;
                            break;
                        }
                    }
                case '/':
                    //Same comment as '-'.
                    result = number1 / number2;
                    break;
            }
            return result;
        }
    }
}