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
    public BookEntity Create(BookEntity entity) => Create(entity.ToEntityData()).ToEntity();
    public IEnumerable<BookEntity> Read() => Read<BookEntityData>().ToEntityEnumerable();
    public BookEntity GetById(int id)
    {
        BookEntity book = GetById<BookEntityData>(id).ToEntity();

        // TODO: Remover futuramente ou implementar include. 
        // INCLUDES
        if (book != null)
        {
            // One To One - Exemplo
            var author = GetById<CharacterEntityData>(book.CharacterId).ToEntity();
            book.LinkAuthor(author); //TODO: Poderia ser um construtor secundário.
            
        }
        return book ?? new(); // TODO: Poderia retornar nulo. E o serviço quem trataria. 
    }
    #endregion 
}