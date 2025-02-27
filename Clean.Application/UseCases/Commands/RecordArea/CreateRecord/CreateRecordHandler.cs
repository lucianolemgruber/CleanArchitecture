using AutoMapper;
using Clean.Application.Repositories.Interfaces;
using Clean.Application.Services.Interfaces;
using Clean.Domain.Entities.RecordArea;
using MediatR;

namespace Clean.Application.UseCases.Commands.RecordArea.CreateRecord;

public class CreateRecordHandler(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ISemaphoreService semaphoreService) : IRequestHandler<CreateRecordCommand, bool>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;
    private readonly ISemaphoreService _semaphoreService = semaphoreService;
    public async Task<bool> Handle(CreateRecordCommand request, CancellationToken cancellationToken)
    {
        await _semaphoreService.AcquireSemaphoreAsync();
        try
        {
            var record = _mapper.Map<Record>(request.CreateRecordRequestDto);
            await _unitOfWork.RecordWriteRepository.InsertAsync(record);
            await _unitOfWork.SaveAsync();

            return true;
        }
        finally
        {
            _semaphoreService.ReleaseSemaphore();
        }
    }
}
