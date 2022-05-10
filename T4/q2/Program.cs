using System;
using System.Collections.Generic;
using System.Linq;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {

            var context = new DemoContext();

            // create a record in DB
            var book = new Book
            {
                Title = "Harry Potter",
                ISBN = "123",
                Author = "JK Rowling"
            };
            context.Add(book);
            context.SaveChanges();


            List<Book> books = context.Books.Where(b => b.ISBN == "123").ToList();
            foreach (var b in books)
            {
                Console.WriteLine(b.Title);
            }

            foreach (var b in books)
            {
                Console.WriteLine($"removing book {book.Title}");
                context.Books.Remove(book);
            }
            context.SaveChanges();



        }
    }
}
