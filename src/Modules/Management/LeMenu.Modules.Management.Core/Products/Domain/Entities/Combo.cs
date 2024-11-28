using LeMenu.Shared.Abstractions.Kernel.ValueObjects;

namespace LeMenu.Modules.Management.Core.Products.Domain.Entities;

internal class Combo : Product
{
    public IEnumerable<ComboCategory> Categories { get; set; }
    
    public Combo(Guid categoryId, string name, string description, string photo, Price price) : base(categoryId, name, description, photo, price)
    {
    }
}

internal class ComboCategory 
{
    public ComboCategory(HashSet<Product> products, bool mandatory)
    {
        Products = products;
        Mandatory = mandatory;
    }

    public IEnumerable<Product> Products { get; set; }
    public bool Mandatory { get; set; }
}