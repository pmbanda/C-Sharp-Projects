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
            // initialize array
            int[] arrayNum = { 12, 85, 76, 122, 568 };

            /*
                pass numbers in the average method 
                with different arguments
            */

            average(10, 100, 20, 300);

            average(1, 22, 10);

            average(arrayNum);

            Console.ReadLine();
        }

        static void average(params int [] numbers )
        {
            // declare sum variable to accumulate the total 
            double sum = 0;
            double average = 0;

            Console.Write("The average of >> " + numbers.Length + " Numbers\n");
            //iterate through the arrays
            foreach (int item in numbers)
            {
                // display numbers
                Console.Write("{0} ", item );
                sum += item;
            }


            average = Convert.ToDouble((sum / numbers.Length));//calculate the average
            Console.WriteLine(" is " + average.ToString("F") + "\n");//display the average
        }
    }
}
