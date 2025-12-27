namespace StorageContextJson;

public interface IGenericRepository
{
    #region "C.R.U.D - Operation"
    #endregion
    public T Create<T>(T entity);
    public IEnumerable<T> ReadAll<T>();
    public T Update<T>(T entity);
    public bool Delete<T>(T entity);
    public int GetLastId<T>();
    public T GetById<T>(int id);

}