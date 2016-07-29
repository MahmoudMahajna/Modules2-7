using System;
using System.Text;

namespace ShapeLib
{
    public class Rectangle:Shape,IPersist,IComparable
    {
        protected double Width { get; set; }
        protected double Height { get; set; }
        public override double Area { get; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
            Area = Width * Height;
        }
        public Rectangle(double width, double height,ConsoleColor c):base(c)
        {
            Width = width;
            Height = height;
            Area = Width*Height;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Rectangle");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Width:{Width}");
        }

        public void Write(StringBuilder sb)
        {
            sb.AppendLine($"Height: {Height}");
            sb.AppendLine($"Width: {Width}");
        }

        public int CompareTo(object obj)
        {
            /**
             if(obj==null)
                throw new System.ArgumentNullException();
             if(obj is Rectangle == false)
                throw new System.ArgumentException();

             */
            var r = obj as Rectangle;
            if (r == null) throw new Exception();
            return (int) ( r.Area-Area);
        }
    }
}