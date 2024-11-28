using LeMenu.Modules.Management.Core.Products.Domain.Entities;

namespace LeMenu.Modules.Management.Core.Products.Domain.Repositories;

internal interface IProductRepository
{
    Task<bool> ExistsAsync(string name, CancellationToken cancellationToken = default);
    Task AddAsync(Product product);
}