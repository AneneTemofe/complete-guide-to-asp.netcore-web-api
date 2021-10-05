using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_books.Data.Models;
using my_books.Services;
using my_books.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_books.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BooksServices _booksServices;

        public BooksController(BooksServices booksServices)
        {
            _booksServices = booksServices;
        }

        [HttpPost("add-book")]
        public IActionResult AddBook(BooksVM books)
        {
            _booksServices.AddBook(books);
            return Ok();
        }

        [HttpGet("get-all-books")]
        public IActionResult GetAllBooks()
        {
            var allBook = _booksServices.GetAllBooks();
            return Ok(allBook);

        }

        [HttpGet("get-books-by-Id/{Id}")]
        public IActionResult GetBooksById(int Id)
        {
            var allBook = _booksServices.GetBookById(Id);
            return Ok(allBook);

        }


        [HttpPut("update-books-by-Id/{Id}")]
        public IActionResult UpdateBooksById(int Id, BooksVM books)
        {
            var allBook = _booksServices.UpdateBookById(Id, books);
            return Ok(allBook);

        }

        [HttpDelete("delete-books-by-Id/{Id}")]
        public IActionResult DeleteBooksById(int Id)
        {
            _booksServices.DeleteBookById(Id);
            return Ok();

        }

    }
}
