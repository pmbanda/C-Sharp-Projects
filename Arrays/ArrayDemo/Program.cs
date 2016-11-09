//Author:   Peter Eugene Mbanda
//Date:     1/29/2016
//Purpose:  Array Demo Application

using System;
using static System.Console;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // sentinel value declaration to terminate entry 
            const int sentinel_value = 999;
            int option;

            // total size of array
            const int size = 8;
            int[] arrayVal = new int[size];

            // iterate through the array to enter the array contents
            for (int i = 0; i < arrayVal.Length; ++i)
            {
                // convert the array value to an integer
                Write("Enter a value in the array >> ");
                arrayVal[i] = Convert.ToInt32(ReadLine());

                if (arrayVal[i] != sentinel_value)
                    continue;
                else
                {
                    // break out of array if the sentinel value has been entered
                    arrayVal[i] = 0;
                    break;
                }
            }
            WriteLine();

            // user prompt for options 
            WriteLine("Enter 1 to (view list in order from first to last )");
            WriteLine("Enter 2 to (view list in order from last to first )");
            WriteLine("Enter 3 to (chose a specific position to view )\n");

            option = Convert.ToInt32(ReadLine());//enter the option chosen by the user

            WriteLine();

            switch (option)
            {
                case 1:
                    firstToLast(arrayVal);
                    break;
                case 2:
                    lastToFirst(arrayVal);
                    break;
                case 3:
                    byIndex(arrayVal);
                    break;
            }

            ReadLine();
        }

        static void firstToLast(params int[] value)
        {
            /*
                iterate through the list to
                view array list in order from the last to the first
            */
            Array.Reverse(value);
            WriteLine("View array contents from the last to the first ");
            for (int i = 0; i < value.Length; ++i)
            {
                if (value[i] == 0)
                    return;
                WriteLine(value[i]);
            }
               
        }

        static void lastToFirst(params int[] value)
        {
            /*
                iterate through the list to
                view array list in order from the first to the last
            */
            WriteLine("View array contents from the first to the last ");
            for (int i = 0; i < value.Length; ++i)
            {
                if (value[i] == 0)
                    return;
                WriteLine(value[i]);
            }
        }

        static void byIndex(params int[] value)
        {
            //  prompt user for index input
            WriteLine("Enter the index you want to view between 0 and " + (value.Length - 1));
            int num = Convert.ToInt32(ReadLine());

            if (num <= (value.Length - 1))
            {
                // display index if the array falls within range 
                WriteLine("Content at position " + num + " is " + value[num]);
            }
            else
            {
                // index out of range
                WriteLine("Index you entered does not exist ");
            }
            
        }
    }
}
