using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;

namespace ConsoleApp1.InputHandlers
{
    public static class BookRender
    {

        public static void WriteAllBooks(List<Book> books)
        {
        
            if (books.Count == 0)
            {
                Console.WriteLine("No books found.");
                return;
            }

            Console.WriteLine("Books List:");
            foreach (Book book in books)
            {
                Console.WriteLine(book.ToString());
            }
        }

        public static void WriteBookById(Book book)
        {
            if (book != null)
            {
                Console.WriteLine(book.ToString());
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
}

