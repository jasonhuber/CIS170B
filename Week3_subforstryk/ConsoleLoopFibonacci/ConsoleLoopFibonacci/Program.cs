using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleLoopFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number of times to loop!");
            int numloop;
            numloop = int.Parse(Console.ReadLine());
            int prevnum = 1;
            int newnum = 1;
            int placeholdernum = 1;
            for (int i = 0; i < numloop; i++)
            {
                placeholdernum = prevnum + newnum;
                newnum = prevnum;
                prevnum = placeholdernum;
            }
            Console.WriteLine("Your final number is: " + placeholdernum.ToString());
            Console.ReadLine();
        }

    }
}
