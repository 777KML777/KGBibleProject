using Domain.Entities;
using Infra.Data.Base.Interfaces;
using Infra.Data.Mappings;

namespace Infra.Data.Interfaces; 

public interface IDoubtRepositoryMapper : IRepositoryMapper<DoubtEntity, DoubtEntityData>
{
    
}