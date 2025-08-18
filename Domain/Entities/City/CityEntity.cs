using System.Reflection.Emit;

namespace Domain.Entities.City;

public class CityEntity : Entity
{
    public CityEntity
    (
        string nome,
        string descricao
    )
    {
        Nome = nome;
        Descricao = descricao;
    }
    public string Nome { get; private set; }
    public string Descricao { get; private set; }

}