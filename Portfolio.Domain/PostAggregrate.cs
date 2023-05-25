using System.Runtime.CompilerServices;
using Portfolio.Domain.Common.Models;
using Portfolio.Domain.Posts.Entities;

namespace Portfolio.Domain;

public class PostAggregrate : AggregateRoot<PostId>{
    public PostAggregrate(PostId id) : base(id)
    {
    }

    private List<Category> _categories = new();
    private List<Tag> _tags = new();

    public string Title { get; }
    public string Excerpt { get; }
    public string Content { get; }
    public DateTime CreatedAt { get; }
    public bool IsPublished { get; }
    public bool IsFeatured { get; }
    public UserId AuthorId { get; }


    public IReadOnlyList<Category> Categories => _categories;

    public IReadOnlyList<Tag> Tags => _tags;

    private PostAggregrate(
        PostId postId,
        string title,
        string excerpt,
        string content,
        DateTime createdAt,
        bool isPublished,
        bool isFeatured,
        UserId authorId,
        List<Category> categories,
        List<Tag> tags) : base(postId)
    {
        Title = title;
        Excerpt = excerpt;
        Content = content;
        CreatedAt = createdAt;
        IsPublished = isPublished;
        IsFeatured = isFeatured;
        AuthorId = authorId;
        _categories = categories;
        _tags = tags;
    }

    public static PostAggregrate Create(
        PostId postId,
        string title,
        string excerpt,
        string content,
        DateTime createdAt,
        bool isPublished,
        bool isFeatured,
        UserId authorId,
        List<Category> categories,
        List<Tag> tags)
    {
        return new(
            PostId.CreateUnique(),
            title,
            excerpt,
            content,
            createdAt,
            isPublished,
            isFeatured,
            authorId,
            categories,
            tags);
    }
}