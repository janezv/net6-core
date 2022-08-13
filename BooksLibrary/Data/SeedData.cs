
using Microsoft.EntityFrameworkCore;
using BooksLibrary.Data;
using BooksLibrary.Models;

namespace BooksLibrary.Data
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context=new LibraryBooksContext(
                serviceProvider.GetRequiredService
                    <DbContextOptions<LibraryBooksContext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(
                    new Book { Title="Tiny C# Projects", Author= "Denis Panjuta", CallNumber ="AXD 2029"},
                    new Book { Title = "Tiny Android Projects", Author="EU tutorial" , CallNumber = "AXQ 2229" }
                );
                context.SaveChanges();
            }
        }
    }
}
