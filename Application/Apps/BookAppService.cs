namespace Application.Apps;

public class BookAppService
(
    IBookService _service
) : IBookAppService
{

    #region "CRUD Operations"
    public BookDto Create(BookInputModel input)
    {
        input.Validate("BOOKCONTROLLER");
        return _service.Create(input.Book);
    }

    public List<BookDto> Read()
    {
        return _service.Read().ToList();
    }

    public BookDto Update(int id, BookInputModel dto)
    {
        dto.Validate("BOOKCONTROLLER");
        return _service.Update(dto.Book);
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region "RCO - Region Commom Operation"
    public async Task<BookInputModel> GetById(GetByIdInput input)
    {
        input.Validate("BOOKCONTROLLER");
        return new BookInputModel(_service.GetById(input.Id), ["Antigo","Novo"]);
    }
    #endregion
}