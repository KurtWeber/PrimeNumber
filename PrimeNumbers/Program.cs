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
            int facNum = 0;
            // User enters number
            Console.Write("Please enter a number between 1 and 100: ");
            String numString = Console.ReadLine();
            // Convert string to Int
            int num = Convert.ToInt32(numString);

            // calculating factorial
            facNum = num - 1;
            int limit = facNum;
            Console.WriteLine("num = {0} and facNum = {1}", num, facNum);

            for (int i = 1; i < limit; i++)
            {
                Console.WriteLine("num = {0} and facNum = {1}", num, facNum);
                Console.WriteLine("i = {0}",i);
                facNum = facNum * i;
            }

            // number is prime iff [(n - 1)! + 1]/n is an integer



            Console.WriteLine("num = {0} and facNum = {1}", num, facNum);

        }
    }
}
