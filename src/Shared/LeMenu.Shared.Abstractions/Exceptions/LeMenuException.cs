namespace LeMenu.Shared.Abstractions.Exceptions;

public abstract class LeMenuException : Exception
{
    protected LeMenuException(string message) : base(message) {}
}