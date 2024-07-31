namespace ExaminationSystem.Models.Entities;

public class Result : BaseAuditableEntity
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int CourseId { get; set; }
    public int ExamId { get; set; }
    public int TotalGrade { get; set; }

    //navigation properties
    public Instructor? Instructor { get; set; }
    public Student? Student { get; set; }
    public Exam? Exam { get; set; }
}
