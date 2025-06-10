namespace NLayeredApp.Core.Constants;

public static class ApplicationConstants
{
    public static class Pagination
    {
        public const int DefaultPageNumber = 1;
        public const int DefaultPageSize = 10;
        public const int MaxPageSize = 100;
        public const int MinPageSize = 1;
        public const bool DefaultIsDescending = false;
    }
    
    public static class AuditFields
    {
        private const int UserNameMaxLength = 100;
        
        public const int CreatedByMaxLength = UserNameMaxLength;
        public const int LastModifiedByMaxLength = UserNameMaxLength;
        public const int DeletedByMaxLength = UserNameMaxLength;
    }
    
    public static class Category
    {
        public const int NameMaxLength = 50;
        public const int DescriptionMaxLength = 1000;
        public const bool IsActiveDefault = true;
    }
    
    public static class Product
    {
        public const int NameMaxLength = 200;
        public const int DescriptionMaxLength = 2000;
        public const int PricePrecision = 18;
        public const int PriceScale = 2;
        public const bool IsActiveDefault = true;
        public const bool IsDeletedDefault = false;
        
        /// <summary>
        /// Stock management constants
        /// </summary>
        public static class Stock
        {
            public const int MinLevel = 0;
            public const int MaxLevel = 10000;
            public const int LowThreshold = 10;
            public const int CriticalThreshold = 5;
            public const int ReorderPoint = 20;
            public const int DefaultReorderQuantity = 50;
        }
    }
    
    // CategoryFeatureType entity constants
    public const int CategoryFeatureTypeLabelMaxLength = 100;
    public const bool CategoryFeatureTypeIsRequired = false;

    // Feature entity constants
    public const int FeatureValueMaxLength = 100;

    // FeatureType entity constants
    public const int FeatureTypeNameMaxLength = 100;
}