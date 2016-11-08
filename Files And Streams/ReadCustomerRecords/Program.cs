//Author:   Peter Eugene Mbanda
//Date:     4/21/2016
//Purpose:  Application to read file and contents for the customers records


using System;
using System.IO;
using static System.Console;

namespace ReadCustomerRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            //name of the file to be read
            string file = @"H:\C#\Chapter14\WriteCustomerRecords\bin\Debug\Customer.txt";

            //open a file stream
            FileStream inFile = new FileStream(file, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inFile);

            //read a line of file and assign values to a variable
            string fileContent = reader.ReadLine();

            //while the file contains data display data and keep reading the file
            while(fileContent != null)
            {
                //display the contents to the console
                Console.WriteLine(fileContent);
                fileContent = reader.ReadLine();//re-read contents in file
            }
        }
    }
}
