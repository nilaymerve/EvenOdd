using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a function that takes an integer as an argument and returns "Even" for even numbers or "Odd" for odd numbers.
            int number = 7;
            Console.WriteLine(number + " is " + CheckEvenOrOdd(number));
        }
            public static string CheckEvenOrOdd(int number)
            {
                if (number % 2 == 0)
                    return "Even";
                else
                    return "Odd";
            }


    }
}

