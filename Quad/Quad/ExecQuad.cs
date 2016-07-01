using System;

namespace Quad
{
    public class ExecQuad
    {
        public void Quad(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("there is no 3 parameters");
                return;
            }
            double a, b, c;
            CheckAndGetParameters(args, out a, out b, out c);
            double sol1, sol2;
            CalculateAndPritSolution(out sol1, out sol2, a, b, c);
        
    }

        public void CalculateAndPritSolution(out double sol1, out double sol2, double a, double b, double c)
        {
            const double TOLERANCE = 0.00000001;
            sol1 = double.PositiveInfinity;
            sol2 = double.PositiveInfinity;
            if (Math.Abs(a) < TOLERANCE && Math.Abs(b) > TOLERANCE)
            {
                sol1 = -c / b;
                Console.WriteLine($"the solution is {sol1}");
                return;
            }
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if (delta > 0)
            {
                sol1 = (-b + Math.Sqrt(delta)) / 2 * a;
                sol2 = (-b - Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine($"the solution is {sol1},{sol2}");
                return;
            }
            if (Math.Abs(delta) < TOLERANCE)
            {
                sol1 = (-b + Math.Sqrt(delta)) / 2 * a;
                Console.WriteLine($"the solution is {sol1}");
                return;
            }
            Console.WriteLine("there is no solution!");
        }

        public void CheckAndGetParameters(string[] args, out double a, out double b, out double c)
        {
            var flag = MyTryParse(args[0], out a);
            if (!flag)
                Console.WriteLine("the first parameter is not a number");
            flag = MyTryParse(args[1], out b);
            if (!flag)
                Console.WriteLine("the second parameter is not a number");
            flag = MyTryParse(args[2], out c);
            if (!flag)
                Console.WriteLine("the third parameter is not a number");
        }

        private bool MyTryParse(string s, out double num)
        {
            return double.TryParse(s, out num);
        }
    }
}