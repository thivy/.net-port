using System.ComponentModel.DataAnnotations;

namespace CardDemo.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AccountId { get; set; }

        [Required]
        [Range(0, double.MaxValue)]
        public double Amount { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
