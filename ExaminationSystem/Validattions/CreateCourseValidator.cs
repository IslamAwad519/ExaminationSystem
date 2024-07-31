

namespace ExaminationSystem.Validattions;

public class CreateCourseValidator  :AbstractValidator<CourseRequest>
{
    public CreateCourseValidator()
    {
        RuleFor(e => e.Name).NotEmpty();

        RuleFor(e => e.Description)
            .NotEmpty()
            .MaximumLength(1000);
    }
 
}
