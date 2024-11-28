using LeMenu.Modules.Management.Core.Commands;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeMenu.Modules.Management.Api.Endpoints;

public static class ProductsEndpoint
{
    public static void RegisterProductEndpoints(this WebApplication app)
    {
        app.MapPost("/api/products", Create);
        app.MapGet("/api/products", GetAll);
    }

    private static IResult Create([FromBody] CreateProduct command)
    {
        return TypedResults.Ok();
    }

    private static IResult GetAll()
    {
        return TypedResults.Ok();
    }
}