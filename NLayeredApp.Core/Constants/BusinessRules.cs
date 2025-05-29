namespace NLayeredApp.Core.Constants;

public static class BusinessRules
{
    public static class Category
    {
        public const bool AllowDeleteWithProducts = false;
        public const bool RequireUniqueNames = true;
        public const bool DefaultIsActive = true;
    }
        
    public static class Product
    {
        public const bool AllowNegativeStock = false;
        public const bool RequireCategory = true;
        public const bool DefaultIsActive = true;
        public const bool UseSoftDelete = true;
        public const decimal PriceChangeThreshold = 0.50m; // %50
    }
        
    public static class Stock
    {
        public const int CriticalLevel = 5;
        public const int LowLevel = 10;
        public const int OptimalLevel = 50;
        public const bool NotifyOnLowStock = true;
    }
}