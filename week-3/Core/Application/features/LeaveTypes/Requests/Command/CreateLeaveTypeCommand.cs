using Application;
using Core;
using MediatR;


public class CreateLeaveTypeCommand : IRequest<BaseCommandReponse> {
    public CreateLeaveTypeDto leaveTypeDto {get; set;}
}