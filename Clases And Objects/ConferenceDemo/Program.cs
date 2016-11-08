//Author:   Peter Eugene Mbanda
//Date:     3/3/2016
//Purpose:  Conference application for hotels

using System;
using static System.Console;

namespace ConferenceDemo
{
    class Program
    {
        //class level variables 
        static string confName, confDate, guestString;
        static int numberValue, guests;
        const int NUM_OF_OBJECTS = 3; //number of objects to be instantiated
        static Conference[] confArray = new Conference[NUM_OF_OBJECTS];//number of objects in the array

        static void Main(string[] args)
        {
            //method to prmpt the user
            UserInput();

            WriteLine();
            WriteLine("Before Sorting: ");
            //display the objects inputs
            Display();

            WriteLine();
            WriteLine("After Sorting: ");
            //sort guests
            Array.Sort(confArray);

            //display the objects inputs
            Display();

            ReadLine();
        }

        private static void Display()
        {
            //loop through the array to display the values
            WriteLine("{0,-20} {1,10} {2,8} ", "Conference", "Date", "Guests");
            WriteLine("----------------------------------------");
            for (int i = 0; i < confArray.Length; i++)
            {
                WriteLine("{0,-20} {1,10} {2,8} ", confArray[i].ConferenceName, confArray[i].StartingDate, confArray[i].NumOfAtteendees);
            }
        }

        public static void UserInput()
            //user prompt to enter data on objects
        {
            for (int i = 0; i < confArray.Length; i++)
            {
                WriteLine();
                //prompt conference array 
                confArray[i] = new Conference();
                Write("Enter the Conference Name >> ");
                confArray[i].ConferenceName = confName;

                confName = ReadLine();
                //prompt the conference date
                Write("Enter the Conference Date >> ");
                confDate = ReadLine();
                confArray[i].StartingDate = confDate;

                //prompt for number of attendees
                Write("Enter the Number Of Attendees >> ");
                guestString = ReadLine();

                //ensure the imput error is handles in case convertion fails
                if (Int32.TryParse(guestString, out numberValue))
                    guests = numberValue;
                else
                    guests = numberValue;
                confArray[i].NumOfAtteendees = guests;

            }
        }
        

    }

    
    }
    class Conference : IComparable
    {
        //class instance fields and properties
        private string conferenceName;
        public string ConferenceName
        {
            get { return conferenceName; }
            set { conferenceName = value; }
        }

        //date field
        private string startingDate;
        public string StartingDate
        {
            get { return startingDate; }
            set { startingDate = value; }
        }

        //number of attendees field
        private int numOfAtteendees;
        public int NumOfAtteendees
        {
            get { return numOfAtteendees; }
            set { numOfAtteendees = value; }
        }

        //implement interface icomparable
        public int CompareTo(object obj)
        {
            //create instance of object through cast to current object
            Conference confObj = (Conference)obj;

            if(this.numOfAtteendees < confObj.numOfAtteendees)
                return -1;
            else
            {
                if (this.numOfAtteendees > confObj.numOfAtteendees)
                    return 1;
                else
                    return 0;
            }
        }
    }
