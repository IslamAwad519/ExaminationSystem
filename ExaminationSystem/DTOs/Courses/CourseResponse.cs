namespace ExaminationSystem.DTOs.Courses;

public record CourseResponse(
    int Id,
    string Name,
    string? Description,
    int Credits,
    DateTime StartDate
    );

