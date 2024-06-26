using FluentValidation;

namespace Application;


public class ILeaveTypeDtoValidator : AbstractValidator<ILeaveTypeDto> {
    public ILeaveTypeDtoValidator()
    {
         RuleFor(p => p.Name)
        .NotEmpty().WithMessage("{PropertyName} is required.")
        .NotNull()
        .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

        RuleFor(p => p.DefaultDays)
        .NotEmpty().WithMessage("{PropertyName} is required.")
        .GreaterThan(0).WithMessage("{PropertyName} must be at least 1.")
        .LessThan(100).WithMessage("{PropertyName} mus be less than 100.");
    }
}