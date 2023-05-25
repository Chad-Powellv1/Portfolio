using Portfolio.Domain.Common.Models;

namespace Portfolio.Domain.Posts.Entities;

public sealed class Tag : Entity<TagId>
{
    public string Name { get; }

    private Tag(TagId tagId, string name) : base(tagId)
    {
        Name = name;
    }

    public static Tag Create(TagId tagId, string name)
    {
        return new(TagId.CreateUnique(), name);
    }
}