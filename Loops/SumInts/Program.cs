/*****************************************
*Author:    Peter Eugene Mbanda          *
*Date:      1/25/2016                    *
*Purpose:   Sum Integers                 *
******************************************/
using System;
using static System.Console;

namespace SumInts
{
    class Program
    {
        static void Main(string[] args)
        {
            //sentinel value to terminate the program
            const int finalValue = 999;
            //initialize the number and the sum variables 
            int num;
            int sum = 0;

            num = 0;
            //iterate through all the values in loop till the sentinel value is encountered
            while (num != finalValue)
            {
                Write("Enter a number: ");//user prompt
                num = Convert.ToInt32(ReadLine());//covert input to an integer
                if (num == finalValue)
                    break;
                sum += num;//get the sum of all the numbers 
            }

            WriteLine();
            //display the sum of all the numbers
            WriteLine("The sum of the numbers is " + sum );
            ReadLine();
        }
    }
}
