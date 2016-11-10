//Author:   Peter Eugene Mbanda
//Date:     2/2/2016
//Purpose:  bus company application

using System;
using static System.Console;

namespace WhippetBus
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare ticket price array
            int subscript;
            double price = 0;
           
            double[] ticket_price = new double[] { 25.00,  40.00,  55.00,  70.00 };
            // declare distance in miles array
            int []distance_in_miles = new int[]  {    0 ,   100,   300,    500 };

            // enter the trip distance
            Write("Enter the trip distance: ");
            UInt16 distance = Convert.ToUInt16(ReadLine());

            // upper subscript limit
            subscript = distance_in_miles.Length - 1;

            WriteLine();

            while (subscript >= 0 && distance < distance_in_miles[subscript])
            {
                // subtract the subscript if number falls on the low range values
                --subscript;
            }

            // assign value to the price
            price = ticket_price[subscript];


            // display the ticket price
            WriteLine("The ticket price is " + price.ToString("C2")); 

            ReadLine();
        }
    }
}
