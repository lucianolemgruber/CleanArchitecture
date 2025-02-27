namespace Clean.Application.Repositories.Interfaces;

/// <summary>
/// This interface defines the write operations on the database for a generic object.
/// </summary>
/// <typeparam name="TEntity"></typeparam>
public interface IGenericWriteRepository<TEntity> : IDisposable
     where TEntity : class
{
    Task<TEntity> InsertAsync(TEntity entity);

    TEntity Insert(TEntity entity);

    void Update(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteByIntAsync(int id);
}
