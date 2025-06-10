using NLayeredApp.Core.Constants;
using NLayeredApp.Core.DTOs.Common;

namespace NLayeredApp.Core.DTOs.Category.Requests;

public class GetCategoriesRequest : PagedRequest
{
    /// <summary>
    /// Include inactive categories in the result set
    /// </summary>
    public bool IncludeInactive { get; set; } = ApplicationConstants.Defaults.IncludeInactive;
    
    /// <summary>
    /// Include product count for each category
    /// </summary>
    public bool IncludeProductCount { get; set; } = ApplicationConstants.Category.IncludeProductCount;
}