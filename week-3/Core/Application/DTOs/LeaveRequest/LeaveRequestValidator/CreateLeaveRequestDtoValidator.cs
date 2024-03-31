using FluentValidation;

namespace Application;

public class CreateLeaveRequestDtoValidator : AbstractValidator<CreateLeaveRequestDto> {
    private readonly ILeaveRequestRepository _leaveRequestRepository;
    public CreateLeaveRequestDtoValidator(ILeaveRequestRepository leaveRequestRepository)
    {
        _leaveRequestRepository = leaveRequestRepository;
        RuleFor(p => p.StartDate)
        .LessThan(p => p.EndDate).WithMessage("{PropertyName} must be before {ComparsionValue}");

        RuleFor(p => p.EndDate)
        .GreaterThan(p => p.StartDate).WithMessage("{PropertyName} must be after {ComparsionValue}");

        RuleFor(p => p.LeaveTypeId)
        .GreaterThan(0).WithMessage("{PropertyName} must be at least 1")
        .MustAsync(async (id, token) => {
            var leaveTypeExists = await _leaveRequestRepository.Exists(id);
            return !leaveTypeExists;
        }).WithMessage("{PropertyName} must be at least 1");
        
    }
}