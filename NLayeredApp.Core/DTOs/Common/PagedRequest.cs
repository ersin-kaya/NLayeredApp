using NLayeredApp.Core.Constants;

namespace NLayeredApp.Core.DTOs.Common;

public abstract class PagedRequest
{
    private int _pageNumber = ApplicationConstants.Pagination.DefaultPageNumber;
    private int _pageSize = ApplicationConstants.Pagination.DefaultPageSize;
    private string? _sortBy;
    
    /// <summary>
    /// Page number (1-based). Minimum value is defined by DefaultPageNumber (1) constant.
    /// </summary>
    public int PageNumber
    {
        get => _pageNumber;
        set => _pageNumber = Math.Max(ApplicationConstants.Pagination.DefaultPageNumber, value);
    }

    /// <summary>
    /// Number of items per page. Valid range: MinPageSize (0) to MaxPageSize (100) constants.
    /// </summary>
    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = Math.Clamp(
            value,
            ApplicationConstants.Pagination.MinPageSize,
            ApplicationConstants.Pagination.MaxPageSize);
    }
    
    /// <summary>
    /// Property name to sort by. Will be validated against allowed properties.
    /// </summary>
    public string? SortBy
    {
        get => _sortBy;
        set => _sortBy = string.IsNullOrWhiteSpace(value) ? null : value.Trim();
    }
    
    /// <summary>
    /// Search term for filtering results
    /// </summary>
    public string? SearchTerm { get; set; }

    /// <summary>
    /// Sort direction. True for descending, false for ascending.
    /// </summary>
    public bool IsDescending { get; set; } = ApplicationConstants.Pagination.DefaultIsDescending;

    /// <summary>
    /// Skip count for pagination. (calculated property)
    /// </summary>
    public int Skip => (PageNumber - 1) * PageSize;
}