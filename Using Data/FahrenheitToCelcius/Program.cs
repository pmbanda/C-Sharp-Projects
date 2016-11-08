//Author:   Peter Eugene Mbanda
//Date:     1/14/2016
//Purpose:  Temperature calculator

using System;


namespace FahrenheitToCelcius
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare fahrenheit and celcius variables 
            double fahrenheit, celcius;

            //prompt user for temperature in fahrenheight
            Console.Write("Enter temperature in fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());

            celcius = (fahrenheit - 32) * 5 / 9.0;//calculate celcius formula

            Console.WriteLine();

            //display the values to the console
            Console.WriteLine("{0} fahrenheit is {1} celcius ", fahrenheit.ToString("F2"), celcius.ToString("F2"));

            Console.ReadLine();
        }
    }
}
