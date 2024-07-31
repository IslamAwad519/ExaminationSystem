namespace ExaminationSystem.DTOs.Courses;

public class EnrollmentRequest
{
    public int StudentId { get; set; }
    public List<int> CourseIds { get; set; } = new List<int>();
}

