namespace ExaminationSystem.DTOs.Exam;

public class CreateExamDto
{
    public int NumberOFSimpleQuestions { get; set; }
    public int NumberOFMediumQuestions { get; set; }
    public int NumberOFHardQuestions { get; set; }

    public bool Automatic { get; set; }
}
