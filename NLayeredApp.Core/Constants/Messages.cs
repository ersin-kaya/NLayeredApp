namespace NLayeredApp.Core.Constants;

public static class Messages
{
    public static class Success
    {
        // General Messages
        public const string OperationSuccessful = "Operation completed successfully.";
        public const string Retrieved = "{0} retrieved successfully.";
        public const string Created = "{0} created successfully.";
        public const string Updated = "{0} updated successfully.";
        public const string Deleted = "{0} deleted successfully.";

        // Category Messages
        public static class Category
        {
            public const string Retrieved = "Categories retrieved successfully.";
            public const string Created = "Category created successfully.";
            public const string Updated = "Category updated successfully.";
            public const string Deleted = "Category deleted successfully.";
            public const string ActiveRetrieved = "Active categories retrieved successfully.";
        }

        // Product Messages
        public static class Product
        {
            public const string Retrieved = "Products retrieved successfully.";
            public const string Created = "Product created successfully.";
            public const string Updated = "Product updated successfully.";
            public const string Deleted = "Product deleted successfully.";
            public const string Restored = "Product restored successfully.";
            public const string StockUpdated = "Stock updated successfully.";
            public const string SufficientStock = "Sufficient stock available.";
            public const string InsufficientStock = "Insufficient stock.";
            public const string SearchCompleted = "Search completed successfully.";
            public const string LowStockFound = "Found {0} products with stock <= {1}.";
        }
    }
    
    public static class Error
    {
        // General Messages
        public const string GeneralError = "An error occurred while processing your request.";
        public const string ValidationFailed = "Validation failed. Please check your input.";
    
        public static class Category
        {
        }
    
        public static class Product
        {
        }
    }
    
    public static class Validation
    {
        public static class Category
        {
        }

        public static class Product
        {
        }
    }
}