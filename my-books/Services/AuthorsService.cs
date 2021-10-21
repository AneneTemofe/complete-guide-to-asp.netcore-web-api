using my_books.Data;
using my_books.Models;
using my_books.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Services
{
    public class AuthorsService
    {
        private AppDbContext _context;
        public AuthorsService(AppDbContext context)
        {
            _context = context;
        }


        public void AddAuthor(AuthorVM author)
        {
            Author _author = new Author()
            {
                FullName = author.fullName,
               
            };

            _context.Authors.Add(_author);
            _context.SaveChanges();
        }
    }
}
