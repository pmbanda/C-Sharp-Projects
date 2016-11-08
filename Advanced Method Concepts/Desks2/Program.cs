/*Author:   Peter Eugene Mbanda
**Date:     2/12/2016
**Purpose:  Application to determine price and type of wood used to make drawers 
**
**@all rights reserved
**@not for unauthorised use
*/
using System;
using static System.Console;

namespace Desks2
{
    class Program
    {
        //declaration of fixed wood prices
        const double PINE = 100;
        const double OAK = 140;
        const double OTHER = 180;
        const double SURCHARGE = 30;

        static void Main(string[] args)
        {
            //define local variables in main
            int numDrawers;
            string typeWood;
            double totalCost;

            //invoke methods for number of drawers
            //type of wood and the total cost
            DrawersInput(out numDrawers);
            WoodType(out typeWood);
            WriteLine();
            //insert arguments with last out reference to be assigned to total cost
            Cost(ref numDrawers, ref typeWood, out totalCost);

            DisplayDetails(ref numDrawers, ref typeWood, ref totalCost);//invoke method to display all the details

            ReadLine();
        }
        static void DrawersInput(out int drawers)
        {
            //promt the user for the number of desks entry
            Write("Enter the number of drawers: ");
            drawers = Convert.ToInt32(ReadLine());
        }
        static void WoodType(out string woodType)
        {
            //local variable
            char wood;
            woodType = "";

            //promt the user for the number of desks entry
            Write("Enter the type of wood either (m o or p) : ");
            wood = Char.ToLower(Convert.ToChar(ReadLine()));

            if (wood == 'm')
                woodType = "Mahogany";
            else if (wood == 'o')
                woodType = "Oak";
            else if (wood == 'p')
                woodType = "Pine";
        }
        static void Cost(ref int numberOfDrawers, ref string typeOfWood, out double totalCost)
        {
            //declaration of the price variable to hold the final cost
            totalCost = 0;

            //select ststements to calulate cost based on the wood type
            if (typeOfWood.Equals("Pine"))
                totalCost = (PINE * numberOfDrawers) + (SURCHARGE * numberOfDrawers);
            else if (typeOfWood.Equals("Oak"))
                totalCost = (OAK * numberOfDrawers) + (SURCHARGE * numberOfDrawers);
            else
                totalCost = (OTHER * numberOfDrawers) + (SURCHARGE * numberOfDrawers);

        }
        static void DisplayDetails(ref int numDrawers, ref string typeWood, ref double totalCost)
        {
            //method to display all the details and the final price
            WriteLine("Wood Type >> {0} ", typeWood);
            WriteLine("Number of drawers >> {0} ", numDrawers.ToString("D"));
            WriteLine("Total cost >> {0} ", totalCost.ToString("C"));
        }
    }
}
