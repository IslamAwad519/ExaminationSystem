using ExaminationSystem.DTOs.Exam;

namespace ExaminationSystem.Services.Exams;

public interface IExamService
{
    Task<bool> GenerateExamAsync(ExamParams examParams);

}
