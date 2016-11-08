using System;
using static System.Console;
namespace BinarySearchDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idNumbers = { 122, 167, 204, 219, 345 };

            int x;
            string entryString;
            int entryID;
            Write("Enter an employee ID ");
            entryString = ReadLine();
            entryID = Convert.ToInt32(entryString);

            x = Array.BinarySearch(idNumbers,entryID);

            if (x < 0)
                WriteLine("ID {0} not found ", entryID);
            else
                WriteLine("ID {0} found at position {1} ", entryID, x );

            ReadLine();
        }
    }
}
