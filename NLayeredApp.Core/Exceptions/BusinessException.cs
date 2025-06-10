using NLayeredApp.Core.Constants;

namespace NLayeredApp.Core.Exceptions;

public class BusinessException : Exception
{
    public string Code { get; }

    public BusinessException(string message) : this(ErrorCodes.BusinessError, message)
    {
    }

    public BusinessException(string code, string message) : base(message)
    {
        Code = code;
    }

    public BusinessException(string message, Exception innerException)
        : this(ErrorCodes.BusinessError, message, innerException)
    {
    }

    public BusinessException(string code, string message, Exception innerException) : base(message, innerException)
    {
        Code = code;
    }
}