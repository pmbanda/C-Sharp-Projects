using System;
using static System.Console;

namespace InputMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //output reference no initial declaration of the variables 
            int first, second;
            InputMethod(out first, out second);
            WriteLine("After input method first is {0} ", first);
            WriteLine("After input method second is {0} ", second);
        }
        static void InputMethod(out int one, out int two)
        {
            string s1, s2;
            Write("Enter first integer ");
            s1 = ReadLine();
            Write("Enter second integer ");
            s2 = ReadLine();
            one = Convert.ToInt32(s1);
            two = Convert.ToInt32(s2);
        }
    }
}
