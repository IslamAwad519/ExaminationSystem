namespace ExaminationSystem.Models.Entities;

public class Choice : BaseAuditableEntity
{
   public int Id { get; set; }
   public required string Text { get; set; }
    public bool IsCorrect { get; set; }

    //navigation properties
    public int QuestionId { get; set; }
    public Question? Question { get; set; }
}
