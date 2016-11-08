//Author:   Peter Eugene Mbanda
//Date:     2/5/2016
//Purpose:  Multiplication application

using System;
using static System.Console;

namespace Multiplication
{
        
    class Program
    {
            //total number range to be multiplied with integer
            const Int32 NUM_RANGE_TOTAL = 10;

        static void Main(string[] args)
        {
            Int32 num;//declare variable

            //prompt user
            Write("Enter an integer: ");
            num = Convert.ToInt32(ReadLine());

            //call method for multiplication display 
            DisplayMultiplicationTable(num);
            WriteLine();
            ReadLine();
        }
        static void DisplayMultiplicationTable(Int32 numbers )
        {
            WriteLine();

            //loop through numbers 1 - 10 
            for (int i = 2; i <= NUM_RANGE_TOTAL; i++)
            {
                //display the result
                WriteLine(i + " * " + numbers + " = " + (i * numbers));
            }
        }
    }
}
