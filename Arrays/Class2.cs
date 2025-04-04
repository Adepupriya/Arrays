using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class2 //Basic Array Declaration and Intialization
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50,};
            Console.WriteLine("Array Elements:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
