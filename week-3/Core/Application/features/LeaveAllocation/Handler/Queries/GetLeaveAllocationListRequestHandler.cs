using AutoMapper;
using Core;
using MediatR;

namespace Application;


public class GetLeaveAllocationListRequestHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
{
    private readonly ILeaveAllocationRepository _LeaveAllocationRepository;
    private readonly IMapper _Mapper;
    public GetLeaveAllocationListRequestHandler(ILeaveAllocationRepository ILeaveAllocationRepository, IMapper IMapper)
    {
      _LeaveAllocationRepository = ILeaveAllocationRepository; 
      _Mapper = IMapper;
    }
    public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
    {
        var leaveTypes = await _LeaveAllocationRepository.GetAll();
        return _Mapper.Map<List<LeaveAllocationDto>>(leaveTypes);
    }
}