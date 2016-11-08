//Author:       Peter Eugene Mbanda
//Date:         2/2/2016
//Purpose:      Zip code application that verifies whether a zip code exists in 
//              a particular delivery area or not

using System;
using static System.Console;

namespace CheckZips
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize the zip codes in the array
            int[] zipCodes = new int[]{ 73120, 74142, 75642, 76534, 72341, 75643, 76523, 75684, 75553, 76635  };

            //prompt the user to enter zip code
            WriteLine("Enter zip code");
            int zipEntry = Convert.ToInt32(ReadLine());

            WriteLine();//empty space

            for (int i = 0; i < zipCodes.Length; ++i)
            {
                if (zipEntry == zipCodes[i])
                {
                    //if zip code matches display the message
                    WriteLine("Zip code exists in delivery area ");
                    break;
                }
                else
                {
                    //if the zip code does not match display the message
                    WriteLine("Zip code does NOT exists in delivery area ");
                    break;
                }
            }

            ReadLine();
        }
    }
}
