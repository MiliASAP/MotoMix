using System.ComponentModel.DataAnnotations;

namespace MotoMix.Models
{
    public class IdentityUser
    {
        [Key]
        public int UserId { get; set; }

        [Required] 
        [MaxLength(50)] 
        public string FirstName { get; set; } = String.Empty;
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = String.Empty;
        [Required]
        [MaxLength(14)]
        public string Mobile { get; set; } = String.Empty;
        [Required]
        [MaxLength(100)]
        public string Email { get; set; } = String.Empty;

    }
}
