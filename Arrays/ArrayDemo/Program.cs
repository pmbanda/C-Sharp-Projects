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
            //sentinel value declaration to terminate entry 
            const int sentinel_value = 999;
            int option;

            //total size of array
            const int size = 8;
            int[] array = new int[size];

            //iterate through the array to enter the array contents
            for (int i = 0; i < array.Length; ++i)
            {
                Write("Enter a value in the array >> ");
                array[i] = Convert.ToInt32(ReadLine());//convert the array value to an integer

                if (array[i] != sentinel_value)
                    continue;
                else
                {
                    array[i] = 0;
                    break;//break out of array if the sentinel value has been entered
                }
            }
            WriteLine();

            //user prompt for options 
            WriteLine("Enter 1 to (view list in order from first to last )");
            WriteLine("Enter 2 to (view list in order from last to first )");
            WriteLine("Enter 3 to (chose a specific position to view )");
            option = Convert.ToInt32(ReadLine());//enter the option chosen by the user

            WriteLine();

            switch (option)
            {
                case 1:
                    //iterate through the list to
                    //view array list in order from the first to the last
                    WriteLine("View array contents from the first to the last ");
                    for (int i = 0; i < array.Length; ++i)
                        WriteLine(array[i]);
                    break;

                case 2:
                    //iterate through the list to
                    //view array list in order from the last to the first
                    Array.Reverse(array);
                    WriteLine("View array contents from the last to the first ");
                    for (int i = 0; i < array.Length; ++i)
                        WriteLine(array[i]);
                    break;

                case 3:
                    //prompt user for index input
                    WriteLine("Enter the index you want to view between 0 and " + (array.Length - 1));
                    int num = Convert.ToInt32(ReadLine());

                    for (int i = 0; i < array.Length; ++i) { }
                 
                    //display index if the array falls within range 
                    if (num <= (array.Length - 1))
                        WriteLine("Content at position " + num + " is " + array[num]);
                    else
                        WriteLine("Index you entered does not exist ");//index out of range 
                    break;
                    //default:
            }

            ReadLine();
        }
    }
}
