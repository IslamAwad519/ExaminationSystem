namespace ExaminationSystem.Models.Common;

public abstract class Person : BaseAuditableEntity
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public DateTime BirthOfDate { get; set; }

}
