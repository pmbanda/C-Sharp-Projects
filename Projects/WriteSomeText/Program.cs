using System;
using System.IO;
using static System.Console;

namespace WriteSomeText
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream outFile = new FileStream("SomeText.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            Write("Enter some text >> ");
            string text = ReadLine();
            writer.WriteLine(text);
            //error occurs if the next two statements are reversed
            writer.Close();
            outFile.Close();
        }
    }
}
