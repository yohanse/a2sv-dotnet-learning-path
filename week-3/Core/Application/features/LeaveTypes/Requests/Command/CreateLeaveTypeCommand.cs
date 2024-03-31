using Application;
using Core;
using MediatR;


public class CreateLeaveTypeCommand : IRequest<int> {
    public LeaveTypeDto leaveTypeDto {get; set;}
}