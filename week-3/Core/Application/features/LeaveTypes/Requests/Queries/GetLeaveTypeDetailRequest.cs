using Core;
using MediatR;

namespace Application;

public class GetLeaveTypeDetailRequest: IRequest<LeaveTypeDto> {
    public int Id {get; set;}
}