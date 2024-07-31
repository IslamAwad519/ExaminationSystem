using ExaminationSystem.Models.Enums;

namespace ExaminationSystem.Models.Entities;

public class Student : Person
{
    public int Id { get; set; }
    public int PhoneNumber { get; set; }
    public string? Address { get; set; }
    public Gender Gender { get; set; }


    //navigation properties
    public ICollection<StudentCourse>? Courses { get; set; } = [];
    public ICollection<StudentExam>? Exams { get; set; } = [];
    public ICollection<Result>? Results { get; set; } = [];

}

