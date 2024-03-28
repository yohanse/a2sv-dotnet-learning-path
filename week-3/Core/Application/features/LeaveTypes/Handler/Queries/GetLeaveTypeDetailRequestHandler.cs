using AutoMapper;
using Core;
using MediatR;

namespace Application;

public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
{
    private readonly ILeaveTypeRepository _LeaveTypeRepository;
    private readonly IMapper _Mapper;
    public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository ILeaveTypeRepository, IMapper IMapper)
    {
      _LeaveTypeRepository = ILeaveTypeRepository; 
      _Mapper = IMapper;
    }
    public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
    {
        var leaveType = await _LeaveTypeRepository.Get(id: request.Id);
        return _Mapper.Map<LeaveTypeDto>(leaveType);
    }
}