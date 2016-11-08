/*Author:   Peter Eugene Mbanda
Date:       1/8/2016
Purpose:    Convert miles to kilometers interactive application 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKilometersInteractive
{
    class Program
    {
        //constant value miles per kilometer 
        const double KILOMETERS_PER_MILE = 1.6;
        static void Main(string[] args)
        {
            //class variables
            double miles;
            double kilometers;

            //user prompt 
            Console.Write("Enter the number of miles >>  ");
            miles = Convert.ToDouble(Console.ReadLine());//console input

            kilometers = miles * KILOMETERS_PER_MILE;//convert to kilometer 

            //display output to user
            Console.WriteLine("{0} miles is {1} kilometers ", miles.ToString("F2") , kilometers.ToString("F2") );//display output in format

            Console.ReadLine();




        }
    }
}
