using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerArray = new[]
            {
                new Customer("mahmoud", 123, "haifa"),
                new Customer("john", 11, "tel-aviv"),
                new Customer("sami", 15, "haifa"),
                new Customer("adam", 22, "hadera"),
                new Customer("mohammad", 132, "um-al-fahem"),
                new Customer("maHmoud", 123, "haifa"),
                new Customer("maHMoud", 44, "haifa"),
                new Customer("adam", 22, "hadera")
            };         
            SortAndDisplayByName(customerArray);   
            Console.WriteLine("***************");
            SortAndDisplayById(customerArray);
        }

        private static void SortAndDisplayByName(Customer[] customerArray )
        {
            Array.Sort(customerArray);
            Console.WriteLine("Sorting by Name");
            foreach (var customer in customerArray)
            {
                Console.WriteLine(customer);
            }
        }
        private static void SortAndDisplayById(Customer[] customerArray)
        {
            Console.WriteLine("Sorting by ID");
            Array.Sort(customerArray, new AnotherCustomerComparer());
            foreach (var customer in customerArray)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
