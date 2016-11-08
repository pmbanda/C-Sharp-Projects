//Author:   Peter Eugene Mbanda
//Date:     2/5/2016
//Purpose:  Application to display sales letter to prospective clients

using System;
using static System.Console;

namespace SalesLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = "Patriot Airlines Company ";//company name
            WriteLine("{0:10} ", companyName);
            //letter contents 1 2 and 3 paragraphs
            WriteLine();
            WriteLine("     I'm writing to express my interest in the Web Content Manager " +
                "position \nlisted on Monster.com. I have experience building large, " +
                "consumer-focused \nhealth-based content sites. While much of my experience " +
                "has been \nin the business world, I understand the social value of the non-profit" + 
                "sector \nand my business experience will be an asset to your organization.");
            WriteLine();
            DisplayContactInfo();//invoke method call with user details

            WriteLine();

            WriteLine("     I worked closely with healthcare professionals and medical " +
                "editors to \nhelp them provide the best possible information to a consumer " +
                "audience \nof patients. In addition, I helped physicians learn to utilize \ntheir medical " + 
                "content to write user-friendly, readily comprehensible text.");
            WriteLine();
            DisplayContactInfo();//invoke method call with user details

            WriteLine();

            WriteLine("     I can work with web engineers to resolve technical issues and implement \ntechnical enhancements, " +
                "work with the development department to implement design and functional enhancements, " +
                "and monitor site statistics and conduct \nsearch engine optimization." +
                "content to write user-friendly, \nreadily comprehensible text.");
            WriteLine();
            DisplayContactInfo();//invoke method call with user details

            ReadLine();
        }
        static void DisplayContactInfo()
        {
            //define local variable fot the users information
            string name = "Eugene Great ";
            double landLine = 4056589865, cellNumber = 4658569564;
            string emailAddress = "greatcoder@codermail.com";

            //display the users information
            WriteLine("Landline: {0}", name);
            WriteLine("Landline: {0}", landLine);
            WriteLine("Cell Number: {0}", cellNumber);
            WriteLine("Mailing Address: {0}", emailAddress);
            WriteLine("");
        }
    }
}
