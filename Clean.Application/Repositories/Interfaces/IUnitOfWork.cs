using Clean.Domain.Entities.RecordArea;

namespace Clean.Application.Repositories.Interfaces;

public interface IUnitOfWork : IBaseUnitOfWork
{
    IGenericReadRepository<Record> RecordReadRepository { get; }
   
    IGenericWriteRepository<Record> RecordWriteRepository { get; }

    //ICustomRepository CustomRepository { get; }

}
