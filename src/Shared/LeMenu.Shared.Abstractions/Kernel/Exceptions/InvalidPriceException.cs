using LeMenu.Shared.Abstractions.Exceptions;

namespace LeMenu.Shared.Abstractions.Kernel.Exceptions;

public class InvalidPriceException : LeMenuException
{
    public decimal Price { get; }
    
    public InvalidPriceException(decimal price) : base($"Price: '{price}' is invalid.")
    {
        Price = price;
    }
}