
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
                if (context.Author.Any())
                {
                    return;
                }
                context.Author.AddRange(
                    new Author { FirstName = "Denis", LastName = "Panjuta", Country = "Germany" },
                    new Author { FirstName = "Mosh", LastName = "Hamedani", Country = "USA" }
                );
                context.SaveChanges();

                if (context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(
                    new Book { 
                        Title = "Tiny C# Projects", 
                        CallNumber = "gh034-567", 
                        Author=context.Author.Where(x=>x.LastName=="Panjuta").FirstOrDefault() }
                    , new Book
                    {
                        Title = "React",
                        CallNumber = "re034-567",
                        Author = context.Author.Where(x => x.LastName == "Hamedani").FirstOrDefault()
                    }
                    , new Book
                    {
                        Title = "Angular",
                        CallNumber = "Ang034-567",
                        Author = context.Author.Where(x => x.LastName == "Hamedani").FirstOrDefault()
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
