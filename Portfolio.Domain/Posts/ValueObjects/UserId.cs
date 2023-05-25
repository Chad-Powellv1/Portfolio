namespace Portfolio.Domain.Common.Models;

public sealed class UserId : ValueObjects
{
    public Guid Value { get; }

    public UserId(Guid value)
    {
        Value = value;
    }

    public static UserId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}