using Clean.Application.Services.Interfaces;

namespace Clean.Application.Services.Implementations;

public class SemaphoreService : ISemaphoreService
{
    private static readonly SemaphoreSlim _semaphoreSlim = new(1, 1);

    public async Task AcquireSemaphoreAsync()
    {
        await _semaphoreSlim.WaitAsync();
    }

    public void ReleaseSemaphore()
    {
        _semaphoreSlim.Release();
    }
}
