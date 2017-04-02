using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize varialbes
            int facNum = 0;
            int limit = 0;
            // User enters number
            Console.Write("Please enter a number between 1 and 100: ");
            String numString = Console.ReadLine();
            // Convert string to Int
            int num = Convert.ToInt32(numString);

            // calculating factorial
            facNum = num - 1;
            limit = facNum;
            for (int i = 1; i < limit; i++)
            {
              facNum = facNum * i;
            }

            // Wilson's Theorem: number is prime iff [(n - 1)! + 1]/n is an integer
            // figure out how to remove 1 as prime

            if (((facNum + 1) % num) == 0)
            {
                Console.WriteLine("The number {0} is a prime number", num);
            }
            else
            {
                Console.WriteLine("The number {0} is not a prime number", num);
            }
        }
    }
}
