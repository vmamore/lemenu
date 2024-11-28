using LeMenu.Shared.Abstractions.Commands;

namespace LeMenu.Modules.Management.Core.Commands;

internal record CreateProduct(string Name, string Description, decimal Price) : ICommand;