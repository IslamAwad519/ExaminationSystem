namespace ExaminationSystem.Models.Entities;

public class Exam : BaseAuditableEntity
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public int TotalGrade { get; set; }
    public int CourseId { get; set; }
    public int InstructorId { get; set; }
    public bool FinalExam { get; set; }


    //navigation properties
    public ICollection<ExamQuestion>? Questions { get; set; } = [];
    public Course? Course { get; set; }
    public Instructor? Instructor { get; set; }
    public ICollection<StudentExam>? Students { get; set; } = [];
    public ICollection<StudentCourse>? St_Courses { get; set; } = [];
    public ICollection<Result>? Results { get; set; } = [];
}
