using LeMenu.Modules.Management.Api.Endpoints;
using LeMenu.Shared.Infrastructure;
using LeMenu.Shared.Infrastructure.Modules;

var builder = WebApplication.CreateBuilder(args)
    .ConfigureModules();

var assemblies = ModuleLoader.LoadAssemblies(builder.Configuration, "LeMenu.Modules");
var modules = ModuleLoader.LoadModules(assemblies);

builder.Services.AddModularInfrastructure(assemblies);
foreach (var module in modules) 
    module.Register(builder.Services);

var app = builder.Build();

app.RegisterProductEndpoints();
app.MapGet("/", () => "Hello World!");

app.Run();