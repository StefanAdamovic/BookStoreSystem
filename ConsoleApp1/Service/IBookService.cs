using ConsoleApp1.Model;
using System.Collections.Generic;

namespace ConsoleApp1.Service
{
    interface IBookService
    {
 
        Book CreateBook(Book book);

        Book GetBookById(int id);

        List<Book> GetAllBooks();

        Book SaveBook(Book book);

        Book DeleteBook(int id);
    }
}
