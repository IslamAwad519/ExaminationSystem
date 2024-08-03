namespace ExaminationSystem.Services.Questions;

public interface IQuestionService
{
    Task<Question> AddQuestionAsync(CreateQuestionDto createQuestionDto);
    Task<IEnumerable<Question>> GetQuestionsForInstructor(string createdBy);
    Task<bool> DeleteQuestionsForSpecificInstructor(int questionId, string instructorId);
}


