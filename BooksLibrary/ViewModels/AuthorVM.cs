
using System.ComponentModel.DataAnnotations;

namespace BooksLibrary.ViewModels
{
    public class AuthorVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public ICollection<BookVM> Books { get; set; }
    }
    public class BookVM
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? CallNumber { get; set; }
    }

}
