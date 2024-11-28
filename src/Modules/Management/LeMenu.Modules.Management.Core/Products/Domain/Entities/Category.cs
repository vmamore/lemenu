namespace LeMenu.Modules.Management.Core.Products.Domain.Entities;

internal class Category
{
    public Guid Id { get; private set; }
    public string Name { get; set; }
    public bool Disabled { get; set; }

    public Category(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
        Disabled = false;
    }
}