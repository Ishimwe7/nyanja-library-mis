using System.ComponentModel.DataAnnotations;

namespace nyanja_library_mis.Models
{
    public class Book
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        public string ImageFileName { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int CategoryId { get; set; }
        public int PublicationYear { get; set; }
        public bool IsaAvailable { get; set; }
        public Book() { }

    }
}
