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
            int subscript;
            double price = 0;
            //declare ticket price array
            double[] ticket_price = new double[] { 25.00,  40.00,  55.00,   70.00 };
            //declare distance in miles array
            int []distance_in_miles = new int[]  {    0 ,   100,   300,     500 };

            Write("Enter the trip distance: ");
            UInt16 distance = Convert.ToUInt16(ReadLine());//enter the trip distance

            subscript = distance_in_miles.Length - 1;//upper subscript limit

            WriteLine();//empty white space

            while (subscript >= 0 && distance < distance_in_miles[subscript])
            {
                --subscript;//subtract the subscript if number falls on the low range values
            }
            price = ticket_price[subscript]; //assign value to the price
            
            WriteLine("The ticket price is " + price.ToString("C2"));//display the ticket price 

            ReadLine();
        }
    }
}
