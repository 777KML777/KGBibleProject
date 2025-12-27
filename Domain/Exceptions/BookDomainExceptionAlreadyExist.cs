using Domain.Exceptions.Base;

namespace Domain.Exceptions;

public class BookDomainExceptionAlreadyExist
(
    string bookName
) : DomainException(code: "BOOK_ALREADY_EXISTS", message: $"A book with the name '{bookName}' already exists.")
{
}