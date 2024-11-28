using LeMenu.Shared.Abstractions.Kernel.ValueObjects;

namespace LeMenu.Modules.Management.Core.Products.Domain.Entities;

internal class Extra
{
    public string Name { get; set; }  
    public Price Price { get; set; }
    public bool Available { get; set; }
    public bool Disabled { get; set; }
    
    public Extra(string name, Price price)
    {
        Name = name;
        Price = price;
        Available = true;
        Disabled = false;
    }
}