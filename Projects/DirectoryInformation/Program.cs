using System;
using System.IO;

namespace DirectoryInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            string directoryName;
            string[] listOfFiles;
            Console.Write("Enter a folder >> ");
            directoryName = Console.ReadLine();
            if(Directory.Exists(directoryName))
            {
                Console.WriteLine("Directory exists, " + " and it contains the following: ");
                listOfFiles = Directory.GetFiles(directoryName);

                for (int i = 0; i < listOfFiles.Length; i++)
                {
                    Console.WriteLine("   {0}", listOfFiles[i]);
                }
            }
            else
            {
                Console.WriteLine("Directory does not exist ");
            }
        }
    }
}
