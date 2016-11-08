//Author:   Peter Eugene Mbanda
//Date:     3/30/2016
//Purpose:  Mortgage Application

/*
Created by Peter Eugene M
Instructions from Visual C# by Joyce Farrell 2015
Under no circumstance for distribution
unless with permission
Rights Reserved @PemBrand software
*/
using System;
using static System.Console;

namespace MortgageApplication
{
    class MortgageApp
    {
        static void Main(string[] args)
        {
            //variable declaration
            string name;
            double score;

            //number of times to prompt user for object instantiation
            const int LOOP_COUNT = 5;
            WriteLine("Allow record entry for " + LOOP_COUNT + " users");
            WriteLine();

            User[] client = new User[LOOP_COUNT];//number of object arrays

            for (int i = 0; i < client.Length; i++)
            {
                //user prompt for user name and credit score
                Write("Enter user name: ");
                name = ReadLine();
                try
                {
                    Write("Enter Credit Score: ");
                    score = Convert.ToDouble(ReadLine());

                    client[i] = new User(name, score);//class instantiation
                }
                catch (ArgumentException e)
                {
                    WriteLine("Invalid - Credit range (300 - 850) " + "\n");
                }   
            }

            ReadLine();
        }
    }
    class User
    {
        //class fields
        private string name;
        private double creditScore;

        //class properties
        public string Name { get; set; }
        public double CreditScore { get; set; }

        //class constructor
        public User(string userName, double userCredit)
        {
            this.name = userName;
            this.creditScore = userCredit;

            //conditional statement to determine whether user is eligible for mortgage
            if (CheckEligibility(userCredit))
                WriteLine("Client is eligible for Mortgage\n");
            else
                WriteLine("Client is NOT eligible for Mortgage\n");
        }

        private bool CheckEligibility(double credit)
        {
            bool eligible = false;//boolean variable to check validity

            if (credit < 300 || credit > 850)
            {
                //if score is invalid exception is thrown
                throw (new ArgumentException());
            }
            else
            {
                //if exception is not thrown verify the magnitude of score
                if (credit >= 650)
                    eligible = true;//eligible if greater than 650
                else
                    eligible = false;//not eligible since score is less than 650
            }

            return eligible;
        }
    }
}
