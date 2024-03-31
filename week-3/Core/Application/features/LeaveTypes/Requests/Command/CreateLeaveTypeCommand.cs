using Application;
using Core;
using MediatR;


public class CreateLeaveTypeCommand : IRequest<int> {
    public CreateLeaveTypeDto leaveTypeDto {get; set;}
}