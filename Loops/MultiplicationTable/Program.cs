//Author:   Peter eugene Mbanda
//Date:     1/26/2016
//Purpose:  Multiplication table

using System;
using static System.Console;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            const Int32 finalNum = 10;
            //user prompt
            Write("Enter an integer value: ");
            int num = Convert.ToInt32(ReadLine());//convert to integer value 

            WriteLine();

            //loop through numbers 1 - 10 
            for (int i = 1; i <= finalNum; i++)
            {
                //display the result
                WriteLine(i + " * " + num + " = " + (i * num));
            }
            ReadLine();
        }
    }
}
