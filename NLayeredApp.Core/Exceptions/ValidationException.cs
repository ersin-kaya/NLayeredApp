using NLayeredApp.Core.Constants;

namespace NLayeredApp.Core.Exceptions;

public class ValidationException : Exception
{
    public List<string> Errors { get; }

    public ValidationException(string error) : this(ErrorMessages.ValidationFailed, new List<string> { error })
    {
    }

    public ValidationException(List<string> errors) : this(ErrorMessages.ValidationFailed, errors)
    {
    }

    public ValidationException(string message, List<string> errors) : base(message)
    {
        Errors = errors ?? new List<string>();
    }
}