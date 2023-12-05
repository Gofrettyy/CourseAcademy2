using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation;

public class InstructorValidator:AbstractValidator<Instructor>
{
    public InstructorValidator()
    {
        RuleFor(ins => ins.Id).NotEmpty();
        RuleFor(ins => ins.Name).MinimumLength(2);
    }
}