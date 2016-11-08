//Author:   Peter eugene Mbanda
//Date:     1/26/2016
//Purpose:  Guessing Game

using System;
using static System.Console;

namespace GuessingGame3
{
    class Program
    {
        static void Main(string[] args)
        {
            //local variables integer and boolean
            int guess, min = 1, max = 11, randomNumber, firstGuess = 10;
            bool valid = false;

            //random class instance for random number generation
            Random randomGenerator = new Random();

            //method invoction for minimum number inclusive and 
            //maximum number exclusive

            randomNumber = randomGenerator.Next(min, max);
            //WriteLine("Computer Generated " + randomNumber);
            
            do
            {
                //prompt user for a guess
                Write("Guess a number: ");
                guess = Convert.ToInt32(ReadLine());

                if (valid && guess < firstGuess)
                    WriteLine("Dumb guess ");

                //use cinditional statement to determine the guess 
                //in comparison to the random number
                if (randomNumber == guess)
                    WriteLine("Guess is Correct");
                else if (randomNumber < guess)
                    WriteLine("Guess was too high ");
                else 
                {
                    WriteLine("Guess was too low ");
                    valid = true;//if guess is too low
                    //assign first guess the first low 
                    //value for the comparison 
                    firstGuess = guess;
                }

                WriteLine();//empty space separating values 
                
            } while ( randomNumber != guess );//repeat if true
     
                
            ReadLine();
        }
    }
}
