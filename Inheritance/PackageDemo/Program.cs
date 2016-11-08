//Author:   Peter Eugene Mbanda
//Date:     3/21/2016
//Purpose:  Appklication to determine the package price and insurance amount

/*
Created by Peter Eugene M
Instructions from Visual C# by Joyce Farrell 2015
Under no circumstance for distribution
unless with permission
Rights Reserved @PemBrand software
*/

using System;

namespace PackageDemo
{
    class Demo
    {
        static void Main(string[] args)
        {
            //class instantiation and object demonstration for Package
            //provide parameter values to the class contructor
            Package p1 = new Package(10, "John Bull", 32);
            Package p2 = new Package(20, "Ray Balboa", 40);
            Package p3 = new Package(30, "Kayden Kross", 70);

            //display the values and separate with spacing
            Console.WriteLine();
            Console.WriteLine(p2);
            Console.WriteLine();
            Console.WriteLine(p3);
            Console.WriteLine();

            //class instantiation and object demonstration for InsuredPackage
            //provide parameter values to the class contructor
            InsuredPackage IP1 = new InsuredPackage(40, "John Bull", 32, 20);
            InsuredPackage IP2 = new InsuredPackage(50, "Jessica Alba", 40, 15);
            InsuredPackage IP3 = new InsuredPackage(60, "Anthonio Banderas", 20, 40);

            //display the values and separate with spacing
            Console.WriteLine(IP1);
            Console.WriteLine();
            Console.WriteLine(IP2);
            Console.WriteLine();
            Console.WriteLine(IP3);
            Console.WriteLine();

            //allow for console display
            Console.ReadLine();
        }
    }
    class Package
    {
        //field for delivery price
        protected double deliveryPrice;

        //auto implemented properties fields for ID, name and weight 
        public int IdNumber { get; set; }
        public string CustomerName { get; set; }
        public double WeightOunces { get; set; }

       
        //delivery prica property
        public virtual double DeliveryPrice
        {
            get {
                return deliveryPrice; 
            }
            set{
                //if the weight is equivalent to 32 ounces assign $5
                if (this.WeightOunces <= 32)
                    deliveryPrice += 5;
                //if the weight is greater then 32 ounces assign $5 and extra 12cents
                else if (this.WeightOunces > 32)
                {
                    double over32 = this.WeightOunces - 32;//12 cents per ounce for every ounce over 32
                    deliveryPrice += (over32 * 0.12) + 5;
                }
                    
            }
        }

        public Package(int ID, string name, double weight)
        {
            //class constructor to instantiate the values
            this.IdNumber = ID;
            this.CustomerName = name;
            this.WeightOunces = weight;
            DeliveryPrice = this.WeightOunces;//assign the weight value to the mutator for delivery price
            ToString();
        }

        //override method to diaplay the class and its properties
        override public string ToString()
        {
            return "Id Number: " + IdNumber + "\nCustomer Name: " + CustomerName + 
                "\nWeight ounces: " + this.WeightOunces.ToString() + "\nDelivery Price: " + this.deliveryPrice.ToString("C");
        }
    }
    class InsuredPackage : Package
    {
        //class field
        private double packageValue;
        private double insurance;

        //overriden delivery price setter 
        override
        public double DeliveryPrice
        {
            get
            {
                return insurance; 
            }
            set
            {
                packageValue = value;
                //if the package value is equivalent to 20 assign $1 to the insurance
                if (this.packageValue <= 20)
                    insurance = 1;
                //if the package value is greater then 20 assign $2.50 to the insurance
                else if (this.packageValue > 20)
                    insurance = 2.50;
            }
        }
        public InsuredPackage(int ID, string name, double weight, double pValue) : base(ID, name, weight)
        {
            this.packageValue = pValue;
            DeliveryPrice = this.packageValue;//assign the weight value to the mutator for delivery price
            ToString();
        }

        //override method to diaplay the class and its properties
        override public string ToString()
        {
            return "Id Number: " + IdNumber + "\nCustomer Name: " + CustomerName +  
                "\nPackage value: " + this.packageValue.ToString("C") + "\nInsurance: " + this.insurance.ToString("C");
        }
    }
}
