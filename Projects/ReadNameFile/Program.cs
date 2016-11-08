using System;
using System.IO;

namespace ReadNameFile
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file = new FileStream("Names.txt", FileMode.Open,FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            int count = 1;
            string text ;
            Console.WriteLine("Display all names ");

            text = reader.ReadLine();
            while(text != null)
            {
                Console.WriteLine(count + " " + text);
                text = reader.ReadLine();
                ++count;
            }

            reader.Close();
            file.Close();
        }
    }
}
