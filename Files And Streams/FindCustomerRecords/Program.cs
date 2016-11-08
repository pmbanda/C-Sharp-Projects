//Author:   Peter Eugene Mbanda
//Date:     4/22/2016
//Purpose:  Application to obtain customer's specific record

using System;
using System.IO;
using WriteCustomerRecords;//import class containing the customer attributes

namespace FindCustomerRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            //class fields
            string data;
            int userEntry;
            bool customerExists = false;

            //stores the file data in a single array
            string[] contents;
            const char DELIM = ',';

            //file name
            string fileName = @"H:\C#\Chapter14\WriteCustomerRecords\bin\Debug\Customer.txt";

            //file stream to read and obtain file contents
            FileStream inStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inStream);

            //prompt the user to enter the customers ID number
            Console.Write("Enter customers number: ");
            userEntry = Convert.ToInt32(Console.ReadLine());

            data = reader.ReadLine();//read a line of data from the file

            while(data != null)
            {
                //instantiate the class
                Customer customer = new Customer();
                contents = data.Split(DELIM);//split contents in array 

                //assign data to the variables 
                customer.IdNumber = Convert.ToInt32(contents[0]);
                customer.Name = contents[1];
                customer.BalanceOwed = Convert.ToDouble(contents[2]);

                //if id enntered matches the id on file display customers information
                if(userEntry == customer.IdNumber)
                {
                    //if customer exists display the customers details based on the id chosen
                    customerExists = true;
                    Console.WriteLine("Customer name: {0}", customer.Name);
                    Console.WriteLine("Balance owed: {0}", customer.BalanceOwed);
                }

                data = reader.ReadLine();//read a line of data from the file
            }

            if(customerExists == false)
            {
                //if the value for customer existence is false display the error message below 
                Console.WriteLine("Sorry-ID does not exist!");
            }

            //close all the file and its resources
            inStream.Close();
            reader.Close();

        }
    }
}
