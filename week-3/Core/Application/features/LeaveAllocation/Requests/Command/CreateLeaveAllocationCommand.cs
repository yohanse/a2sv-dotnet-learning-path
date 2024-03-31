using Core;
using MediatR;

namespace Application;


public class CreateLeaveAllocationCommand : IRequest<int> {
    public LeaveAllocationDto leaveAllocationDto{get; set;}
}