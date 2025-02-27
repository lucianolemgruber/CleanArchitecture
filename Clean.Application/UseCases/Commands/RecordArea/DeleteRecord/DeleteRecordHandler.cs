using AutoMapper;
using Clean.Application.Repositories.Interfaces;
using Clean.Application.Services.Interfaces;
using MediatR;

namespace Clean.Application.UseCases.Commands.RecordArea.DeleteRecord;

public class DeleteRecordHandler(
    IUnitOfWork unitOfWork,
    ISemaphoreService semaphoreService) : IRequestHandler<DeleteRecordCommand, bool>
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly ISemaphoreService _semaphoreService = semaphoreService;
    public async Task<bool> Handle(DeleteRecordCommand request, CancellationToken cancellationToken)
    {
        await _semaphoreService.AcquireSemaphoreAsync();
        try
        {
            await _unitOfWork.RecordWriteRepository.DeleteByIntAsync(request.Id);
            await _unitOfWork.SaveAsync();
            return true;
        }
        catch
        {
            return false;
        }
        finally
        {
            _semaphoreService.ReleaseSemaphore();
        }
    }
}
