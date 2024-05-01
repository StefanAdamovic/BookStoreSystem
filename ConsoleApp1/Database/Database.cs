using ConsoleApp1.Model;
using System.Collections.Generic;

namespace ConsoleApp1.Database
{
    class Database
    {
        public static List<Book> Books = new List<Book>
        {
            new Book(1, "Book 1", 9.99m),
            new Book(2, "Book 2", 19.70m),
            new Book(3, "Book 3", 1.23m),
            new Book(4, "Book 4", 5.44m),
            new Book(5, "Book 5", 11.33m),
        };
    }
}
