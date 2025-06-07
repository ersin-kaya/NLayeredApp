namespace NLayeredApp.Core.DTOs.Common;

public abstract class PagedRequest
{
    private int _pageNumber = 1;
    private int _pageSize = 10;
    private string? _sortBy;
    
    /// <summary>
    /// Page number (1-based). Minimum value is 1.
    /// </summary>
    public int PageNumber
    {
        get => _pageNumber;
        set => _pageNumber = value < 1 ? 1 : value;
    }

    /// <summary>
    /// Number of items per page. Valid range: 1-100
    /// </summary>
    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = value < 1 ? 1 : value > 100 ? 100 : value;
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
    public bool IsDescending { get; set; } = false;
    
    /// <summary>
    /// Skip count for pagination. (calculated property)
    /// </summary>
    public int Skip => (PageNumber - 1) * PageSize;
}