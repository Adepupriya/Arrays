using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the starting value: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending value: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nArmstrong numbers in range ({start}, {end}):");

            for (int i = start; i <= end; i++)
            {
                if (IsArmstrong(i))
                {
                    Console.Write(i + " ");
                }
            }
           bool IsArmstrong(int num)
            {
                int originalNum = num;
                int sum = 0;
                int digits = num.ToString().Length;

                while (num > 0)
                {
                    int digit = num % 10;  // Extract last digit
                    sum += (int)Math.Pow(digit, digits);  // Raise to power and add
                    num /= 10;  // Remove last digit
                }

                return sum == originalNum;  // Check if sum equals original number
            }
        }
    }
    
}
