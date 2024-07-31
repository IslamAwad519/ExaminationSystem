using ExaminationSystem.Models.Enums;

namespace ExaminationSystem.Services.Questions;

public class QuestionService : IQuestionService
{
    private readonly ApplicationDbContext _context;

    public QuestionService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Question> AddQuestionAsync(CreateQuestionDto createQuestionDto)
    {
        // Create a new Question object from the DTO
        var question = new Question
        {
            Text = createQuestionDto.Text,
            Grade = createQuestionDto.Grade
        };
        if (Enum.TryParse(createQuestionDto.QuestionLevel, out QuestionLevel level))
        {
            question.QuestionLevel = level;
        }
        else
        {
            // Handle the case where the enum parsing fails
            throw new ArgumentException($"Invalid question level: {createQuestionDto.QuestionLevel}");
        }

        _context.Questions.Add(question);
        await _context.SaveChangesAsync();

        // Create Choice objects and associate them with the Question ID
        var choices = createQuestionDto.Choices.Select(c => new Choice
        {
            Text = c.Text,
            IsCorrect = c.IsCorrect,
            QuestionId = question.Id  // Assuming Choice entity has a QuestionId property
        }).ToList();

        _context.Choices.AddRange(choices);
        await _context.SaveChangesAsync();
        return question;
    }

    public async Task<IEnumerable<Question>> GetQuestionsForInstructor(string createdBy)
    {
        return await _context.Questions
           .Where(c => c.CreatedById == createdBy)
           .Include(c => c.Choices)
           .ToListAsync();
    }
}
