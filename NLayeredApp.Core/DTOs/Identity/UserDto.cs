namespace NLayeredApp.Core.DTOs.Identity;

public class UserDto
{
    public int Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string FullName => $"{FirstName} {LastName}".Trim();
    public bool IsActive { get; set; }
    public bool EmailConfirmed { get; set; }
    public DateTimeOffset CreatedAt { get; set; }
    public List<string> Roles { get; set; } = new();
}