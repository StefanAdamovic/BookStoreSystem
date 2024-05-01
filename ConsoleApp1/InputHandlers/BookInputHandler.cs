using ConsoleApp1.Model;
using System;

namespace ConsoleApp1.InputHandlers
{
    public static class BookInputHandler
    {

        public static Book GetBookDetailsFromUser()
        {
            Console.WriteLine("\nEnter book details:");

            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            decimal price;
            while (true)
            {
                Console.Write("Enter book price: ");
                if (!decimal.TryParse(Console.ReadLine(), out price))
                {
                    Console.WriteLine("Invalid price format. Please enter a valid decimal number.");
                }
                else
                {
                    break;
                }
            }
            return new Book(title, price);
        }


        public static int GetIdForBook()
        {
            int id = 0;
            bool validInput = false;

            while (!validInput)
            {
                Console.Write("Enter book ID: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out id))
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid book ID. Please enter a valid integer.");
                }
            }

            return id;
        }
    }
}
