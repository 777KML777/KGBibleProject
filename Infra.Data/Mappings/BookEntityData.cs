namespace Infra.Data.Mappings;

public class BookEntityData
{
    public int Id { get; set; }
    public string Nome { get; set; }  = string.Empty;
    public string Testamento { get; set; }  = string.Empty;
    public int AutorId { get; set; }
    public string Descricao { get; set; }  = string.Empty;
    public int Capitulos { get; set; }
    public int Versiculos { get; set; }
}