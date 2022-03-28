using System;
using System.Collections.Generic;
using System.Linq;

namespace Cpagemini.EFCoreCodeFirst.Models
{
    public class BookService
    {
        private readonly AppDbContext _context;

        public BookService()
        {
            _context = new AppDbContext();
        }

        //CRUD
        /// <summary>
        /// Method used to add new book
        /// </summary>
        /// <param name="book">Details for the book</param>
        /// <returns>return number of rows affected</returns>
        public int AddBook(Book book)
        {
            int res = 0;
            if (book != null)
            {
                _context.Books.Add(book);
                res = _context.SaveChanges();
            }
            return res;
        }

        /// <summary>
        /// Get all the books details
        /// </summary>
        /// <returns>Return List of Books</returns>
        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        /// <summary>
        /// Get Book by its Id
        /// </summary>
        /// <param name="id">Book Id</param>
        /// <returns>Returns a book</returns>
        public Book GetBookById(int id)
        {
            return _context.Books.Find(id);
        }

        public int UpdateBook(int id, Book book)
        {
            int res = 0;
            var bookFromDB = _context.Books.Find(id);
            if (bookFromDB != null)
            {
                //Displaying Old Book
                Console.WriteLine("Displaying Current Book Details");
               // Console.WriteLine($"Name :{bookFromDB.BookName}\tISBN :{bookFromDB.ISBN}\tAuthor Name :{bookFromDB.AuthorName}");

                //Perform Update Operation
                bookFromDB.BookName = book.BookName;
               // bookFromDB.AuthorName = book.AuthorName;
                _context.Entry(bookFromDB).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                res = _context.SaveChanges();
            }
            return res;
        }        
        public int DeleteABook(int id)
        {
            int res = 0;
            var bookFromDb = _context.Books.Find(id);
            if (bookFromDb != null)
            {
                _context.Books.Remove(bookFromDb);
                _context.Entry(bookFromDb).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                res = _context.SaveChanges();
            }
            return res;
        }       
    }
}
