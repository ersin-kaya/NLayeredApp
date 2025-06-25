using NLayeredApp.Core.Constants;

namespace NLayeredApp.Core.Exceptions;

public class InvalidRefreshTokenException : Exception
{
    public InvalidRefreshTokenException() : base(Messages.User.Error.InvalidOrExpiredRefreshToken)
    {
    }

    public InvalidRefreshTokenException(string message) : base(message)
    {
    }
}