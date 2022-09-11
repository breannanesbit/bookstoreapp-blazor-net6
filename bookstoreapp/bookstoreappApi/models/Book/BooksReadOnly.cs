using bookstoreappApi.models.author;

namespace bookstoreappApi.models.Book
{
    public class BooksReadOnly : BaseDto
    {
        public int? AuthorId { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public string? Price { get; set; }
        public string? AuthorName { get; set; }

    }
}
