using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            int[] sourceArray = { 1, 2, 3, 4, 5 };
            int[] destinationArray = new int[sourceArray.Length];

            Array.Copy(sourceArray, destinationArray, sourceArray.Length);

            Console.WriteLine("copied Array:");
            foreach(int num in destinationArray)
            {
                Console.Write(num + "");    
            }
        }
    }
}
