//Author:   Peter eugene Mbanda
//Date:     3/2/2016
//Purpose:  

using System;
using static System.Console;

namespace TilingDemo
{
    class TileDemo
    {
        static void Main(string[] args)
        {
            //instantiate a random number
            Random rand = new Random();
            double length;
            double width;

            //instantiate an array of 10 objects
            const int NUM_OBJECTS = 10;
            Room []rm = new Room[NUM_OBJECTS];
           
            //demonstrate its methods
            for (int i = 0; i < rm.Length; i++)
            {
                length = rand.Next(10, 30);//assign random value to the length
                width = rand.Next(10, 30);//assign random value to the width
                rm[i] = new Room(length, width);
            }

            //display values
            WriteLine("{0,4} {1,8} {2,5} ", "Room", "Feet ", "Boxes");
            for (int i = 0; i < rm.Length; i++)
            {   DisplayValues(rm[i], i); }

            ReadLine();
        }
        //method to display the values
        private static void DisplayValues(Room room, int position)
        {
            WriteLine("{0,4} {1,8} {2,5} ",
                (position + 1), room.FloorArea.ToString("F"), room.NumberOfBoxes);
        }

    }
    class Room
    {
        //class fields
        private double floorArea;
        private int numberOfBoxes;
        private double length;
        private double width;

        //length and width properties 
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        
        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        //readonly properties for floor area and number of boxes 
        public double FloorArea
        {
            get { return floorArea; }
        }
        public double NumberOfBoxes
        {
            get { return numberOfBoxes; }
        }

        //room constructor parameter for the length and width of fields
        public Room(double length, double width)
        {
            this.length = length;
            this.width = width;
            calcFloorArea();
            calcNumberOfBoxes();
        }

        //floor area computed by calling the private methods
        private double calcFloorArea()
        {
            floorArea = Length * Width;
            return floorArea;
        }
        //number of boxes for tiles computed by calling the private methods
        private int calcNumberOfBoxes()
        {
            //number of feet needed for 1 box of tiles
            const int SQR_FEET_PER_BOX = 12;
            //1 extra box for partial square feet 
            //plus 1 extra box for waste
            const int EXTRA_FEET_BOXES = 2;

            numberOfBoxes = ((int)(floorArea / SQR_FEET_PER_BOX )) + EXTRA_FEET_BOXES;
            return numberOfBoxes;
        }
   
    }
}
