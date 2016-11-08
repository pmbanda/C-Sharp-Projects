//Author:   Peter Eugene Mbanda 
//Date:     1/15/2016
//Purpose:  Dollar converter 
using System;
using static System.Console;

namespace Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare the variables
            double dollars;
            int remainingAmount, twenties, tens, fives, ones;

            //prompt user for the dollar amount
            Write("Enter the dollar amount >> ");
            dollars = Convert.ToDouble(ReadLine());

            //determine the number of twenties
            twenties = (Int32)dollars / 20;
            remainingAmount = (Int32)dollars % 20;

            //determine the number of tens
            tens = remainingAmount / 10;
            remainingAmount = remainingAmount % 10;

            //determine the number of fives
            fives = remainingAmount / 5;
            remainingAmount = remainingAmount % 5;

            //determine the number of ones
            ones = remainingAmount / 1;
            remainingAmount = remainingAmount % 1;

            WriteLine();

            //display the results 
            WriteLine("Dollar amount: {0} ", (Int32)dollars );
            WriteLine("Twenties: {0} ", twenties);
            WriteLine("Tens: {0} ", tens);
            WriteLine("Fives: {0} ", fives);
            WriteLine("Ones: {0} ", ones);

            ReadLine();


        }
    }
}
