namespace Application.Interfaces;

public interface IBookAppService
{
    #region "CRUD Operations"
    public BookDto Create(BookInputModel input);
    public List<BookDto> Read();
    public BookDto Update(int identifier, BookInputModel dto);
    public bool Delete(int identifier);
    #endregion

    #region "RCO - Region Commom Operation"
    public Task<BookDto> GetById(GetByIdInput input);
    #endregion
}