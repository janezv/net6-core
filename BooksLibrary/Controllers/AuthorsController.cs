using BooksLibrary.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using BooksLibrary.ViewModels;
using BooksLibrary.ViewModels.Mapping;

namespace BooksLibrary.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly LibraryBooksContext _context;

        public AuthorsController(LibraryBooksContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Author.ToList());
        }
        public IActionResult AuthorDetails(int id)
        {
            AuthorMapping mapp = new AuthorMapping(_context);
            AuthorVM authorVM = mapp.authro2AuthorMV(_context.Author.Find(id));
            return View(authorVM);
        }
    }
}
