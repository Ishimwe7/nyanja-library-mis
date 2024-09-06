using System.ComponentModel.DataAnnotations;

namespace nyanja_library_mis.Models
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(150)]
        public string Description { get; set; }
    }
}
