using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using ConsoleApp1.Exception;

namespace ConsoleApp1.Service.impl
{
    class BookService : IBookService
    {
        public Book CreateBook(Book book)
        {
            foreach (Book a in Database.Database.Books)
            {
                if (a.Name.Equals(book.Name))
                {
                    throw new BookException("Book already exists.");
                }
            }
            int idOfLastItem = Database.Database.Books[(Database.Database.Books.Count - 1)].Id;
            book.Id = idOfLastItem + 1;
            Database.Database.Books.Add(book);
            return book;
        }

        public Book DeleteBook(int id)
        {
            Book returningAuthor = null;
            foreach (Book a in Database.Database.Books)
            {
                if (a.Id == id)
                {
                    returningAuthor = a;
                    Database.Database.Books.Remove(a);
                    break;
                }
            }
            return returningAuthor;
        }

        public List<Book> GetAllBooks()
        {
            return Database.Database.Books;
        }

        public Book GetBookById(int id)
        {
            Book returningBook = null;
            foreach (Book a in Database.Database.Books)
            {
                if (a.Id == id)
                {
                    returningBook = a;
                    break;
                }
            }
            return returningBook;
        }

        public Book SaveBook(Book author)
        {
            throw new NotImplementedException();
        }
    }
}
