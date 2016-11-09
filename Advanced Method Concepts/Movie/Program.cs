/*Author:   Peter Eugene Mbanda
**Date:     2/12/2016
**Purpose:  Movie application to display title and the movie runtime
**
**@all rights reserved
**@not for unauthorised use
*/
using System;

namespace Movie
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare variables name and time
            string name = "The Godfather ";
            int time = 120;

            // invoke method only with a string argument
            MovieInfo(name);

            // invoke method with a string and integer argument
            MovieInfo(name, time);

            Console.ReadLine();
        }

        static void MovieInfo(string movieName, int time = 90 )
        {
            // method to display the movie details 
            Console.WriteLine("Movie Name: {0} ", movieName);
            Console.WriteLine("Movie Runtime: {0} ", time);
            Console.WriteLine();
        }
    }
}
