using AutoMapper;
using Core;
using MediatR;

namespace Application;

public class CreateLeaveTypeCommandHandler : IRequestHandler<CreateLeaveTypeCommand, BaseCommandReponse>
{
     private readonly ILeaveTypeRepository _LeaveTypeRepository;
    private readonly IMapper _Mapper;
    public CreateLeaveTypeCommandHandler(ILeaveTypeRepository ILeaveTypeRepository, IMapper IMapper)
    {
      _LeaveTypeRepository = ILeaveTypeRepository; 
      _Mapper = IMapper;
    }

    public async Task<BaseCommandReponse> Handle(CreateLeaveTypeCommand request, CancellationToken cancellationToken)
    {  
        var response = new BaseCommandReponse();
        var validator = new CreateLeaveTypeDtoValidator(); 
        var validationResult = await validator.ValidateAsync(request.leaveTypeDto);
        
        
        if (!validationResult.IsValid){
          response.Success = false;
          response.Message = "Creation Failed";
          response.Errors = validationResult.Errors.Select(error => error.ErrorMessage).ToList();  
        }
        else {
          var leaveType = _Mapper.Map<LeaveType>(request.leaveTypeDto);
          var result = await _LeaveTypeRepository.Add(leaveType);
          response.Success = true;
          response.Message = "Creation Failed";
          response.Errors = validationResult.Errors.Select(error => error.ErrorMessage).ToList(); 
          response.Id = result.Id;
        }
        
        return response;
    }
}