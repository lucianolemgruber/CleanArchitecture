using AutoMapper;
using Clean.Application.DTOs.RecordArea;
using Clean.Application.Repositories.Interfaces;
using Clean.Application.Services.Interfaces;
using MediatR;

namespace Clean.Application.UseCases.Queries.RecordArea.GetAllRecords;

public class GetAllRecordsHandler(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ISemaphoreService semaphoreService) : IRequestHandler<GetAllRecordsRequest, List<RecordDto>?>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;
    private readonly ISemaphoreService _semaphoreService = semaphoreService;

    public async Task<List<RecordDto>?> Handle(GetAllRecordsRequest request, CancellationToken cancellationToken)
    {
        await _semaphoreService.AcquireSemaphoreAsync();
        try
        {
            var records = _unitOfWork.RecordReadRepository.GetAll();
            return _mapper.Map<List<RecordDto>>(records);
        }
        finally
        {
            _semaphoreService.ReleaseSemaphore();
        }
    }
}
