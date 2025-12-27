using Domain.Entities;
using Infra.Data.Base.Interfaces;
using Infra.Data.Mappings;

namespace Infra.Data.Interfaces;

public interface IBookRepositoryMapper : IRepositoryMapper<BookEntity, BookEntityData>
{
    
}