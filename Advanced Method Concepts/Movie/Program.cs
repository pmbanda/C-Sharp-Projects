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
            //declare variables name and time
            string name = "The Godfather ";
            int time = 120;

            MovieInfo(name);//invoke method only with a string argument
            MovieInfo(name, time);//invoke method with a string and intrger argument
            Console.ReadLine();
        }

        static void MovieInfo(string movieName, int movieRuntime = 90 )
        {
            //method to display the movie details 
            Console.WriteLine("Movie Name: {0} ", movieName);
            Console.WriteLine("Movie Runtime: {0} ", movieRuntime);
            Console.WriteLine();
        }
    }
}
