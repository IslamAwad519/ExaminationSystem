namespace ExaminationSystem.Models.Entities;

public class StudentExam
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public int ExamId { get; set; }

    public Student? Student { get; set; }
    public Exam? Exam { get; set; }
}
