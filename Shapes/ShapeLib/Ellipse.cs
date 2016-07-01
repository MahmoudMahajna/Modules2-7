using System;
using System.Text;

namespace ShapeLib
{
    public class Ellipse:Shape,IPersist,IComparable
    {
        public override double Area { get; }
        protected double A { get; set; }
        protected double B { get; set; }
        public Ellipse(double a, double b)
        {
            A = a;
            B = b;
            Area = Math.PI * A * B;
        }
        public Ellipse(double a, double b,ConsoleColor c):base(c)
        {
            A = a;
            B = b;
            Area = Math.PI*A*B;
        }

        public  override void Display()
        {
            base.Display();
            Console.WriteLine("Ellipse");
            Console.WriteLine($"a: {A}");
            Console.WriteLine($"b: {B}");
        }

        public void Write(StringBuilder sb)
        {
            sb.AppendLine($"a: {A}");
            sb.AppendLine($"b: {B}");
        }

        public int CompareTo(object obj)
        {
            var e = obj as Ellipse ;
            if(e==null)throw new Exception();
            return (int) (e.Area-Area);
        }
    }
}