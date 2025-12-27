using Domain.Entities;
using Infra.Data.Extension;
using Infra.Data.Mappings;

namespace Infra.Data.Repositories;

public class BookRepository
(
    IGenericRepository context
) : Repository(context), IBookRepository
{

    #region "r1 Specific Operation" 
    public BookEntity GetByName(string name) => Read<BookEntityData>().FirstOrDefault(b => b.Nome.Equals(name))?.ToEntity() ?? new();
    #endregion 

    #region r4 TEMPORALLY
    public BookEntity GetById(int id) => GetById<BookEntityData>(id).ToEntity();
    public BookEntity Create(BookEntity entity) => Create(entity.ToEntityData()).ToEntity();
    #endregion 
}