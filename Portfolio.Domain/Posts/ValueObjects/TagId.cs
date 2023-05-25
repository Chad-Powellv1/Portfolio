namespace Portfolio.Domain.Common.Models;

public sealed class TagId : ValueObjects
{
    public Guid Value { get; }
    public TagId(Guid value)
    {
        Value = value;
    }

    public static TagId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}