using LeMenu.Shared.Abstractions.Commands;
using LeMenu.Shared.Abstractions.Dispatchers;

namespace LeMenu.Shared.Infrastructure.Dispatchers;

internal sealed class InMemoryDispatcher(ICommandDispatcher commandDispatcher) : IDispatcher
{
    public Task SendAsync<T>(T command, CancellationToken cancellationToken = default) where T : class, ICommand
        => commandDispatcher.SendAsync(command, cancellationToken);
}