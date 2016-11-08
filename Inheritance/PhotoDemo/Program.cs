//Author:   Peter Eugene Mbanda
//Date:     3/11/2016
//Purpose:  Photo Application for pricing information

/*
Created by Peter Eugene M
Instructions from Visual C# by Joyce Farrell 2015
Under no circumstance for distribution
unless with permission
Rights Reserved @PemBrand software
*/

using System;
using static System.Console;

namespace PhotoDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //demonstrate the methods for photo related classes
            Photo photo = new Photo(8, 10);
            Photo photo1 = new Photo(10, 12);

            //display objects
            WriteLine(photo);
            WriteLine();
            WriteLine(photo1);

            WriteLine();

            //demonstrate the methods for matted photo related classes
            MattedPhoto mPhoto1 = new MattedPhoto(8, 10, "Red");
            MattedPhoto mPhoto2 = new MattedPhoto(10, 12, "Green");
            MattedPhoto mPhoto3 = new MattedPhoto(15, 11, "Blue");

            //display objects
            WriteLine(mPhoto1);
            WriteLine();
            WriteLine(mPhoto2);
            WriteLine();
            WriteLine(mPhoto3);

            WriteLine();

            //demonstrate the methods for framed photo related classes
            FramedPhoto fPhoto1 = new FramedPhoto(8, 10,"Silver", "Modern");
            FramedPhoto fPhoto2 = new FramedPhoto(10, 12,"Gold", "Old");
            FramedPhoto fPhoto3 = new FramedPhoto(15, 11,"Bronze", "Classic");

            //display objects
            WriteLine(fPhoto1);
            WriteLine();
            WriteLine(fPhoto2);
            WriteLine();
            WriteLine(fPhoto3);

            ReadLine();
        }
    }
    class Photo
    {
        //PhotoDemo.Photo class fields and properties
        private int width;
        private int height;
        protected double price;//protected field for custom pricing by extended classes

        //field properties
        public int Width { get { return width; } set { width = value; } }
        public int Height { get { return height; } set { height = value; } }

        public Photo(int width, int height)
        {
            //assign constructor parameters to the class fields
            this.width = width;
            this.height = height;
            this.price = Price;
            ToString();//invoke to string method for display of classes instance
        }
        public double Price
        {
            //return the pricing based on the size of the photo
            get
            {
                if (this.width == 8 && this.height == 10)//8 by 10 
                {
                    price = 3.99;
                    return price;
                }

                else if (this.width == 10 && this.height == 12)//10 by 12
                {
                    price = 5.99;
                    return price;
                }
                else
                {
                    price = 9.99;
                    return price;//if none is specified return 9.99
                }
            }
        }

        //override to string method for custom display
        override public string ToString()
        {
            return this.GetType().ToString() + " \nWidth: " + width + " \nHeight: " + height + " \nPrice: " + price.ToString("C");
        }
    }
    class MattedPhoto: Photo
    {
        //declaration of the PhotoDemo.MattedPhoto field variable for this class instance
        private string color;

        //constructor creation
        public MattedPhoto(int width , int height, string color) : base(width, height)
        {
            this.color = color;
            price += 10;
            this.ToString();//invoke to string method for display of classes instance
        }

        //override the base class to this class instance
        //and assign color 
        override public string ToString()
        {
            return base.ToString() + " \nColor: " + color ;
        }

    }
    class FramedPhoto : Photo
    {
        //declate the class field variable for this class instance
        private string frameMaterial;
        private string style;

        public FramedPhoto(int width, int height, string frameMaterial, string style) : base(width, height)
        {
            this.frameMaterial = frameMaterial;
            this.style = style;
            price += 25;
            this.ToString();//invoke to string method for display of classes instance
        }

        //override the base class to this class instance
        //and assign frame material and the style
        override public string ToString()
        {
            return base.ToString() + " \nFrame Material: " + frameMaterial + " \nStyle: " + style;
        }
    }
}
