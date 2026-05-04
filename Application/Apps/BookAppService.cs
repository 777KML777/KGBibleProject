namespace Application.Apps;

public class BookAppService
(
    IBookService _service
) : IBookAppService
{

    #region "CRUD Operations"
    public BookDto Create(BookInputModel input)
    {
        // input.Validate("BOOKCONTROLLER");
        return _service.Create(input.Book);
    }

    public List<BookDto> Read()
    {
        return _service.Read().ToList();
    }

    public BookDto Update(int id, BookInputModel dto)
    {
        throw new NotImplementedException();
    }

    public bool Delete(int id)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region "RCO - Region Commom Operation"
    public async Task<BookDto> GetById(GetByIdInput input)
    {
        input.Validate("BOOKCONTROLLER");
        return _service.GetById(input.Id);
    }
    #endregion
}