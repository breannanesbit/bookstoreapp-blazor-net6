using bookstoreappApi.models.author;
using System.ComponentModel.DataAnnotations;

namespace bookstoreappApi.models.Book
{
    public class BookUpdateDto : BaseDto
    {
        [Required]
        [StringLength(75)]
        public string Title { get; set; }

        [Required]
        [StringLength(75)]
        public string AuthorName { get; set; }

        [StringLength(250)]
        public string? Summary { get; set; }

        [Required]
        public int? Year { get; set; }
        
        [Required]
        public string Isbn { get; set; } = null!;
        [Required]
        public string? Image { get; set; }
        [Required]
        public decimal? Price { get; set; }
        [Required]
        public DateTime? YearPublished { get; set; }
        [Required]
        public int? AuthorId { get; set; }
    }
}
