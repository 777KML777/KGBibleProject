namespace Infra.Data.Base.Class;

public abstract class Repository
(
    IGenericRepository context
) : IRepository
{
    protected readonly IGenericRepository _context = context;

    #region RSO - Region Specific Operation
    // depends of class will implement
    #endregion

    #region RCO - Region Commom Operation
    public TEntity GetById<TEntity>(int identifier) => _context.GetById<TEntity>(identifier);

    public TEntity GetLast<TEntity>()
    {
        throw new NotImplementedException();
    }

    public int GetLastId<TEntity>()
    {
        throw new NotImplementedException();
    }
    #endregion

    #region CRUD Operations
    public TEntity Create<TEntity>(TEntity entity) => _context.Create(entity);
    public IEnumerable<TEntity> Read<TEntity>() => _context.ReadAll<TEntity>();
    public TEntity Update<TEntity>(TEntity entity) => _context.Update(entity);
    public bool Delete<TEntity>(int identifier)
    {
        throw new NotImplementedException();
    }
    #endregion
}