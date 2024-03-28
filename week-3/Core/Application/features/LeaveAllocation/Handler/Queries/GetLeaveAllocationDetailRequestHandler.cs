using AutoMapper;
using Core;
using MediatR;

namespace Application;

public class GetLeaveAllocationDetailRequestHandler : IRequestHandler<GetLeaveAllocationDetailRequest, LeaveAllocationDto>
{
    private readonly ILeaveAllocationRepository _LeaveAllocationRepository;
    private readonly IMapper _Mapper;
    public GetLeaveAllocationDetailRequestHandler(ILeaveAllocationRepository ILeaveAllocationRepository, IMapper IMapper)
    {
      _LeaveAllocationRepository = ILeaveAllocationRepository; 
      _Mapper = IMapper;
    }
    public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
    {
        var leaveType = await _LeaveAllocationRepository.Get(id: request.Id);
        return _Mapper.Map<LeaveAllocationDto>(leaveType);
    }
}