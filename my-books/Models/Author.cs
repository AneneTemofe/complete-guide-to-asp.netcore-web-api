﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public List<Book_Author> Book_Author { get; set; }

    }
}
