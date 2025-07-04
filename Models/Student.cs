using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentPortalSystem.Models;

namespace StudentPortalSystem.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ApplicationUserId { get; set; } = string.Empty;

        [ForeignKey("ApplicationUserId")]
        public ApplicationUser? ApplicationUser { get; set; }

        public ICollection<StudentSubject>? StudentSubjects { get; set; }

        public DateTime EnrollmentDate { get; set; } = DateTime.UtcNow;

        public bool IsActive { get; set; } = true;

        [Required]
        public int Grade { get; set; } // Keep default empty for validation to catch missing data

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; } = DateTime.UtcNow; // Consider removing default to force real DOB input

        public bool CanJoinSubjectChannels { get; set; } = false;
    }
}
