using NLayeredApp.Core.DTOs.Common;

namespace NLayeredApp.Core.DTOs.Category.Requests;

public class GetCategoriesRequest : PagedRequest
{
    public bool IncludeInactive { get; set; } = false;
    public bool IncludeProductCount { get; set; } = false;
}