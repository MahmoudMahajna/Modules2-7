using System;
using System.Text;
using ShapeLib;

namespace ShapesApp
{
    class Program
    {
        static void Main()
        {
            var shapedManager=new ShapeManager();
            shapedManager.Add(new Ellipse(15, 3));
            shapedManager.Add(new Ellipse(15,3,ConsoleColor.Blue));
            shapedManager.Add(new Ellipse(3, 3,ConsoleColor.Cyan));
            shapedManager.Add(new Rectangle(20.5, 15.8,ConsoleColor.Red));
            shapedManager.Add(new Circle(10.5,ConsoleColor.Gray));
            shapedManager.Add(new Circle(4,ConsoleColor.DarkYellow));

            shapedManager.DisplayAll(); 
            var sb=new StringBuilder();
            shapedManager.Save(sb);
            Console.WriteLine(sb.ToString());
        }
    }
}
