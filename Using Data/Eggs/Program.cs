//Author:   Peter Eugene Mbanda
//Date:     1/15/2016
//Purpose:  Egg tray calculator and dozen equivalents 

using static System.Console;

namespace Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare the number of eggs laid by each chicken 
            int chick1 = 30;
            int chick2 = 45;
            int chick3 = 20;
            int chick4 = 32;

            //display the result to the console
            WriteLine("Chicken 1 laid {0} eggs ", chick1);
            WriteLine("Chicken 2 laid {0} eggs ", chick2);
            WriteLine("Chicken 3 laid {0} eggs ", chick3);
            WriteLine("Chicken 4 laid {0} eggs ", chick4);
            WriteLine();

            //determine the sum of all the eggs laid 
            int sum = chick1 + chick2 + chick3 + chick4;

            int totalEggs = sum;//total of all eggs 
            int eggsInDozens = totalEggs / 12;//number of dozens 
            int remainingeggs = totalEggs % 12;//remaining number of eggs 

            //display the results to the console 
            WriteLine("{0} eggs is {1} dozen and {2} eggs ",totalEggs.ToString("D") , eggsInDozens.ToString("D"), remainingeggs.ToString("D") );
            WriteLine();



        }
    }
}
