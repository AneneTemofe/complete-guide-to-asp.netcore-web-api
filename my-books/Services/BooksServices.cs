using my_books.Data;
using my_books.Data.Models;
using my_books.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Services
{
    public class BooksServices
    {
        private AppDbContext _context;
        public BooksServices(AppDbContext context)
        {
            _context = context;
        }

        public void AddBook(BooksVM books)
        {
            Book _book = new Book()
            {
                Title = books.Title,
                Description = books.Description,
                IsRead = books.IsRead,
                DateRead = books.IsRead ? books.DateRead.Value : null,
                Rate = books.IsRead ? books.Rate.Value : null,
                Genre = books.Genre,
                Author = books.Author,
                CoverUrl = books.CoverUrl,
                DateAdded = DateTime.Now,
            };

            _context.Books.Add(_book);
            _context.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            return _context.Books.ToList();
        }

        public Book GetBookById(int bookId)
        {
            return _context.Books.FirstOrDefault( x => x.Id == bookId);
        }

        public Book UpdateBookById(int Id, BooksVM books)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == Id);
            if (book != null)
            {
                book.Title = books.Title;
                book.Description = books.Description;
                book.IsRead = books.IsRead;
                book.DateRead = books.IsRead ? books.DateRead.Value : null;
                book.Rate = books.IsRead ? books.Rate.Value : null;
                book.Genre = books.Genre;
                book.Author = books.Author;
                book.CoverUrl = books.CoverUrl;

                _context.Books.Update(book);
                _context.SaveChanges();
            }

            return book;
        }

        public void DeleteBookById(int Id)
        {
            var book = _context.Books.FirstOrDefault(x => x.Id == Id);
            if (book != null)
            {
            
                _context.Books.Remove(book);
                _context.SaveChanges();
            }

        }

    }
}
