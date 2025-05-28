namespace NLayeredApp.Core.Exceptions;

public class ValidationException : Exception
{
    public List<string> Errors { get; }

    public ValidationException(string error) : base("Validation failed")
    {
        Errors = new List<string> { error };
    }

    public ValidationException(List<string> errors) : base("Validation failed")
    {
        Errors = errors ?? new List<string>();
    }

    public ValidationException(string message, List<string> errors) : base(message)
    {
        Errors = errors ?? new List<string>();
    }
}