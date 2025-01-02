using System.ComponentModel.DataAnnotations;

namespace CardDemo.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(16)]
        public string Number { get; set; }

        [Required]
        [StringLength(5)]
        public string ExpiryDate { get; set; }
    }
}
