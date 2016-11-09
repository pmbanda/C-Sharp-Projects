//Author:   Peter Eugene Mbanda
//Date:     2/3/2016
//Purpose:  Application for guessing words in a sequence of disguised characters

using System;
using static System.Console;

namespace GuessAWord
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                class level variables
                with array containeing characters
             */
            Char[] ch = new char[] { 'b', 'u', 'z', 'z', 'w', 'o', 'r', 'd', 's' };
            bool exist = false;
            const int NUM_CHARS = 9;
            char letter;
            /*
                total number of disguised character array
                counter variable for accumulating contained character in array
            */
            char[] disguise = new char [NUM_CHARS];
            int count = 0;

            // prompt the user for a guess 
            WriteLine("Guess a Word: ");
           
            //  display the asterix characters 
            for (int i = 0; i < disguise.Length ; ++i)
            {
                //  assign to the array disguised
                disguise[i] = '*';
                Write(disguise[i]);
            }
                
            WriteLine();

            // prompt the user for a letter guess 
            Write("Guess one letter >> ");
            letter = Convert.ToChar(ReadLine());

            while (count < ch.Length)
            {
                for (int i = 0; i < NUM_CHARS; ++i)
                {
                    if (letter.Equals(ch[i]))
                    {
                        // if letter is in the word
                        // assign letter to the array 
                        // assign true to the boolean for the value authenticity
                        // increment counter for surety of letter contained
                        WriteLine("{0} is in the word ", letter);
                        disguise[i] = letter;
                        exist = true;
                        ++count;
                    }
                }

                // display non existent word if character absent
                if (!exist)
                    WriteLine("Sorry {0} does not exist ", letter);

                for (int i = 0; i < NUM_CHARS; ++i)
                    Write(disguise[i]);// display the characters
 
                WriteLine();
                if (count == ch.Length)
                {
                    // if character comoletion achieved display the congratulatory message to the user
                    WriteLine("!!Congratulations you completed the word !!");
                    WriteLine();
                    break;
                }
                    
                // prompt the user for a letter guess 
                Write("Guess a letter >> ");
                letter = Convert.ToChar(ReadLine());
            }
        }
    }
}
