//Author:       Peter Eugene Mbanda
//Date:         2/2/2016
//Purpose:      Rate of calls per minute depending on the area codes

using System;
using static System.Console;

namespace ChatAWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare class variables
            double total;
            bool exists = false;

            //array of area codes 
            Int32[] areaCode = { 262, 414, 608, 715, 815, 920 };

            //  rate of calls array 
            double[] per_minute_rate = { 0.07, 0.10, 0.05, 0.16, 0.24, 0.14 };

            //  prompt the user for the area code
            Write("Enter area code: ");
            int code = Convert.ToInt32(ReadLine());

            WriteLine();

            //  iterate through the loop to determine if the zip code exists
            for (int i = 0; i < areaCode.Length; ++i)
            {
                if (code == areaCode[i])
                {
                    // prompt user for time entry 
                    Write("Price per minute for the call is >> " + per_minute_rate[i]);
                    WriteLine();

                    // prompt user for the length of time the call made in minutes
                    Write("Enter the time in minutes for the call: >> ");
                    double time = Convert.ToDouble(ReadLine());

                    // multiply the duration of call and price per minute 
                    total = time * per_minute_rate[i];

                    // assign if zip code is accessed
                    WriteLine("The total cost for the call is " + total.ToString("C2"));
                    exists = true;
                }
            }

            // if the zip code does NOT exist display the message below
            if (!exists)
                WriteLine("The zip code does NOT exist ");
            ReadLine();

        }
    }
}
