using System.ComponentModel.DataAnnotations;

namespace nyanja_library_mis.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int Rating { get; set; }

        [MaxLength(150)]
        public string Comment { get; set; }
        public DateTime ReviewDate { get; set; }
    }
}
