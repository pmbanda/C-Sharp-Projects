//Author:       Peter Eugene Mbanda
//Date:         2/2/2016
//Purpose:      Zip code application that verifies price at a particular zip code

using System;
using static System.Console;

namespace DeliveryCharges
{
    class Program
    {
        static void Main(string[] args)
        {
            // class variable
            bool exist = false;

            // initialize the zip codes in the array
            Int32[] zipCodes = new Int32[] { 73120, 74142, 75642, 76534, 72341, 75643, 76523, 75684, 75553, 76635 };

            // initialize the prices in the delivery areas
            double[] prices = new double[] { 100.25, 22.56, 800.25, 96.45, 122.32, 56.32, 456.25, 78.25, 965.25, 10.00 };

            // prompt the user to enter zip code
            Write("Enter zip code: ");
            int zipEntry = Convert.ToInt32(ReadLine());

            // iterate through loop to verify if a zip code matches 
            for (int i = 0; i < zipCodes.Length; ++i)
            {
                if (zipEntry == zipCodes[i])
                {
                    //if zip code matches display the message
                    WriteLine("The price of delivery to {0} is {1} ", zipCodes[i], prices[i].ToString("C2"));
                    exist = true;
                    break;
                }
                
            }

            // if the zip code does not match display the message
            if(!exist)
                WriteLine("Company does NOT deliver to zipcode ");
            

            ReadLine();
        }
    }
}
