namespace NLayeredApp.Core.DTOs.Category.Responses;

public record CategoryDto
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public bool IsActive { get; init; }
    public DateTimeOffset CreatedAt { get; init; }
    public DateTimeOffset? LastModifiedAt { get; init; }

    public CategoryDto() { }

    public CategoryDto(int id, string name, string? description, bool isActive, DateTimeOffset createdAt, DateTimeOffset? lastModifiedAt)
    {
        Id = id;
        Name = name;
        Description = description;
        IsActive = isActive;
        CreatedAt = createdAt;
        LastModifiedAt = lastModifiedAt;
    }
}