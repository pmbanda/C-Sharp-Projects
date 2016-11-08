using System;
using System.IO;


namespace FileStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename;
            Console.Write("Enter a file name >> ");
            filename = Console.ReadLine();

            if(File.Exists(filename))
            {
                Console.WriteLine("File exists");
                Console.WriteLine("File was created " + File.GetCreationTime(filename));
                Console.WriteLine("File was last accessed " + File.GetLastAccessTime(filename));
                Console.WriteLine("File was last written to " + File.GetLastWriteTime(filename));
            }
            else
            {
                Console.WriteLine("File does not exist ");
            }
        }
    }
}
