using bookstoreappApi.models.author;
using System;
using System.Collections.Generic;

namespace bookstoreappApi.Data
{
    public partial class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int? Year { get; set; }
        public string Isbn { get; set; } = null!;
        public string? Summary { get; set; }
        public string? Image { get; set; }
        public decimal? Price { get; set; }
        public DateTime? YearPublished { get; set; }
        public int? AuthorId { get; set; }

        public virtual AuthorUpdatedDto? Author { get; set; }
    }
}
