using AutoMapper;
using Core;
using MediatR;

namespace Application;

public class UpdateLeaveTypeCommandHandler : IRequestHandler<UpdateLeaveTypeCommand, Unit>
{
    private readonly ILeaveTypeRepository _LeaveTypeRepository;
    private readonly IMapper _Mapper;
    public UpdateLeaveTypeCommandHandler(ILeaveTypeRepository ILeaveTypeRepository, IMapper IMapper)
    {
      _LeaveTypeRepository = ILeaveTypeRepository; 
      _Mapper = IMapper;
    }
    public async Task<Unit> Handle(UpdateLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        var leaveType = await _LeaveTypeRepository.Get(request.leaveTypeDto.Id);
        // updating leavType by leaveTypeDto
        _Mapper.Map(request.leaveTypeDto, leaveType);
        await _LeaveTypeRepository.Update(leaveType);
        return Unit.Value;
    }
}