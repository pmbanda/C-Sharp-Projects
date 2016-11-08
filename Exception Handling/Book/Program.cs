//Author:   Peter Eugene Mbanda
//Date:     4/29/2016
//Purpose:  Book programe to determine if the price of a book falls within a 
//          specified price per page


using System;

namespace Book
{
    class BookClient
    {
        static void Main(string[] args)
        {
            //number of client objects to be instantiated
            Books[] client = new Books[4];
            int count = 0;//counter variable

            //class clients
            
            for (int i = 0; i < client.Length; i++)
            {
                try
                {
                    switch (count)
                    {
                        case 0:
                            //determine objects validity by passing arguments to constructor
                            //and display if the requirements are met
                            Console.WriteLine("Client: " + (count + 1));
                            client[count] = new Books("Goblet Of Fire", "J.K Rawlings", 15.22, 150);
                            Console.WriteLine(client[count].ToString());
                            break;
                        case 1:
                            //determine objects validity by passing arguments to constructor
                            //and display if the requirements are met
                            Console.WriteLine("Client: " + (count + 1));
                            client[count] = new Books("10000 Hours", "Malcom Gladwell", 2.5, 25);
                            Console.WriteLine(client[count].ToString());
                            break;
                        case 2:
                            //determine objects validity by passing arguments to constructor
                            //and display if the requirements are met
                            Console.WriteLine("Client: " + (count + 1));
                            client[count] = new Books("Highly Effective People", "Stephen Covey", 3.00, 50);
                            Console.WriteLine(client[count].ToString());
                            break;
                        case 3:
                            //determine objects validity by passing arguments to constructor
                            //and display if the requirements are met
                            Console.WriteLine("Client: " + (count + 1));
                            client[count] = new Books("Magic Of Thinking Big", "David Schwartz", 7.68, 30);
                            Console.WriteLine(client[count].ToString());
                            break;
                    }

                }
                catch (BookException ex)
                {
                    //catch the book exception error
                    Console.WriteLine(ex.Message + "\n");
                }
                ++count;
            }
        }
    }
    class Books
    {
        //class fields
        private string title;
        private string author;
        private double price;
        private int pages;

        //class properties read only characteristics
        public string Title { get { return title; } }
        public string Author { get { return author; } }
        public double Price { get { return price; } }
        public int Pages { get { return pages; } }

        //class constructor 
        public Books(string title, string author, double price, int pages)
        {
            //assign the values to the object 
            this.title = title;
            this.author = author;
            this.price = price;
            this.pages = pages;

            //determine the price per page
            PricePerPage();

            //throw exception if conditions are not met
            if (PricePerPage() > 0.10)
            {
                throw new BookException("ERROR-Price shouldn't exceed 10cent per page");
            }
        }

        private double PricePerPage()
        {
            //calculate the price per page 
            double pricePerPage = this.Price / this.Pages;

            return pricePerPage;//teturn value to the calling method
        }
        public override string ToString()
        {
            return "\nTitle: " + this.title + "\nAuthor: " + this.author + "\nPrice: " + this.price 
                + "\nPages: " + this.pages + "\nPrice per page: " + PricePerPage().ToString("F2") + "\n";
        }
    }

    internal class BookException : Exception
    {
        public BookException(string message) : base(message)
        {
            //book exception class with constructor
        }

    }
}
