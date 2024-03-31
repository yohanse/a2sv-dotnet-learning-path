using Core;
using MediatR;

namespace Application;

public class UpdateLeaveTypeCommand : IRequest<Unit> {
    public LeaveTypeDto leaveTypeDto {get; set;}
}