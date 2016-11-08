//Author:   Peter eugene Mbanda
//Date:     1/26/2016
//Purpose:  Multiplication table

()using System;
using static System.Console;

namespace DisplayMultiplicationTable
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Int32 i, j;
            //display
            WriteLine("Multiplication table for 10 ");
            WriteLine();
            for ( i = 1; i < 11; ++i )
            {
                //on outer loop through the 10 numbers 
                Write( string.Format("{0,2} | ",  i.ToString("D3").TrimStart('0') ));
                for ( j = 1; j < 11; ++j)
                {
                    //on inner loop multiply the outer and inner loop variables
                    Write(string.Format("{0,2}  ",(i * j).ToString("D3").TrimStart('0')) );
                  
                }
                WriteLine();//empty space to leave a whiteline between inner and outer loop
            }
            ReadLine();
        }
    }
}
