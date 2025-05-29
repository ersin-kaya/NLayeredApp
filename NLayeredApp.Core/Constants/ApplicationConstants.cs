namespace NLayeredApp.Core.Constants;

public static class ApplicationConstants
{
    // Pagination
    public const int DefaultPageNumber = 1;
    public const int DefaultPageSize = 10;
    public const int MaxPageSize = 100;
    
    // String Lengths
    public const int CreatedByMaxLength = 100;
    public const int LastModifiedByMaxLength = 100;
    public const int DeletedByMaxLength = 100;
    
    public const int CategoryNameMaxLength = 100;
    public const int CategoryDescriptionMaxLength = 500;
    public const bool CategoryIsActive = true;
    
    public const int ProductNameMaxLength = 200;
    public const int ProductDescriptionMaxLength = 2000;
    public const int ProductPricePrecision = 18;
    public const int ProductPriceScale = 2;
    public const bool ProductIsActive = true;
    public const bool ProductIsDeleted = false;
    
    public const int CategoryFeatureTypeLabelMaxLength = 100;
    public const bool CategoryFeatureTypeIsRequired = false;

    public const int FeatureValueMaxLength = 100;

    public const int FeatureTypeNameMaxLength = 100;
}