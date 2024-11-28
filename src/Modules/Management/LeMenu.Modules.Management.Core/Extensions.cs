using System.Runtime.CompilerServices;
using LeMenu.Modules.Management.Core.Products.DAL;
using LeMenu.Modules.Management.Core.Products.DAL.Repositories;
using LeMenu.Modules.Management.Core.Products.Domain.Repositories;
using LeMenu.Shared.Infrastructure.Postgres;
using Microsoft.Extensions.DependencyInjection;

[assembly: InternalsVisibleTo("LeMenu.Modules.Management.Api")]
namespace LeMenu.Modules.Management.Core;

internal static class Extensions
{
    public static IServiceCollection AddCore(this IServiceCollection services)
    {
        return services
            .AddScoped<IProductRepository, ProductRepository>()
            .AddPostgres<ManagementDbContext>();
    }
}