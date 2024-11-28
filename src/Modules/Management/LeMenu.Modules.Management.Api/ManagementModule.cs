using LeMenu.Modules.Management.Core;
using LeMenu.Shared.Abstractions.Modules;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LeMenu.Modules.Management.Api;

internal class ManagementModule : IModule
{
    public string Name { get; } = "Management";
    
    public void Register(IServiceCollection services) => services.AddCore();

    public void Use(WebApplication app) {}
}