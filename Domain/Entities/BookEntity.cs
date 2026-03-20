using Domain.Base.Class;

namespace Domain.Entities;

public class BookEntity
(

) : Entity
{

    public BookEntity(string nome, string testamento, string descricao) : this()
    {
        Nome = nome;
        Descricao = descricao;
        Testamento = testamento;
        CreatedDate = DateTime.Now;
    }
    public string Nome { get; set; }
    public string Testamento { get; set; }
    public string Descricao { get; set; }
}