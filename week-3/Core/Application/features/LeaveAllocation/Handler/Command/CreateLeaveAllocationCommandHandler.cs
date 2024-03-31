using AutoMapper;
using Core;
using MediatR;

namespace Application;

public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, int>
{
    private readonly ILeaveAllocationRepository _LeaveAllocationRepository;
    private readonly IMapper _Mapper;
    public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository ILeaveAllocationRepository, IMapper IMapper)
    {
      _LeaveAllocationRepository = ILeaveAllocationRepository; 
      _Mapper = IMapper;
    }
    public async Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
    {
        var leaveAllocation = _Mapper.Map<LeaveAllocation>(request.leaveAllocationDto);
        var result = await _LeaveAllocationRepository.Add(leaveAllocation);
        return result.Id;
    }
}
