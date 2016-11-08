using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//declare a delegate
delegate void GreetingDelegate(string s);

namespace DelegatePrep
{
    class Program
    {
        //define methods similar to the delegate architecture
        public static void Hello(string s)
        {
            Console.WriteLine("Hello, {0} ", s);
        }
        public static void Goodbye(string s)
        {
            Console.WriteLine("Goodbye, {0} ", s);
        }

        static void Main(string[] args)
        {
            //create the delegate reference
            GreetingDelegate firstDel = new GreetingDelegate(Hello);
            GreetingDelegate secondDel = new GreetingDelegate(Goodbye);


            firstDel("Ray");
            secondDel("Romano");

            DelegateChosen(firstDel, "Ray");
            DelegateChosen(secondDel, "Romano");

            DelegateChosen(secondDel, "Romano");

        }
        //method to pass the delegate
        private static void DelegateChosen(GreetingDelegate gd, string name)
        {
            Console.WriteLine("Inside Method");
            gd(name);
        }
    }
}
