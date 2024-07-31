namespace ExaminationSystem.Models.Entities;

public class Instructor : Person
{
    public int Id { get; set; }
    public int CourseId { get; set; }

    public ICollection<Result>? Results { get; set; }
    public ICollection<Exam>? Exams { get; set; } = [];
    public Course? Course { get; set; } 
}
