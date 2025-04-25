using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem.Models
{
    public class Author
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();
    }
}