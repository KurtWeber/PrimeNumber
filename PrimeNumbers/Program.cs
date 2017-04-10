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
            int num = 0;
            int divCount = 0;
            // User enters number
            Console.Write("Please enter a number between 1 and 100: ");
            String numString = Console.ReadLine();
            // Convert string to Int
            num = Convert.ToInt32(numString);

            // Definition of a prime number - A number that can be divided evenly only by 1, or itself. 

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divCount = divCount + 1;
                }
            }
            if (divCount <= 2)
            {
                Console.WriteLine("{0} is a prime number", num);
            }
            else if (divCount > 2)
            {
                Console.WriteLine("{0} is not a prime number", num);
            }
        }
    }
}
