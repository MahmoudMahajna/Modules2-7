using System;
using System.Collections;
using System.Text;
using ShapeLib;

namespace ShapesApp
{
    public class ShapeManager
    {
        private ArrayList _shapes;
        public int Count { get; private set; }

        public ShapeManager()
        {
            _shapes=new ArrayList();
        }
        public void Add(Shape shape)
        {
            _shapes.Add(shape);
            Count++;
        }
         public object this[int index] => _shapes[index];

        public void DisplayAll()
        {
            foreach (var element in _shapes)
            {
                var shape = (Shape) element;
                shape.Display();
                Console.WriteLine($"Area: {shape.Area}");
                Console.WriteLine("******************");
            }
        }

        public void Save(StringBuilder sb)
        {
            foreach (var element in _shapes)
            {
                if (!(element is IPersist)) continue;
                var r = element as Rectangle;
                r?.Write(sb);
                var e = element as Ellipse;
                e?.Write(sb);
            }
        }
    }
}