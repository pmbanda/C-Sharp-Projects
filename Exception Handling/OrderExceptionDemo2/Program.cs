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

namespace OrderExceptionDemo2
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

            //create an array to compose the object 
            //and its instances
            const int NUM_ARRAY = 5;
            Order[] orders = new Order[NUM_ARRAY]; //number of array objects

            for (int i = 0; i < 5; i++)
            {
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
                    orders[i] = new Order(items, quantity, day);
                    WriteLine("\n" + orders[i].ToString());//display the items
                }
                catch(ArgumentException e)
                {
                    WriteLine(e.Message);//display the error message
                }
 
                catch (Exception e)
                {
                    WriteLine(e.Message);//display the error message
                } 
            }

            ReadLine();
        }
    }
    class Order
    {
        //class fields and their properties
        private int itemNumber;
        public int ItemNumber { get { return itemNumber; } }
        private double quantity;
        public double Quantity { get { return quantity; } }
        private int dayOrdered;
        public int DayOrdered { get { return dayOrdered; } }

        //class constructor with values as the parameters
        public Order(int item, double qty, int day)
        {
            //if the user enters an invalid number 
            //set all the values to 0
            itemNumber = item;
            quantity = qty;
            dayOrdered = day;

            //if the item range falls below any category return 0 to all the fields
            if ((ItemNumber < 100 || ItemNumber > 999) || (Quantity < 1 || Quantity > 12) || (DayOrdered < 1 || DayOrdered > 31))
            {
                itemNumber = 0;
                quantity = 0;
                dayOrdered = 0;
            }
        }

        //override the object class to display the class information
        public override string ToString()
        {
            //display the values by overriding the object method to string
            return "Item number: " + ItemNumber + "\n" + "Quantity: " + Quantity + "\n" + "Day ordered: " + DayOrdered + "\n";
        }
    }
}
