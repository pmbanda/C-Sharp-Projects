//Author:   Peter Eugene Mbanda
//Date:     3/23/2016
//Purpose:  Application to determine the area of different shapes

/*
Created by Peter Eugene M
Instructions from Visual C# by Joyce Farrell 2015
Under no circumstance for distribution
unless with permission
Rights Reserved @PemBrand software
*/
using System;
using static System.Console;

namespace ShapesDemo
{
    class Demo
    {
        static void Main(string[] args)
        {
            //create objects and test the methods
            //rectangle object
            GeometricFigure rectangle;
            rectangle = new Rectangle(15, 20);
            Console.WriteLine(rectangle.ToString());

            //square object 
            GeometricFigure square;
            square = new Square(30, 22);
            Console.WriteLine(square.ToString());

            //square object
            square = new Square(10);
            Console.WriteLine(square.ToString());

            //triangle object
            GeometricFigure triangle;
            triangle = new Triangle(50, 70);
            Console.WriteLine(triangle.ToString());

            ReadLine();
        }
    }
    abstract class GeometricFigure
    {
        //class level fields
        protected double height;
        protected double width;
        protected double area;
        public GeometricFigure(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        //field properties
        public double Height { get; set; }
        public double Width { get; set; }

        //readonly property for area
        private double Area { get { return Area; } }

        //abstract method area
        public abstract double ComputeArea();
    }
    class Rectangle : GeometricFigure
    {
        //override the method to compute the area of a rectangle
        public Rectangle(double height, double width) : base(height, width)
        {
            ComputeArea();
        }
       
        public override double ComputeArea()
        {
            area = width * height;
            return area;
        }
        //override to diaplay the objects instance
        public override string ToString()
        {
            return this.GetType() + "\nHeight: " + this.height + "\nWidth: " + this.width + "\nArea: " + this.area;
        }
    }
    class Square : GeometricFigure
    {
        //assign same value to the height and width if the values are different
        public Square(double width , double height) : base(height, width)
        {
            this.width = width;
            if(this.width != height)
                this.height = width;
            ComputeArea();
        }
        //use one parametet to assign both the height and width as the same values
        public Square(double height) : base(height, height)
        {
            this.height = height;
            this.width = height;
            ComputeArea();
        }

        //override the method to compute the area of a Square
        override
        public double ComputeArea()
        {
            area = this.height * this.width;
            return area;
        }
        //override to diaplay the objects instance
        public override string ToString()
        {
            return this.GetType() + "\nHeight: " + this.height + "\nWidth: " + this.width + "\nArea: " + this.area;
        }
    }
    class Triangle : GeometricFigure
    {
        public Triangle(double height, double width) : base(height, width)
        {
            ComputeArea();
        }
        //override the method to compute the area of a Triangle
        override
        public double ComputeArea()
        {
            area = width * (height / 2.0);
            return area;
        }
        //override to diaplay the objects instance
        public override string ToString()
        {
            return this.GetType() + "\nHeight: " + this.height + "\nWidth: " + this.width + "\nArea: " + this.area;
        }
    }
}
