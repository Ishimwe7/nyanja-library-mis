using System.ComponentModel.DataAnnotations;

namespace nyanja_library_mis.Models
{
    public class Author
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string Names { get; set; }
        [MaxLength(100)]
        public string Bio { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime DeathDate { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
