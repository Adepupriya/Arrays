using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            {
                int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9} };

                Console.WriteLine("2D Array Elements:");
                Console.WriteLine("2D Array Elements:");
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    Console.WriteLine();
                }




            }
        }
    }
}
