namespace ExaminationSystem.DTOs.Courses;

public record CourseRequest(
    string Name,
    string? Description,
    int Credits,
    DateTime StartDate,
    DateTime EndDate
    );
