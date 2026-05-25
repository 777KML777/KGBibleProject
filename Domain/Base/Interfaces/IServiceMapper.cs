namespace Domain.Base.Interfaces;

public interface IServiceMapper<TDto, TEntity>
{
    #region RMO - Region Mapper Objects
    public TEntity DtoToEntity(TDto dto);
    public TDto EntityToDto(TEntity entity);

    #endregion

    #region RMC - Region Mapper Collection
    public IEnumerable<TDto> EntityToDto(IEnumerable<TEntity> entities);
    #endregion
}