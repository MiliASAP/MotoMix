using System.ComponentModel.DataAnnotations;

namespace MotoMix.Models
{
    public class Car
    {
        [Key]
        public int CarId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Brand { get; set; } = String.Empty;
        [Required]
        [MaxLength(50)]
        public string Model { get; set; } = String.Empty;
        [Required]
        public int HorsePower { get; set; }
        [Required]
        public DateTime ProdDate { get; set; }
    }
}
