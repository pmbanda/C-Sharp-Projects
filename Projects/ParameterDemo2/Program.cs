using System;
using static System.Console;

namespace ParameterDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare and display x
            int x = 4;
            WriteLine("In main x is {0} ", x);

            //use the reference parameter to point to the memory location 
            DisplayReferenceParameter(ref x );

            WriteLine("In main x is {0}", x);
        }
        static void DisplayReferenceParameter(ref int number)//point to memeory location with ref
        {
            number = 888;
            WriteLine("In method number is {0}" , number);
        }
    }
}
