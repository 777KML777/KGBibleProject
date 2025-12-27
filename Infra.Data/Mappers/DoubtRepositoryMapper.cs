using Domain.Entities;
using Infra.Data.Base.Interfaces;
using Infra.Data.Interfaces;
using Infra.Data.Mappings;

namespace Infra.Data.Mappers;

public class DoubtRepositoryMapper : IDoubtRepositoryMapper
{
    IEnumerable<DoubtEntity> IRepositoryMapper<DoubtEntity, DoubtEntityData>.MappingEntityDataEnumerableToEntityEnumerable(IEnumerable<DoubtEntityData> datas)
    {
        throw new NotImplementedException();
    }

    DoubtEntity IRepositoryMapper<DoubtEntity, DoubtEntityData>.MappingEntityDataToEntity(DoubtEntityData data)
    {
        throw new NotImplementedException();
    }

    DoubtEntityData IRepositoryMapper<DoubtEntity, DoubtEntityData>.MappingEntityToEntityData(DoubtEntity entity)
    {
        throw new NotImplementedException();
    }
}