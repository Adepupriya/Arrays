using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class3
    {
        static void Main(string[] args)//Maximum and Minimum in an Array
        {
            int[] numbers = { 15, 42, 3, 27, 9, 54 };
            int max = numbers.Max();
            int min = numbers.Min();

            Console.WriteLine($"Maximum: {max}");
            Console.WriteLine($"Minimum: {min}");
        }
    }
}
