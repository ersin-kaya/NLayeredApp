namespace NLayeredApp.Core.Constants;

public static class Messages
{
    public static class General
    {
        public static class Success
        {
            public const string OperationSuccessful = "Operation completed successfully.";
            public const string Retrieved = "{0} retrieved successfully.";
            public const string Created = "{0} created successfully.";
            public const string Updated = "{0} updated successfully.";
            public const string Deleted = "{0} deleted successfully.";
        }

        public static class Error
        {
            public const string GeneralError = "An error occurred while processing your request.";
            public const string ValidationFailed = "Validation failed.";
            public const string NotFound = "{0} not found.";
            public const string AlreadyExists = "{0} already exists.";
        }
    }
    
    public static class User
    {
        public static class Success
        {
            public const string Created = "User created successfully.";
            public const string Updated = "User updated successfully.";
            public const string Deleted = "User deleted successfully.";
        }

        public static class Error
        {
            public const string NotFound = "User not found.";
            public const string EmailExists = "Email already exists.";
            public const string InvalidCredentials = "Invalid email or password.";
        }

        public static class Validation
        {
            public const string EmailRequired = "Email is required.";
            public const string PasswordTooShort = "Password must be at least 6 characters.";
        }
    }
    
    public static class Category
    {
        public static class Success
        {
            public const string Retrieved = "Categories retrieved successfully.";
            public const string Created = "Category created successfully.";
            public const string Updated = "Category updated successfully.";
            public const string Deleted = "Category deleted successfully.";
            public const string ActiveRetrieved = "Active categories retrieved successfully.";
        }

        public static class Error
        {
            public const string NotFound = "Category not found.";
            public const string NameExists = "Category name already exists.";
            public const string HasProducts = "Cannot delete category with existing products.";
            public const string InactiveCategory = "Category is inactive.";
        }

        public static class Validation
        {
            public const string NameRequired = "Category name is required.";
            public const string NameTooLong = "Category name cannot exceed 100 characters.";
            public const string InvalidId = "Invalid category ID.";
        }
    }

    public static class Product
    {
        public static class Success
        {
            public const string Retrieved = "Products retrieved successfully.";
            public const string Created = "Product created successfully.";
            public const string StockUpdated = "Stock updated successfully.";
        }

        public static class Error
        {
            public const string NotFound = "Product not found.";
            public const string InsufficientStock = "Insufficient stock available.";
            public const string InvalidPrice = "Price must be greater than zero.";
        }
    }
}