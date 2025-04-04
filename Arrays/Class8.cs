using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5},
            new int[] {6, 7, 8, 9}
        };

            Console.WriteLine("Jagged Array Elements:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                foreach (int num in jaggedArray[i])
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
