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
            //total size of array
            const int SIZE = 20;
            static int[] numArray = new int[SIZE];//array declaration
            const int FIRST_ARRAY_POSITION = 0;//arrays first index
            const int LAST_ARRAY_POSITION = SIZE - 1;//arrays last index

        static void Main(string[] args)
        {
            //variable declaration
            int num, highestValue, lowestValue, sum;
            double average;

            Random r = new Random();//implement the random number class

            //iterate through the array to populate random number in the array
            for (int i = 0; i < numArray.Length; ++i)
            {
                num = r.Next(1, 999);//obtain random number
                numArray[i] = num;//populate the values in the array 
            }
            Console.WriteLine("Numbers in the Array: ");
            DisplayArray(numArray);
            //invoke method call that assigns values at the method level using output reference
            Calculations(out highestValue, out lowestValue, out sum, out average);

            Console.WriteLine();

            //display the highest value , lowest value, sum and the average
            Console.WriteLine("Highest Value >> {0} ", highestValue);
            Console.WriteLine("Lowest Value >> {0} ", lowestValue);
            Console.WriteLine("Sum >> {0} ", sum);
            Console.WriteLine("Average >> {0} ", average.ToString("F"));

            Console.ReadLine();

        }

        static void Calculations(out int highestValue, out int lowestValue, out int sum, out double average)
        {
            sum = 0;//initial sum variable number 
            average = 0.0;//initial average variable number

            Array.Sort(numArray);//sort the array in ascending order
            highestValue = numArray[LAST_ARRAY_POSITION];//assign last array value to the high value variable
            lowestValue = numArray[FIRST_ARRAY_POSITION];//assign first array value to the lowest value variable

            //iterate over the array to accumulate the sum of all the array numbers 
            for (int i = 0; i < numArray.Length; ++i)
                sum += numArray[i];

            average = sum / SIZE;//obtain the average by dividing the sum by the array size

        }
        static void DisplayArray(params int [] array )
        {
            //iterate through the array to display the values 
            for (int i = 0; i < array.Length; ++i)
                Console.Write( array[i] + " ");
            Console.WriteLine();
        }
    }
}
