namespace Application.Apps;

public class BookAppService
(
    IBookService _service
) : IBookAppService
{
    public BookDto Create(BookInputModel input)
    {
        var bookDto = _service.Create(input.Book);
        return bookDto;
    }

    public List<BookDto> Read()
    {
        return _service.Read().ToList();
    }

    public async Task<BookDto> GetById(GetByIdInput input)
    {
        input.Validate("BOOKCONTROLLER");
        return _service.GetById(input.Id);
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