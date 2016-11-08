//Author:   Peter Eugene Mbanda
//Date:     1/26/2016
//Purpose:  Tipping Table Calculator
using System;
using static System.Console;

namespace TippingTable3
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variables declaration 
            double minDinnerPrice, maxDinnerPrice, tipRate, tip, lowRate, highRate;
            const double TIPSTEP = 0.05;//tip step number
            const double DINNERSTEP = 10.00;//dinner step number

            //low tip user prompt
            Write("Lowest tipping Percentage: ");
            lowRate = Convert.ToDouble(ReadLine());
            lowRate /= 100.0;

            //high tip user prompt
            Write("Highest tipping Percentage: ");
            highRate = Convert.ToDouble(ReadLine());
            highRate /= 100.0;

            //minimum dinner price user prompt
            Write("Minimum dinner price: ");
            minDinnerPrice = Convert.ToDouble(ReadLine());

            //maximum dinner price user prompt
            Write("Maximum dinner price: ");
            maxDinnerPrice = Convert.ToDouble(ReadLine());

            WriteLine();
            //loop throught the lowest tip rate to the 
            //highest tip rate
            Write("Price");
            for (tipRate = lowRate; tipRate <= highRate; tipRate += TIPSTEP)
                Write("{0,8}",tipRate.ToString("F"));//display the values
            WriteLine();
            WriteLine("----------------------------------------");//line separator

            tipRate = lowRate;//assign the tip rate to the low rate 

            //outer loop for the minimum dinner price
            //and tip values in increments based on the tip rate 
            while(minDinnerPrice <= maxDinnerPrice)
            {
                Write("{0,8}", minDinnerPrice.ToString("C"));
                while(tipRate <= highRate)
                {
                    //inner loop to display the tip values 
                    tip = minDinnerPrice * tipRate;
                    Write("{0,8}", tip.ToString("C"));
                    tipRate += TIPSTEP;
                }
                minDinnerPrice += DINNERSTEP;//increment based on the dinner step value
                tipRate = lowRate;
                WriteLine();
            }
            ReadLine();
        }
    }
}
