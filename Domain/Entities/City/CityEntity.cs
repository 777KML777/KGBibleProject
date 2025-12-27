using Domain.Base.Class;

namespace Domain.Entities.City;

public class CityEntity : Entity
{

    public string Nome { get; private set; }
    public string Descricao { get; private set; }

    public CityEntity(string nome, string descricao)
    {
        Nome = nome;
        Descricao = descricao;
    }


    
}   