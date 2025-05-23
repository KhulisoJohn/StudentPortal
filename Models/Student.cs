using System.Collections.Generic;
using StudentPortal.Models;
using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Models
{
  public class Student
{
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string? FullName { get; set; }

    public int? UserProfileId { get; set; }
    public UserProfile? UserProfile { get; set; }

    public ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
}
  
}
