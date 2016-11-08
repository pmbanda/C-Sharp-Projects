//Author:   Peter Eugene Mbanda
//Date:     4/4/2016
//Purpose:  Application to display orders made by clients 

/*
Created by Peter Eugene M
Instructions from Visual C# by Joyce Farrell 2015
Under no circumstance for distribution
unless with permission
Rights Reserved @PemBrand software
*/
using System;
using static System.Console;

namespace OrderExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //create and test objects
            //in the order class
            //variable declaration
            int items, day;
            double quantity;

             //user prompt
             Write("Enter the number of items: ");
             items = Convert.ToInt32(ReadLine());
             Write("Enter the Quantity ordered: ");
             quantity = Convert.ToDouble(ReadLine());
             Write("Enter the Day ordered: ");
             day = Convert.ToInt32(ReadLine());

             //user try catch block to catch the error
             try
             {
                 Order myOrder = new Order(items, quantity, day);
                 WriteLine("\n" + myOrder);//display the items
             }
             catch (Exception e)
             {
                 WriteLine(e.Message);//display the error message
             }
            
            ReadLine();
        }
    }
    class Order
    {
        //class fields
        private int itemNumber;
        private double quantity;
        private int dayOrdered;

        //class constructor with values as the parameters
        public Order(int item, double qty, int day)
        {
            itemNumber = item;
            if (itemNumber < 100 || itemNumber > 999)
                throw new ArgumentException("\nERROR - Item Out Of Range(100-999)");
            quantity = qty;
            if(quantity < 1 || quantity > 12)
                throw new ArgumentException("\nERROR - Quantity Out Of Range(1-12)");
            dayOrdered = day;
            if (day < 1 || day > 31)
                throw new ArgumentException("\nERROR - Invalid Day(1-31)");
        }

        //override the object class to display the class information
        public override string ToString()
        {
            //display the values by overriding the object method to string
            return "\nItem number: " + itemNumber +"\n" + "Quantity: " + quantity  + "\n" + "Day ordered: " + dayOrdered + "\n";
        }
    }
}
