using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Number2
{
    internal class PalindromeChecker
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            if (IsNumberPalindrome(input))
            {
                Console.WriteLine($"The number '{input}' is a numerical palindrome!");
            }
            else
            {
                Console.WriteLine($"The number '{input}' is not a palindrome.");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }

        static bool IsNumberPalindrome(string number)
        {
            number = number.ToLower(); // Case-insensitivity
            for (int i = 0, j = number.Length - 1; i < j; i++, j--)
            {
                if (number[i] != number[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}