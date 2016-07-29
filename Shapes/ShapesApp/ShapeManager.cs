using System;
using System.Collections;
using System.Text;
using ShapeLib;

namespace ShapesApp
{
    public class ShapeManager
    {
        private ArrayList _shapes;

        /**
         * Consider : '_shapes.Count;'
         * It would mean that you do not need to update your 'Counter'.
         */
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

        /**
      
      What happens when you add more shapes?
      Do you add more cases to the loop body?
      What happens if you want to use this method for any shape out there, even those which are not in your code?
      Polymorphism is the answer

      Consider this implementation:

          foreach (var persistable in Shapes.OfType<IPersist>())
          {
             persistable.Write(st);
          }

      OfType will select only members which are assignable to an IPersist reference and return such a collection
      https://msdn.microsoft.com/en-us/library/bb360913(v=vs.110).aspx

      */
        public void Save(StringBuilder sb)
        {
            foreach (var element in _shapes)
            {
                if (!(element is IPersist)) continue;
                /** TODO notice - you almost had it:
                 (element as IPersist).Write(sb);
                 */
                var r = element as Rectangle;
                r?.Write(sb);
                var e = element as Ellipse;
                e?.Write(sb);
            }
        }
    }
}