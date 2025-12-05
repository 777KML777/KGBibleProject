namespace Domain.Base.Interfaces;

public interface IRepository<TEntity>
{
    #region "RSO - Region Specific Operation"
    // depends of class will implement interface
    #endregion

    #region "RCO - Region Commom Operation"
    public TEntity GetById(int identifier);
    public TEntity GetLast(int identifier);
    public int GetLastId(int identifier);
    #endregion

    #region "CRUD Operations"
    public TEntity Create(TEntity entity);
    public IEnumerable<TEntity> Read();
    public TEntity Update(TEntity entity);
    public bool Delete(int identifier);
    #endregion
}