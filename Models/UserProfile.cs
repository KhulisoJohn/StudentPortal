using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Models
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public Student? Student { get; set; } // Optional 1-to-1
    }
}
