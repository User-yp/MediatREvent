using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace MediatREvent;

public static class MediatRExtension
{
    public static IServiceCollection AddMediatR(this IServiceCollection service)
    {
        service.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetEntryAssembly()));
        service.AddSingleton<IDomainEvents, DomainEvents>();
        //service.AddScoped<IDomainEvents, DomainEvents>();
        return service;
    }
}