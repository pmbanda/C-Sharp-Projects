using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDeal
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            int result;
            int num = 78;
            Console.WriteLine("Enter an integer >> ");
            answer = Convert.ToInt32(Console.ReadLine());
            result = num / answer;
            Console.WriteLine("The answer is " + answer);
            Console.ReadLine();
        }
    }
}
