using System;

namespace Quad
{
    //wrong result in input 5 6 1. Expected (-1, -0.2) Actual (-5, -25)
    //Shouldn't print 'The solution is 0' in case of fail validation, like if one of the argument isn't a number
    public class Program
    {
        public static void Main(string[] args)
        {
            var eq=new ExecQuad();
            eq.Quad(args);
        }
    }
}
