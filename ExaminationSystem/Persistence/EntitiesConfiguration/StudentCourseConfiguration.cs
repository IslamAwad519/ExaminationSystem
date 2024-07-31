namespace ExaminationSystem.Persistence.EntitiesConfiguration;

public class StudentCourseConfiguration : IEntityTypeConfiguration<StudentCourse>
{
    public void Configure(EntityTypeBuilder<StudentCourse> builder)
    {
        builder.HasIndex(sc => new { sc.CourseId, sc.StudentId, }).IsUnique();
    }
}
