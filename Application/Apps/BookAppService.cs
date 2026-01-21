using Domain.Dtos;
using Domain.Interfaces;
using Application.Inputs;

namespace Application.Apps;

// public class BookAppService : IBookAppService
// {
//     private readonly IBookService _service;

//     public BookAppService(IBookService service)
//     {
//         _service = service;
//     }
// }
public class BookAppService
(
    IBookService _service
) : IBookAppService
{
    public BookDto Create(BookInputModel input)
    {
        // TODO: Validar aqui se o autor existe. Não existe mais mapeamento do InputModel para outra coisa. 
        
        // return _service.Create
        // (
        //     input.Book
        // );
        var bookDto = _service.Create(input.Book);

        return bookDto;
    }

    public List<BookDto> Read()
    {
        return _service.Read().ToList();
    }

    public BookDto GetById(int id)
    {
        var bookDto = _service.GetById(id);

         return bookDto;
    }

    public BookDto Update(int id, BookInputModel dto)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }
}