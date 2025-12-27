using Domain.Base.Class;

namespace Domain.Entities;

public class BookEntity
(
    
) : Entity
{

    public string Nome { get; set; }
    public string Testamento { get; set; }
    public int AutorId { get; set; }
    public string Descricao { get; set; }

    public BookEntity(string nome, string testamento, int autorId, string descricao) : this()
    {
        Nome = nome;
        Testamento = testamento;
        AutorId = autorId;
        Descricao = descricao;
    }
}