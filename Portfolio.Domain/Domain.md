# Domain Layer
<hr>

## Blog Posts

```csharp
class Post
{
    Post Create();
    void AddPost(Post post);
    void UpdatePost(Post post);
    void DeletePost(Post post);
}
```

```json
{
  "id": "Guid Id",
  "title": "Blog Post Title",
  "excerpt": "Blog Post Excerpt",
  "content": "Blog Post Content",
  "created_at": "DateTime Created",
  "is_featured": "Boolean IsFeatured",
  "UserId": "Guid UserId",
  "Categories": [
    {
      "id": "Guid Id",
      "name": "Category Name"
    }
  ],
    "Tags": [
        {
        "id": "Guid Id",
        "name": "Tag Name"
        }
    ]
}
```

