using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation;

public class CourseValidator:AbstractValidator<Course>
{
    public CourseValidator()
    {
        RuleFor(c => c.Title).NotEmpty();
        RuleFor(c => c.Title).MinimumLength(2);
        RuleFor(c => c.Price).NotEmpty();
        RuleFor(c => c.Price).GreaterThan(0);
        RuleFor(c => c.Title).Must(StartWithA).WithMessage("Kurslar A harfi ile başlamalı");
    }

    private bool StartWithA(string arg)
    {
        return arg.StartsWith("A");
    }
}