using NLayeredApp.Core.Constants;
using NLayeredApp.Core.DTOs.Common;

namespace NLayeredApp.Core.DTOs.Product.Requests;

public class GetProductsRequest : PagedRequest
{
    /// <summary>
    /// Filter by category ID
    /// </summary>
    public int? CategoryId { get; set; }

    /// <summary>
    /// Include inactive products
    /// </summary>
    public bool IncludeInactive { get; set; } = ApplicationConstants.Defaults.IncludeInactive;

    /// <summary>
    /// Minimum price filter
    /// </summary>
    public decimal? MinPrice { get; set; }

    /// <summary>
    /// Maximum price filter
    /// </summary>
    public decimal? MaxPrice { get; set; }

    /// <summary>
    /// Filter by stock availability
    /// </summary>
    public bool? InStockOnly { get; set; }

    /// <summary>
    /// Include deleted products (soft delete)
    /// </summary>
    public bool IncludeDeleted { get; set; } = ApplicationConstants.Defaults.IncludeDeleted;
}