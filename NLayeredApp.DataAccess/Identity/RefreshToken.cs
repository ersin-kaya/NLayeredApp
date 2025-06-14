namespace NLayeredApp.DataAccess.Identity;

public class RefreshToken : Core.Entities.Identity.RefreshToken
{
    public virtual ApplicationUser User { get; set; } = null!;
}