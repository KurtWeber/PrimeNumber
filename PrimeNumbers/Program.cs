﻿using System;
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
            // User enters number
            Console.Write("Please enter a number between 1 and 100: ");
            String numString = Console.ReadLine();
            // Convert string to Int
            int num = Convert.ToInt32(numString);

            // number is prime iff [(n - 1)! + 1]/n is an integer
            for (int i = 0; i <= 100; i++ )
            {
                
            }


        }
    }
}
