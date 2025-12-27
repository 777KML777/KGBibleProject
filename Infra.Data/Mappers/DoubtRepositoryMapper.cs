using Domain.Entities;
using Infra.Data.Mappings;
using Infra.Data.Base.Interfaces;

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