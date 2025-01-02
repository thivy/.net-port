using System.ComponentModel.DataAnnotations;

namespace CardDemo.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Balance { get; set; }
    }
}
