using AutoMapper;
using Core;
using MediatR;

namespace Application;

public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, int>
{
     private readonly ILeaveTypeRepository _LeaveTypeRepository;
    private readonly IMapper _Mapper;
    public CreateLeaveTypeCommandHandler(ILeaveTypeRepository ILeaveTypeRepository, IMapper IMapper)
    {
      _LeaveTypeRepository = ILeaveTypeRepository; 
      _Mapper = IMapper;
    }

    public async Task<int> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
    {   
        var leaveType = _Mapper.Map<LeaveType>(request.leaveTypeDto);
        var result = await _LeaveTypeRepository.Add(leaveType);
        return result.Id;
    }
}