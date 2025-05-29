namespace NLayeredApp.Core.Constants;

public static class ErrorCodes
{
    // General Errors (1000-1999)
    public const string GeneralError = "ERR1000";
    public const string ValidationError = "ERR1001";
    public const string NotFound = "ERR1002";
    public const string Unauthorized = "ERR1003";
    public const string Forbidden = "ERR1004";
        
    // Business Errors (2000-2999)
    public const string BusinessError = "ERR2000";
    public const string DuplicateRecord = "ERR2001";
    public const string InvalidOperation = "ERR2002";
    public const string ConstraintViolation = "ERR2003";
        
    // Category Errors (3000-3099)
    public const string CategoryNotFound = "ERR3001";
    public const string CategoryNameExists = "ERR3002";
    public const string CategoryHasProducts = "ERR3003";
    public const string CategoryInactive = "ERR3004";
        
    // Product Errors (3100-3199)
    public const string ProductNotFound = "ERR3101";
    public const string ProductNameExists = "ERR3102";
    public const string InsufficientStock = "ERR3103";
    public const string ProductAlreadyDeleted = "ERR3104";
    public const string ProductNotDeleted = "ERR3105";
    public const string InvalidPrice = "ERR3106";
    public const string InvalidStock = "ERR3107";
}