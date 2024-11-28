using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace LeMenu.Shared.Infrastructure.Modules;

public static class Extensions
{
    public static WebApplicationBuilder ConfigureModules(this WebApplicationBuilder builder)
    {
        builder.Host.ConfigureAppConfiguration((ctx, cfg) =>
        {
            foreach (var settings in GetSettings("*")) 
                cfg.AddJsonFile(settings);

            foreach (var settings in GetSettings($"*.{ctx.HostingEnvironment.EnvironmentName}")) 
                cfg.AddJsonFile(settings);
            
            IEnumerable<string> GetSettings(string pattern)
                => Directory.EnumerateFiles(ctx.HostingEnvironment.ContentRootPath, 
                    $"module.{pattern}.json", SearchOption.AllDirectories);
        });
        return builder;
    }
}