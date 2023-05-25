namespace Portfolio.Domain.Common.Models;

/// <summary name="AggregateRoot">
/// This is the base class for all aggregate roots in the domain,
/// </summary>
public abstract class AggregateRoot<TId> : Entity<TId> where TId : notnull
{
    protected AggregateRoot(TId id) : base(id)
    {
    }
}