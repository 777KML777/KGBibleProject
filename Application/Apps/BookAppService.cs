using Domain.Dtos;
using Domain.Interfaces;
using Application.Inputs;

namespace Application.Apps;

public class BookAppService
(
    IBookService _service
) : IBookAppService
{
    public BookDto Create(BookInputModel input)
    {
        // TODO: Validar aqui se o autor existe. Não existe mais mapeamento do InputModel para outra coisa. 
        
        return _service.Create
        (
            input.Book
        );
    }

    public List<BookDto> Read()
    {
        return _service.Read().ToList();
    }
}