using System.ComponentModel.DataAnnotations;

namespace BookFare.Model
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        [Required]
        [StringLength(100)]
        public string? Author { get; set; }

        public int Price { get; set; }

    }
}
