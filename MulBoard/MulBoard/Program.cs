using System;

namespace MulBoard
{
    //Not printing the left column or the last row.

    class Program
    {
        static void Main()
        {
            var mb=new MulBoardView(10);
            mb.DisplayBoard();
        }
    }
}
