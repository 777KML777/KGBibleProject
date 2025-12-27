namespace Domain.Interfaces;

public interface IBookRepository : IRepository
{
    #region "r1 Specific Operation" 
    public BookEntity GetByName(string name);
    #endregion
    #region r4 TEMPORALLY
    public BookEntity Create(BookEntity entity);
    public BookEntity GetById(int id);
    #endregion 
}