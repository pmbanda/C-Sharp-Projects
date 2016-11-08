//Author:   Peter Eugene Mbanda
//Date:     4/18/2016
//Purpose:  Determine whether directories exist and obtain info from one of the files

using System;
using System.IO;

namespace TestFileAndDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            //sentinel value to terminate the program
            const string END = "end";
            string directoryName = "";
            string fileName = "";
            string [] filesInDirectory;

            //prompt the user for the directory name
            Console.Write("Enter name of Directory or \"" + END + "\" to terminate >> ");
            directoryName = Console.ReadLine();

            if(!directoryName.Equals(END))
            {
                //determine whether the directory exists
                if (Directory.Exists(directoryName))
                {
                    //if it exists assign the names to an array
                    filesInDirectory = Directory.GetFiles(directoryName);

                    for (int i = 0; i < filesInDirectory.Length; i++)
                    {
                        //display the files stores in the array
                        Console.WriteLine((i + 1) + " " + filesInDirectory[i]);
                    }
                    //prompt the user to enter the file name
                    Console.Write("Please enter one file name in the list >> ");
                    fileName = Console.ReadLine();
                    Console.WriteLine();//empty white space

                    if (File.Exists(fileName))
                    {
                        //display the files information
                        Console.WriteLine(fileName);
                        Console.WriteLine("Creation Date and Time: " + File.GetCreationTime(fileName).ToString());
                    }
                    else
                        Console.WriteLine("Sorry- File does not exist! ");//message if file does not exist
                }
                else
                    Console.WriteLine("Sorry- Directory does not exist! ");//message if directory is not in existence

            }
            else
            {
                Console.WriteLine("Program Terminates shortly...");
                System.Threading.Thread.Sleep(3000);
            }


        }
    }
}
