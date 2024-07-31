using ExaminationSystem.DTOs.Choices;

namespace ExaminationSystem.Services.Choices;

public class ChoiceService : IChoiceService
{
    private readonly ApplicationDbContext _context;
    public ChoiceService(ApplicationDbContext context)
    {
        _context = context;
    }

   
    public async Task<bool> AddChoicesToQuestionAsync(int questionId, List<ChoiceDto> choiceDtos)
    {
        var question = await _context.Questions
            .AsNoTracking()
            .FirstOrDefaultAsync(q=>q.Id == questionId);

        if(question is null)
            return false;

        var choices = choiceDtos.Select(c => new Choice
        {
            Text = c.Text,
            IsCorrect = c.IsCorrect,
            QuestionId = questionId
        }).ToList();

        await _context.Choices.AddRangeAsync(choices);
        await _context.SaveChangesAsync();
        return true;
    }
}
