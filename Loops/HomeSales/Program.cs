/*****************************************
*   Author:    Peter Eugene Mbanda       *
*   Date:      1/25/2016                 *
*   Purpose:   Home sales application    *
******************************************/
using System;
using static System.Console;

namespace HomeSales
{
    class Program
    {
        static void Main(string[] args)
        {
            //define character variable
            string initialString;
            char initial;
            double total = 0,dTotal = 0, eTotal = 0, fTotal = 0;
            bool valid = false;

            //user prompt
            Write("Enter sales person initial (D E or F): ");
            initialString = (ReadLine());
            initial = char.ToLower(char.Parse(initialString));//convert string to a character value

            while (initial == 'd' || initial == 'e' || initial == 'f')
            {
                valid = true;
                //prompt for sales if the initial does not equal z
                Write("Enter the sales amount ");
                double sales = Convert.ToDouble(ReadLine());

                switch (initial)
                {
                    //use switch case to determine the user entered 
                    //and accmulate users total sales and total 
                    //amount for all the users
                    case 'd':
                        dTotal += sales;
                        break;
                    case 'e':
                        eTotal += sales;
                        break;
                    case 'f':
                        fTotal += sales;
                        break;
                    default:
                        break;
                }
                //prompt user again
                Write("Enter sales person initial (D E or F): ");
                initialString = (ReadLine());
                initial = char.ToLower(char.Parse(initialString));//convert string to a character value

                if (initial == 'z')
                {
                    WriteLine();

                    total += dTotal + eTotal + fTotal;//accumulate the total sales 
                    //display the values 
                    WriteLine("Daniel's total is {0} ", dTotal);
                    WriteLine("Edward's total is {0} ", eTotal);
                    WriteLine("Francis's total is {0} ", fTotal);
                    WriteLine("Grand total is {0} ", total);

                    //determine the salesperson with the highest sales
                    if (dTotal > eTotal && dTotal > fTotal)
                        WriteLine("Dave had the hightest sales");
                    else if (eTotal > dTotal && eTotal > fTotal)
                        WriteLine("Edward had the hightest sales");
                    else if (fTotal > eTotal && fTotal > dTotal)
                        WriteLine("Francis had the hightest sales");
                }
                else
                {
                    WriteLine();//if wrong initial entered
                    WriteLine("You entered wrong initials only (D E and F)");
                }
            }
            ReadLine();
        }
     }
}

