namespace Clean.Application.Repositories.Interfaces;

public interface IBaseUnitOfWork
{
    void Save();

    Task SaveAsync();

    Task BeginTransactionAsync();
    Task CommitTransactionAsync();
    Task RollbackTransactionAsync();
}
