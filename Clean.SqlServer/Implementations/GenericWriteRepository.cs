using Clean.Application.Repositories.Interfaces;
using Clean.SqlServer.Context;
using Microsoft.EntityFrameworkCore;

namespace Clean.SqlServer.Implementations;

/// <summary>
/// This interface defines the write operations on the database for a generic object.
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public class GenericWriteRepository<TEntity> : IGenericWriteRepository<TEntity>
         where TEntity : class
{

    private readonly SQLServerDbContext _dbContext;

    public GenericWriteRepository(SQLServerDbContext context)
    {
        _dbContext = context;
    }

    public TEntity Insert(TEntity entity)
    {
        _dbContext.Set<TEntity>().Add(entity);
        return entity;
    }

    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        await _dbContext.Set<TEntity>().AddAsync(entity);
        return entity;
    }

    public void Update(TEntity entity)
    {
        if (_dbContext.Entry(entity).State == EntityState.Detached)
        {
            _dbContext.Attach(entity);
        }
        _dbContext.Set<TEntity>().Update(entity);
    }

    public async Task UpdateAsync(TEntity entity)
    {
        if (_dbContext.Entry(entity).State == EntityState.Detached)
        {
            _dbContext.Attach(entity);
        }
        _dbContext.Set<TEntity>().Update(entity);
        await Task.CompletedTask;
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }

    public async Task DeleteByIntAsync(int id)
    {
        var entity = await _dbContext.Set<TEntity>().FindAsync(id);
        if (entity != null)
        {
            _dbContext.Remove(entity);
        }
    }
}
