using BooksLibrary.Data;
using BooksLibrary.Models;
using System.Linq;


namespace BooksLibrary.ViewModels.Mapping
{
    public class AuthorMapping
    {
        private readonly LibraryBooksContext _context;

        public AuthorMapping(LibraryBooksContext context)
        {
            _context = context;
        }
        public AuthorVM authro2AuthorMV(Author author)
        {
            AuthorVM vm = new AuthorVM();
            vm.Id = author.Id;
            vm.FirstName = author.FirstName;
            vm.LastName = author.LastName;
            vm.Country = author.Country;
            var booksDb = from booksdb in _context.Books
                          where booksdb.Author.Id == author.Id
                          select booksdb;
            booksDb.ToList();
            vm.Books = new List<BookVM>();
            foreach (var book in booksDb)
            {
                BookVM bookvm = new BookVM();
                bookvm.Id = book.Id;
                bookvm.Title = book.Title;
                bookvm.CallNumber = book.CallNumber;
                vm.Books.Add(bookvm);
            }

            return vm;
        }
    }
}
