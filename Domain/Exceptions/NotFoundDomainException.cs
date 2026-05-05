namespace Domain.Exceptions;

public class NotFoundDomainException
(
    string entity,
    string message
) : DomainException(code: $"{entity.ToUpper()}_NOT_FOUND", message: message)
{
}