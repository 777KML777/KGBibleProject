namespace Domain.Interfaces;

public interface ICharacterRepository : IRepository
{
    #region "r1 Specific Operation" 
    public CharacterEntity GetByName(string name);
    #endregion
    #region r4 TEMPORALLY
    public CharacterEntity Create(CharacterEntity entity);
    public IEnumerable<CharacterEntity> Read();
    public CharacterEntity GetById(int id);
    #endregion 
}