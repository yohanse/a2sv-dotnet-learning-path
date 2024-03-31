using FluentValidation;

namespace Application;
public class CreateLeaveTypeDtoValidator : AbstractValidator<CreateLeaveTypeDto> {

    public CreateLeaveTypeDtoValidator()
    {
        Include(new ILeaveTypeDtoValidator());
    }
}