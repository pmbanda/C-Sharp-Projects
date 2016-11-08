//Author:   Peter Eugene Mbanda
//Date:     3/1/2016
//Purpose:  Classified application wording and pricing

using System;

namespace TestClassifiedAd
{
    //class 
    class Classified
    {
        //field var for price per word
        const double PRICE_PER_WORD = (9 / 100.0);
        //class variables
        private string category;
        private int numberOfWords;
        private double price;

        //class properties getter and setters for class fields
        public string Category
        {
            get { return category; }
            set { category = value;  }
        }
        public int NumberOfWords
        {
            get { return numberOfWords; }
            set { numberOfWords = value; }
        }

        //price field only contains the getter property 
        public double Price
        {
            get
            {
                //calculate price by multiplying the number of words and price per word
                price = numberOfWords * PRICE_PER_WORD;
                return price;
            }
        }

    }
    class CreateClassified
    {
        static void Main()
        {
            //instantiate the class and populate the values
            Classified c1 = new Classified { Category = "New Cars ", NumberOfWords = 20 };
            Classified c2 = new Classified { Category = "Used Cars ", NumberOfWords = 100 };

            //Display the values of the classified object
            Console.WriteLine("{0,-10}{1,5}{2,4}", "Category", "Words ", "Price");
            Console.WriteLine("{0,-10}{1,5}{2,6}", c1.Category, c1.NumberOfWords, c1.Price.ToString("C"));
            Console.WriteLine("{0,-10}{1,5}{2,6}", c2.Category, c2.NumberOfWords, c2.Price.ToString("C"));

            Console.ReadLine();
        }
    }
}
