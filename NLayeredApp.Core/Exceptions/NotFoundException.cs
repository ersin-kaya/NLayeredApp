namespace NLayeredApp.Core.Exceptions;

public class NotFoundException : Exception
{
    public string EntityName { get; }
    public object? Key { get; }

    public NotFoundException(string message) : base(message)
    {
        EntityName = string.Empty;
        Key = null;
    }

    public NotFoundException(string entityName, object key) 
        : base($"{entityName} with key '{key}' was not found.")
    {
        EntityName = entityName;
        Key = key;
    }

    public NotFoundException(string message, Exception innerException)
        : base(message, innerException)
    {
        EntityName = string.Empty;
        Key = null;
    }
}