namespace NLayeredApp.Core.Constants;

public static class ApplicationConstants
{
    // Pagination
    public const int DefaultPageNumber = 1;
    public const int DefaultPageSize = 10;
    public const int MaxPageSize = 100;
    
    // Common audit fields
    public const int CreatedByMaxLength = 100;
    public const int LastModifiedByMaxLength = 100;
    public const int DeletedByMaxLength = 100;
    
    // Category entity constants
    public const int CategoryNameMaxLength = 100;
    public const int CategoryDescriptionMaxLength = 500;
    public const bool CategoryIsActive = true;
    
    // Product entity constants
    public const int ProductNameMaxLength = 200;
    public const int ProductDescriptionMaxLength = 2000;
    public const int ProductPricePrecision = 18;
    public const int ProductPriceScale = 2;
    public const bool ProductIsActive = true;
    public const bool ProductIsDeleted = false;
    
    // CategoryFeatureType entity constants
    public const int CategoryFeatureTypeLabelMaxLength = 100;
    public const bool CategoryFeatureTypeIsRequired = false;

    // Feature entity constants
    public const int FeatureValueMaxLength = 100;

    // FeatureType entity constants
    public const int FeatureTypeNameMaxLength = 100;
}