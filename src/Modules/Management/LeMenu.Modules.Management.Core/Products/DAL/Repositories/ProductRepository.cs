using LeMenu.Modules.Management.Core.Products.Domain.Entities;
using LeMenu.Modules.Management.Core.Products.Domain.Repositories;

namespace LeMenu.Modules.Management.Core.Products.DAL.Repositories;

internal class ProductRepository : IProductRepository
{
    public Task<bool> ExistsAsync(string name, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Product product)
    {
        throw new NotImplementedException();
    }
}