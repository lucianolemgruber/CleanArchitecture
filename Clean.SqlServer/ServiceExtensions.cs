using Clean.Application.Repositories.Interfaces;
using Clean.Application.Services.Implementations;
using Clean.Application.Services.Interfaces;
using Clean.Domain.Entities.RecordArea;
using Clean.SqlServer.Context;
using Clean.SqlServer.Implementations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Clean.SqlServer;

public static class ServiceExtensions
{
    public static void ConfigurePersistenceSQLServer(this IServiceCollection services,
                                                IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DataConnection' not found.");

        services.AddDbContextPool<SQLServerDbContext>(options => options.UseSqlServer(connectionString));

        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<ISemaphoreService, SemaphoreService>();
        services.AddScoped<IGenericReadRepository<Record>, GenericReadRepository<Record>>();
        services.AddScoped<IGenericWriteRepository<Record>, GenericWriteRepository<Record>>();

        //services.AddScoped<ICustomRepository, CustomRepository>();
    }
}
