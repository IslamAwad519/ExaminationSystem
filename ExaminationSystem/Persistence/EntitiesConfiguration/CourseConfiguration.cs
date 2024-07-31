namespace ExaminationSystem.Persistence.EntitiesConfiguration;

public class CourseConfiguration : IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.Property(e => e.Name)
               .HasMaxLength(250);

        builder.HasIndex(e => e.Name).IsUnique();

        builder.Property(e => e.Description)
               .HasMaxLength(1000);

        builder.HasQueryFilter(e => !e.IsDeleted);
    }   
}
