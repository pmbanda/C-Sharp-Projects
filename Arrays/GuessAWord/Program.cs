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
            //class variables
            Char[] ch = new char[] { 'b', 'u', 'z', 'z', 'w', 'o', 'r', 'd', 's' };//array of contained characters
            bool exist = false;
            const int NUM_CHARS = 9;//total number of characters final field
            char letter;
            char[] disguise = new char [NUM_CHARS];//total number of disguised character array
            int count = 0;//counter variable for accumulating contained character in array

            //prompt the user for a guess 
            WriteLine("Guess a Word: ");
           
            Write("Word: ");

            //display the asterix characters 
            for (int i = 0; i < disguise.Length ; ++i)
            {
                disguise[i] = '*';//assign to the array disguised
                Write(disguise[i]);
            }
                
            WriteLine();

            //prompt the user for a letter guess 
            Write("Guess one letter >> ");
            letter = Convert.ToChar(ReadLine());

            while (count < ch.Length)
            {
                for (int i = 0; i < NUM_CHARS; ++i)
                {
                    if (letter.Equals(ch[i]))
                    {
                        //if letter is in the word
                        WriteLine("{0} is in the word ", letter);
                        disguise[i] = letter;//assign letter to the array 
                        exist = true;//assign true to the boolean for the value authenticity
                        ++count;//increment counter for surety of letter contained
                    }
                }
                //display non existent word if character absent
                if (!exist)
                    WriteLine("Sorry {0} does not exist ", letter);

                for (int i = 0; i < NUM_CHARS; ++i)
                    Write(disguise[i]);//display the characters
 
                WriteLine();
                if (count == ch.Length)
                {
                    //if character comoletion achieved display the congratulatory message to the user
                    WriteLine("!!Congratulations you completed the word !!");
                    WriteLine();
                    break;
                }
                    
                //prompt the user for a letter guess 
                Write("Guess a letter >> ");
                letter = Convert.ToChar(ReadLine());
            }
        }
    }
}
