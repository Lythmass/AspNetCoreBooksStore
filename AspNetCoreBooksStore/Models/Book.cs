using System.ComponentModel.DataAnnotations;
namespace AspNetCoreBooksStore.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "Cannot be longer than 50")]
        public string Title { get; set; }

        [Required]
        public string AuthorName { get; set; }

        [Required]
        [Range(1900, 2023, ErrorMessage = "Year must be between 1900 and 2023")]
        public int yearOfPublication { get; set; }
    }
}
