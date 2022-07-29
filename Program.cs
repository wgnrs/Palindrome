using System;

namespace PalindromeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int originalNumber = 0;
            int tempNumber = 0;
            int remainder = 0;
            int reverseNumber = 0;

            try
            {
                System.Console.WriteLine("Input a 4 digit number : ");
                originalNumber = int.Parse(Console.ReadLine());
                if (originalNumber.ToString().ToCharArray().Length != 4)
                    throw new Exception("Incorrect character size");
                System.Console.WriteLine();

                tempNumber = originalNumber;

                while (originalNumber > 0)
                {
                    remainder = originalNumber % 10;
                    reverseNumber = reverseNumber * 10 + remainder;
                    originalNumber /= 10;
                }
                if (tempNumber == reverseNumber)
                    Console.WriteLine("Entered number is a palindrome number");
                else
                    Console.WriteLine("Entered number is not a palindrome number");
            }
            catch (FormatException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}