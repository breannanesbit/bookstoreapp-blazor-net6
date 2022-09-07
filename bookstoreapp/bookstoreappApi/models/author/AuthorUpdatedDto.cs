using System.ComponentModel.DataAnnotations;

namespace bookstoreappApi.models.author
{
    public class AuthorUpdatedDto : BaseDto
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(250)]
        public int Bio { get; set; }
    }
}
