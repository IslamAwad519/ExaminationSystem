namespace ExaminationSystem.DTOs.Exam;

public class ExamParams
{
    public string Title { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public int TotalGrade { get; set; }
    public int CourseId { get; set; }
    public int InstructorId { get; set; }
    public bool FinalExam { get; set; }
    public int SimpleQuestions { get; set; } = 5;
    public int HardQuestions { get; set; }  = 5;
    public int MediumQuestions { get; set; } = 5;
}
