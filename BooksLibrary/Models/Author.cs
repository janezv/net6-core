namespace BooksLibrary.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Country { get; set; }
        List<Book> Books { get; set; }
    }
}
