namespace Portfolio.Domain.Posts.ValueObjects;

public sealed class CategoryId : Common.Models.ValueObjects
{
    public Guid Value { get; }
    public CategoryId(Guid value)
    {
        Value = value;
    }

    public static CategoryId CreateUnique()
    {
        return new(Guid.NewGuid());
    }

    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}