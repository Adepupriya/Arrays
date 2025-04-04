using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50 };
            int searchElement = 30;
            int index = Array.IndexOf(numbers, searchElement);

            if (index != -1)

                Console.WriteLine($"Element found at index: {index}");
            else
                Console.WriteLine("Element not found");

        
        }
    }
}
