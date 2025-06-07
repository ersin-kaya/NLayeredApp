namespace NLayeredApp.Core.DTOs.Category.Requests;

public record CreateCategoryRequest
{
    public string Name { get; init; } = string.Empty;
    public string? Description { get; init; }

    public CreateCategoryRequest() { }

    public CreateCategoryRequest(string name, string? description)
    {
        Name = name;
        Description = description;
    }
}