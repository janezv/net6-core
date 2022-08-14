using Microsoft.AspNetCore.Mvc;
using BooksLibrary.Models;

namespace BooksLibrary.Controllers
{
    public class authorsAjaxController : Controller
    {
        [HttpPost]
        public Book Index(Book book)
        {
            Book bookOut = new Book();
            bookOut.Id = book.Id;
            bookOut.Title = book.Title;
            bookOut.CallNumber = book.CallNumber;
            bookOut.Author = book.Author;
            return bookOut;
        }
    }
}
