using System;
using static System.Console;

namespace Delgates
{
    delegate void GreetingDelegate(string s);

    class Greeting
    {
        public static void Hello(string s)
        {
            WriteLine("Hello, {0}!", s);
        }
        public static void Goodbye(string s)
        {
            WriteLine("Goodbye, {0}!", s);
        }

        static void Main(string[] args)
        {
            GreetingDelegate firstDel = new GreetingDelegate(Hello);
            GreetingDelegate secondDel = new GreetingDelegate(Goodbye);
            GreetMethod(firstDel, "Cathy");
            GreetMethod(secondDel, "Bob");
        }

        private static void GreetMethod(GreetingDelegate gd, string name)
        {
            WriteLine("The greeting is:");
            gd(name);
        }
    }
}
