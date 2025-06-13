namespace NLayeredApp.Core.DTOs.Identity.Requests;

public class UpdateRoleRequest
{
    public string? Description { get; set; }
    public bool IsActive { get; set; }
}