using ExaminationSystem.DTOs.Choices;

namespace ExaminationSystem.Services.Choices;

public interface IChoiceService
{
    Task<bool> AddChoicesToQuestionAsync(int questionId, List<ChoiceDto> choiceDtos);
}
