namespace NLayeredApp.Core.DTOs.Category;

public record UpdateCategoryRequest
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public bool IsActive { get; init; }

    public UpdateCategoryRequest() { }

    public UpdateCategoryRequest(int id, string name, string? description, bool isActive)
    {
        Id = id;
        Name = name;
        Description = description;
        IsActive = isActive;
    }
}