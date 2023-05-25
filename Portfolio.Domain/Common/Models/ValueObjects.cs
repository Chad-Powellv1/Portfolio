namespace Portfolio.Domain.Common.Models;

/// <summary name="ValueObjects">
/// This is the base class for all value objects in the domain,
/// and they are considered equal if all their properties are equal.
/// </summary>
public abstract class ValueObjects : IEquatable<ValueObjects>
{
    public abstract IEnumerable<object> GetEqualityComponents();

    public override bool Equals(object? obj)
    {
        if (obj == null || obj.GetType() != GetType())
            return false;
            
        var other = (ValueObjects) obj;
        return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }

    public override int GetHashCode()
    {
        return GetEqualityComponents()
            .Select(x => x != null ? x.GetHashCode() : 0)
            .Aggregate((x, y) => x ^ y);
    }

    public static bool operator ==(ValueObjects left, ValueObjects right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(ValueObjects left, ValueObjects right)
    {
        return !Equals(left, right);
    }


    public bool Equals(ValueObjects? other)
    {
        return Equals((object?) other);
    }
}