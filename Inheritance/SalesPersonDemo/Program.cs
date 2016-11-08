//Author:   Peter Eugene Mbanda
//Date:     3/23/2016
//Purpose:  Sales Application

/*
Created by Peter Eugene M
Instructions from Visual C# by Joyce Farrell 2015
Under no circumstance for distribution
unless with permission
Rights Reserved @PemBrand software
*/
using System;
using static System.Console;

namespace SalesPersonDemo
{
    class Demo
    {
        static void Main(string[] args)
        {
            //demonstrate the class methods using the instance variables
            SalesPerson realEstate;//real estate instance
            realEstate = new RealEstateSalesPerson("Jamal ", "Peterson ", 15);
            WriteLine(realEstate.DisplayUser());

            WriteLine();

            SalesPerson girlScout;//girl scout instance 
            girlScout = new GirlScout("Rachael ", "Murdock ");
            WriteLine(girlScout.DisplayUser());

            ReadLine();
        }
    }
    abstract class SalesPerson
    {
        //class fields 
        private string firstName;
        private string lastName;

        //class properties for access to class fields
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //create class constructor and pass the two parameters
        public SalesPerson(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName  = lastName;
        }

        //return full name of class instance
        public virtual string DisplayUser()
        {
            return this.firstName + " " + this.lastName;
        }

    }
    class RealEstateSalesPerson: SalesPerson, ISellable
    {
        //class fields with 0 initial values 
        private double totalSales = 0;
        private double commission = 0;
        private double rate;
        //field properties
        public double TotalSales { get; set; }
        public double Commission { get; set; }
        public double Rate { get; set; }
        public RealEstateSalesPerson(string firstName, string lastName, double commissionRate): base(firstName, lastName)//include base class constructor
        {
            this.rate = commissionRate;
            SalesSpeech();
            MakeSale();
        }

        //implement the interface abstract methods
        public void SalesSpeech()
        {
            WriteLine("Real Estate Sales Speech!");
        }

        public void MakeSale()
        {
            //prompt user for total sale
            Write("Enter house total sale: ");
            totalSales = Double.Parse(ReadLine());

            //calculate the commission based on the rate
            commission = (this.rate / 100.0) * totalSales;
        }
        //display the class instance fields
        public override string DisplayUser()
        {
            return base.DisplayUser() + "\nPrice sold: " + this.totalSales + "\nCommission Earned: " + this.commission;
        }

    }
    class GirlScout: SalesPerson , ISellable
    {
        //class fields with 0 initial values 
        private int boxCookiesSold = 0;
        private int total;

        //field properties
        public int BoxCookiesSold { get; set; }
        public GirlScout(string firstName, string lastName): base(firstName, lastName)//include base class constructor
        {
            SalesSpeech();
            MakeSale();
        }

        //implement the interface abstract methods
        public void SalesSpeech()
        {
            WriteLine("Girl Scout Speech!");
        }

        public void MakeSale()
        {
            //prompt user for total sale
            Write("Boxes sold: ");
            boxCookiesSold = int.Parse(ReadLine());
            total += boxCookiesSold;

        }
        //display the class instance fields
        public override string DisplayUser()
        {
            return base.DisplayUser() + "\nTotal boxes sold: " + this.total;
        }
    }
    //interface class
    interface ISellable
    {
        //isellable interface allows for multiple inheritance
        void SalesSpeech();
        void MakeSale();
    }
}
