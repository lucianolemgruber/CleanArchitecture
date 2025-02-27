namespace Clean.Application.Services.Interfaces;

public interface ISemaphoreService
{
    Task AcquireSemaphoreAsync();
    void ReleaseSemaphore();
}
