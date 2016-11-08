//Author:   Peter Eugene Mbanda
//Date:     2/8/2016
//Purpose:  Application used to count the number of vowels in a string

using System;
using static System.Console;

namespace VowelsModularized
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare the string 
            string s = "The quick brown fox jumped over the lazy dog ";
            WriteLine("The number of vowels is {0} ", CountVowels(s));
            ReadLine();
        }
        static int CountVowels(string str)
        {
            //the vowels to be compared with a string
            char[] vowels = new char[] {'a', 'e', 'i' , 'o', 'u' };
            int count = 0;//initialize the count to count the total vowels in the string

            //iterate through the string
            for (int i = 0; i < str.Length; i++)
                foreach (char v in vowels)//iterate through the vowels
                {
                    if (str[i] == v)//if a match is found increment the count variable
                        ++count;
                }

            return count;//return the count to the calling method
        }
    }
}
