namespace Application.Models;

public class BookInputModel
{
    public string Nome { get; set; }
    public string Testamento { get; set; }
    public int AutorId { get; set; }
    public string Descricao { get; set; }
    public int Capitulos {get; set; }
    public int Versiculos { get; set; }
}