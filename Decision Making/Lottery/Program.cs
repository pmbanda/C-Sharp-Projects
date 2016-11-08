//Author:   Peter Eugene Mbanda
//Date:     1/25/2016
//Purpose:  Lottery application in C#

using System;
using static System.Console;

namespace Lottery
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variable declaration 
            int max, min, guess1, guess2, guess3, numRemainder1, numRemainder2, lotteryNumber, rem1, rem2;
            int num1, num2, num3, guessRemainder1, guessRemainder2;

            //random class constructor
            Random r = new Random();

            //user guess prompt
            Console.Write("Guess three numbers between 100 and 999: ");
            int guess = Convert.ToInt32(ReadLine());

            WriteLine();

            min = 100;//minimum value
            max = 1000;//maximum value exclusive

            lotteryNumber = r.Next(min,max);//generate random number with three digits

            //obtain the three numbers from the lottery generated number 
            num3 = lotteryNumber % 10;
            numRemainder2 = lotteryNumber / 10;
            rem1 = lotteryNumber / 100;

            num2 = numRemainder2 % 10;
            numRemainder1 = numRemainder2 / 10;

            num1 = numRemainder1;
            //obtain the three numbers from the guessed numbers 
            guess3 = guess % 10;
            guessRemainder2 = guess / 10;
            rem2 = lotteryNumber / 100;

            guess2 = guessRemainder2 % 10;
            guessRemainder1 = guessRemainder2 / 10;

            guess1 = guessRemainder1;

            WriteLine("You entered {0} while the computer generated {1} ", guess , lotteryNumber );
            if (guess == lotteryNumber)
                WriteLine("Won $" + 10000);//if all the three numbers match dislay the message to console

            else if ((guessRemainder1 == numRemainder1) || (guessRemainder1 == numRemainder2)
               || (guessRemainder2 == numRemainder1) || (guessRemainder2 == numRemainder2))
                WriteLine("Won $" + 100);

            else if ((guess1 == num1) || (guess1 == num2) || (guess1 == num3) ||
                (guess2 == num1) || (guess2 == num2) || (guess2 == num3) ||
                (guess3 == num1) || (guess3 == num2) || (guess3 == num3))
                WriteLine("Won $" + 10);//if at least any of the numbers match

            else if (guess != lotteryNumber)
                WriteLine("Won $" + 0);//if none of the numbers match

            
                        
           

            ReadLine();



        }
    }
}
