using LeMenu.Shared.Abstractions.Kernel.ValueObjects;

namespace LeMenu.Modules.Management.Core.Products.Domain.Entities;

internal class Product
{
    private HashSet<Extra> _extras = new();

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Photo { get; set; }
    public Price Price { get; set; }
    public bool Available { get; set; }
    public bool Disabled { get; set; }

    public Guid CategoryId { get; set; }

    public Category Category { get; set; }
    
    public IEnumerable<Extra> Extras
    {
        get => _extras;
        init => _extras = new HashSet<Extra>(value);
    }
    
    public Product(Guid categoryId, string name, string description, string photo, Price price)
    {
        CategoryId = categoryId;
        Name = name;
        Description = description;
        Photo = photo;
        Price = price;
        Available = true;
        Disabled = false;
    }
}