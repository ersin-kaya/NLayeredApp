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
    
    /// <summary>
    /// Common default values
    /// </summary>
    public static class Defaults
    {
        public const bool IncludeInactive = false;
        public const bool IncludeDeleted = false;
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
        public const bool IncludeProductCount = false;
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
    
    public static class CategoryFeatureType
    {
        public const int LabelMaxLength = 100;
        public const bool IsRequiredDefault = false;
    }
    
    public static class Feature
    {
        public const int ValueMaxLength = 100;
    }
    
    public static class FeatureType
    {
        public const int NameMaxLength = 100;
    }
}