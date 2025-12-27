namespace Domain.Exceptions.Base;

public abstract class DomainException(string code, string message) : Exception(message)
{
    public string Code { get; } = code;
}