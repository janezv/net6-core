using BooksLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksLibrary.Data
{
    public class LibraryBooksContext : DbContext
    {
        public LibraryBooksContext(DbContextOptions<LibraryBooksContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

    }
}