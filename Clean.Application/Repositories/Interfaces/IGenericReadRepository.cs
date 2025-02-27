using System.Linq.Expressions;

namespace Clean.Application.Repositories.Interfaces;

public interface IGenericReadRepository<TEntity> : IDisposable
         where TEntity : class
{
    Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> predicate);

    List<TEntity> GetAll();

    TEntity GetById(int id);

    Task<TEntity> GetByIdAssync(int id);

    int Count(Expression<Func<TEntity, bool>> predicate);

    //Task<int> CountAssync(int id);

    IQueryable<TEntity> Get(Expression<Func<TEntity, bool>>? predicate = null, bool trackChanges = false);
}
