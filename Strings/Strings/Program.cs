using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var str = Console.ReadLine();
                var sc = new StringsClass(str);
                if (sc._words == null) return;
                Console.WriteLine($"Number of words is {sc.Count}");
                sc.ArrayReverse();
                Console.WriteLine($"Reversed: {sc}");
                sc.ArraySort();
                Console.WriteLine($"Sorted: {sc}");
            }
        }
    }
}
