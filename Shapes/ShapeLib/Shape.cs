using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace ShapeLib
{
    public abstract class Shape
    {
        protected ConsoleColor Color { get; set; }
        public  abstract double Area { get; }

        protected Shape(ConsoleColor c)
        {
            Color = c;
        }
        protected Shape()
        {
            Color = ConsoleColor.White;
        }

        public virtual void Display()
        {
            Console.ForegroundColor = Color;
        }
    }
}