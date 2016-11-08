//Author:   Peter Eugene Mbanda
//Date:     3/21/2016
//Purpose:  Order application

/*
Created by Peter Eugene M
Instructions from Visual C# by Joyce Farrell 2015
Under no circumstance for distribution
unless with permission
Rights Reserved @PemBrand software
*/
using System;
using System.Collections.Generic;
using static System.Console;

namespace OrderDemo2
{
    class OrderTest
    {
        static void Main(string[] args)
        {
            //declare class variables
            int order;
            double quantity;
            string name;

            List<string> myList = new List<string>();//list to store the values

            //number of objects
            const int NUMBER_OF_OBJECTS = 3;

            //create an array of five order objects 
            Order[] orderArray = new Order[NUMBER_OF_OBJECTS];

            for (int i = 0; i < orderArray.Length; i++)
            {
                //prompt the user for order , customer number and quantity
                Write("Enter customer name: ");
                name = ReadLine();

                Write("Enter order number: ");//order number entry
                order = Int32.Parse(ReadLine());

                //if order number exists in the list re-prompt the user for the order number
                while (myList.Contains(order.ToString()))
                {
                    Write("ERROR - Enter Order Number: ");
                    order = Int32.Parse(ReadLine());
                }
                myList.Add(order.ToString());//assign the value entered to the list collection

                //prompt for quantity ordered
                Write("Enter quantity ordered: ");
                quantity = Double.Parse(ReadLine());

                //call constructor and assign the values to the object 
                orderArray[i] = new Order(order, name, quantity);

                WriteLine();
            }

            DisplayObjects(orderArray);//display the objects by invoking call in main

            ReadLine();
        }

        public static void DisplayObjects(Object []obj)
        {
            //display all the objects entered by calling the ToString equivalent
            for (int i = 0; i < obj.Length; i++)
            {
                WriteLine();
                WriteLine(obj[i].ToString());
            }
        }
    }
    class Order
    {
        const double UNIT_PRICE = 19.95;
        //class level variables
        private int orderNumber;
        private string customerName;
        private double quantityOrdered;
        private double totalPrice;

        //class properties
        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public double QuantityOrdered { get; set; }

        //read only member for total price 
        public double TotalPrice { get { return totalPrice; } }

        //class constructor
        public Order(int orderNumber, string customerName, double quantityOrdered)
        {
            this.orderNumber = orderNumber;
            this.customerName = customerName;
            this.quantityOrdered = quantityOrdered;
            CalculateTotalPrice();//invoke the method call in the consteructor
        }

        //method to calculate the total price
        private double CalculateTotalPrice()
        {
            totalPrice = quantityOrdered * UNIT_PRICE;
            return totalPrice; //return total price value to the calling method
        }

        //override the object class 
        override
        public bool Equals(Object obj)
        {
            bool validity = false;//boolean initial value

            Order temp = (Order)obj;//assign the object to a temporary object 

            if (this.orderNumber == temp.orderNumber)
                validity = true;//if objects order numbers are equal assign true to the boolean variable
            else
                validity = false;//else if objects are not equal assign false

            return validity;
        }

        override
        public int GetHashCode()
        {
            return this.orderNumber;//return order number as the hash code
        }

        //override method to return all the order information
        override
        public string ToString()
        {
            return this.orderNumber + ": " + this.customerName + " \nItem Quantity " + 
                this.quantityOrdered + " \nTotal Price " + this.TotalPrice.ToString("C") ;
        }
    }
}
