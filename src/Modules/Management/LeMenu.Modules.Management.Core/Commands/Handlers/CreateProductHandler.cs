using LeMenu.Modules.Management.Core.Products.Domain.Entities;
using LeMenu.Modules.Management.Core.Products.Domain.Repositories;
using LeMenu.Shared.Abstractions.Commands;
using LeMenu.Shared.Abstractions.Kernel.ValueObjects;
using Microsoft.Extensions.Logging;

namespace LeMenu.Modules.Management.Core.Commands.Handlers;

internal sealed class CreateProductHandler(IProductRepository repository, ILogger<CreateProductHandler> logger) : ICommandHandler<CreateProduct>
{
    public async Task HandleAsync(CreateProduct command, CancellationToken cancellationToken = default)
    {
        var productAlreadyExist = await repository.ExistsAsync(command.Name, cancellationToken);

        if (productAlreadyExist)
            throw new ArgumentException($"Product with name: {command.Name} already exists.");

        var product = new Product(
            Guid.NewGuid(),
            command.Name,
            command.Description,
            string.Empty,
            new Price(command.Price));

        await repository.AddAsync(product);
        
        logger.LogInformation($"Created a product with ID: '{product.Id}'.");
    }
}