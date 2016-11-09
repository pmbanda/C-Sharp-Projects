/*Author:   Peter Eugene Mbanda
**Date:     2/12/2016
**Purpose:  Application to reverse variable positions and display array  
**          highest lowest sum and average values
**
**@all rights reserved
**@not for unauthorised use
*/
using System;

namespace IntegerFacts
{
    class Program
    {
        /*
            decare total size of array
            and obtain first index last index
        */
        const int SIZE = 20;    
        static int[] numArray = new int[SIZE];
        const int FIRST_ARRAY_POSITION = 0;
        const int LAST_ARRAY_POSITION = SIZE - 1;

        static void Main(string[] args)
        {
            // variable declaration
            int num, highestValue, lowestValue;
            double sum, average;

            // implement the random number class
            Random r = new Random();

            // iterate through the array to populate random number in the array
            for (int i = 0; i < numArray.Length; ++i)
            {
                /*
                    obtain random number and populate
                    the array.
                */
                num = r.Next(1, 999);
                numArray[i] = num;
            }

            Console.WriteLine("Numbers in the Array: ");
            DisplayArray(numArray);

            // invoke method call that assigns values at the method level using output reference
            Calculations(out highestValue, out lowestValue, out sum, out average);

            Console.WriteLine();

            //display the highest value , lowest value, sum and the average
            Console.WriteLine("Highest Value >> {0} ", highestValue);
            Console.WriteLine("Lowest Value >> {0} ", lowestValue);
            Console.WriteLine("Sum >> {0} ", sum);
            Console.WriteLine("Average >> {0} ", average.ToString("F"));

            Console.ReadLine();

        }

        static void Calculations(out int highestValue, out int lowestValue, out double sum, out double average)
        {
            // initial sum variable number
            // initial average variable number
            sum = 0; 
            average = 0.0;

            //sort the array in ascending order
            Array.Sort(numArray);

            // assign last array value to the high value variable
            // assign first array value to the lowest value variable
            highestValue = numArray[LAST_ARRAY_POSITION];
            lowestValue = numArray[FIRST_ARRAY_POSITION];

            // iterate over the array to accumulate the sum of all the array numbers 
            for (int i = 0; i < numArray.Length; ++i)
                sum += numArray[i];

            // obtain the average by dividing the sum by the array size
            average = sum / SIZE;

        }
        static void DisplayArray(params int [] array )
        {
            // iterate through the array to display the values 
            for (int i = 0; i < array.Length; ++i)
                Console.Write( array[i] + " ");
            Console.WriteLine();
        }
    }
}
