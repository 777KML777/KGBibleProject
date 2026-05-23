namespace Application.Interfaces;

public interface IBookAppService
{
    #region "CRUD Operations"
    public BookDto Create(BookInputModel input);
    public List<BookDto> Read();
    public BookDto Update(BookInputModel dto);
    public bool Delete(int identifier);
    #endregion

    #region "RCO - Region Commom Operation"
    public Task<BookInputModel> GetById(GetByIdInput input);
    #endregion
}