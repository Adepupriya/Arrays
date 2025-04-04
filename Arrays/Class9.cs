using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the starting value: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the ending value: ");
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nPalindrome list ({start}, {end}):");

            for (int i = start; i <= end; i++)
            {
                if (IsPalindrome(i))
                {
                    Console.Write(i + " ");
                }
            }
        }

        // Method to check if a number is a palindrome
        static bool IsPalindrome(int num)
        {
            string strNum = num.ToString();
            char[] reversed = strNum.ToCharArray();
            Array.Reverse(reversed);
            return strNum == new string(reversed);
        }
    }
}
    