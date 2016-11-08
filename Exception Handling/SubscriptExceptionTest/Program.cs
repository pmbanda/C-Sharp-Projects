//Author:   Peter Eugene Mbanda
//Date:     3/30/2016
//Purpose:  Index out of bounds exception application

/*
Created by Peter Eugene M
Instructions from Visual C# by Joyce Farrell 2015
Under no circumstance for distribution
unless with permission
Rights Reserved @PemBrand software
*/
using System;
using static System.Console;

namespace SubscriptExceptionTest
{
    class SubscriptException
    {
        static void Main(string[] args)
        {
            int sub;
            const int QUIT = 99;//sentinel value
            //elements in the array
            const int ARRAY_ELEMENTS = 20;
            //declare an array of 20 doubles
            double[] numbers = new double[ARRAY_ELEMENTS];

            Random rand = new Random();//random number generation

            //populate the double values to the array
            for (int i = 0; i < numbers.Length; i++)                           
                numbers[i] = rand.NextDouble() * 100;
            
            
                //prompt the user to enter the subscript
                Write("Enter an array subscript or {0} to quit: ", QUIT);
                sub = Convert.ToInt32(ReadLine());

             while (sub != QUIT)
             {
                 try
                 {
                     //display the value at the particular subscript
                     WriteLine("Index {0} contains value {1} ", sub, numbers[sub].ToString("F2"));

                     WriteLine();
                     //re-prompt the user
                     Write("Enter an array subscript or {0} to quit: ", QUIT);
                     sub = Convert.ToInt32(ReadLine());
                   
                 }
                 catch (IndexOutOfRangeException e)//catch the error if index array is out of range
                 {
                     WriteLine(e.Message + "\n");//display the message of object caught
                    Write("Enter an array subscript or {0} to quit: ", QUIT);
                    sub = Convert.ToInt32(ReadLine());

                }
                 catch (Exception e)//if other general errors exist catch with base class
                 {
                     WriteLine(e.Message + "\n");
                    Write("Enter an array subscript or {0} to quit: ", QUIT);
                    sub = Convert.ToInt32(ReadLine());
                }
              }
            if (sub == QUIT)
                Environment.Exit(0);
            
            
            ReadLine();
        }
    }
}
