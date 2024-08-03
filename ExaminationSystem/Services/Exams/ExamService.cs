using ExaminationSystem.DTOs.Exam;
using ExaminationSystem.Models.Enums;

namespace ExaminationSystem.Services.Exams;

public class ExamService : IExamService
{
    private readonly ApplicationDbContext _context;
    public ExamService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> GenerateExamAsync(ExamParams examParams)
    {
        // Check if there is already a final exam
        var existingFinalExam = await _context.Exams.AnyAsync(e => e.FinalExam);
        if (examParams.FinalExam && existingFinalExam)
        {
            throw new InvalidOperationException("A final exam already exists. Cannot add another final exam.");
        }

        var totalSimpleQuestions = await _context.Questions.CountAsync(q => q.QuestionLevel == QuestionLevel.Simple);
        var totalMediumQuestions = await _context.Questions.CountAsync(q => q.QuestionLevel == QuestionLevel.Medium);
        var totalHardQuestions = await _context.Questions.CountAsync(q => q.QuestionLevel == QuestionLevel.Hard);

        if (totalSimpleQuestions < examParams.SimpleQuestions || totalMediumQuestions < examParams.MediumQuestions || totalHardQuestions < examParams.HardQuestions)
        {
            throw new InvalidOperationException("Not enough questions available to generate the exam.");
        }

        var simpleQuestionsList = await _context.Questions
            .Where(q => q.QuestionLevel == Models.Enums.QuestionLevel.Simple)
            .OrderBy(r => Guid.NewGuid())
            .Take(examParams.SimpleQuestions)
            .ToListAsync();

        var mediumQuestionsList = await _context.Questions
            .Where(q => q.QuestionLevel == Models.Enums.QuestionLevel.Medium)
            .OrderBy(r => Guid.NewGuid())
            .Take(examParams.MediumQuestions)
            .ToListAsync();

        var hardQuestionsList = await _context.Questions
            .Where(q => q.QuestionLevel == Models.Enums.QuestionLevel.Hard)
            .OrderBy(r => Guid.NewGuid())
            .Take(examParams.HardQuestions)
            .ToListAsync();

            var exam = new Exam
            {
                Title = examParams.Title,
                CourseId = examParams.CourseId,
                TotalGrade = examParams.TotalGrade,
                FinalExam = examParams.FinalExam,
                StartDate = examParams.StartDate,
                InstructorId = examParams.InstructorId
            };

        _context.Exams.Add(exam);
        await _context.SaveChangesAsync();

        var examQuestions = simpleQuestionsList.Concat(mediumQuestionsList).Concat(hardQuestionsList)
            .Select(q => new ExamQuestion
            {
                ExamId = exam.Id,
                QuestionId = q.Id
            }).ToList();

        _context.ExamQuestions.AddRange(examQuestions);
        await _context.SaveChangesAsync();

        // Load the questions into the exam entity
        exam.Questions = examQuestions;

        return true;
    }

}
