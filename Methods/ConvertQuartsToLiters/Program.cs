//Author:   Peter Eugene Mbanda
//Date:     2/5/2016
//Purpose:  Quarts to liter convertion

using System;
using static System.Console;

namespace ConvertQuartsToLiters
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare variable
            double quartz;

            //prompt user for quarts
            Write("Enter the number of quartz: ");
            quartz = Convert.ToDouble(ReadLine());
            WriteLine();
            //display liter amount
            WriteLine("{0} Quarts is equivalent to {1} Liters", quartz, convertToLiters(quartz).ToString("F"));

            ReadLine();
        }
        static double convertToLiters(double quartz)
        {
            //declare liter variable
            double liter;
            const double QUARTS_PER_LITER = 0.946352946;//constant quarts per liter

            liter = quartz * QUARTS_PER_LITER;//convert quarts to liters

            return liter;//return the value
        }
    }
}
