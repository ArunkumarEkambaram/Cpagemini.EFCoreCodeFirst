using Cpagemini.EFCoreCodeFirst.Models;
using System;

namespace Cpagemini.EFCoreCodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookService bookService = new BookService();

            ////Calling Add Book Method
            ////Initializing book class
            //Book book = new Book
            //{
            //    BookName = "EF Core for Dummies",
            //    ISBN = "789-456",
            //    AuthorName = "Sam",
            //    AddedDate = DateTime.Now,
            //};

            //int res = bookService.AddBook(book);
            //if (res > 0)
            //{
            //    Console.WriteLine("New Book Added Successfully");
            //}

            ////Calling Get All Books Method
            //var books = bookService.GetAllBooks();
            //foreach (var b in books)
            //{
            //    Console.WriteLine($"Name :{b.BookName}\tISBN :{b.ISBN}\tAuthor Name :{b.AuthorName}");
            //}

            ////Calling Book By Id
            //var book = bookService.GetBookById(10);
            //if(book != null)
            //{
            //    Console.WriteLine($"Book Name :{book.BookName}\tISBN :{book.ISBN}\tAuthor Name :{book.AuthorName}");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter valid book id");
            //}

            ////Calling Update Book
            //Book updateBook = new Book
            //{
            //    BookName = "C# 7.0 Advance",
            //    AuthorName = "Andrew Philip"
            //};
            //int res = bookService.UpdateBook(1, updateBook);
            //if (res > 0)
            //{
            //    Console.WriteLine("Book Modified"); ;
            //}

            //Calling Delete Book
            int res = bookService.DeleteABook(2);
            if (res > 0)
            {
                Console.WriteLine("Book Deleted");
            }
        }
    }    
}
