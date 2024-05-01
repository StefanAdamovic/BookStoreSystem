using ConsoleApp1.InputHandlers;
using ConsoleApp1.Service;
using ConsoleApp1.Service.impl;
using System;

namespace ConsoleApp1.UI
{
    public class MainMenu
    {

        private readonly IBookService bookService = new BookService();
        public void DisplayMenu()
        {
            Console.WriteLine("Welcome to Book Service");

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1 - Create Book");
                Console.WriteLine("2 - See All Books");
                Console.WriteLine("3 - Find Book By ID");
                Console.WriteLine("4 - Delete Book By ID");
                Console.WriteLine("5 - Exit");

                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        bookService.CreateBook(BookInputHandler.GetBookDetailsFromUser());
                        break;
                    case "2":
                        BookRender.WriteAllBooks(bookService.GetAllBooks());
                        break;
                    case "3":
                        BookRender.WriteBookById(bookService.GetBookById(BookInputHandler.GetIdForBook()));
                        break;
                    case "4":
                        BookRender.WriteBookById(bookService.DeleteBook(BookInputHandler.GetIdForBook()));
                        break;
                    case "5":
                        Environment.Exit(0); // Exit the program
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
