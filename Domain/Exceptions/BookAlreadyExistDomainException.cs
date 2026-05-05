namespace Domain.Exceptions;

public class BookAlreadyExistDomainException
(
    string bookName
) : DomainException(code: "BOOK_ALREADY_EXISTS", message: $"A book with the name '{bookName}' already exists.")
{
}