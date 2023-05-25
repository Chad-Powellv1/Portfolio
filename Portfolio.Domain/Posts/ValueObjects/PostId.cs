using Portfolio.Domain.Common.Models;

public sealed class PostId : ValueObjects
{
    public Guid Value { get; }
    public PostId(Guid value)
    {
        Value = value;
    }

    public static PostId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}