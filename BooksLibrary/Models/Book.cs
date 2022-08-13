
using System.ComponentModel.DataAnnotations;

namespace BooksLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(40), MinLength(1)]
        [Required(ErrorMessage = "Please enter Title of The book")]
        [Display(Name = "Naslov Knjige")]
        public string? Title { get; set; }
        [MaxLength(40), MinLength(1)]
        [Required(ErrorMessage = "Please enter CallNumber")]
        [Display(Name = "Šifra knjige")]
        public string? CallNumber { get; set; }
        public Author Author { get; set; }
    }
}
