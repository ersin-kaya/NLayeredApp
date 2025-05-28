namespace NLayeredApp.Core.DTOs.Category;

public record CreateCategoryDto
{
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }

    public CreateCategoryDto() { }

    public CreateCategoryDto(string name, string? description)
    {
        Name = name;
        Description = description;
    }
}