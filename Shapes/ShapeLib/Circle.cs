using System;

namespace ShapeLib
{
    public class Circle:Ellipse
    {
        public Circle(double a) : base(a, a) { }
        public Circle(double a,ConsoleColor c) : base(a, a,c) { }

        public override void Display()
        {
            /**
             * You need to use 'base.Display()' and figure out how to not print out Ellipse's implementation.
             * Please revise your solution
             */
            Console.ForegroundColor = Color;
            Console.WriteLine("Circle");
            Console.WriteLine($"R: {A}");
        }
    }
}