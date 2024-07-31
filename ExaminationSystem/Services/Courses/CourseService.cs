using ExaminationSystem.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Services.Courses;

public class CourseService : ICourseService
{
    private readonly ApplicationDbContext _context;

    public CourseService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<bool> EnrollStudentInCourse(int studentId, List<int> courseIds)
    {
        var student = await _context.Students
            .Include(s => s.Courses)
            .FirstOrDefaultAsync(s=>s.Id == studentId);

        if (student is null)
            return false;

        var courses = await _context.Courses.Where(c=>courseIds.Contains(c.Id)).ToListAsync();
        foreach (var course in courses)
        {
            if(!student.Courses.Any(sc=>sc.CourseId == course.Id))
                {
                 student.Courses.Add(new StudentCourse { StudentId = studentId, CourseId = course.Id });
                } 
        }
        await _context.SaveChangesAsync();
        return true;

    }

    public async Task<IEnumerable<Course>> GetCourseForInstructor(string createdBy)
    {
        return await _context.Courses
            .Where(c => c.CreatedById == createdBy)
            .ToListAsync();
    }
}
