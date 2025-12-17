using System.Reflection.Emit;

namespace Domain.Entities.Book;

public class BookEntity : Entity
{
    public string Nome { get; set; }
    public string Testamento { get; set; }
    public int AutorId { get; set; }
    public string Descricao { get; set; }
    public int Capitulos { get; set; }
    public int Versiculos { get; set; }

    public BookEntity(string nome, string testamento, int autorId, string descricao, int capitulos, int versiculos)
    {
        Nome = nome;
        Testamento = testamento;
        AutorId = autorId;
        Descricao = descricao;
        Capitulos = capitulos;
        Versiculos = versiculos;
    }
}
