using System;
using System.Collections.Generic;

namespace ConsoleApp1.Model
{
    public class Book
    {

        // Properties
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal Price { get; set; }


        // Constructors
        public Book(int id, string name, decimal price)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Price = price;
        }


        public Book(string name, decimal price)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Price = price;
        }

        // Methods
        public override bool Equals(object obj)
        {
            return obj is Book book &&
                   Id == book.Id &&
                   Name == book.Name &&
                   Price == book.Price;
        }

        public override string ToString()
        {
            return "Book ID: "+ Id + " / Book Name: "+ Name+" / Book Price: "+Price+" eur";
        }
    }
}
