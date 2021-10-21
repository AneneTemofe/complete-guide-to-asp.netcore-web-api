using my_books.Data;
using my_books.Models;
using my_books.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Services
{
    public class PublisherService
    {
        private AppDbContext _context;
        public PublisherService(AppDbContext context)
        {
            _context = context;
        }


        public void AddPublisher(PublisherVM publisher)
        {
            Publisher _publisher = new Publisher()
            {
                Name = publisher.Name,
               
            };

            _context.Publishers.Add(_publisher);
            _context.SaveChanges();
        }
    }
}
