namespace ExaminationSystem.Persistence.EntitiesConfiguration;

public class ExamQuestionConfiguration : IEntityTypeConfiguration<ExamQuestion>
{
    public void Configure(EntityTypeBuilder<ExamQuestion> builder)
    {
        builder.HasIndex(eq => new { eq.ExamId, eq.QuestionId }).IsUnique();
    }
}
