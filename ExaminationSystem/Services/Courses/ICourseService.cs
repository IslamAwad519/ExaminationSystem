namespace ExaminationSystem.Services.Courses;

public interface ICourseService
{
    Task<bool> EnrollStudentInCourse(int studentId, List<int> courseIds);
    Task<IEnumerable<Course>> GetCourseForInstructor(string createdBy);
}
