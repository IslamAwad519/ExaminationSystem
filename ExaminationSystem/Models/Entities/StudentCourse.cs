using System.ComponentModel.DataAnnotations;

namespace ExaminationSystem.Models.Entities;

public class StudentCourse
{
    [Key]
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }

    public Student? Student { get; set; }
    public Course? Course { get; set; }
}
