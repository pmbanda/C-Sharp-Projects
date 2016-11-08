//Author:   Peter Eugene Mbanda
//Date:     2/8/2016
//Purpose:  Different wood prices application 

using System;
using static System.Console;

namespace Desks
{
    class DeskPrices
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
            numDrawers = DrawersInput();
            typeWood =  WoodType();
            WriteLine();
            totalCost = Cost(numDrawers, typeWood);
            DisplayDetails(numDrawers, typeWood, totalCost);//invoke method to display all the details

        }
        static int DrawersInput()
        {
            //local variable
            int drawers;

            //promt the user for the number of desks entry
            Write("Enter the number of drawers: ");
            drawers = Convert.ToInt32(ReadLine());

            return drawers;
        }
        static string WoodType()
        {
            //local variable
            char wood;
            string type = "";

            //promt the user for the number of desks entry
            Write("Enter the type of wood either (m o or p) : ");
            wood = Char.ToLower(Convert.ToChar(ReadLine()));

            if (wood == 'm')
                type = "Mahogany";
            else if (wood == 'o')
                type = "Oak";
            else if (wood == 'p')
                type = "Pine";

            return type;//return the type of wood as a string
        }
        static double Cost(double numberOfDrawers, string typeOfWood )
        {
            //declaration of the price variable to hold the final cost
            double price = 0;

            //select ststements to calulate cost based on the wood type
            if (typeOfWood.Equals("Pine"))
                price = (PINE* numberOfDrawers) + (SURCHARGE * numberOfDrawers);
            else if (typeOfWood.Equals("Oak"))
                price = (OAK * numberOfDrawers) + (SURCHARGE * numberOfDrawers);
            else
                price = (OTHER * numberOfDrawers) + (SURCHARGE * numberOfDrawers);

            return price;//return the total cost price
        }
        static void DisplayDetails(int numDrawers, string typeWood, double totalCost)
        {
            //method to display all the details and the final price
            WriteLine("Wood Type >> {0} ", typeWood);
            WriteLine("Number of drawers >> {0} ", numDrawers.ToString("D"));
            WriteLine("Total cost >> {0} ", totalCost.ToString("C"));
        }

    }
}
