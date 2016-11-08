
using System;

delegate void GreetingDelegate(string s);
namespace Greeting2
{
    class Program
    {
        public static void Hello(string s)
        {
            Console.WriteLine("Hello, {0}!", s);
        }
        public static void Goodbye(string s)
        {
            Console.WriteLine("Goodbye, {0}!", s);
        }
        static void Main(string[] args)
        {
            GreetingDelegate firstDel, secondDel;
            firstDel = new GreetingDelegate(Hello);
            secondDel = new GreetingDelegate(Goodbye);

            firstDel += secondDel;

            GreetingDelegate(firstDel, "Cathy");
            GreetingDelegate(secondDel, "Bob");
        }
        static void GreetingDelegate(GreetingDelegate gD, string name)
        {
            Console.WriteLine("Greeting is ");
            gD(name);
        }

    }
}
