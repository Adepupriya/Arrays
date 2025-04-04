using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class4
    {
        static void Main(string[] args)// Sorting an array
        {
            int[] numbers = { 22, 54, 67, 2, 12 };
            Array.Sort(numbers);
            Console.WriteLine("Sorted Array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
