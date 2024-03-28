using Core;
using MediatR;

namespace Application;

public class GetLeaveAllocationDetailRequest: IRequest<LeaveAllocationDto> {
    public int Id {get; set;}
}