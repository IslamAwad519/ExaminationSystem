using ExaminationSystem.DTOs.Choices;
namespace ExaminationSystem.DTOs.Questions;


public class CreateQuestionDto
{
    public required string Text { get; set; }
    public required int Grade { get; set; }
    public string QuestionLevel { get; set; }
    public required List<ChoiceDto> Choices { get; set; }
}
