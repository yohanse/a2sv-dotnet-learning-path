using AutoMapper;
using Core;
using MediatR;

namespace Application;


public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
{
    private readonly ILeaveTypeRepository _LeaveTypeRepository;
    private readonly IMapper _Mapper;
    public GetLeaveTypeListRequestHandler(ILeaveTypeRepository ILeaveTypeRepository, IMapper IMapper)
    {
      _LeaveTypeRepository = ILeaveTypeRepository; 
      _Mapper = IMapper;
    }
    public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
    {
        var leaveTypes = await _LeaveTypeRepository.GetAll();
        return _Mapper.Map<List<LeaveTypeDto>>(leaveTypes);
    }
}