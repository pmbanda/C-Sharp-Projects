//Author:   Peter Eugene Mbanda
//Date:     2/5/2016
//Purpose:  Application to calculate the amount of money used to paint a room

using System;
using static System.Console;

namespace PaintingEstimate
{
    class Program
    {
            static double ceilingFeet = 9.0;
        static void Main(string[] args)
        {
            //local variables length and width
            double lengthFeet, widthFeet;

            //user prompt  for length and width of the room
            Write("Enter the length in feet: ");
            lengthFeet = Convert.ToDouble(ReadLine());
            Write("Enter the width in feet: ");
            widthFeet = Convert.ToDouble(ReadLine());

            WriteLine();
            //display the painting quote
            WriteLine("Painting Quote ");
            WriteLine("Length of room: {0} Feet ", lengthFeet);
            WriteLine("Width of room: {0} Feet ", widthFeet);
            WriteLine("Ceiling Height: {0} Feet ", ceilingFeet);
            WriteLine("Total cost for painting room is {0} ", calculateCost(lengthFeet, widthFeet).ToString("C2"));//invoke the method call
            ReadLine();
        }
        static double calculateCost(double length, double width)
        {
            //height of the ceiling and total area variable
            double totalArea = 0;
            const double PRICE_PER_SQFEET = 6.00;//price per square feet
            double price = 0.00;

            //area of opposite sides of walls on each side
            double oppositeSides1 = (length * ceilingFeet) * 2;
            double oppositeSides2 = (width * ceilingFeet) * 2;

            //total area of both walls 
            totalArea += (oppositeSides1 + oppositeSides2);
            price = (totalArea * PRICE_PER_SQFEET);

            return price;

        }
    }
}
