using System.Reflection;
using DiligenciaProveedores.Domain.Interfaces;
using DiligenciaProveedores.Persistence.Contexts;
using DiligenciaProveedores.Persistence.Repositories;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DiligenciaProveedores.Presentation.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<IProviderRepository, ProviderRepository>();

        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssembly(typeof(ServiceCollectionExtensions).Assembly));

        services.AddAutoMapper(cfg => {
            cfg.AddMaps(typeof(ServiceCollectionExtensions).Assembly);
        });

        services.AddControllers();
        services.AddEndpointsApiExplorer();

        return services;
    }
}
