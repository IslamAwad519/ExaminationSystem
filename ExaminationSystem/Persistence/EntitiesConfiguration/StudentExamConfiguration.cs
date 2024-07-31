
namespace ExaminationSystem.Persistence.EntitiesConfiguration;

public class StudentExamConfiguration : IEntityTypeConfiguration<StudentExam>
{
    public void Configure(EntityTypeBuilder<StudentExam> builder)
    {
        builder.HasIndex(se => new { se.StudentId, se.ExamId }).IsUnique();
    }
}
