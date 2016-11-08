//Author:   Peter Eugene Mbanda
//Date:     3/30/2016
//Purpose:  Application to determine the square root of numbers

/*
Created by Peter Eugene M
Instructions from Visual C# by Joyce Farrell 2015
Under no circumstance for distribution
unless with permission
Rights Reserved @PemBrand software
*/
using System;
using static System.Console;

namespace FindSquareRoot
{
    class SqRoot
    {
        static void Main(string[] args)
        {
            //local variable
            double value;

            //user prompt
            try
            {
                //user prompt
                Write("Enter number to determine square root: ");
                value = Convert.ToDouble(ReadLine());

                //display value
                WriteLine("The square root of {0} is {1} ", value, DetermineSquareRoot(value).ToString("F2"));

            }
            //catch exceptions in the main class and display the values
            catch(ApplicationException e)
            {
                WriteLine("ERROR-" + e.Message);
            }
            catch (Exception e)//catch general exception 
            {
                value = 0;
                WriteLine("ERROR-" + e.Message + "\n");
            }

            ReadLine();
        }
        private static double DetermineSquareRoot(double value)
        {
            //local method variable to store square root
            double root;

            root = Math.Sqrt(value);//square root calculation

            //if number is negative throw the exception below
            if (value <= 0)
            {
                root = 0;//assign the root value to zero
                WriteLine("The square root of {0} is {1} ", value, root);
                throw (new ApplicationException("ERROR-Number cant be negative\n"));
            }

            return root;//return value to the calling method
        }
    }
    
}
