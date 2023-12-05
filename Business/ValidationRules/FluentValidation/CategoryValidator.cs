using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation;

public class CategoryValidator:AbstractValidator<Category>
{
    public CategoryValidator()
    {
        RuleFor(ct => ct.Id).NotEmpty();
        RuleFor(ct => ct.Name).MinimumLength(2);
    }
}