namespace Domain.Entities;

public class BookEntity : Tracker
{
    public BookEntity()
    {
        Name = string.Empty;
        Testament = string.Empty;
        Description = string.Empty;
    }
    public BookEntity(string name, string testament, string description)
    {
        CreatedAt = DateTime.Now;
        Name = name;
        Description = description;
        Testament = testament;
    }

    internal BookEntity(BookDto dto) : this 
    (
        dto.Nome, 
        dto.Testamento, 
        dto.Descricao
    )
    {
        Id = dto.Id;
        // ValidarAutor();
    }
    public string Name { get; private set; }
    public string Testament { get; private set; }
    public string Description { get; private set; }

    #region "RELATIONAL PROPERTIES
    public int CharacterId { get; private set; }
    public CharacterEntity Author { get; private set; }
    public void SetAuthorId(int authorId) => CharacterId = authorId;
    public void LinkAuthor(CharacterEntity author) => Author = author;
    #endregion

    // TODO: E se quisermos exibir todos os personagens do livro? Como iriamos diferenciar dos autores? 
}