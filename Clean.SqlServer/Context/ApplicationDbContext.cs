using Clean.Domain.Entities.RecordArea;
using Microsoft.EntityFrameworkCore;

namespace Clean.SqlServer.Context;

public class SQLServerDbContext : DbContext
{
    public SQLServerDbContext()
    {
    }
     public SQLServerDbContext(DbContextOptions<SQLServerDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }

    public DbSet<Record> Records { get; set; }
}
