namespace Portfolio.Domain.Common.Models;

/// <summary name="Entity">
/// This is the base class for all entities in the domain,
/// and they are considered equal if their Ids are equal.
/// </summary>
public abstract class Entity<TId> where TId : notnull
{
    public TId Id { get; protected set; }

    protected Entity(TId id)
    {
        Id = id;
    }

    public override bool Equals(object? obj)
    {
        return obj is Entity<TId> other && Equals(other);
    }

    public bool Equals(Entity<TId>? other)
    {
        return Equals((object?) other);
    }

    public static bool operator ==(Entity<TId>? left, Entity<TId>? right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Entity<TId>? left, Entity<TId>? right)
    {
        return !Equals(left, right);
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

}