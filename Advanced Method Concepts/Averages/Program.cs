/*Author:   Peter Eugene Mbanda
**Date:     2/12/2016
**Purpose:  App to determine number averages
**
**@all rights reserved
**@not for unauthorised use
*/
using System;

namespace Averages
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNum = { 12, 85, 76, 122, 568 };
            //insert the number of arguments as integers
            Console.WriteLine("Four numbers passed: ");
            average(10, 100, 20, 300);
            Console.WriteLine();
            Console.WriteLine("Three numbers passed: ");
            average(1, 22, 10);//as less integers
            Console.WriteLine();
            Console.WriteLine("Array  of numbers passed: ");
            average(arrayNum);//as array

            Console.ReadLine();
        }

        static void average(params int [] numbers )
        {
            //declare sum to accumulate the total
            double sum = 0;
            double average = 0;

            Console.Write("The average of >> ");
            //iterate through the arrays
            foreach (int item in numbers)
            {
                Console.Write("{0} ", item);
                sum += item;//populate the sum variable with the number in array
            }
            Console.WriteLine();
            average = (sum / numbers.Length);//calculate the average
            Console.WriteLine("The average is " + average.ToString("F"));//display the average
        }
    }
}
