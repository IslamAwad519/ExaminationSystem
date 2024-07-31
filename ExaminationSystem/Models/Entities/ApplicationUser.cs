namespace ExaminationSystem.Models.Entities;

public sealed class ApplicationUser : IdentityUser
{
    public  string FirstName { get; set; }
    public  string LastName { get; set; }

}
