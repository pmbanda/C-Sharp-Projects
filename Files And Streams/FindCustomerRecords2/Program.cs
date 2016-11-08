/*
Author:   Peter Eugene Mbanda
Date:     4/22/2016
Purpose:  Display customer details whose balance is equal or greater
          than the entered value
*/

using System;
using System.IO;
using WriteCustomerRecords;


namespace FindCustomerRecords2
{
    class Program
    {
        static void Main(string[] args)
        {
            //class fields
            string data;
            double userEntry;
            bool customerExists = false;

            //stores the file data in a single array
            string[] contents;
            const char DELIM = ',';

            //file name 
            string fileName = @"H:\C#\Chapter14\WriteCustomerRecords\bin\Debug\Customer.txt";

            //file stream to read and obtain file contents
            FileStream inStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inStream);

            //prompt the user to enter the customers minimum balance
            Console.Write("Enter customers minimum balance due: ");
            userEntry = Convert.ToDouble(Console.ReadLine());

            data = reader.ReadLine();//read a line of data from the file

            while (data != null)
            {
                //instantiate the class
                Customer customer = new Customer();
                contents = data.Split(DELIM);//split contents in array 

                //assign data to the variables 
                customer.IdNumber = Convert.ToInt32(contents[0]);
                customer.Name = contents[1];
                customer.BalanceOwed = Convert.ToDouble(contents[2]);

                //determine customers whose balance fall within the condition
                if (customer.BalanceOwed >= userEntry)
                {
                    //if customer exists display the customers details based on the balance owed
                    customerExists = true;
                    Console.WriteLine("Customer ID: {0}", customer.IdNumber);
                    Console.WriteLine("Customer name: {0}", customer.Name);
                    Console.WriteLine("Balance owed: {0}", customer.BalanceOwed);
                }

                data = reader.ReadLine();//read a line of data from the file
            }

            if (customerExists == false)
            {
                //if the value for customer existence is false display the error message below 
                Console.WriteLine("Sorry-Balance NOT valid!");
            }

            //close all the file and its resources
            inStream.Close();
            reader.Close();
        }
    }
}
