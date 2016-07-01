using System;

namespace ShapeLib
{
    public class Circle:Ellipse
    {
        public Circle(double a) : base(a, a) { }
        public Circle(double a,ConsoleColor c) : base(a, a,c) { }

        public override void Display()
        {
            Console.ForegroundColor = Color;
            Console.WriteLine("Circle");
            Console.WriteLine($"R: {A}");
        }
    }
}