namespace NLayeredApp.Core.DTOs.Common;

/// <summary>
/// Generic paginated response container for API responses
/// </summary>
/// <typeparam name="T">The type of items in the response</typeparam>
public record PagedResponse<T>
{
    /// <summary>
    /// The items in the current page
    /// </summary>
    public List<T> Items { get; init; }
    
    /// <summary>
    /// Total count of all items across all pages
    /// </summary>
    public int TotalCount { get; init; }
    
    /// <summary>
    /// Current page number (1-based)
    /// </summary>
    public int PageNumber { get; init; }
    
    /// <summary>
    /// Number of items per page
    /// </summary>
    public int PageSize { get; init; }
    
    /// <summary>
    /// Total number of pages available
    /// </summary>
    public int TotalPages { get; init; }
    
    /// <summary>
    /// Indicates whether there is a previous page available
    /// </summary>
    public bool HasPreviousPage => PageNumber > 1;
    
    /// <summary>
    /// Indicates whether there is a next page available
    /// </summary>
    public bool HasNextPage => PageNumber < TotalPages;

    /// <summary>
    /// Initializes a new instance of the PagedResponse record
    /// </summary>
    /// <param name="items">The items in the current page</param>
    /// <param name="totalCount">Total count of all items</param>
    /// <param name="pageNumber">Current page number</param>
    /// <param name="pageSize">Number of items per page</param>
    public PagedResponse(List<T> items, int totalCount, int pageNumber, int pageSize)
    {
        Items = items;
        TotalCount = totalCount;
        PageNumber = pageNumber;
        PageSize = pageSize;
        TotalPages = (int)Math.Ceiling(totalCount / (double)pageSize);
    }
}