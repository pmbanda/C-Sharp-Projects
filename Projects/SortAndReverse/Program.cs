using System;
using static System.Console;


namespace SortAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Olive", "Patty", "Richard", "Ned", "Mindy" };

            int i;
           
            WriteLine("Reversing the array ");
            Array.Reverse(names);

            for (i = 0; i < names.Length; i++)
            {
                WriteLine(names[i]);
            }
            WriteLine();
            WriteLine("After sorting the array ");
            Array.Sort(names);

            for ( i = 0; i < names.Length; i++)
            {
                WriteLine(names[i]);
            }
            WriteLine();
            WriteLine("Reversing the array ");
            Array.Reverse(names);

            for (i = 0; i < names.Length; i++)
            {
                WriteLine(names[i]);
            }
            ReadLine();
        }
    }
}
