using Domain.Exceptions.Base;

namespace Domain.Exceptions;

public class ApplicationInputModelException : DomainException
{
    public ApplicationInputModelException
    (
        string code,
        string message
    ) : base(code: code, message: message)
    {

    }
}