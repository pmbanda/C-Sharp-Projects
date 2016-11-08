using static System.Console;
using static Books.Book;

namespace AddBooks
{
    class AddBook
    {
        public static void main()
        {
            Book book1 = new Books.Book("Silas Marner ", 350, 15.95);
            Book book2 = new Books.Book("Moby Dick ", 250, 16.00);

            Book book3;
            book3 = book1 + book2;
            WriteLine("The new book is \"{0}\"", book3.Title);
            WriteLine("It has {0} pages and costs {1}", book3.NumPages, book3.Price.ToString("C"));
        }

    }
}

