using ExaminationSystem.Models.Enums;

namespace ExaminationSystem.Models.Entities;

public class Question : BaseAuditableEntity
{
    public int Id { get; set; }
    public required string Text { get; set; }
    public int Grade { get; set; }
    public ICollection<ExamQuestion>? Exams { get; set; }
    public QuestionLevel QuestionLevel { get; set; }
    public ICollection<Choice>? Choices { get; set; }

}