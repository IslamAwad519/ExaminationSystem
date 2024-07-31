namespace ExaminationSystem.Models.Entities;

public class Course : BaseAuditableEntity
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
    public int Credits { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }


    //navigation properties
    public Instructor? Instructor { get; set; }
    public ICollection<Exam>? Exams { get; set; } = [];
    public ICollection<StudentCourse>? Students { get; set; } = [];

}
