using Clean.Application.Profiles;
using Clean.Application.Shared.Behavior;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Clean.Application.Services;

public static class ServiceExtensions
{
    public static void ConfigureApplicationApp(this IServiceCollection services)
    {

        services.AddAutoMapper(cfg =>
        {
            #region RecordArea
            cfg.AddProfile<RecordProfile>();
            #endregion


        });

        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
    }
}