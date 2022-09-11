using Microsoft.Build.Framework;

namespace bookstoreappApi.models.Book
{
    public class BookCreateDto
    {
        [Required]
        public string? Title { get; set; }
        [Required]
        public int? Year { get; set; }
        [Required]
        public string Isbn { get; set; } = null!;
        [Required]
        public string? Summary { get; set; }
        public string? Image { get; set; }
        [Required]
        public decimal? Price { get; set; }
        public DateTime? YearPublished { get; set; }
        [Required]
        public int? AuthorId { get; set; }
        [Required]
        public string? AuthorName { get; set; }
    }
}
