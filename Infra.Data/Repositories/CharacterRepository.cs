using Domain.Entities;
using Infra.Data.Mappings;
using Infra.Data.Extension;

namespace Infra.Data.Repositories;

public class CharacterRepository
(
    IGenericRepository context
) : Repository(context), ICharacterRepository
{

    #region "r1 Specific Operation" 
    public CharacterEntity GetByName(string name) => Read<CharacterEntityData>().FirstOrDefault(b => b.Nome.Equals(name))?.ToEntity() ?? new();
    #endregion 

    #region r4 TEMPORALLY
    public CharacterEntity Create(CharacterEntity entity) => Create(entity.ToEntityData()).ToEntity();
    public IEnumerable<CharacterEntity> Read() => Read<CharacterEntityData>().ToEntityEnumerable();
    public CharacterEntity GetById(int id) => GetById<CharacterEntityData>(id).ToEntity();
    #endregion 
}