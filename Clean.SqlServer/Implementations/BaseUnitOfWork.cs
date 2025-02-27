using Clean.Application.Repositories.Interfaces;
using Clean.SqlServer.Context;

namespace Clean.SqlServer.Implementations;

public class BaseUnitOfWork : IBaseUnitOfWork
{
    protected SQLServerDbContext _dbContext;

    protected BaseUnitOfWork(SQLServerDbContext dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }

    public Task BeginTransactionAsync()
    {
        _dbContext.Database.BeginTransaction();
        return Task.CompletedTask;
    }

    public Task CommitTransactionAsync()
    {
        _dbContext.Database.CommitTransaction();
        return Task.CompletedTask;
    }

    public Task RollbackTransactionAsync()
    {
        _dbContext.Database.RollbackTransaction();
        return Task.CompletedTask;
    }

    public void Save()
    {
        _dbContext.SaveChanges();
    }

    public async Task SaveAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
