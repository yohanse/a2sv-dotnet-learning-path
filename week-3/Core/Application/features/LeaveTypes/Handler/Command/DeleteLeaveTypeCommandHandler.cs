using AutoMapper;
using Core;
using MediatR;

namespace Application;


public class DeleteLeaveTypeCommandHandler : IRequestHandler<DeleteLeaveTypeCommand, Unit>
{
    private readonly ILeaveTypeRepository _LeaveTypeRepository;
    private readonly IMapper _Mapper;
    public DeleteLeaveTypeCommandHandler(ILeaveTypeRepository ILeaveTypeRepository, IMapper IMapper)
    {
      _LeaveTypeRepository = ILeaveTypeRepository; 
      _Mapper = IMapper;
    }

    public async Task<Unit> Handle(DeleteLeaveTypeCommand request, CancellationToken cancellationToken)
    {
        var leaveType = await _LeaveTypeRepository.Get(request.Id);
        if(leaveType == null) {
          throw new NotFoundException(nameof(LeaveType), request.Id);
        }
        await _LeaveTypeRepository.Delete(leaveType);
        return Unit.Value;
    }
}