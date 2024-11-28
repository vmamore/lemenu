using System.Globalization;
using LeMenu.Shared.Abstractions.Kernel.Exceptions;

namespace LeMenu.Shared.Abstractions.Kernel.ValueObjects;

public class Price : IEquatable<Price>
{
    public decimal Value { get; }

    public Price(decimal value)
    {
        if (value is < 0 or > 1_000_000)
        {
            throw new InvalidPriceException(value);
        }

        Value = value;
    }

    public static implicit operator Price(decimal value) => new(value);
    public static implicit operator decimal(Price price) => price.Value;

    public static bool operator ==(Price a, Price b)
    {
        if (ReferenceEquals(a, b)) return true;

        if (a is not null && b is not null) return a.Value.Equals(b.Value);
        
        return false;
    }

    public static bool operator !=(Price a, Price b) => !(a == b);
    
    public static bool operator >(Price a, Price b) => a.Value > b.Value;

    public static bool operator <(Price a, Price b) => a.Value < b.Value;

    public static bool operator >=(Price a, Price b) => a.Value >= b.Value;

    public static bool operator <=(Price a, Price b) => a.Value <= b.Value;
        
    public static Price operator +(Price a, Price b) => a.Value + b.Value;
        
    public static Price operator -(Price a, Price b) => a.Value - b.Value;
    public bool Equals(Price? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return Value == other.Value;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        return obj.GetType() == GetType() && Equals((Price)obj);
    }

    public override int GetHashCode() => Value.GetHashCode();
    
    public override string ToString() => Value.ToString(CultureInfo.InvariantCulture);
}