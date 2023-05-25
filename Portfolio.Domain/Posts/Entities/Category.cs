using Portfolio.Domain.Common.Models;
using Portfolio.Domain.Posts.ValueObjects;

namespace Portfolio.Domain.Posts.Entities;

public sealed class Category : Entity<CategoryId> 
{
    public string Name { get;  }

    private Category(CategoryId categoryId, string name) : base(categoryId)
    {
        Name = name;
    }

    public static Category Create(CategoryId categoryId, string name)
    {
        return new(CategoryId.CreateUnique(), name);
    }
}