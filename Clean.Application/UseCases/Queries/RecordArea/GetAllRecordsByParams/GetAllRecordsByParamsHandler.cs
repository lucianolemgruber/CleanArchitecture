using AutoMapper;
using Clean.Application.DTOs.RecordArea;
using Clean.Application.Repositories.Interfaces;
using Clean.Application.Services.Interfaces;
using Clean.Domain.Entities.RecordArea;
using MediatR;

namespace Clean.Application.UseCases.Queries.RecordArea.GetAllRecordsByParams;

public class GetAllRecordsByParamsHandler(
    IUnitOfWork unitOfWork,
    IMapper mapper,
    ISemaphoreService semaphoreService) : IRequestHandler<GetAllRecordsByParamsRequest, List<RecordDto>?>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly IMapper _mapper = mapper;
    private readonly ISemaphoreService _semaphoreService = semaphoreService;
    public async Task<List<RecordDto>?> Handle(GetAllRecordsByParamsRequest request, CancellationToken cancellationToken)
    {
        await _semaphoreService.AcquireSemaphoreAsync();
        try
        {

            int skip = (request.RequestDto.Page - 1) * request.RequestDto.PageSize;

            IQueryable<Record> query = _unitOfWork.RecordReadRepository.Get();

            if (!string.IsNullOrEmpty(request.RequestDto.Name))
            {
                query = query.Where(e => !string.IsNullOrEmpty(e.Name) && e.Name.Contains(request.RequestDto.Name));
            }

            if (!string.IsNullOrEmpty(request.RequestDto.Phone))
            {
                query = query.Where(e => !string.IsNullOrEmpty(e.Phone) && e.Phone.Contains(request.RequestDto.Phone));
            }

            if (!string.IsNullOrEmpty(request.RequestDto.Email))
            {
                query = query.Where(e => !string.IsNullOrEmpty(e.Email) && e.Email.Contains(request.RequestDto.Email));
            }

            query = query.Skip(skip);
            query = query.Take(request.RequestDto.PageSize);

            var records = query.ToList();

            return _mapper.Map<List<RecordDto>>(records);
        }
        finally
        {
            _semaphoreService.ReleaseSemaphore();
        }
    }
}
