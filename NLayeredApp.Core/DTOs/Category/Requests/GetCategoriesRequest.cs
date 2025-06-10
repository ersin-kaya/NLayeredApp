using NLayeredApp.Core.Constants;
using NLayeredApp.Core.DTOs.Common;

namespace NLayeredApp.Core.DTOs.Category.Requests;

public class GetCategoriesRequest : PagedRequest
{
    public bool IncludeInactive { get; set; } = ApplicationConstants.Defaults.IncludeInactive;
    public bool IncludeProductCount { get; set; } = ApplicationConstants.Category.IncludeProductCount;
}