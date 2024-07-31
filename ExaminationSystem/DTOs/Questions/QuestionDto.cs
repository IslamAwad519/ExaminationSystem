using ExaminationSystem.DTOs.Choices;

namespace ExaminationSystem.DTOs.Questions;

public class QuestionDto
{
    public int Id { get; set; }
    public required string Text { get; set; }
    public int Grade { get; set; }
    public required string QuestionLevel { get; set; }
    //public ICollection<ChoiceDto>? Choices { get; set; }
}
