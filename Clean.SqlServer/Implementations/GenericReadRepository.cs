using Clean.Application.Repositories.Interfaces;
using Clean.SqlServer.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Clean.SqlServer.Implementations;

public class GenericReadRepository<TEntity>(SQLServerDbContext context) : IGenericReadRepository<TEntity>
    where TEntity : class
{
    protected readonly SQLServerDbContext _dbContext = context;

    public List<TEntity> GetAll()
    {
        return _dbContext.Set<TEntity>()
            .AsNoTracking()
            .ToList();
    }


    public TEntity GetById(int id)
    {
        return _dbContext.Set<TEntity>().Find(id);
    }


    public async Task<TEntity?> GetByIdAsync(int id)
    {
        return await _dbContext.Set<TEntity>()
            .FindAsync();
    }


    public int Count(Expression<Func<TEntity, bool>> predicate)
    {
        return _dbContext.Set<TEntity>()
            .AsNoTracking()
            .Count(predicate);
    }

    public IQueryable<TEntity> Get(Expression<Func<TEntity, bool>>? predicate = null, bool trackChanges = false)
    {
        IQueryable<TEntity> query = _dbContext.Set<TEntity>();

        if (predicate != null)
        {
            query = query.Where(predicate);
        }

        return trackChanges ? query : query.AsNoTracking();
    }

    public Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate)
    {
        return _dbContext.Set<TEntity>()
            .AsNoTracking()
            .Where(predicate).ToListAsync();
    }

    public void Dispose()
    {
        _dbContext.Dispose();
    }

    public Task<TEntity> GetByIdAssync(int id)
    {
        throw new NotImplementedException();
    }
}
