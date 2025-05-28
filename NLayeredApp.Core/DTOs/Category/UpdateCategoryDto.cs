namespace NLayeredApp.Core.DTOs.Category;

public record UpdateCategoryDto
{
    public int Id { get; init; }
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }
    public bool IsActive { get; init; }

    public UpdateCategoryDto() { }

    public UpdateCategoryDto(int id, string name, string? description, bool isActive)
    {
        Id = id;
        Name = name;
        Description = description;
        IsActive = isActive;
    }
}