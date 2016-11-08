//Author:   Peter Eugene Mbanda
//Date:     4/21/2016
//Purpose:  Application to write customer's record to a file

using System;
using System.IO;
using static System.Console;

namespace WriteCustomerRecords
{
    class WriteRecords
    {
        static void Main(string[] args)
        {
            //use of delimiter for comma separated values on the file
            const string DELIM = ",";
            //sentinel value
            const int QUIT = 999;

            //create a file stream for file writing
            FileStream outFile = new FileStream(@"Customer.txt", FileMode.Create,
                FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);//write to file stream

            //instantiate a customer object
            Customer customer = new Customer();

            //prompt the user for input
            Console.Write("Enter ID number or " + QUIT + " to quit : ");
            customer.IdNumber = Convert.ToInt32(ReadLine());//convert the input to integer

            while (customer.IdNumber != QUIT)
            {
                //terminate the program if the sentinel value is invoked
                if(customer.IdNumber == QUIT)
                {
                    //terminate program
                    Environment.Exit(0);
                }
                else
                {
                    //prompt the user for name
                    Console.Write("Enter name: ");
                    customer.Name = ReadLine();
                    //prompt the user for balance owed
                    Console.Write("Enter balance owed: ");
                    customer.BalanceOwed = Convert.ToDouble(ReadLine());

                    //write the values to the file separated by the delimeter
                    writer.WriteLine(customer.IdNumber + DELIM + customer.Name + DELIM + customer.BalanceOwed);

                    //re-prompt the user for id input
                    Console.Write("Enter ID number or " + QUIT + " to quit : ");
                    customer.IdNumber = Convert.ToInt32(ReadLine());
                }
            }

            //close the stream resources
            writer.Close();
            outFile.Close();
        }
    }
    public class Customer
    {
        //class field properties for customer class
        public int IdNumber { get; set; }
        public string Name { get; set; }
        public double BalanceOwed { get; set; }
    }
}
