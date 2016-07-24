using System;

namespace MulBoard
{
    public class MulBoardView
    {
        private int _dim;
        public MulBoardView(int dim)
        {
            _dim = dim;
        }

        public void DisplayBoard()
        {
            for (var i = 0; i < _dim; i++)
            {
                for (var j = 0; j < _dim; j++)
                {
                    var r = (i+1) * (j+1);
                    Console.Write($"{r,4}");
                }
                Console.WriteLine();
            }
        }
    }
}