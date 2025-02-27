using Clean.Application.Repositories.Interfaces;
using Clean.Domain.Entities.RecordArea;
using Clean.SqlServer.Context;

namespace Clean.SqlServer.Implementations;

public class UnitOfWork(SQLServerDbContext dbContext,
    IGenericReadRepository<Record> recordReadRepository,
    IGenericWriteRepository<Record> recordWriteRepository
//IcustomRepository customRepository
    ) : BaseUnitOfWork(dbContext), IUnitOfWork
{
    public IGenericReadRepository<Record> RecordReadRepository { get; } = recordReadRepository;

    public IGenericWriteRepository<Record> RecordWriteRepository { get; } = recordWriteRepository;

    //public ICustomRepository CustomRepository { get; } = customRepository;
}
