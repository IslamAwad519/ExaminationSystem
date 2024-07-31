using ExaminationSystem.DTOs.Auth;
namespace ExaminationSystem.Validattions.Auth;

public class RegisterDtoValidator : AbstractValidator<RegisterDto>
{
    public RegisterDtoValidator()
    {
        RuleFor(e => e.Email)
            .NotEmpty()
            .EmailAddress();

        RuleFor(e => e.Password)
            .NotEmpty()
            .Matches(RegexPatterns.Password)
            .WithMessage("password must be at least 6 digits,contains lower case,upper case special chars");

        RuleFor(e=>e.FirstName).NotEmpty().Length(2,100);
        RuleFor(e=>e.LastName).NotEmpty().Length(2, 100);
    }
}